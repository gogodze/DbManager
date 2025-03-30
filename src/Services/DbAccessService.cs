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
        }

        public SQLiteDataAdapter GetDatabaseData()
        {
            return new SQLiteDataAdapter(
                "SELECT name Tables FROM sqlite_master WHERE type = 'table' and name != 'sqlite_sequence'", _connection
            );
        }

        public SQLiteDataAdapter ExecuteQuery(string query)
        {
            return new SQLiteDataAdapter(
                query, _connection
            );
        }

        public void CloseConnection()
        {
            _connection.Close();
        }
    }
}