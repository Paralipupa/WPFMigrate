using System;
using System.Threading.Tasks;
using System.Windows;
using dlgForm = System.Windows.Forms;
using System.Threading;
using MigrateBase.Model;

namespace MigrateBase
{

    public partial class MainWindow : Window
    {

        private readonly OpenDatabases dataBase;
        private CancellationTokenSource cts = new CancellationTokenSource();

        public MainWindow()
        {
            InitializeComponent();
            dataBase = new OpenDatabases();

            if (dataBase.IsOpenAccess) listTables.ItemsSource =  dataBase.GetAllTablesFromAccess();
            if (!dataBase.IsOpenMySQL)
            {
                string message = $"Не удалось открыть БД MySQL {dataBase.DatabaseName()}. Создать БД?";
                string caption = "Ошибка при открытии БД";
                dlgForm.MessageBoxButtons buttons = dlgForm.MessageBoxButtons.YesNo;
                dlgForm.DialogResult result = dlgForm.MessageBox.Show(message, caption, buttons);
                if (result == dlgForm.DialogResult.Yes)
                {
                    dataBase.CreateDatabase();
                }
            }

            btnCreate.IsEnabled = (dataBase.IsOpenMySQL);
            btnLoad.IsEnabled = dataBase.IsOpenMySQL && dataBase.IsOpenAccess;
            btnLoadAll.IsEnabled = btnLoad.IsEnabled;
            btnRelation.IsEnabled= (dataBase.IsOpenMySQL);

            if (!String.IsNullOrWhiteSpace(dataBase.Message))
            {

                listRows.Items.Add(dataBase.Message);
            
            }
        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dataBase.IsOpenAccess) dataBase.ConnAccess.Close();
            if (dataBase.IsOpenMySQL) dataBase.ConnMySQL.Close();
        }

        private void ButExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit( 0 );
        }

        private void BtnAbort_Click(object sender, RoutedEventArgs e)
        {
            cts?.Cancel();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            CreateTablesAsync();
        }

        private void BtnRelation_Click_1(object sender, RoutedEventArgs e)
        {
            RelationSetAsync();
        }

        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {
            InsertDataCurrentAsync();
        }

        private void BtnLoad_Click_All(object sender, RoutedEventArgs e)
        {
            InsertDataAsync();
        }

        private void ReportProgress(ProgressIndicate progressindicate = null)
        {
            if (progressindicate != null)
            {
                if (progressindicate.GetTotal() != 0) progressBar1.Value = progressindicate.GetCurrent() * 100 / progressindicate.GetTotal();

                lblMessage.Content = (progressindicate?.GetTitle() ?? "") + " " + (progressindicate?.GetName() ?? "") + " " + (progressindicate.GetCurrent() != 0 ? progressindicate.GetCurrent().ToString() : "");

                if (progressindicate.Message != null)
                {                        
                    listRows.Items.Add(progressindicate.Message);
                    progressindicate.ClearMessage();
                }
                        

            }
            else 
            { 
                progressBar1.Value = 0;
                lblMessage.Content = "";
            }
        }


        async void CreateTablesAsync()
        {

            btnCreate.IsEnabled = false;
            btnAbort.IsEnabled = true;


            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            var progressIndicator = new Progress<ProgressIndicate>(ReportProgress);
            SQLCreate sqlCreate = new SQLCreate(dataBase.ConnMySQL);

            await Task.Run(() => sqlCreate.CreateTables(progressIndicator, token));

            MessageBox.Show("Создание таблиц завершено");
            ReportProgress();

            btnAbort.IsEnabled = false;
            btnCreate.IsEnabled = true;

        }

        private async void InsertDataAsync()
        {

            btnLoad.IsEnabled = false;
            btnAbort.IsEnabled = true;
            listRows.Items.Clear();

            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            SQLInsert sqlInsert = new SQLInsert(dataBase.ConnMySQL);

            foreach (var o in listTables.Items)
            {
                string nameTable = o.ToString();
                var progressIndicator = new Progress<ProgressIndicate>(ReportProgress);
                
                await Task.Run(() => sqlInsert.InsertToMySQL( dataBase.ConnAccess, nameTable, progressIndicator, token));

                if (token.IsCancellationRequested) break;

            }

            MessageBox.Show($"Загрузка завершена");
            ReportProgress();

            btnAbort.IsEnabled = false;
            btnCreate.IsEnabled = true;

        }

        private async void InsertDataCurrentAsync()
        {
            if (listTables.SelectedItems.Count == 0)
            {
                return;
            }
            btnLoad.IsEnabled = false;
            btnAbort.IsEnabled = true;
            listRows.Items.Clear();

            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            SQLInsert sqlInsert = new SQLInsert(dataBase.ConnMySQL);
            foreach (var o in listTables.SelectedItems)
            {
                string nameTable = o.ToString();
                var progressIndicator = new Progress<ProgressIndicate>(ReportProgress);

                await Task.Run(() => sqlInsert.InsertToMySQL(dataBase.ConnAccess, nameTable, progressIndicator, token));

                if (token.IsCancellationRequested) break;

            }
            MessageBox.Show($"Загрузка завершена");
            ReportProgress();

            btnLoad.IsEnabled = true;
            btnAbort.IsEnabled = false;

        }


        private async void RelationSetAsync()
        {

            btnRelation.IsEnabled = false;
            btnAbort.IsEnabled = true;
            listRows.Items.Clear();

            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            var progressIndicator = new Progress<ProgressIndicate>(ReportProgress);
            SQLCreate dd = new SQLCreate(dataBase.ConnMySQL);

            await Task.Run(() => dd.RelationTables(progressIndicator, token));

            MessageBox.Show("Установка отношений завершена");
            ReportProgress();

            btnRelation.IsEnabled = true;
            btnAbort.IsEnabled = false;

        }

        private void MainForm_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //lblMessage.Width = DocPanelLeft.ActualWidth;
            //lblMessage.Content = $"left={ColumnLeft.ActualWidth.ToString()}  razd={ColumnRazd.Offset.ToString()}";
        }

    }
}
