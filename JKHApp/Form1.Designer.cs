namespace JKHApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jKHInfoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jKHInfoDataSet = new JKHApp.JKHInfoDataSet();
            this.tariffReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExitBtn = new System.Windows.Forms.Button();
            this.payerTableAdapter = new JKHApp.JKHInfoDataSetTableAdapters.PayerTableAdapter();
            this.SendDataBtn = new System.Windows.Forms.Button();
            this.ProfileBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.payerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tariffReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeTableAdapter = new JKHApp.JKHInfoDataSetTableAdapters.HomeTableAdapter();
            this.apartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentTableAdapter = new JKHApp.JKHInfoDataSetTableAdapters.ApartmentTableAdapter();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyTableAdapter = new JKHApp.JKHInfoDataSetTableAdapters.CompanyTableAdapter();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptTableAdapter = new JKHApp.JKHInfoDataSetTableAdapters.ReceiptTableAdapter();
            this.tariffReceiptTableAdapter = new JKHApp.JKHInfoDataSetTableAdapters.TariffReceiptTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jKHInfoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jKHInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffReceiptBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.payerBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(0, 93);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(800, 359);
            this.dataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.middleNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // payerBindingSource
            // 
            this.payerBindingSource.DataMember = "Payer";
            this.payerBindingSource.DataSource = this.jKHInfoDataSetBindingSource;
            // 
            // jKHInfoDataSetBindingSource
            // 
            this.jKHInfoDataSetBindingSource.DataSource = this.jKHInfoDataSet;
            this.jKHInfoDataSetBindingSource.Position = 0;
            // 
            // jKHInfoDataSet
            // 
            this.jKHInfoDataSet.DataSetName = "JKHInfoDataSet";
            this.jKHInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tariffReceiptBindingSource
            // 
            this.tariffReceiptBindingSource.DataMember = "TariffReceipt";
            this.tariffReceiptBindingSource.DataSource = this.jKHInfoDataSetBindingSource;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Location = new System.Drawing.Point(709, 41);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(79, 34);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // payerTableAdapter
            // 
            this.payerTableAdapter.ClearBeforeFill = true;
            // 
            // SendDataBtn
            // 
            this.SendDataBtn.BackColor = System.Drawing.Color.Orange;
            this.SendDataBtn.Location = new System.Drawing.Point(0, 31);
            this.SendDataBtn.Name = "SendDataBtn";
            this.SendDataBtn.Size = new System.Drawing.Size(152, 54);
            this.SendDataBtn.TabIndex = 4;
            this.SendDataBtn.Text = "ВНЕСТИ ДАННЫЕ";
            this.SendDataBtn.UseVisualStyleBackColor = false;
            this.SendDataBtn.Click += new System.EventHandler(this.SendDataBtn_Click);
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ProfileBtn.Location = new System.Drawing.Point(621, 41);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(82, 34);
            this.ProfileBtn.TabIndex = 5;
            this.ProfileBtn.Text = "PROFILE";
            this.ProfileBtn.UseVisualStyleBackColor = false;
            this.ProfileBtn.Click += new System.EventHandler(this.ProfileBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payerToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.apartmentToolStripMenuItem,
            this.companyToolStripMenuItem,
            this.receiptToolStripMenuItem,
            this.tariffReceiptToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // payerToolStripMenuItem
            // 
            this.payerToolStripMenuItem.Name = "payerToolStripMenuItem";
            this.payerToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.payerToolStripMenuItem.Text = "Payer";
            this.payerToolStripMenuItem.Click += new System.EventHandler(this.payerToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // apartmentToolStripMenuItem
            // 
            this.apartmentToolStripMenuItem.Name = "apartmentToolStripMenuItem";
            this.apartmentToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.apartmentToolStripMenuItem.Text = "Apartment";
            this.apartmentToolStripMenuItem.Click += new System.EventHandler(this.apartmentToolStripMenuItem_Click);
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.companyToolStripMenuItem.Text = "Company";
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.companyToolStripMenuItem_Click);
            // 
            // receiptToolStripMenuItem
            // 
            this.receiptToolStripMenuItem.Name = "receiptToolStripMenuItem";
            this.receiptToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.receiptToolStripMenuItem.Text = "Receipt";
            this.receiptToolStripMenuItem.Click += new System.EventHandler(this.receiptToolStripMenuItem_Click);
            // 
            // tariffReceiptToolStripMenuItem
            // 
            this.tariffReceiptToolStripMenuItem.Name = "tariffReceiptToolStripMenuItem";
            this.tariffReceiptToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.tariffReceiptToolStripMenuItem.Text = "Tariff Receipt";
            this.tariffReceiptToolStripMenuItem.Click += new System.EventHandler(this.tariffReceiptToolStripMenuItem_Click);
            // 
            // homeBindingSource
            // 
            this.homeBindingSource.DataMember = "Home";
            this.homeBindingSource.DataSource = this.jKHInfoDataSetBindingSource;
            // 
            // homeTableAdapter
            // 
            this.homeTableAdapter.ClearBeforeFill = true;
            // 
            // apartmentBindingSource
            // 
            this.apartmentBindingSource.DataMember = "Apartment";
            this.apartmentBindingSource.DataSource = this.jKHInfoDataSetBindingSource;
            // 
            // apartmentTableAdapter
            // 
            this.apartmentTableAdapter.ClearBeforeFill = true;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.jKHInfoDataSetBindingSource;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "Receipt";
            this.receiptBindingSource.DataSource = this.jKHInfoDataSetBindingSource;
            // 
            // receiptTableAdapter
            // 
            this.receiptTableAdapter.ClearBeforeFill = true;
            // 
            // tariffReceiptTableAdapter
            // 
            this.tariffReceiptTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProfileBtn);
            this.Controls.Add(this.SendDataBtn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jKHInfoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jKHInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffReceiptBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource jKHInfoDataSetBindingSource;
        private JKHInfoDataSet jKHInfoDataSet;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.BindingSource payerBindingSource;
        private JKHInfoDataSetTableAdapters.PayerTableAdapter payerTableAdapter;
        private System.Windows.Forms.Button SendDataBtn;
        private System.Windows.Forms.Button ProfileBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem payerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tariffReceiptToolStripMenuItem;
        private System.Windows.Forms.BindingSource homeBindingSource;
        private JKHInfoDataSetTableAdapters.HomeTableAdapter homeTableAdapter;
        private System.Windows.Forms.BindingSource apartmentBindingSource;
        private JKHInfoDataSetTableAdapters.ApartmentTableAdapter apartmentTableAdapter;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private JKHInfoDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private JKHInfoDataSetTableAdapters.ReceiptTableAdapter receiptTableAdapter;
        private System.Windows.Forms.BindingSource tariffReceiptBindingSource;
        private JKHInfoDataSetTableAdapters.TariffReceiptTableAdapter tariffReceiptTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}

