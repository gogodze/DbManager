using System.Data.SQLite;

namespace DbManager.Util.Factory
{
    public static class SqLiteDataAdapterFactory
    {
        public static SQLiteDataAdapter CreateDataAdapter(SQLiteCommand command)
        {
            return new SQLiteDataAdapter(command);
        }
    }
}