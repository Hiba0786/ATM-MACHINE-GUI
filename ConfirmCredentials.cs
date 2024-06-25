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
    public partial class ConfirmCredentials : Form
    {
        public ConfirmCredentials()
        {
            InitializeComponent();
        }
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zubai\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        private void ConfirmCredentials_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // Parse the account number from the accNumTextBox
            int accountNumber;
            if (!int.TryParse(accNum.Text, out accountNumber))
            {
                MessageBox.Show("Please enter a valid account number.");
                return;
            }

            // Format the date of birth from the dobDate DateTimePicker control
            string birthday = dobdate.Value.Date.ToString("yyyy-MM-dd");

            // Connect to the database and retrieve user's credentials
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT AccNum, Dob FROM AccountTbl WHERE AccNum = @AccountNumber";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccountNumber", accountNumber);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Retrieve account number and date of birth from the database
                        int dbAccountNumber = (int)reader["AccNum"];
                        string dbBirthday = reader["Dob"].ToString();

                        // Compare the retrieved values with the values entered by the user
                        if (accountNumber == dbAccountNumber && birthday == dbBirthday)
                        {
                            MessageBox.Show("Credentials confirmed. Proceed to next step.");
                            changepin cp = new changepin();
                            cp.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error: Incorrect birthday or account number.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Account number not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            forgotpassword fp = new forgotpassword();
            fp.Show();
            this.Hide();
        }
    }
}
  