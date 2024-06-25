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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            LoadWeatherData();


        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zubai\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void signupBtn_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccNametb.Text == "" || AccNumTb.Text == "" || PhoneTb.Text == "" || Addresstb.Text == "" || pintb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into AccountTbl (AccNum, Name, Dob, Phone, Address, Gender, PIN, Balance) values (@AccNum, @AccName, @Dob, @Phone, @Address, @Gender, @Pin, @Bal)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@AccNum", AccNumTb.Text);
                    cmd.Parameters.AddWithValue("@AccName", AccNametb.Text);
                    cmd.Parameters.AddWithValue("@Dob", dobdate.Value.Date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Phone", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@Address", Addresstb.Text);
                    string genderValue = GenderTb.SelectedItem?.ToString();
                    if (genderValue == null)
                    {
                        MessageBox.Show("Please select a gender.");
                        return;
                    }
                    Console.WriteLine("Selected Gender: " + genderValue); 
                    cmd.Parameters.AddWithValue("@Gender", genderValue);
                    cmd.Parameters.AddWithValue("@PIN", pintb.Text); 
                    cmd.Parameters.AddWithValue("@Bal", bal);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    Con.Close();
                    login log = new login();
                    log.Show();
                    this.Hide();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    
        

        private void Btn5_Click(object sender, EventArgs e)
        {
            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {

        }

       
        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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

