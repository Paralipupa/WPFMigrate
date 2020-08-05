using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace MigrateBase.Model
{
    class OpenDatabases
    {
        private readonly string _database = "clientbase"; // Имя базы данных
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

        public bool CreateDatabase()
        {
            bool flag = false;
            try 
            {
                _command.CommandText = $"CREATE DATABASE `{_database}`"; _command.ExecuteNonQuery();
                OpenMySQL();

                flag = true;
            }
            catch (Exception ex) 
            {
                _message_error = $"{ex.Message}, {ex.Source} ";
            }

            return (flag);
        }

        public bool DropDatabase()
        {
            bool flag = false;
            try
            {
                _command.CommandText = $"DROP DATABASE IF EXISTS {_database}"; _command.ExecuteNonQuery();

                flag = true;
            }
            catch (Exception ex)
            { 
                _message_error = $"{ex.Message}, {ex.Source} ";
            }

            return (flag);            
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
            string connstring = ConfigurationManager.AppSettings.Get("MySQLConnStr");

            // создаём объект для подключения к БД
            _connmysql = new MySqlConnection(connstring);
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
            string connstring = ConfigurationManager.AppSettings.Get("AccessConnStr");

            _connaccess = new OleDbConnection(connstring);
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



