using System.Data;
using System.Data.SQLite;

namespace DbManager.Util.Factory
{
    public static class DataSetFactory
    {
        public static DataSet CreateAdFillDataSet(SQLiteDataAdapter adapter)
        {
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet;
        }
    }
}