using System.Data;

namespace DbManager.Abstractions
{
    public interface IDatabaseAccessService
    {
        void ConnectToDatabase(string databaseName);
        DataSet GetTables();

        DataSet GetDataFromTable(string tableName);
        bool ExecuteQuery(string query, out DataSet result, out string errorMessage);
        int ExecuteNonQuery(string query, out string errorMessage);
        void CloseConnection();
    }
}