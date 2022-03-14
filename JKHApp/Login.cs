using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JKHApp
{
    public partial class Login : Form
    {
        public static string login;
        public static string password;

        public Login()
        {
            InitializeComponent();
        }

        private void loginEnter_Click(object sender, EventArgs e)
        {
            AppDBContext db = new AppDBContext();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand(
                $"SELECT * FROM Payer WHERE LastName = '{loginText.Text}' AND Password = '{loginPassword.Text}'", db.GetConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            login = loginText.Text;
            password = loginPassword.Text;

            if (loginText.Text == "Дьяконов" && loginPassword.Text == "111")
                Form1.isAdmin = true;
            else
                Form1.isAdmin = false;
            if (dt.Rows.Count > 0)
            {
                Form1 f = new Form1();
                Hide();
                f.Show();
            }
            else
                MessageBox.Show("No");
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
