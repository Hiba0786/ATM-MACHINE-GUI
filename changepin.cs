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
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace ATM_Management_Machine
{
    public partial class changepin : Form
    {
        public changepin()
        {
            InitializeComponent();
            LoadWeatherData();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zubai\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        string Acc = login.AccNumber;
        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void cpinBtn_Click(object sender, EventArgs e)
        {
            if (pinBox.Text == "" || pin2Box.Text == "")
            {
                MessageBox.Show("Enter And Confirm The New Pin");
            }
            else if (pin2Box.Text != pinBox.Text)
            {
                MessageBox.Show("Pin1 and Pin2 are Different");
            }
            else
            {
                try
                {
                    // Open connection to the database
                    Con.Open();

                    // Prepare SQL update query to change PIN for the specified account number
                    string query = "UPDATE AccountTbl SET PIN = @NewPIN WHERE AccNum = @AccNum";

                    // Create SqlCommand object with the query and connection
                    SqlCommand cmd = new SqlCommand(query, Con);

                    // Add parameters to the query (to prevent SQL injection)
                    cmd.Parameters.AddWithValue("@NewPIN", pinBox.Text);
                    cmd.Parameters.AddWithValue("@AccNum", Acc); // Supply the value for AccNum parameter

                    // Execute the query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if the query affected any rows (i.e., if the PIN was updated)
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("PIN Successfully Changed");
                        // Close the connection
                        Con.Close();
                        // Redirect to the login form
                        login Login = new login();
                        Login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error: PIN not changed. Account number not found or PIN update failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Ensure connection is closed after use
                    Con.Close();
                }
            }
        }



        private void changepin_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
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

        private void helpBtn_CheckedChanged(object sender, EventArgs e)
        {
            help Help = new help();
            Help.Show();
            this.Hide();
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}


 