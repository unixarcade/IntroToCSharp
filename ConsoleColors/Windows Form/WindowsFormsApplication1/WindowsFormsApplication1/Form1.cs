﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

 
    public partial class Form1 : Form
    {
        string thebigvar;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Form1.Text = textBox1.Text;

            thebigvar = textBox1.Text;
            MessageBox.Show("Hello Friend");
            MessageBox.Show(thebigvar);
        }
    }
}
