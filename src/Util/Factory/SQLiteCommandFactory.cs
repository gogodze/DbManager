using System.Data.SQLite;

namespace DbManager.Util.Factory
{
    public static class SqLiteCommandFactory
    {
        public static SQLiteCommand CreateCommand(string query, SQLiteConnection connection)
        {
            return new SQLiteCommand(query, connection);
        }
    }
}