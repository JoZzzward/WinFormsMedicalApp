using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JKHApp
{
    public partial class Form1 : Form
    {
        public static bool isAdmin;
        public Form1()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = true;
            dataGridView.AllowUserToDeleteRows = true;
            dataGridView.ReadOnly = isAdmin ? false : true;

            if (isAdmin)
                doctorsMenuItem.Visible = true;
            else 
                doctorsMenuItem.Visible = false; 
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            isAdmin = false;
            Login l = new Login();
            MessageBox.Show("Вы вышли из учетной записи");
            l.Show();
            Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e) =>
            Application.Exit();

        private void clientsMenuItem_Click(object sender, EventArgs e) => 
            dataGridView.DataSource = clientsTableAdapter.GetData();

        private void doctorsMenuItem_Click(object sender, EventArgs e) => 
            dataGridView.DataSource = doctorsTableAdapter.GetData();

        private void callsMenuItem_Click(object sender, EventArgs e) => 
            dataGridView.DataSource = callsTableAdapter.GetData();
        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.clientsTableAdapter.Fill(this.ambulanceDataSet.Пациенты);
            this.callsTableAdapter.Fill(this.ambulanceDataSet.Вызовы);
            this.doctorsTableAdapter.Fill(this.ambulanceDataSet.Врачи);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string sqlQuery = FilterSearchSqlQuery();
            
            FilterData(sqlQuery);
        }

        public string FilterSearchSqlQuery()
        {
            string sqlQuery = "";

            if (dataGridView.DataSource.ToString() 
                == "Вызовы")
                sqlQuery = $"Услуга LIKE '%{searchBox.Text}%'";
            else if (dataGridView.DataSource.ToString() 
                == "Пациенты")
                sqlQuery = $"Фамилия LIKE '%{searchBox.Text}%'";
            else if (dataGridView.DataSource.ToString() 
                == "Врачи")
                sqlQuery = $"Фамилия LIKE '%{searchBox.Text}%'";

            return sqlQuery;
        }
        public void FilterData(string sqlQuery)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView.DataSource;
            bs.Filter = sqlQuery;
            dataGridView.DataSource = bs;
        }
    }
}
