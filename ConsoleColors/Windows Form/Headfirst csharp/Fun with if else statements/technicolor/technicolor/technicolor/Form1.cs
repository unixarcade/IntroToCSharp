using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace technicolor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;

            for (int x = 0; x <= 255; x++)
            {
                this.BackColor = Color.FromArgb(x, 255 - x, x);
                Application.DoEvents();
                Thread.Sleep(3);
            }
        }
    }
}
