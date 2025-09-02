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

namespace BankApp
{
    public partial class Login : Form
    {
        public Login()
        {
            
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool loginSuccess = false;

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                string query = "SELECT Id, FirstName, LastName, EmailAddress " +
                               "FROM UserInfo_New " +
                               "WHERE EmailAddress = @EmailAddress AND Pin = @Pin";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmailAddress", loginEmailTextBox.Text);
                    cmd.Parameters.AddWithValue("@Pin", pinTextBox.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CurrentUser.Id = reader.GetInt32(0);
                            CurrentUser.FirstName = reader.GetString(1);
                            CurrentUser.LastName = reader.GetString(2);
                            CurrentUser.Email = reader.GetString(3);

                            loginSuccess = true;
                        }
                    }
                }
            }

            if (loginSuccess)
            {
                HomePage homePage = new HomePage();
                homePage.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register RegisterForm = new Register();
            RegisterForm.Show();
            this.Hide();
        }
    }
}
