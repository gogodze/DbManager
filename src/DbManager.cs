using System;
using System.Data;
using System.Windows.Forms;
using DbManager.Abstractions;

namespace DbManager
{
    public partial class DatabaseManager : Form
    {
        private readonly IFileAccessService _fileAccessService;
        private readonly IDatabaseAccessService _databaseAccessService;

        public DatabaseManager(IFileAccessService fileAccessService, IDatabaseAccessService databaseAccessService)
        {
            _fileAccessService = fileAccessService;
            _databaseAccessService = databaseAccessService;
            InitializeComponent();
        }

        private bool IsQuery(string sql)
        {
            sql = sql.Trim().ToUpper();


            if (sql.StartsWith("SELECT"))
            {
                return true;
            }
            else if (sql.StartsWith("INSERT") || sql.StartsWith("UPDATE") || sql.StartsWith("DELETE") || sql.StartsWith("CREATE"))
            {
                return false;
            }

            return false;
        }

        private void UpdateDataView(DataSet ds = null, string tableName = null)
        {
            if (ds != null)
            {
                dataView.DataSource = ds.Tables[0];
            }

            else if (string.IsNullOrEmpty(tableName))
            {
                dataView.DataSource = _databaseAccessService.GetTables().Tables[0];
            }
            else
            {
                dataView.DataSource = _databaseAccessService.GetDataFromTable(tableName).Tables[0];
            }

            dataView.Refresh();
        }

        private void LoadDatabase(object sender, EventArgs e)
        {
            if (_fileAccessService.ShowOpenDialog(out var filePath))
            {
                _databaseAccessService.ConnectToDatabase(filePath);
                UpdateDataView();
                executeQuery.Visible = true;
                closeDatabase.Visible = true;
            }

            else
            {
                MessageBox.Show(@"Please select a file to open", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CreateDatabase(object sender, EventArgs e)
        {
            try
            {
                if (_fileAccessService.ShowSaveDialog(out var filePath))
                {
                    _databaseAccessService.ConnectToDatabase(filePath);
                    UpdateDataView();
                    executeQuery.Visible = true;
                    closeDatabase.Visible = true;
                }

                else
                {
                    MessageBox.Show(@"Please select a location to save to", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                logWindow.Text = ex.Message;
            }
        }


        private void ExecuteQuery(object sender, EventArgs e)
        {
            if (_databaseAccessService.ExecuteQuery(queryBox.Text, out var result, out string error))
            {
                UpdateDataView(result);
                logWindow.Text = "";
            }

            else
            {
                logWindow.Text = error;
            }
        }

        private void CloseClick(object sender, EventArgs e)
        {
            _databaseAccessService.CloseConnection();
            dataView.DataSource = null;
            executeQuery.Visible = false;
            closeDatabase.Visible = false;
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string cellValue = dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                UpdateDataView(tableName: cellValue);
            }
        }
    }
}