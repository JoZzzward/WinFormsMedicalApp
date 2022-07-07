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
            this.кодПациентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодЛичногоВрачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ambulanceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ambulanceDataSet = new JKHApp.AmbulanceDataSet();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsTableAdapter = new JKHApp.AmbulanceDataSetTableAdapters.ВрачиTableAdapter();
            this.callsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.callsTableAdapter = new JKHApp.AmbulanceDataSetTableAdapters.ВызовыTableAdapter();
            this.clientsTableAdapter = new JKHApp.AmbulanceDataSetTableAdapters.ПациентыTableAdapter();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПациентаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.кодЛичногоВрачаDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.clientsBindingSource;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.Location = new System.Drawing.Point(0, 93);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(800, 359);
            this.dataGridView.TabIndex = 0;
            // 
            // кодПациентаDataGridViewTextBoxColumn
            // 
            this.кодПациентаDataGridViewTextBoxColumn.DataPropertyName = "КодПациента";
            this.кодПациентаDataGridViewTextBoxColumn.HeaderText = "КодПациента";
            this.кодПациентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодПациентаDataGridViewTextBoxColumn.Name = "кодПациентаDataGridViewTextBoxColumn";
            this.кодПациентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодПациентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            this.фамилияDataGridViewTextBoxColumn.Width = 95;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            this.имяDataGridViewTextBoxColumn.Width = 62;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.ReadOnly = true;
            this.отчествоDataGridViewTextBoxColumn.Width = 99;
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "ДатаРождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "ДатаРождения";
            this.датаРожденияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            this.датаРожденияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаРожденияDataGridViewTextBoxColumn.Width = 133;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.ReadOnly = true;
            this.адресDataGridViewTextBoxColumn.Width = 76;
            // 
            // кодЛичногоВрачаDataGridViewTextBoxColumn
            // 
            this.кодЛичногоВрачаDataGridViewTextBoxColumn.DataPropertyName = "КодЛичногоВрача";
            this.кодЛичногоВрачаDataGridViewTextBoxColumn.HeaderText = "КодЛичногоВрача";
            this.кодЛичногоВрачаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодЛичногоВрачаDataGridViewTextBoxColumn.Name = "кодЛичногоВрачаDataGridViewTextBoxColumn";
            this.кодЛичногоВрачаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодЛичногоВрачаDataGridViewTextBoxColumn.Width = 156;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Пациенты";
            this.clientsBindingSource.DataSource = this.ambulanceDataSetBindingSource;
            // 
            // ambulanceDataSetBindingSource
            // 
            this.ambulanceDataSetBindingSource.DataSource = this.ambulanceDataSet;
            this.ambulanceDataSetBindingSource.Position = 0;
            // 
            // ambulanceDataSet
            // 
            this.ambulanceDataSet.DataSetName = "AmbulanceDataSet";
            this.ambulanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(709, 41);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(79, 34);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "ВЫХОД";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsMenuItem,
            this.doctorsMenuItem,
            this.callsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(246, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientsMenuItem
            // 
            this.clientsMenuItem.Name = "clientsMenuItem";
            this.clientsMenuItem.Size = new System.Drawing.Size(94, 24);
            this.clientsMenuItem.Text = "Пациенты";
            this.clientsMenuItem.Click += new System.EventHandler(this.clientsMenuItem_Click);
            // 
            // doctorsMenuItem
            // 
            this.doctorsMenuItem.Name = "doctorsMenuItem";
            this.doctorsMenuItem.Size = new System.Drawing.Size(66, 24);
            this.doctorsMenuItem.Text = "Врачи";
            this.doctorsMenuItem.Click += new System.EventHandler(this.doctorsMenuItem_Click);
            // 
            // callsMenuItem
            // 
            this.callsMenuItem.Name = "callsMenuItem";
            this.callsMenuItem.Size = new System.Drawing.Size(78, 24);
            this.callsMenuItem.Text = "Вызовы";
            this.callsMenuItem.Click += new System.EventHandler(this.callsMenuItem_Click);
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Врачи";
            this.doctorsBindingSource.DataSource = this.ambulanceDataSetBindingSource;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // callsBindingSource
            // 
            this.callsBindingSource.DataMember = "Вызовы";
            this.callsBindingSource.DataSource = this.ambulanceDataSetBindingSource;
            // 
            // callsTableAdapter
            // 
            this.callsTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(67, 47);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(123, 22);
            this.searchBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Поиск:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Green;
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(196, 41);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(79, 34);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "ПОИСК";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callsMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ambulanceDataSetBindingSource;
        private AmbulanceDataSet ambulanceDataSet;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private AmbulanceDataSetTableAdapters.ВрачиTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.BindingSource callsBindingSource;
        private AmbulanceDataSetTableAdapters.ВызовыTableAdapter callsTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private AmbulanceDataSetTableAdapters.ПациентыTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПациентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЛичногоВрачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
    }
}

