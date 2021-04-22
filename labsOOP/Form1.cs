using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace labsOOP
{
    public partial class Lab1Form : Form
    {
        double a, h, b, ungle, c;
       
        public Lab1Form()
        {
            InitializeComponent();
        }


        private void textBoxStorA_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStorA.Text != "")
                a = double.Parse(textBoxStorA.Text);
            else
                a = 0;
        }

        private void textBoxStorB_TextChanged(object sender, EventArgs e)
        {
            if(textBoxStorB.Text!="")
            b = double.Parse(textBoxStorB.Text);
            else
                b = 0;
        }

        private void textBoxStorC_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStorC.Text != "")
                c = double.Parse(textBoxStorC.Text);
            else
                c = 0;
        }

        private void textBoxAngle_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAngle.Text != "")
                ungle = double.Parse(textBoxAngle.Text);
            else
                ungle = 0;
        }

        private void textBoxH_TextChanged(object sender, EventArgs e)
        {
            if (textBoxH.Text != "")
                h = double.Parse(textBoxH.Text);
            else
                h = 0;
        }

        private void textBoxOsn_TextChanged(object sender, EventArgs e)
        {
            if (textBoxOsn.Text != "")
                a = double.Parse(textBoxOsn.Text);
            else
                a = 0;
        }

        private void textBoxStA_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStA.Text != "")
                a = double.Parse(textBoxStA.Text);
            else
                a = 0;
        }

        private void textBoxStB_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStB.Text != "")
                b = double.Parse(textBoxStB.Text);
            else
                b = 0;
        }

        private void textBoxStorA_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBoxStorB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBoxStorC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBoxAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBoxH_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBoxOsn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBoxStA_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBoxStB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void OsyHradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OsyHradioButton.Checked )
                panel1.Visible = true;
            else
                panel1.Visible = false;
        }

        private void StUngradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (StUngradioButton.Checked)           
                panel2.Visible = true;
            else
                panel2.Visible = false;
        }

        private void StradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (StradioButton.Checked)
                panel3.Visible = true;
            else
                panel3.Visible = false;
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            if (OsyHradioButton.Checked)
                Rezlabel.Text = ((a * h) / 2).ToString();
            else if (StUngradioButton.Checked)
                Rezlabel.Text = (0.5 * a * b * Math.Sin(ungle)).ToString();
            else if (StradioButton.Checked)
            {
                double p = (a + b + c) / 2;
                Rezlabel.Text = (Math.Sqrt(p * (p - a) * (p - b) * (p - c)).ToString());
            }
            else
                MessageBox.Show("Выберите группу измерений");
        }
    }
}
