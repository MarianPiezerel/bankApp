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
using System.Net;

namespace BankApp
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            LoadBalance();
        }

        private void LoadBalance()
        {
            welcomeLabel.Text = "Welcome" + CurrentUser.FirstName + CurrentUser.LastName;

            using (SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                con.Open();
                string query = "SELECT ISNULL(SUM(Amount), 0) FROM Transactions WHERE UserId = @UserId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserId", CurrentUser.Id);

                    object result = cmd.ExecuteScalar();
                    decimal balance = (result != DBNull.Value) ? Convert.ToDecimal(result) : 0;

                    balanceLabel.Text = "Your balance is:" + balance.ToString("C");
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SendMoneyButton_Click(object sender, EventArgs e)
        {

            decimal amount;
            if (!decimal.TryParse(amountTextBox.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            using (SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                con.Open();

                SqlTransaction transaction = con.BeginTransaction();

                try
                {

                    string receiverquery = "Insert Into Transactions (UserId, Amount, TransactionDate, Description) " +
                                    "Values((Select Id From UserInfo_New Where GeneratedIban = @iban), @amount, @transactionDate, @description)";
                    using (SqlCommand cmd = new SqlCommand(receiverquery, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@iban", receiverIbanTextBox.Text);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@transactionDate", DateTime.UtcNow);
                        cmd.Parameters.AddWithValue("@description", "money received from " + CurrentUser.FirstName);

                        cmd.ExecuteNonQuery();
                    }
                    string senderquery = "Insert Into Transactions (UserId, Amount, TransactionDate, Description) " +
                                    "Values(@senderId, @amount, @transactionDate, @description)";
                    using (SqlCommand command = new SqlCommand(senderquery, con, transaction))
                    {
                        command.Parameters.AddWithValue("@senderId", CurrentUser.Id);
                        command.Parameters.AddWithValue("@amount", -amount);
                        command.Parameters.AddWithValue("@transactionDate", DateTime.UtcNow);
                        command.Parameters.AddWithValue("@description", "money sent");

                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    MessageBox.Show("Transfer failed!");
                    return;
                }


                LoadBalance();

            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void balanceLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
