﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai10_bangcuuchuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTInhTong_Click(object sender, EventArgs e)
        {
            lsbBcc.Items.Clear();
            int so = Convert.ToInt32(txtso.Text);


            for (int i = 1; i <= 10; i++)
            {
                lsbBcc.Items.Add(so + " x " + i + " = " + so * i);

            }
        }
    }
}

        

        
    

