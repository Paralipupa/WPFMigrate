using System;
using System.Threading.Tasks;
using System.Windows;
using dlgForm = System.Windows.Forms;
using System.Threading;
using MigrateBase.Model;
using System.Configuration;

namespace MigrateBase
{

    public partial class MainWindow : Window
    {

        private readonly OpenDatabases _dataBase;
        private CancellationTokenSource _cts = new CancellationTokenSource();

        public MainWindow()
        {
            InitializeComponent();
            _dataBase = new OpenDatabases();

            if (_dataBase.IsOpenAccess) listTables.ItemsSource = _dataBase.GetAllTablesFromAccess();
            if (!_dataBase.IsOpenMySQL)
            {
                string message = $"Не удалось открыть БД MySQL. Создать БД?";
                string caption = "Ошибка при открытии БД";
                dlgForm.MessageBoxButtons buttons = dlgForm.MessageBoxButtons.YesNo;
                dlgForm.DialogResult result = dlgForm.MessageBox.Show(message, caption, buttons);
                if (result == dlgForm.DialogResult.Yes)
                {
                    _dataBase.CreateDatabase();
                }
            }

            btnCreate.IsEnabled = (_dataBase.IsOpenMySQL);
            btnLoadAll.IsEnabled = _dataBase.IsOpenMySQL && _dataBase.IsOpenAccess;
            btnRelation.IsEnabled = (_dataBase.IsOpenMySQL);

            if (!String.IsNullOrWhiteSpace(_dataBase.Message))
            {

                listRows.Items.Add(_dataBase.Message);

            }

        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_dataBase.IsOpenAccess) _dataBase.ConnAccess.Close();
            if (_dataBase.IsOpenMySQL) _dataBase.ConnMySQL.Close();
        }

        private void ButExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnAbort_Click(object sender, RoutedEventArgs e)
        {
            _cts?.Cancel();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            CreateTablesAsync();
        }

        private void BtnRelation_Click_1(object sender, RoutedEventArgs e)
        {
            RelationSetAsync();
        }



        private void BtnLoad_Click_All(object sender, RoutedEventArgs e)
        {
            InsertDataAsync();
        }

        private void btnRunAll_Click(object sender, RoutedEventArgs e)
        {
            RunAllAsync();
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

            _cts = new CancellationTokenSource();
            CancellationToken token = _cts.Token;
            listRows.Items.Clear();
            listRows.Items.Add($"Начало создания структуры {DateTime.Now.ToString()}");

            var progressindicator = new Progress<ProgressIndicate>(ReportProgress);
            SQLCreate sqlcreate = new SQLCreate(_dataBase.ConnMySQL);

            await Task.Run(() => sqlcreate.CreateTables(progressindicator, token));

            listRows.Items.Add($"Завершение {DateTime.Now.ToString()}");
            ReportProgress();

            btnAbort.IsEnabled = false;
            btnCreate.IsEnabled = true;

        }

        private async void InsertDataAsync()
        {
            btnLoadAll.IsEnabled = false;
            btnAbort.IsEnabled = true;
            listRows.Items.Clear();
            listRows.Items.Add($"Начало копирования данных {DateTime.Now.ToString()}");

            _cts = new CancellationTokenSource();
            CancellationToken token = _cts.Token;

            SQLInsert sqlinsert = new SQLInsert(_dataBase.ConnMySQL);

            foreach (var o in listTables.Items)
            {
                string nametable = o.ToString();
                var progressindicator = new Progress<ProgressIndicate>(ReportProgress);

                await Task.Run(() => sqlinsert.InsertToMySQL(_dataBase.ConnAccess, nametable, progressindicator, token));

                if (token.IsCancellationRequested) break;

            }

            listRows.Items.Add($"Завершение {DateTime.Now.ToString()}");
            ReportProgress();

            btnAbort.IsEnabled = false;
            btnLoadAll.IsEnabled = true;

        }

