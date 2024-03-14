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

        private void HPParent1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (HPParent1TextBox.Text.Length > 1)
            {
                HPParent1TextBox.Text = HPParent1TextBox.Text.Remove(0,1);
                HPParent1TextBox.Select(HPParent1TextBox.Text.Length, 0);
            }
        }

        private void AtkParent1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AtkParent1TextBox.Select(1, AtkParent1TextBox.Text.Length);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (AtkParent1TextBox.Text.Length > 1)
            {
                AtkParent1TextBox.Text = AtkParent1TextBox.Text.Remove(0, 1);
                AtkParent1TextBox.Select(AtkParent1TextBox.Text.Length, 0);
            }
        }

        private void DefParent1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            DefParent1TextBox.Select(1, DefParent1TextBox.Text.Length);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (DefParent1TextBox.Text.Length > 1)
            {
                DefParent1TextBox.Text = DefParent1TextBox.Text.Remove(0, 1);
                DefParent1TextBox.Select(DefParent1TextBox.Text.Length, 0);
            }
        }

        private void SpAParent1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpAParent1TextBox.Select(1, SpAParent1TextBox.Text.Length);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (SpAParent1TextBox.Text.Length > 1)
            {
                SpAParent1TextBox.Text = SpAParent1TextBox.Text.Remove(0, 1);
                SpAParent1TextBox.Select(SpAParent1TextBox.Text.Length, 0);
            }
        }

        private void SpDParent1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpDParent1TextBox.Select(1, SpDParent1TextBox.Text.Length);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (SpDParent1TextBox.Text.Length > 1)
            {
                SpDParent1TextBox.Text = SpDParent1TextBox.Text.Remove(0, 1);
                SpDParent1TextBox.Select(SpDParent1TextBox.Text.Length, 0);
            }
        }

        private void SpeParent1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpeParent1TextBox.Select(1, SpeParent1TextBox.Text.Length);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (SpeParent1TextBox.Text.Length > 1)
            {
                SpeParent1TextBox.Text = SpeParent1TextBox.Text.Remove(0, 1);
                SpeParent1TextBox.Select(SpeParent1TextBox.Text.Length, 0);
            }
        }

        private void HPParent2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPParent2TextBox.Select(1, HPParent2TextBox.Text.Length);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (HPParent2TextBox.Text.Length > 1)
            {
                HPParent2TextBox.Text = HPParent2TextBox.Text.Remove(0, 1);
                HPParent2TextBox.Select(HPParent2TextBox.Text.Length, 0);
            }
        }

        private void AtkParent2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AtkParent2TextBox.Select(1, AtkParent2TextBox.Text.Length);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (AtkParent2TextBox.Text.Length > 1)
            {
                AtkParent2TextBox.Text = AtkParent2TextBox.Text.Remove(0, 1);
                AtkParent2TextBox.Select(AtkParent2TextBox.Text.Length, 0);
            }
        }

        private void DefParent2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            DefParent2TextBox.Select(1, DefParent2TextBox.Text.Length);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (DefParent2TextBox.Text.Length > 1)
            {
                DefParent2TextBox.Text = DefParent2TextBox.Text.Remove(0, 1);
                DefParent2TextBox.Select(DefParent2TextBox.Text.Length, 0);
            }
        }

        private void SpAParent2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpAParent2TextBox.Select(1, SpAParent2TextBox.Text.Length);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (SpAParent2TextBox.Text.Length > 1)
            {
                SpAParent2TextBox.Text = SpAParent2TextBox.Text.Remove(0, 1);
                SpAParent2TextBox.Select(SpAParent2TextBox.Text.Length, 0);
            }
        }

        private void SpDParent2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpDParent2TextBox.Select(1, SpDParent2TextBox.Text.Length);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (SpDParent2TextBox.Text.Length > 1)
            {
                SpDParent2TextBox.Text = SpDParent2TextBox.Text.Remove(0, 1);
                SpDParent2TextBox.Select(SpDParent2TextBox.Text.Length, 0);
            }
        }

        private void SpeParent2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpeParent2TextBox.Select(1, SpeParent2TextBox.Text.Length);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (SpeParent2TextBox.Text.Length > 1)
            {
                SpeParent2TextBox.Text = SpeParent2TextBox.Text.Remove(0, 1);
                SpeParent2TextBox.Select(SpeParent2TextBox.Text.Length, 0);
            }
        }

        private void HPDesiredTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPDesiredTextBox.Select(1, HPDesiredTextBox.Text.Length);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (    HPParent1TextBox.Text.Length > 1)
            {
                HPDesiredTextBox.Text = HPDesiredTextBox.Text.Remove(0, 1);
                HPDesiredTextBox.Select(HPDesiredTextBox.Text.Length, 0);
            }
        }

        private void AtkDesiredTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AtkDesiredTextBox.Select(1, AtkDesiredTextBox.Text.Length);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (AtkDesiredTextBox.Text.Length > 1)
            {
                AtkDesiredTextBox.Text = AtkDesiredTextBox.Text.Remove(0, 1);
                AtkDesiredTextBox.Select(AtkDesiredTextBox.Text.Length, 0);
            }
        }

        private void DefDesiredTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            DefDesiredTextBox.Select(1, DefDesiredTextBox.Text.Length);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (DefDesiredTextBox.Text.Length > 1)
            {
                DefDesiredTextBox.Text = DefDesiredTextBox.Text.Remove(0, 1);
                DefDesiredTextBox.Select(DefDesiredTextBox.Text.Length, 0);
            }
        }

        private void SpADesiredTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpADesiredTextBox.Select(1, SpADesiredTextBox.Text.Length);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (SpADesiredTextBox.Text.Length > 1)
            {
                SpADesiredTextBox.Text = SpADesiredTextBox.Text.Remove(0, 1);
                SpADesiredTextBox.Select(SpADesiredTextBox.Text.Length, 0);
            }
        }

        private void SpDDesiredTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpDDesiredTextBox.Select(1, SpDDesiredTextBox.Text.Length);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (SpDDesiredTextBox.Text.Length > 1)
            {
                SpDDesiredTextBox.Text = SpDDesiredTextBox.Text.Remove(0, 1);
                SpDDesiredTextBox.Select(SpDDesiredTextBox.Text.Length, 0);
            }
        }

        private void SpeDesiredTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpeDesiredTextBox.Select(1, SpeDesiredTextBox.Text.Length);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (SpeDesiredTextBox.Text.Length > 1)
            {
                SpeDesiredTextBox.Text = SpeDesiredTextBox.Text.Remove(0, 1);
                SpeDesiredTextBox.Select(SpeDesiredTextBox.Text.Length, 0);
            }
        }

        private void HPParent1TextBox_Leave(object sender, EventArgs e)
        {
            if (HPParent1TextBox.Text.Length == 0)
            {
                HPParent1TextBox.Text = "0";
            }
            try
            {
                if (Int32.Parse(HPParent1TextBox.Text) > 31)
                {
                    HPParent1TextBox.Text = "31";
                }
            } catch
            {
                    HPParent1TextBox.Text = "31";
            }
        }

        private void AtkParent1TextBox_Leave(object sender, EventArgs e)
        {
            if (AtkParent1TextBox.Text.Length == 0)
            {
                AtkParent1TextBox.Text = "0";
            }
            try
            {
                if (Int32.Parse(AtkParent1TextBox.Text) > 31)
                {
                    AtkParent1TextBox.Text = "31";
                }
            }
            catch
            {
                AtkParent1TextBox.Text = "31";
            }
        }

        private void DefParent1TextBox_Leave(object sender, EventArgs e)
        {
            if (DefParent1TextBox.Text.Length == 0)
            {
                DefParent1TextBox.Text = "0";
            }
            try
            {
                if (Int32.Parse(DefParent1TextBox.Text) > 31)
                {
                    DefParent1TextBox.Text = "31";
                }
            }
            catch
            {
                DefParent1TextBox.Text = "31";
            }
        }

        private void SpAParent1TextBox_Leave(object sender, EventArgs e)
        {
            if (SpAParent1TextBox.Text.Length == 0)
            {
                SpAParent1TextBox.Text = "0";
            }
            try
            {
                if (Int32.Parse(SpAParent1TextBox.Text) > 31)
                {
                    SpAParent1TextBox.Text = "31";
                }
            }
            catch
            {
                SpAParent1TextBox.Text = "31";
            }
        }

        private void SpDParent1TextBox_Leave(object sender, EventArgs e)
        {
            if (SpDParent1TextBox.Text.Length == 0)
            {
                SpDParent1TextBox.Text = "0";
            }
            try
            {
                if (Int32.Parse(SpDParent1TextBox.Text) > 31)
                {
                    SpDParent1TextBox.Text = "31";
                }
            }
            catch
            {
                SpDParent1TextBox.Text = "31";
            }
        }

        private void SpeParent1TextBox_Leave(object sender, EventArgs e)
        {
            if (SpeParent1TextBox.Text.Length == 0)
            {
                SpeParent1TextBox.Text = "0";
            }
            try
            {
                if (Int32.Parse(SpeParent1TextBox.Text) > 31)
                {
                    SpeParent1TextBox.Text = "31";
                }
            }
            catch
            {
                SpeParent1TextBox.Text = "31";
            }
        }

        private void HPParent2TextBox_Leave(object sender, EventArgs e)
        {
            if (HPParent2TextBox.Text.Length == 0)
            {
                HPParent2TextBox.Text = "0";
            }
            try
            {
                if (Int32.Parse(HPParent2TextBox.Text) > 31)
                {
                    HPParent2TextBox.Text = "31";
                }
            }
            catch
            {
                HPParent2TextBox.Text = "31";
            }
        }

        private void AtkParent2TextBox_Leave(object sender, EventArgs e)
        {
            if (AtkParent2TextBox.Text.Length == 0)
            {
                AtkParent2TextBox.Text = "0";
            }
            try
            {
                if (Int32.Parse(AtkParent2TextBox.Text) > 31)
                {
                    AtkParent2TextBox.Text = "31";
                }
            }
            catch
            {
                AtkParent2TextBox.Text = "31";
            }
        }

        private void DefParent2TextBox_Leave(object sender, EventArgs e)
        {
            if (DefParent2TextBox.Text.Length == 0)
            {
                DefParent2TextBox.Text = "0";
            }
            try
            {
                if (Int32.Parse(DefParent2TextBox.Text) > 31)
                {
                    DefParent2TextBox.Text = "31";
                }
            }
            catch
            {
                AtkParent2TextBox.Text = "31";
            }
        }

        private void SpAParent2TextBox_Leave(object sender, EventArgs e)
        {
            if (SpAParent2TextBox.Text.Length == 0)
            {
                SpAParent2TextBox.Text = "0";
            }
            try
            {
                if (Int32.Parse(SpAParent2TextBox.Text) > 31)
                {
                    SpAParent2TextBox.Text = "31";
                }
            }
            catch
            {
                SpAParent2TextBox.Text = "31";
            }
        }

        private void SpDParent2TextBox_Leave(object sender, EventArgs e)
        {
            if (SpDParent2TextBox.Text.Length == 0)
            {
                SpDParent2TextBox.Text = "0";
            }
            try
            {
                if (Int32.Parse(SpDParent2TextBox.Text) > 31)
                {
                    SpDParent2TextBox.Text = "31";
                }
            }
            catch
            {
                SpDParent2TextBox.Text = "31";
            }
        }

        private void SpeParent2TextBox_Leave(object sender, EventArgs e)
        {
            if (SpeParent2TextBox.Text.Length == 0)
            {
                SpeParent2TextBox.Text = "0";
            }
            try
            {
                if (Int32.Parse(SpeParent2TextBox.Text) > 31)
                {
                    SpeParent2TextBox.Text = "31";
                }
            }
            catch
            {
                SpeParent2TextBox.Text = "31";
            }
        }

        private void HPDesiredTextBox_Leave(object sender, EventArgs e)
        {
            if (HPDesiredTextBox.Text.Length == 0)
            {
                HPDesiredTextBox.Text = "0";
            }
            try
            {
                if (Int32.Parse(HPDesiredTextBox.Text) > 31)
                {
                    HPDesiredTextBox.Text = "31";
                }
            }
            catch
            {
                HPDesiredTextBox.Text = "31";
            }
        }

        private void AtkDesiredTextBox_Leave(object sender, EventArgs e)
        {
            if (AtkDesiredTextBox.Text.Length == 0)
            {
                AtkDesiredTextBox.Text = "0";
            }
            try
            {
                if (Int32.Parse(AtkDesiredTextBox.Text) > 31)
                {
                    AtkDesiredTextBox.Text = "31";
                }
            }
            catch
            {
                AtkDesiredTextBox.Text = "31";
            }
        }

        private void DefDesiredTextBox_Leave(object sender, EventArgs e)
        {
            if (DefDesiredTextBox.Text.Length == 0)
            {
                DefDesiredTextBox.Text = "0";
            }
            try
            {
                if (Int32.Parse(DefDesiredTextBox.Text) > 31)
                {
                    DefDesiredTextBox.Text = "31";
                }
            }
            catch
            {
                DefDesiredTextBox.Text = "31";
            }
        }

        private void SpADesiredTextBox_Leave(object sender, EventArgs e)
        {
            if (SpADesiredTextBox.Text.Length == 0)
            {
                SpADesiredTextBox.Text = "0";
            }
            try
            {
                if (Int32.Parse(SpADesiredTextBox.Text) > 31)
                {
                    SpADesiredTextBox.Text = "31";
                }
            }
            catch
            {
                SpADesiredTextBox.Text = "31";
            }
        }

        private void SpDDesiredTextBox_Leave(object sender, EventArgs e)
        {
            if (SpDDesiredTextBox.Text.Length == 0)
            {
                SpDDesiredTextBox.Text = "0";
            }
            try
            {
                if (Int32.Parse(SpDDesiredTextBox.Text) > 31)
                {
                    SpDDesiredTextBox.Text = "31";
                }
            }
            catch
            {
                SpDDesiredTextBox.Text = "31";
            }
        }

        private void SpeDesiredTextBox_Leave(object sender, EventArgs e)
        {
            if (SpeDesiredTextBox.Text.Length == 0)
            {
                SpeDesiredTextBox.Text = "0";
            }
            try
            {
                if (Int32.Parse(SpeDesiredTextBox.Text) > 31)
                {
                    SpeDesiredTextBox.Text = "31";
                }
            }
            catch
            {
                SpeDesiredTextBox.Text = "31";
            }
        }
    }
}
