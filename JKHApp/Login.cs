using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JKHApp
{
    public partial class Login : Form
    {
        AppDbContext db;
        public Login()
        {
            InitializeComponent();
            db = new AppDbContext();
        }

        private void loginEnter_Click(object sender, EventArgs e)
        {
            string sqlQuery = $"SELECT * FROM Врачи WHERE Фамилия = '{loginText.Text}' AND Специализация = '{loginPassword.Text}'";
            if (db.InvokeSqlQuery(sqlQuery) > 0)
            {
                Form1.isAdmin = (loginText.Text == "Геров" && loginPassword.Text == "Хирург") ? true : false;
                Form1 f = new Form1();
                Hide();
                f.Show();
            }
            else MessageBox.Show("Неправильный логин или пароль!");
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }
    }
}