        private async void InsertDataCurrentAsync()
        {
            if (listTables.SelectedItems.Count == 0)
            {
                return;
            }

            btnAbort.IsEnabled = true;
            listRows.Items.Clear();
            listRows.Items.Add($"Начало копирования данных {DateTime.Now.ToString()}");

            _cts = new CancellationTokenSource();
            CancellationToken token = _cts.Token;

            SQLInsert sqlinsert = new SQLInsert(_dataBase.ConnMySQL);
            foreach (var o in listTables.SelectedItems)
            {
                string nametable = o.ToString();
                var progressindicator = new Progress<ProgressIndicate>(ReportProgress);

                await Task.Run(() => sqlinsert.InsertToMySQL(_dataBase.ConnAccess, nametable, progressindicator, token));

                if (token.IsCancellationRequested)
                {
                    break;
                }
            }

            listRows.Items.Add($"Завершение {DateTime.Now.ToString()}");
            ReportProgress();

            btnAbort.IsEnabled = false;

        }

        private async void RelationSetAsync()
        {

            btnRelation.IsEnabled = false;
            btnAbort.IsEnabled = true;
            listRows.Items.Clear();
            listRows.Items.Add($"Начало создания индексов {DateTime.Now.ToString()}");

            _cts = new CancellationTokenSource();
            CancellationToken token = _cts.Token;
            var progressindicator = new Progress<ProgressIndicate>(ReportProgress);
            SQLCreate dd = new SQLCreate(_dataBase.ConnMySQL);

            await Task.Run(() => dd.RelationTables(progressindicator, token));

            listRows.Items.Add($"Завершение {DateTime.Now.ToString()}");
            ReportProgress();

            btnRelation.IsEnabled = true;
            btnAbort.IsEnabled = false;

        }

        private async void RunAllAsync()
        {

            btnAbort.IsEnabled = true;
            btnCreate.IsEnabled = false;
            btnRelation.IsEnabled = false;
            btnLoadAll.IsEnabled = false;
            btnRunAll.IsEnabled = false;

            listRows.Items.Clear();

            _cts = new CancellationTokenSource();
            CancellationToken token = _cts.Token;
            SQLCreate dd = new SQLCreate(_dataBase.ConnMySQL);

            listRows.Items.Add($"Создание таблиц  {DateTime.Now.ToString()}");
            var progressindicator = new Progress<ProgressIndicate>(ReportProgress);
            await Task.Run(() => dd.CreateTables(progressindicator, token));

            if (listRows.Items.Count ==1)
            {
                listRows.Items.Add($"Создание индексов {DateTime.Now.ToString()}");
                progressindicator = new Progress<ProgressIndicate>(ReportProgress);
                await Task.Run(() => dd.RelationTables(progressindicator, token));

                if (listRows.Items.Count == 2)
                {
                    SQLInsert sqlinsert = new SQLInsert(_dataBase.ConnMySQL);
                    listRows.Items.Add($"Копирование данных {DateTime.Now.ToString()}");
                    foreach (var o in listTables.Items)
                    {
                        string nametable = o.ToString();
                        progressindicator = new Progress<ProgressIndicate>(ReportProgress);

                        await Task.Run(() => sqlinsert.InsertToMySQL(_dataBase.ConnAccess, nametable, progressindicator, token));

                        if (token.IsCancellationRequested) break;

                    }
                    listRows.Items.Add($"Завершение {DateTime.Now.ToString()}");
                }
                else
                {
                    listRows.Items.Add($"Аварийное завершение создания индексов {DateTime.Now.ToString()}");
                }

            }
            else
            {
                listRows.Items.Add($"Аварийное завершение создания таблиц {DateTime.Now.ToString()}");
            }

            ReportProgress();

            btnCreate.IsEnabled = true;
            btnRelation.IsEnabled = true;
            btnLoadAll.IsEnabled = true;
            btnRunAll.IsEnabled = true;
            btnAbort.IsEnabled = false;

        }

        private void MainForm_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //lblMessage.Width = DocPanelLeft.ActualWidth;
            //lblMessage.Content = $"left={ColumnLeft.ActualWidth.ToString()}  razd={ColumnRazd.Offset.ToString()}";
        }

    }
}

