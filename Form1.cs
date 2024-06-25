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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int starting = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            starting += 1;
            Myprogress.Value = starting;
            perLbl.Text =""+ starting;
            if(Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer.Stop();
                login Log = new login();
                this.Hide();
                Log.Show();

            }
            else
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
