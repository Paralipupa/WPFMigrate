using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WpfApp3.Model
{
    class OpenDatabases
    {
        

        private readonly string _host = "192.168.0.61"; // Имя хоста
        private readonly string _database = "clientbase"; // Имя базы данных
        private readonly string _user = "user"; // Имя пользователя
        private readonly string _password = "taab501deest"; // Пароль пользователя
        private string _message_error;
        private bool _isopenmysql = false;
        private bool _isopenaccess = false;
        private MySqlConnection _connmysql;
        private OleDbConnection _connaccess;
        private readonly MySqlCommand _command = new MySqlCommand();

        public bool IsOpenMySQL => (_isopenmysql);
        public bool IsOpenAccess => (_isopenaccess);
        public OleDbConnection ConnAccess => (_connaccess);
        public MySqlConnection ConnMySQL => (_connmysql);
        public MySqlCommand Command => (_command);
        public string Message => (_message_error);

        public OpenDatabases()
        {
            OpenMySQL();
            OpenMSAccess();
        }


        public string DatabaseName()
        {
            return (_database);
        }


        public bool CreateDatabase()
        {
            bool _flag = false;
            try 
            {
                _command.CommandText = $"CREATE DATABASE `{_database}`"; _command.ExecuteNonQuery();
                OpenMySQL();

                _flag = true;
            }
            catch (Exception ex) 
            {
                _message_error = $"{ex.Message}, {ex.Source} ";
            }

            return (_flag);
        }

        public bool DropDatabase()
        {
            bool _flag = false;
            try
            {
                _command.CommandText = $"DROP DATABASE IF EXISTS {_database}"; _command.ExecuteNonQuery();

                _flag = true;
            }
            catch (Exception ex)
            {
                _message_error = $"{ex.Message}, {ex.Source} ";
            }

            return (_flag);            
        }
                
        public List<string> GetAllTablesFromAccess()
        {
            var queries = new List<string>();
            var dt = _connaccess.GetSchema("Tables");

            queries = dt.AsEnumerable().Select(dr => dr.Field<string>("TABLE_NAME")).Where(l => !l.Contains("MSys") && !l.Contains("_") && !l.Contains("Запрос")).ToList();

            return queries;
        }

        private void OpenMySQL()
        {
            string connStr = "Database=" + _database + ";Datasource=" + _host + ";User=" + _user + ";Password=" + _password;

            // создаём объект для подключения к БД
            _connmysql = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            try
            {
                _connmysql.Open();
                _command.Connection = _connmysql;
                _isopenmysql = true;
            }
            catch (Exception ex)
            {
                _message_error = $"{ex.Message}, {ex.Source} ";
            }
        }

        private void OpenMSAccess()
        {
            string connString = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=D:\\Infoteh\\BASE\\NewBase.mdb;";
            _connaccess = new OleDbConnection(connString);
            try
            {
                _connaccess.Open();
                _isopenaccess = true;
            }
            catch (Exception ex)
            {
                _message_error = $"{ex.Message}, {ex.Source} ";
            }
        }

    }


}



