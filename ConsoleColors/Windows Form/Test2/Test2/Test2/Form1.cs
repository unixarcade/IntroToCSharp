using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "L";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            MessageBox.Show("Name is " + name
                + "\nx is " + x
                + "\nd is " + d);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                MessageBox.Show(" x must be 10");
            }
            else
            {
                MessageBox.Show("x is " + x);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int someValue = 3;
            string name = "Superstar in code";
            if ((someValue == 3) && (name == "Superstar in code"))
            {
                MessageBox.Show(" x \n is \n and \n the \n name \n is \n " + name);
            }
            MessageBox.Show(" Code Flow");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;

            while (count < 10)
            {
                count = count + 1;
            }

            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }
            MessageBox.Show("The answer is " + count);
        }

        
    }
}
