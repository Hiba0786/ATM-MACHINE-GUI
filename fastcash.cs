using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Management_Machine
{
    public partial class fastcash : Form
    {
        public fastcash()
        {
            InitializeComponent();
            LoadWeatherData();
           
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zubai\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        string Acc = login.AccNumber;
        int bal;

        private void Shutdown_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            home Home = new home();
            Home.Show();
            this.Hide();
        }



        
        private void fastcash_Load(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "SELECT Balance FROM AccountTbl WHERE Accnum = '" + Acc + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    bal = Convert.ToInt32(reader["Balance"]);
                }
                else
                {
                    MessageBox.Show("Error: Unable to retrieve balance.");
                }

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void addtransaction1()
        {
            string TrType = "Withdraw";
            Con.Open();

            try
            {
                string query = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @TrType, @Amount, @TDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@TrType", TrType);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(1000));
                cmd.Parameters.AddWithValue("@TDate", DateTime.Today.Date.ToString());

                cmd.ExecuteNonQuery();
                Con.Close();
                home Home = new home();
                Home.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Con.Close();
        }
        private void addtransaction2()
        {
            string TrType = "Withdraw";
            Con.Open();

            try
            {
                string query = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @TrType, @Amount, @TDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@TrType", TrType);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(2000));
                cmd.Parameters.AddWithValue("@TDate", DateTime.Today.Date.ToString());

                cmd.ExecuteNonQuery();
                Con.Close();
                home Home = new home();
                Home.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Con.Close();
        }
        private void addtransaction3()
        {
            string TrType = "Withdraw";
            Con.Open();

            try
            {
                string query = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @TrType, @Amount, @TDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@TrType", TrType);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(3000));
                cmd.Parameters.AddWithValue("@TDate", DateTime.Today.Date.ToString());

                cmd.ExecuteNonQuery();
                Con.Close();
                home Home = new home();
                Home.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Con.Close();
        }
        private void addtransaction4()
        {
            string TrType = "Withdraw";
            Con.Open();

            try
            {
                string query = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @TrType, @Amount, @TDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@TrType", TrType);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(4000));
                cmd.Parameters.AddWithValue("@TDate", DateTime.Today.Date.ToString());

                cmd.ExecuteNonQuery();
                Con.Close();
                home Home = new home();
                Home.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Con.Close();
        }
        private void addtransaction5()
        {
            string TrType = "Withdraw";
            Con.Open();

            try
            {
                string query = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @TrType, @Amount, @TDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@TrType", TrType);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(5000));
                cmd.Parameters.AddWithValue("@TDate", DateTime.Today.Date.ToString());

                cmd.ExecuteNonQuery();
                Con.Close();
                home Home = new home();
                Home.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Con.Close();
        }
        private void addtransaction6()
        {
            string TrType = "Withdraw";
            Con.Open();

            try
            {
                string query = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @TrType, @Amount, @TDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@TrType", TrType);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(6000));
                cmd.Parameters.AddWithValue("@TDate", DateTime.Today.Date.ToString());

                cmd.ExecuteNonQuery();
                Con.Close();
                home Home = new home();
                Home.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Con.Close();
        }
        private void addtransaction7()
        {
            string TrType = "Withdraw";
            Con.Open();

            try
            {
                string query = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @TrType, @Amount, @TDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@TrType", TrType);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(10000));
                cmd.Parameters.AddWithValue("@TDate", DateTime.Today.Date.ToString());

                cmd.ExecuteNonQuery();
                Con.Close();
                home Home = new home();
                Home.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Con.Close();
        }
        private void addtransaction8()
        {
            string TrType = "Withdraw";
            Con.Open();

            try
            {
                string query = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @TrType, @Amount, @TDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@TrType", TrType);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(20000));
                cmd.Parameters.AddWithValue("@TDate", DateTime.Today.Date.ToString());

                cmd.ExecuteNonQuery();
                Con.Close();
                home Home = new home();
                Home.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Con.Close();
        }


        private void rp1Btn_Click(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("Transaction Failed due to Insufficent Balance");

            }
            else
            {
                try
                {
                    int newbalance = bal - 1000;


                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + "where Accnum = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful Withdraw");
                        Con.Close();
                        addtransaction1();
                        
                        home Home = new home();
                        Home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("Transaction Failed due to Insufficent Balance");

            }
            else
            {
                try
                {
                    int newbalance = bal - 1000;


                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + "where Accnum = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful Withdraw");
                        Con.Close();
                        addtransaction1();
                        
                        home Home = new home();
                        Home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void rp2Btn_Click(object sender, EventArgs e)
        {
            if (bal < 2000)
            {
                MessageBox.Show("Transaction Failed due to Insufficent Balance");

            }
            else
            {
                try
                {
                    int newbalance = bal - 2000;


                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + "where Accnum = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful Withdraw");
                        Con.Close();
                        addtransaction2();
                        
                        home Home = new home();
                        Home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (bal < 2000)
            {
                MessageBox.Show("Transaction Failed due to Insufficent Balance");

            }
            else
            {
                try
                {
                    int newbalance = bal - 2000;


                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + "where Accnum = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful Withdraw");
                        Con.Close();
                        addtransaction2();
                        
                        home Home = new home();
                        Home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void rp3Btn_Click(object sender, EventArgs e)
        {
            if (bal < 3000)
            {
                MessageBox.Show("Transaction Failed due to Insufficent Balance");

            }
            else
            {
                try
                {
                    int newbalance = bal - 3000;


                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + "where Accnum = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful Withdraw");
                        Con.Close();
                        addtransaction3();
                        
                        home Home = new home();
                        Home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (bal < 3000)
            {
                MessageBox.Show("Transaction Failed due to Insufficent Balance");

            }
            else
            {
                try
                {
                    int newbalance = bal - 3000;


                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + "where Accnum = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful Withdraw");
                        Con.Close();
                        addtransaction3();
                        
                        home Home = new home();
                        Home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void rp4Btn_Click(object sender, EventArgs e)
        {
            if (bal < 4000)
            {
                MessageBox.Show("Transaction Failed due to Insufficent Balance");

            }
            else
            {
                try
                {
                    int newbalance = bal - 4000;


                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + "where Accnum = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful Withdraw");
                        Con.Close();
                        addtransaction4();
                       
                        home Home = new home();
                        Home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (bal < 4000)
            {
                MessageBox.Show("Transaction Failed due to Insufficent Balance");

            }
            else
            {
                try
                {
                    int newbalance = bal - 4000;


                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + "where Accnum = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful Withdraw");
                        Con.Close();
                        addtransaction4();
                        
                        home Home = new home();
                        Home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void rp5Btn_Click(object sender, EventArgs e)
        {
            if (bal < 5000)
            {
                MessageBox.Show("Transaction Failed due to Insufficent Balance");

            }
            else
            {
                try
                {
                    int newbalance = bal - 5000;


                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + "where Accnum = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful Withdraw");
                        Con.Close();
                        addtransaction5();
                       
                        home Home = new home();
                        Home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (bal < 5000)
            {
                MessageBox.Show("Transaction Failed due to Insufficent Balance");

            }
            else
            {
                try
                {
                    int newbalance = bal - 5000;


                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + "where Accnum = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful Withdraw");
                        Con.Close();
                        addtransaction5();
                      
                        home Home = new home();
                        Home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void rp6Btn_Click(object sender, EventArgs e)
        {
            if (bal < 6000)
            {
                MessageBox.Show("Transaction Failed due to Insufficent Balance");

            }
            else
            {
                try
                {
                    int newbalance = bal - 6000;


                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + "where Accnum = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful Withdraw");
                        Con.Close();
                        addtransaction6();
                      
                        home Home = new home();
                        Home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (bal < 6000)
            {
                MessageBox.Show("Transaction Failed due to Insufficent Balance");

            }
            else
            {
                try
                {
                    int newbalance = bal - 6000;


                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + "where Accnum = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful Withdraw");
                        Con.Close();
                        addtransaction6();
                        home Home = new home();
                        Home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void rp10Btn_Click(object sender, EventArgs e)
        {
            if (bal < 10000)
            {
                MessageBox.Show("Transaction Failed due to Insufficent Balance");

            }
            else
            {
                try
                {
                    int newbalance = bal - 10000;


                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + "where Accnum = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful Withdraw");
                        Con.Close();
                        addtransaction7();
                        home Home = new home();
                        Home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (bal < 10000)
            {
                MessageBox.Show("Transaction Failed due to Insufficent Balance");

            }
            else
            {
                try
                {
                    int newbalance = bal - 10000;


                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + "where Accnum = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful Withdraw");
                        Con.Close();
                        addtransaction7();
                        home Home = new home();
                        Home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void rp20Btn_Click(object sender, EventArgs e)
        {
            if (bal < 20000)
            {
                MessageBox.Show("Transaction Failed due to Insufficent Balance");

            }
            else
            {
                try
                {
                    int newbalance = bal - 20000;


                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + "where Accnum = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful Withdraw");
                        Con.Close();
                        addtransaction8();
                        home Home = new home();
                        Home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (bal < 20000)
            {
                MessageBox.Show("Transaction Failed due to Insufficent Balance");

            }
            else
            {
                try
                {
                    int newbalance = bal - 20000;


                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + "where Accnum = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful Withdraw");
                        Con.Close();
                        addtransaction8();
                        home Home = new home();
                        Home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }








        private async void LoadWeatherData()
        {
            string apiKey = "fc2a99d809e4325e62762e2adfa417e6";
            string cityName = "Islamabad";
            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q=Islamabad&appid=fc2a99d809e4325e62762e2adfa417e6&units=metric";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    JObject weatherData = JObject.Parse(responseBody);

                    string temperature = weatherData["main"]["temp"].ToString();
                    string description = weatherData["weather"][0]["description"].ToString();
                    string iconCode = weatherData["weather"][0]["icon"].ToString();
                    string iconUrl = $"http://openweathermap.org/img/wn/03n.png";

                    tempLbl.Text = $"Temperature: {temperature} °C";
                    desLbl.Text = $"Description: {description}";
                    cityLbl.Text = cityName;


                }
                catch (HttpRequestException httpEx)
                {
                    MessageBox.Show($"Error fetching weather data: {httpEx.Message}");
                }
            }
        }







        private void helpBtn_CheckedChanged(object sender, EventArgs e)
        {
            help Help = new help();
            Help.Show();
            this.Hide();
        }
    }
}
