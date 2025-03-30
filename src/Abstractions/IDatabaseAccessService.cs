using System.Data.SQLite;

namespace DbManager.Abstractions
{
    public interface IDatabaseAccessService
    {
        void ConnectToDatabase(string databaseName);
        SQLiteDataAdapter GetDatabaseData();
        void CloseConnection();
        SQLiteDataAdapter ExecuteQuery(string query);

    }
}