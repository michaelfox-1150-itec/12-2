﻿using System;
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
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private Form1 mainForm = null;
        public OptionsForm(Form Form1)
        {
            mainForm = Form1 as Form1;
            InitializeComponent();
        }
        

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
