using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void DisplayTimer()
        {
            System.Timers.Timer ticketTimer = new System.Timers.Timer();
            ticketTimer.Interval = 15000;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {

            Form options = new Form();
            options.Show();
        }

        public string minutesPerWindow()
        {
            get { return txtMinutesPerWindow.Text; }
            set { txtMinutesPerWindow = value; }
        }
    }
}
