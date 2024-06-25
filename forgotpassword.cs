using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;


namespace ATM_Management_Machine
{
    public partial class forgotpassword : Form
    {
        public forgotpassword()
        {
            InitializeComponent();
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void forgotpassword_Load(object sender, EventArgs e)
        {
            
        }
       
       
     


        private void closeBtn_Click(object sender, EventArgs e)
        {
            login Login = new login();
            Login.Show();
            this.Hide();
        }

        private void qrBtn_Click(object sender, EventArgs e)
        {

            Random rand = new Random();
            int randomNumber = rand.Next(100000, 999999);


            Code128BarcodeDraw barcode = BarcodeDrawFactory.Code128WithChecksum;
            Image barcodeImage = barcode.Draw(randomNumber.ToString(), 40, 2);


            qrBox.Image = barcodeImage;

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ConfirmCredentials cc = new ConfirmCredentials();
            cc.Show();
            this.Hide();
        }
    }
}