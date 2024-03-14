using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritingStatsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool greaterHP = true;
        bool greaterAtk = true;
        bool greaterDef = true;
        bool greaterSpA = true;
        bool greaterSpD = true;
        bool greaterSpe = true;





        private void greaterHPButton_Click(object sender, EventArgs e)
        {
            if (greaterHP)
            {
                greaterHPButton.Text = "<";
                greaterHP = false;
            }
            else
            {
                greaterHPButton.Text = "≥";
                greaterHP = true;
            }
        }

        private void greaterAtkButton_Click(object sender, EventArgs e)
        {
            if (greaterAtk)
            {
                greaterAtkButton.Text = "<";
                greaterAtk = false;
            }
            else
            {
                greaterAtkButton.Text = "≥";
                greaterAtk = true;
            }
        }

        private void greaterDefButton_Click(object sender, EventArgs e)
        {
            if (greaterDef)
            {
                greaterDefButton.Text = "<";
                greaterDef = false;
            }
            else
            {
                greaterDefButton.Text = "≥";
                greaterDef = true;
            }
        }

        private void greaterSpAButton_Click(object sender, EventArgs e)
        {
            if (greaterSpA)
            {
                greaterSpAButton.Text = "<";
                greaterSpA = false;
            }
            else
            {
                greaterSpAButton.Text = "≥";
                greaterSpA = true;
            }
        }

        private void greaterSpDButton_Click(object sender, EventArgs e)
        {
            if (greaterSpD)
            {
                greaterSpDButton.Text = "<";
                greaterSpD = false;
            }
            else
            {
                greaterSpDButton.Text = "≥";
                greaterSpD = true;
            }
        }

        private void greaterSpeButton_Click(object sender, EventArgs e)
        {
            if (greaterSpe)
            {
                greaterSpeButton.Text = "<";
                greaterSpe = false;
            }
            else
            {
                greaterSpeButton.Text = "≥";
                greaterSpe = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPParent1TextBox.Select(1, HPParent1TextBox.Text.Length);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
