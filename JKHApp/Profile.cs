using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JKHApp
{
    public partial class Profile : Form
    {
        Login l;
        Form1 f1;
        public Profile()
        {
            InitializeComponent();
            AppDBContext db = new AppDBContext();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            l = new Login();
            f1 = new Form1();



            SqlCommand cmd = new SqlCommand($"SELECT * FROM Payer WHERE LastName = '{Login.login}' AND Password = '{Login.password}'", db.GetConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Name.Text = dt.Rows[0]["Name"].ToString();
                LastName.Text = dt.Rows[0]["LastName"].ToString();
                MiddleName.Text = dt.Rows[0]["MiddleName"].ToString();
                Age.Text = dt.Rows[0]["Age"].ToString();
                Address.Text = dt.Rows[0]["Address"].ToString();
                Password.Text = dt.Rows[0]["Password"].ToString();
            }
            else
            {
                Form1.isAdmin = false;
                Hide();
                f1.Hide();
                l.ShowDialog();
            }
        }

        private void EditDataBtn_Click(object sender, EventArgs e)
        {
            AppDBContext db = new AppDBContext();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"UPDATE Payer SET Name = '{Name.Text}', LastName = '{LastName.Text}', MiddleName = '{MiddleName.Text}', Age = '{Convert.ToInt32(Age.Text)}', Address = '{Address.Text}', Password = '{Password.Text}' WHERE LastName = '{LastName.Text}'", db.GetConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            Refresh();
        }

        private void ProfileBackBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
