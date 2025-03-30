using System;
using System.Data.SQLite;
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

        private void UpdateDataView()
        {
            using (DataSet ds = new DataSet())
            {
                _databaseAccessService.GetDatabaseData().Fill(ds);
                dataView.DataSource = ds.Tables[0];
                dataView.Refresh();
            }
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
            try
            {
                using (DataTable dt = new DataTable())
                {
                    _databaseAccessService.ExecuteQuery(queryBox.Text).Fill(dt);
                    dataView.DataSource = dt;
                }

                logWindow.Text = "";
            }

            catch (SQLiteException ex)
            {
                logWindow.Text = ex.Message;
            }
        }

        private void CloseClick(object sender, EventArgs e)
        {
            _databaseAccessService.CloseConnection();
            dataView.DataSource = null;
            executeQuery.Visible = false;
            closeDatabase.Visible = false;
        }
    }
}