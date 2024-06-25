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

namespace ATM_Management_Machine
{
    public partial class transfer : Form
    {
        public transfer()
        {
            InitializeComponent();
        }
        private void transfer_Load(object sender, EventArgs e)
        {

        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            home Home = new home();
            Home.Show();
            this.Hide();
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zubai\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        int oldbalance, newbalance;


        private void transferBtn_Click(object sender, EventArgs e)
        {
            int senderAccNum = Convert.ToInt32(senderAccNumTextBox.Text);
            int receiverAccNum = Convert.ToInt32(receiverAccNumTextBox.Text);
            int amount = Convert.ToInt32(accAmount.Text);

            try
            {
                Con.Open();

                // Retrieve sender's old balance and check if it's sufficient
                string getSenderBalanceQuery = "SELECT Balance FROM AccountTbl WHERE AccNum = @SenderAccNum";
                SqlCommand cmd = new SqlCommand(getSenderBalanceQuery, Con);
                cmd.Parameters.AddWithValue("@SenderAccNum", senderAccNum);
                int senderOldBalance = (int)cmd.ExecuteScalar();

                if (senderOldBalance < amount)
                {
                    MessageBox.Show("Insufficient funds in sender's account.");
                    Con.Close();
                    return;
                }

                // Update sender's balance
                string updateSenderBalanceQuery = "UPDATE AccountTbl SET Balance = Balance - @Amount WHERE AccNum = @SenderAccNum";
                cmd = new SqlCommand(updateSenderBalanceQuery, Con);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@SenderAccNum", senderAccNum);
                cmd.ExecuteNonQuery();

                // Update receiver's balance
                string updateReceiverBalanceQuery = "UPDATE AccountTbl SET Balance = Balance + @Amount WHERE AccNum = @ReceiverAccNum";
                cmd = new SqlCommand(updateReceiverBalanceQuery, Con);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@ReceiverAccNum", receiverAccNum);
                cmd.ExecuteNonQuery();

                // Add transaction record
                string addTransactionQuery = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @Type, @Amount, @TDate)";
                cmd = new SqlCommand(addTransactionQuery, Con);
                cmd.Parameters.AddWithValue("@AccNum", senderAccNum);
                cmd.Parameters.AddWithValue("@Type", "Transfer");
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@TDate", DateTime.Today.Date);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Transfer completed successfully!");

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}








