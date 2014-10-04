using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fwpeople
{
    public partial class Form1 : Form
    {
        object Woman;
        Woman nikki;
        Woman sharon;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();
            nikki = new Woman() { Cash = 100, Name = "Nikki" };
            sharon = new Woman() { Cash = 100, Name = "Sharon" };
            UpdateForm();
        }

        public void UpdateForm()
        {
            nikkisCashLabel.Text = nikki.Name + " has $" + nikki.Cash;
            sharonsCashLabel.Text = sharon.Name + " has $" + sharon.Cash;
            bankCashLabel.Text = " The bank has $" + bank;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= nikki.RecieveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show(" The bank is out of money.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += nikki.GiveCash(5);
            UpdateForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nikki.RecieveCash(sharon.GiveCash(5);
            UpdateForm();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sharon.RecieveCash(nikki.GiveCash(5));
            UpdateForm();
        }
    }
}
