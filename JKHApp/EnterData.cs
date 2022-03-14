using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKHApp
{
    public partial class EnterData : Form
    {
        Form1 f;
        public EnterData()
        {
            InitializeComponent();
            f = new Form1();
        }

        private void EnterDataBtn_Click(object sender, EventArgs e)
        {
            AppDBContext db = new AppDBContext();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = new SqlCommand(
                $"INSERT INTO Payer (Name, LastName, MiddleName, Age, Address, Password) VALUES ( '{nameText.Text}', '{lastNameText.Text}', '{middleNameText.Text}', '{Convert.ToInt32(ageText.Text)}', '{addressText.Text}', '{passwordText.Text}')",
                db.GetConnection());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }

            /*for (int i = 0; i < ageText.Text.Length; i++)
            {
                if (ageText.Text[i] !=)
                    continue;
                else
                {
                    MessageBox.Show("Некоректный возраст!");
                    return;
                }
            }*/
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            f.Show();
            Hide();
        }

        private void BackEnterBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
