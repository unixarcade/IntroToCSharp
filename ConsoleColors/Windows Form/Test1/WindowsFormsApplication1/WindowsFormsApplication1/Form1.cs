using System;
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
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            Int32 a = Convert.ToInt32(textBox1.Text);
            Int32 b = Convert.ToInt32(textBox1.Text);
            Int32 c = a + b;
           string d = Convert.ToString(c);
           label1.Text = d;
            MessageBox.Show(d); 
            //label1.Text = a + b;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
