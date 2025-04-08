using System.Data;

namespace DbManager.Abstractions
{
    public interface IDatabaseAccessService
    {
        void ConnectToDatabase(string databaseName);
        DataSet GetTables();

        DataSet GetDataFromTable(string tableName);
        bool ExecuteQuery(string query, out DataSet result, out string errorMessage);
        bool ExecuteNonQuery(string query, out int rowsAffected, out string errorMessage);
        void CloseConnection();
    }
}