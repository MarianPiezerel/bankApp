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
using System.Net.Mail;
using System.Configuration;
using System.Net;

namespace BankApp
{
    public partial class Register : Form
    {
        bool free = false;
        public Register()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login LoginPage = new Login();
            LoginPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            string pin = rnd.Next(1000, 9999).ToString();

            using (SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                string query = "INSERT INTO UserInfo_New (FirstName, LastName, CNP, Sex, GeneratedIban, EmailAddress, Pin) VALUES (@FirstName, @LastName, @CNP, @sex, @generatedIban, @emailAddress, @pin)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@firstName", firstName.Text);
                cmd.Parameters.AddWithValue("@lastName", lastName.Text);
                cmd.Parameters.AddWithValue("@cnp", personalNumericCode.Text);
                cmd.Parameters.AddWithValue("@sex", free);
                cmd.Parameters.AddWithValue("@generatedIban", ibanTextBox.Text);
                cmd.Parameters.AddWithValue("@emailAddress", emailAddressTextBox.Text);
                cmd.Parameters.AddWithValue("@pin", pin);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("User registered!");


            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            {

                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("piezerelmarian1@gmail.com", "zzsf qpuj hrlt wdjj");
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("piezerelmarian1@gmail.com");
                    mail.To.Add(emailAddressTextBox.Text);
                    Console.WriteLine(emailAddressTextBox.Text);
                    mail.Subject = "Test Email";
                    mail.Body = $"Hello {lastName.Text} {lastName.Text} your pin is {pin}";
                    client.Send(mail);
                }
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void ibanTextBox_TextChanged(object sender, EventArgs e)
        {
            //ibanTextBox.Text = "RO25INGB12312413" + "";
        }

        private void generateIban_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            //int randomNumber = rnd.Next(10000, 999999);
            ibanTextBox.Text = "RO25INGB12312413" + rnd.Next(100000, 999999).ToString();
        }

        private void radioButtonDa_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDa.Checked)
            {
                free = true;
            }
        }

        private void sendEmailTest_Click(object sender, EventArgs e)
        {
            
        }
    }
}
