using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JKHApp
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
            AppDBContext db = new AppDBContext();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
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
                Login l = new Login();
                Hide();
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

            this.Refresh();
        }

        private void ProfileBackBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
