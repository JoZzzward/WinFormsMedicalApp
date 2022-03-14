using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JKHApp
{
    public partial class Form1 : Form
    {
        AppDBContext db;
        SqlDataAdapter adapter;
        DataTable dt;
        public static bool isAdmin;
        public Form1()
        {
            InitializeComponent();
            db = new AppDBContext();
            adapter = new SqlDataAdapter();
            dt = new DataTable();
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Payer", db.GetConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            if (isAdmin)
                SendDataBtn.Visible = true;
            else
                SendDataBtn.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jKHInfoDataSet.TariffReceipt' table. You can move, or remove it, as needed.
            this.tariffReceiptTableAdapter.Fill(this.jKHInfoDataSet.TariffReceipt);
            // TODO: This line of code loads data into the 'jKHInfoDataSet.Receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter.Fill(this.jKHInfoDataSet.Receipt);
            // TODO: This line of code loads data into the 'jKHInfoDataSet.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.jKHInfoDataSet.Company);
            // TODO: This line of code loads data into the 'jKHInfoDataSet.Apartment' table. You can move, or remove it, as needed.
            this.apartmentTableAdapter.Fill(this.jKHInfoDataSet.Apartment);
            // TODO: This line of code loads data into the 'jKHInfoDataSet.Home' table. You can move, or remove it, as needed.
            this.homeTableAdapter.Fill(this.jKHInfoDataSet.Home);
            // TODO: This line of code loads data into the 'jKHInfoDataSet.Payer' table. You can move, or remove it, as needed.
            this.payerTableAdapter.Fill(this.jKHInfoDataSet.Payer);
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы вышли из учетной записи");
            Form1.isAdmin = false;
            Login.login = "";
            Login.password = "";
            SendDataBtn.Visible = false;
        }


        private void SendDataBtn_Click(object sender, EventArgs e)
        {
            EnterData ed = new EnterData();
            ed.ShowDialog();
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            if (Login.login != "" && Login.password != "")
            {
                ProfileForm p = new ProfileForm();
                p.ShowDialog();
            }
            else
            {
                Login l = new Login();
                Login.login = "";
                Login.password = "";
                Hide();
                l.ShowDialog();
            }
        }

        private void payerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = "payerBindingSource";
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = "homeBindingSource";
        }

        private void apartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = "apartmentBindingSource";
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = "companyBindingSource";
        }

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = "receiptBindingSource";
        }

        private void tariffReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = "tariffReceiptBindingSource";
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Внесение данных через настройки админа
         * db = new AppDBContext();
        adapter = new SqlDataAdapter();
        dt = new DataTable();

        db.OpenConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO Pay", db.GetConnection());
        adapter.SelectCommand = cmd;
            adapter.Fill(dt);
        */
    }
}
