using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fwcsharp
{
    public partial class Form1 : Form
    {
        bool mycheckbox;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mycheckbox == true)
            {
                label1.BackColor = Color.Azure;
            }
            else
            {
                MessageBox.Show("Contain the secrets");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
              mycheckbox = true;

            }
            else
            {
                mycheckbox = false;
                label1.BackColor = Color.Red;
            }
        }
    }
}
