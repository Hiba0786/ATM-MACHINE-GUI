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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            LoadWeatherData();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            register acc = new register();
            acc.Show();
            this.Hide();
        }
        public static String AccNumber;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zubai\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void loginBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where Accnum='" + accBox.Text + "'and PIN = " + pinBox.Text + "", Con);
            DataTable dt = new DataTable();
            
            if (accBox.Text == "" ||  pinBox.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                AccNumber = accBox.Text;

                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    home Home = new home();
                    Home.Show();
                    this.Hide();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Account Number Or PIN Code");

                }
            }
            Con.Close();
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void login_Load(object sender, EventArgs e)
        {

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

        private void forgotBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotpassword fp = new forgotpassword();
            fp.Show();
            this.Hide();
        }
    }
}
