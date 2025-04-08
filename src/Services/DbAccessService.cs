using System.Data;
using System.Data.SQLite;
using DbManager.Abstractions;
using DbManager.Util.Factory;

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
            var getTableQuery = $"SELECT * FROM {tableName}";
            using (var adapter = SqLiteDataAdapterFactory.CreateDataAdapter
                       (SqLiteCommandFactory.CreateCommand(getTableQuery, _connection)))
            {
                return DataSetFactory.CreateAdFillDataSet(adapter);
            }
        }

        public DataSet GetTables()
        {
            var getTablesQuery =
                "SELECT name FROM sqlite_master WHERE type = 'table'";
            using (var adapter = SqLiteDataAdapterFactory.CreateDataAdapter
                       (SqLiteCommandFactory.CreateCommand(getTablesQuery, _connection)))
            {
                return DataSetFactory.CreateAdFillDataSet(adapter);
            }
        }

        public bool ExecuteQuery(string query, out DataSet result, out string errorMessage)
        {
            try
            {
                using (var adapter = SqLiteDataAdapterFactory.CreateDataAdapter
                           (SqLiteCommandFactory.CreateCommand(query, _connection)))
                {
                    result = DataSetFactory.CreateAdFillDataSet(adapter);
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

        public bool ExecuteNonQuery(string query, out int rowsAffected, out string errorMessage)
        {
            try
            {
                errorMessage = null;
                rowsAffected = SqLiteCommandFactory.CreateCommand(query, _connection)
                    .ExecuteNonQuery();
                return true;
            }
            catch (SQLiteException ex)
            {
                errorMessage = ex.Message;
                rowsAffected = 0;
                return false;
            }
        }

        public void CloseConnection()
        {
            _connection.Close();
        }
    }
}