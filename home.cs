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
    public partial class home : Form
    {
        public static string AccNumber { get; internal set; }

        public home()
        {
            InitializeComponent();
            LoadWeatherData();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zubai\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        string Acc = login.AccNumber;

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
                balanceLbl.Text = " Rs " + balance.ToString();
            }

            Con.Close(); ;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void balBtn_Click(object sender, EventArgs e)
        {
           balance balance = new balance();
            balance.Show();
            this.Hide();
        }

        private void home_Load(object sender, EventArgs e)
        {
            AccNumlbl.Text = "Account Number:  " + login.AccNumber;
            AccNumber = login.AccNumber;
            getbalance();

        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dBox_Click(object sender, EventArgs e)
        {
            deposit Deposit = new deposit();
            Deposit.Show();
            this.Hide();
        }

        private void cpBtn_Click(object sender, EventArgs e)
        {
            changepin pin = new changepin();
            pin.Show();
            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void wBtn_Click(object sender, EventArgs e)
        {
            withdraw Withdraw = new withdraw();
            Withdraw.Show();
            this.Hide();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            deposit Deposit = new deposit();
            Deposit.Show();
            this.Hide();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            withdraw Withdraw = new withdraw();
            Withdraw.Show();
            this.Hide();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            fastcash Fastcash = new fastcash();
            Fastcash.Show();
            this.Hide();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            ministatement Ministatement = new ministatement();
            Ministatement.Show();   
            this.Hide();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            transfer T = new transfer();
            T.Show();
            this.Hide();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            changepin Changepin = new changepin();
            Changepin.Show();   
            this.Hide();
        }

        private void fcBtn_Click(object sender, EventArgs e)
        {
            fastcash Fastcash = new fastcash();
            Fastcash.Show();
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

        private void msBtn_Click(object sender, EventArgs e)
        {
            ministatement Ministatement = new ministatement();
            Ministatement.Show();
            this.Hide();
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            transfer T = new transfer();
            T.Show();
            this.Hide();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
                  }

        private void button1_Click(object sender, EventArgs e)
        {
            help Help = new help();
            Help.Show();
            this.Hide();
        }

        private void helpBtn_CheckedChanged(object sender, EventArgs e)
        {
            help Help = new help();
            Help.Show();
            this.Hide();
        }

        private void balanceLbl_Click(object sender, EventArgs e)
        {

        }
    }
}

