using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JKHApp
{
    public partial class Form3 : Form
    {
        DataTable dt = new DataTable();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sqlCommand = $"INSERT INTO 'Выпуск газеты' (Номер, " +
                        $"Дата, Выход объявления) VALUES ( value1, value2, value3)";
            SqlCommand cmd = new SqlCommand(sqlCommand, 
                AppDbContext.GetDBConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
        }
    }
}

