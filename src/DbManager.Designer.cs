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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.queryBox = new System.Windows.Forms.TextBox();
            this.loadDatabase = new System.Windows.Forms.Button();
            this.createDatabase = new System.Windows.Forms.Button();
            this.executeInput = new System.Windows.Forms.Button();
            this.logWindow = new System.Windows.Forms.TextBox();
            this.closeDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.dataView, "dataView");
            this.dataView.MultiSelect = false;
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            // 
            // queryBox
            // 
            this.queryBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.queryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            // executeInput
            // 
            resources.ApplyResources(this.executeInput, "executeInput");
            this.executeInput.Name = "executeInput";
            this.executeInput.UseVisualStyleBackColor = true;
            this.executeInput.Click += new System.EventHandler(this.ExecuteInput);
            // 
            // logWindow
            // 
            this.logWindow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.logWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.closeDatabase);
            this.Controls.Add(this.logWindow);
            this.Controls.Add(this.executeInput);
            this.Controls.Add(this.createDatabase);
            this.Controls.Add(this.loadDatabase);
            this.Controls.Add(this.queryBox);
            this.Controls.Add(this.dataView);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Button executeInput;
        private System.Windows.Forms.TextBox logWindow;
        private System.Windows.Forms.Button closeDatabase;
    }
}

