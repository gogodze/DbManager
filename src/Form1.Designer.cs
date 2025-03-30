namespace DbManager
{
    partial class DatabaseManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseManager));
            this.dataView = new System.Windows.Forms.DataGridView();
            this.queryBox = new System.Windows.Forms.TextBox();
            this.loadDatabase = new System.Windows.Forms.Button();
            this.createDatabase = new System.Windows.Forms.Button();
            this.executeQuery = new System.Windows.Forms.Button();
            this.logWindow = new System.Windows.Forms.TextBox();
            this.closeDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            //
            // dataView
            //
            this.dataView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataView, "dataView");
            this.dataView.Name = "dataView";
            //
            // queryBox
            //
            resources.ApplyResources(this.queryBox, "queryBox");
            this.queryBox.Name = "queryBox";
            //
            // loadDatabase
            //
            resources.ApplyResources(this.loadDatabase, "loadDatabase");
            this.loadDatabase.Name = "loadDatabase";
            this.loadDatabase.UseVisualStyleBackColor = true;
            this.loadDatabase.Click += new System.EventHandler(this.LoadDatabase);
            //
            // createDatabase
            //
            resources.ApplyResources(this.createDatabase, "createDatabase");
            this.createDatabase.Name = "createDatabase";
            this.createDatabase.UseVisualStyleBackColor = true;
            this.createDatabase.Click += new System.EventHandler(this.CreateDatabase);
            //
            // executeQuery
            //
            resources.ApplyResources(this.executeQuery, "executeQuery");
            this.executeQuery.Name = "executeQuery";
            this.executeQuery.UseVisualStyleBackColor = true;
            this.executeQuery.Click += new System.EventHandler(this.ExecuteQuery);
            //
            // logWindow
            //
            resources.ApplyResources(this.logWindow, "logWindow");
            this.logWindow.Name = "logWindow";
            this.logWindow.ReadOnly = true;
            //
            // closeDatabase
            //
            resources.ApplyResources(this.closeDatabase, "closeDatabase");
            this.closeDatabase.Name = "closeDatabase";
            this.closeDatabase.UseVisualStyleBackColor = true;
            this.closeDatabase.Click += new System.EventHandler(this.CloseClick);
            //
            // DatabaseManager
            //
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeDatabase);
            this.Controls.Add(this.logWindow);
            this.Controls.Add(this.executeQuery);
            this.Controls.Add(this.createDatabase);
            this.Controls.Add(this.loadDatabase);
            this.Controls.Add(this.queryBox);
            this.Controls.Add(this.dataView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DatabaseManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.TextBox queryBox;
        private System.Windows.Forms.Button loadDatabase;
        private System.Windows.Forms.Button createDatabase;
        private System.Windows.Forms.Button executeQuery;
        private System.Windows.Forms.TextBox logWindow;
        private System.Windows.Forms.Button closeDatabase;
    }
}

