using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATM_Management_Machine
{
    public partial class deposit : Form
    {
        public deposit()
        {
            InitializeComponent();
            LoadWeatherData();
        }
       
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zubai\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        string Acc = login.AccNumber;

        private void Shutdown_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void balanceLbl_Click(object sender, EventArgs e)
        {
            
        }
        int oldbalance, newbalance;
        private void getbalance()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Balance FROM AccountTbl WHERE AccNum = '" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int balance = Convert.ToInt32(dt.Rows[0][0]);
            if (balance <= 0)
            {
                balanceLbl.Text = " Rs 0"; 
            }
            else
            {
                balanceLbl.Text = " Rs " + dt.Rows[0][0].ToString();
                oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString()); 
            }

            Con.Close();
            
            
          
        }
        private void deposit_Load(object sender, EventArgs e)
        {
            getbalance();

        }

        private void addtransaction()
        {
            string TrType = "Deposit";
            Con.Open();
            if (depositBox.Text == "" || Convert.ToInt32(depositBox.Text) <= 0)
            {
                MessageBox.Show("Enter The Amount To Deposit");
            }
            else
            {
                newbalance = oldbalance + Convert.ToInt32(depositBox.Text);
                try
                {
                    string query = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @TrType, @Amount, @TDate)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@AccNum", Acc);
                    cmd.Parameters.AddWithValue("@TrType", TrType);
                    cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(depositBox.Text));
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
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            if(depositBox.Text == "" || Convert.ToInt32(depositBox.Text) <= 0 )
            {
                MessageBox.Show("Enter The Amount To Deposit");
            }
            else
            {
                
                newbalance = oldbalance + Convert.ToInt32(depositBox.Text);
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance="+newbalance+"where Accnum = '"+Acc+ "'";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Deposit");
                    Con.Close();
                    addtransaction();
                    home Home = new home();
                    Home.Show();
                    this.Hide();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void depositBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            home Home = new home();
            Home.Show();
            this.Hide();

        }

        private void helpBtn_CheckedChanged(object sender, EventArgs e)
        {
            help Help = new help();
            Help.Show();
            this.Hide();
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
    }
}


