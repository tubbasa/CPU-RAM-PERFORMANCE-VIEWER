﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPURAM
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRam.NextValue();
            progressBarCPU.Value = (int)fcpu;
            progressBarRAM.Value = (int)fram;
            lblCPU.Text = string.Format("{0:0.00}% ",fcpu);
            lblRAM.Text = string.Format("{0:0.00}% ", fram);
        }

      
    }
}
