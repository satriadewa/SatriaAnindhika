﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBL;

namespace Terbilang
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

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 trb = new Class1();

            int nominal = int.Parse(textBox1.Text);
            textBox2.Text = Convert.ToString(trb.TerbilangIndonesia(nominal));
        }       
            
    }
}
