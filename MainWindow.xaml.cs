using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.Data;
using System.Threading;
using DevExpress.Internal;
using DevExpress.Data.Helpers;
using WpfApp3.Model;

namespace WpfApp3
{

    public partial class MainWindow : Window
    {


        private OleDbConnection connAccess;
        private MySqlConnection connMySQL;
        private SQLTemplates sql;
        private MySqlCommand command;

        private string currentName;
        private List<string> listMessage;
        CancellationTokenSource cts = new CancellationTokenSource();

        public MainWindow()
        {
            InitializeComponent();
            OpenMySQL();
            OpenMSAccess();
            listTables.ItemsSource = GetAllTablesFromDataBase();
            listMessage = new List<string>();
        }


        private void OpenMySQL()
        {
            string host = "192.168.0.61"; // Имя хоста
            string database = "clientbase"; // Имя базы данных
            string user = "user"; // Имя пользователя
            string password = "taab501deest"; // Пароль пользователя
            string connStr = "Database=" + database + ";Datasource=" + host + ";User=" + user + ";Password=" + password;

            // создаём объект для подключения к БД
            connMySQL = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            connMySQL.Open();
            command = new MySqlCommand
            {
                Connection = connMySQL
            };
            sql = new SQLTemplates();
        }

        private void OpenMSAccess()
        {
            string connString = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=D:\\Infoteh\\BASE\\NewBase.mdb;";
            connAccess = new OleDbConnection(connString);
            connAccess.Open();
        }

        private List<string> GetAllTablesFromDataBase()
        {
            var queries = new List<string>();
            var dt = connAccess.GetSchema("Tables");

            queries = dt.AsEnumerable().Select(dr => dr.Field<string>("TABLE_NAME")).Where(l=>!l.Contains("MSys") && !l.Contains("_") && !l.Contains("Запрос")).ToList();

            return queries;
        }


        private void ButExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit( 0 );
        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            connAccess.Close();
            connMySQL.Close();
        }

        private async void InsertToMySQL(string nameTable, IProgress<ProgressIndicate> progress, CancellationToken token)
        {
            OleDbDataAdapter da;
            OleDbCommand cmd;
            DataSet ds;

            string connStr = $"SELECT * FROM [{nameTable}]";
            string mSQLHead = "";
            string mSQLValue = "";

            da = new OleDbDataAdapter(connStr, connAccess);
            ds = new DataSet();
            da.Fill(ds, nameTable);

            int j = 0;
            int k = 0;

            foreach (DataTable dt in ds.Tables)
            {


                mSQLHead = $"INSERT INTO `{dt.TableName.ToString().Trim()}` ";


                string str = "";
                foreach (DataColumn column in dt.Columns)
                    str +=  $"`{column.ColumnName.Trim()}`,";

                mSQLHead += $"({str.Trim().TrimEnd(',')})";
                mSQLHead += " VALUES ";

                mSQLValue = "";

                // перебор всех строк таблицы
                ProgressIndicate p = new ProgressIndicate();
                foreach (DataRow row in dt.Rows)
                {
                    // получаем все ячейки строки
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }

                    if (progress != null)
                    {
                        p.current = k;
                        p.count = dt.Rows.Count;
                        progress.Report(p);
                    }
                    int i = 0;
                    var cells = row.ItemArray;
                    str = "";
                    foreach (object cell in cells)
                    {
                        
                            switch (cell.GetType().ToString())
                            {
                                case "System.String":
                                    str += "'" + cell.ToString().Trim() + "', ";
                                    break;
                                case "System.DBNull":
                                    str += "Null, ";
                                    break;
                                case "System.DateTime":
                                    DateTime d;
                                    if (DateTime.TryParse(cell.ToString(), out d))
                                    {
                                        str += "'" + d.ToString("o") + "', ";
                                    }
                                    else str += "Null, ";
                                    break;
                                default:
                                    str += cell.ToString().Trim() + ", ";
                                    break;
                            }
                        
                        i++;
                    }

                    mSQLValue += $"({ str.Trim().TrimEnd(',') }), ";
                    str = "";
                    j++;
                    k++;
                    if (j > 4000)
                    {
                        ExecuteQuery(mSQLHead + mSQLValue.Trim().TrimEnd(','), j);

                        j = 0;
                        mSQLValue = "";
                    }

                }

            }

            if (mSQLValue.Length != 0)
            {
                ExecuteQuery(mSQLHead + mSQLValue.Trim().TrimEnd(','), j);
            }

        }

        private void ExecuteQuery(string query, int j)
        {
            try
            {
                command.CommandText = query; int n = command.ExecuteNonQuery();
                if (n != j) listMessage.Add($" Предупреждение: '{query.Substring(11, 20)}' запрошено {j},  записано {n} ");
            }
            catch (Exception ex)
            {
                listMessage.Add($" Ошибка {j}зап.: {ex.Message}. '{query.Substring(11, 20)}'");
            }

        }

        private void ReportProgress(ProgressIndicate value = null)
        {
            if (value != null)
            {
                if (value.count != 0)
                {
                    progressBar1.Value = value.current * 100 / value.count;
                    lblMessage.Content = currentName?.ToString() +" "+ value.current.ToString();

                }
            }
            else 
            { 
                progressBar1.Value = 0;
                lblMessage.Content = "";
            }
            if (listMessage.Count !=0 )
            {
                for (int i = 0; i < listMessage.Count; i++)
                {
                    listRows.Items.Add(listMessage[i].ToString());
                }
                listMessage.Clear();

            }
        }

        private void btnRelation_Click(object sender, RoutedEventArgs e)
        {
            RelationSetAsync();
        }

        async void CreateTablesAsync()
        {

            btnCreate.IsEnabled = false;
            currentName = "Create";

            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            var progressIndicator = new Progress<ProgressIndicate>(ReportProgress);
            SQLCreate dd = new SQLCreate();
            await Task.Run(() => dd.CreateTables(command, sql, progressIndicator, token));
            btnCreate.IsEnabled = true;
            MessageBox.Show("Создание таблиц завершено");
            ReportProgress();

        }

        private async void InsertDataAsync()
        {

                cts = new CancellationTokenSource();
                CancellationToken token = cts.Token;
                btnLoad.IsEnabled = false;

                foreach (var o in listTables.Items)
                {
                    string nameTable = o.ToString();
                    currentName = nameTable;
                    var progressIndicator = new Progress<ProgressIndicate>(ReportProgress);
                    await Task.Run(() => InsertToMySQL(nameTable, progressIndicator, token));
                    if (token.IsCancellationRequested) break;
                }

                btnLoad.IsEnabled = true;
                MessageBox.Show($"Загрузка завершена");
                ReportProgress();

        }

        private async void RelationSetAsync()
        {
            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            btnRelation.IsEnabled = false;
            currentName = "Relation";
            var progressIndicator = new Progress<ProgressIndicate>(ReportProgress);
            SQLCreate dd = new SQLCreate();
            await Task.Run(() =>
            {
                dd.RelationTables(command, sql, progressIndicator, token);
            });
            btnRelation.IsEnabled = true;
            MessageBox.Show("Установка отношений завершена");
            ReportProgress();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            CreateTablesAsync();
        }

        private void btnRelation_Click_1(object sender, RoutedEventArgs e)
        {
            RelationSetAsync();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            InsertDataAsync();
        }

        private void btnAbort_Click(object sender, RoutedEventArgs e)
        {
            cts?.Cancel();
        }
    }
}
