using System;
using System.Threading;
using System.Data.OleDb;
using System.Data;
using MySql.Data.MySqlClient;

namespace MigrateBase.Model
{
    class SQLInsert
    {

        private readonly MySqlCommand _command;
        
        public SQLInsert(MySqlConnection connect)
        {
            _command = new MySqlCommand
            {
                Connection = connect
            };
        }

        public void InsertToMySQL(OleDbConnection connAccess, string nameTable, IProgress<ProgressIndicate> progress, CancellationToken token)
        {
            string _connStr = $"SELECT * FROM [{nameTable}]";
            ProgressIndicate progressindicate = new ProgressIndicate(0);
            progressindicate.SetTitle($"Чтение из {nameTable}");
            progress.Report(progressindicate);

            OleDbDataAdapter _da = new OleDbDataAdapter(_connStr, connAccess);
            DataSet _ds = new DataSet();
            _da.Fill(_ds, nameTable);

            foreach (DataTable _dt in _ds.Tables)
            {

                progressindicate = new ProgressIndicate(_dt.Rows.Count);
                progressindicate.SetTitle($"Запись в {nameTable}");

                string _mSQLHead = $"INSERT INTO `{_dt.TableName.ToString().Trim()}` ";

                string _str = "";
                foreach (DataColumn column in _dt.Columns)
                    _str += $"`{column.ColumnName.Trim()}`,";

                _mSQLHead += $"({_str.Trim().TrimEnd(',')})";
                _mSQLHead += " VALUES ";

                string _mSQLValue = "";

                // перебор всех строк таблицы                
                foreach (DataRow _row in _dt.Rows)
                {
                    // получаем все ячейки строки
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }

                    progressindicate.MoveNextCurrent();

                    var _cells = _row.ItemArray;
                    _str = "";
                    foreach (object _cell in _cells)
                    {
                        switch (_cell.GetType().ToString())
                        {
                            case "System.String":
                                _str += "'" + _cell.ToString().Trim().Replace("'","`") + "', ";
                                break;
                            case "System.DBNull":
                                _str += "Null, ";
                                break;
                            case "System.DateTime":
                                DateTime _d;
                                if (DateTime.TryParse(_cell.ToString(), out _d))
                                {
                                    _str += "'" + _d.ToString("o") + "', ";
                                }
                                else _str += "Null, ";
                                break;
                            default:
                                _str += _cell.ToString().Trim() + ", ";
                                break;
                        }
                    }

                    _mSQLValue += $"({ _str.Trim().TrimEnd(',') }), ";
                    _str = "";
                    
                    if (progressindicate.GetInterval() > 4000)
                    {
                        ExecuteQuery( _mSQLHead + _mSQLValue.Trim().TrimEnd(','), progress, progressindicate);

                        progressindicate.ClearInterval();
                        _mSQLValue = "";
                    }

                }
                                

                if (_mSQLValue.Length != 0) ExecuteQuery(_mSQLHead + _mSQLValue.Trim().TrimEnd(','), progress, progressindicate);
                

            }
            
        }

        public void ExecuteQuery(string query, IProgress<ProgressIndicate> progress, ProgressIndicate progressindicate )
        {
            try
            {
                _command.CommandText = query; int _n = _command.ExecuteNonQuery();
                if (_n != progressindicate.GetInterval()) 
                    progressindicate.AddMessage($" Предупреждение: '{query.Substring(11, 20)}' запрошено {progressindicate.GetInterval()},  записано {_n} ");
            }
            catch (Exception ex)
            {
                 progressindicate.AddMessage($" Ошибка {progressindicate.GetInterval()}зап.: {ex.Message}. '{query.Substring(11, 20)}'");
            }
            finally 
            {
                if (progress != null) progress.Report(progressindicate);

            }
        }
    }
}
