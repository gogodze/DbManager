using System.Data;
using System.Data.SQLite;
using DbManager.Abstractions;

namespace DbManager.Services
{
    public sealed class DbAccessService : IDatabaseAccessService
    {
        private SQLiteConnection _connection;


        public void ConnectToDatabase(string databaseName)
        {
            _connection = new SQLiteConnection($"Data Source = {databaseName}; Version = 3;");
            _connection.Open();
        }

        public DataSet GetDataFromTable(string tableName)
        {
            using (var command = new SQLiteCommand($"SELECT * FROM {tableName}", _connection))
            using (var adapter = new SQLiteDataAdapter(command))
            {
                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
            }
        }

        public DataSet GetTables()
        {
            using (var command = new SQLiteCommand("SELECT name Tables FROM sqlite_master WHERE type = 'table' and name != 'sqlite_sequence'", _connection))
            using (var adapter = new SQLiteDataAdapter(command))
            {
                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
            }
        }

        public bool ExecuteQuery(string query, out DataSet result, out string errorMessage)
        {
            try
            {
                using (var command = new SQLiteCommand(query, _connection))
                using (var adapter = new SQLiteDataAdapter(command))
                {
                    var dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    result = dataSet;
                    errorMessage = null;
                    return true;
                }
            }

            catch (SQLiteException ex)
            {
                errorMessage = ex.Message;
                result = null;
                return false;
            }
        }

        public int ExecuteNonQuery(string query, out string errorMessage)
        {
            try
            {
                using (var command = new SQLiteCommand(query, _connection))
                {
                    errorMessage = null;
                    return command.ExecuteNonQuery();
                    ;
                }
            }
            catch (SQLiteException ex)
            {
                errorMessage = ex.Message;
                return 0;
            }
        }

        public void CloseConnection()
        {
            _connection.Close();
        }
    }
}