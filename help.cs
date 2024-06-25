using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Management_Machine
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void help_Load(object sender, EventArgs e)
        {

        }

        private void dhelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deposit: Store Money Into Your Account\n" +
                "Enter the amount you wish to store in your bank and press deposit!");
        }

        private void wdhelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Withdraw: Retrieve Money From Your Account\n" +
               "Enter the amount you wish to retrieve from your bank and press withdraw!");
        }

        private void bhelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Balance: Your Remaining Money! \n");
        }

        private void mshelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mini-Statement: Your Account Details\n" );
        }

        private void fchelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fast Cash: Quick Money Withdraw!\n");
        }

        private void cphelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change Pin: Change You Pin Code!\n" +
               "You are supposed to enter your new pin code and please remember it!");
        }

        private void lhelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login: Created Account!\n" +
               "Enter your account number and pin code in order to access further options");
        }

        private void rhelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register: Creating New Account\n" +
               "Enter your information accoringly");
        }

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

        private void Btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deposit: Store Money Into Your Account\n" +
                "Enter the amount you wish to store in your bank and press deposit!");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Withdraw: Retrieve Money From Your Account\n" +
               "Enter the amount you wish to retrieve from your bank and press withdraw!");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login: Created Account!\n" +
               "Enter your account number and pin code in order to access further options");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register: Creating New Account\n" +
               "Enter your information accoringly");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Balance: Your Remaining Money! \n");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mini-Statement: Your Account Details\n");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fast Cash: Quick Money Withdraw!\n");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Change Pin: Change You Pin Code!\n" +
               "You are supposed to enter your new pin code and please remember it!");

        }
    }
}
