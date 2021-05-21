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
    public partial class FormLab7 : Form
    {
        public FormLab7()
        {
            InitializeComponent();
            textBoxSTR.Text = "0";
        }
        private string Check(string str)
        {
            if (str[0] == '0' && str.IndexOf(',')!=1 ) 
                str = str.Remove(0, 1);
            else if (str[0]== '-' && str[1] == '0' && str.IndexOf(',') != 2)
                str = str.Remove(1, 1);
            return str;
        }

        private void buttonNumb1_Click(object sender, EventArgs e)
        {
            textBoxSTR.Text += 1;
            textBoxSTR.Text = Check(textBoxSTR.Text);
        }

        private void buttonNumb2_Click(object sender, EventArgs e)
        {
            textBoxSTR.Text += 2;
            textBoxSTR.Text = Check(textBoxSTR.Text);
        }

        private void buttonNumb3_Click(object sender, EventArgs e)
        {
            textBoxSTR.Text += 3;
            textBoxSTR.Text = Check(textBoxSTR.Text);
        }

        private void buttonNumb4_Click(object sender, EventArgs e)
        {
            textBoxSTR.Text += 4;
            textBoxSTR.Text = Check(textBoxSTR.Text);
        }

        private void buttonNumb5_Click(object sender, EventArgs e)
        {
            textBoxSTR.Text += 5;
            textBoxSTR.Text = Check(textBoxSTR.Text);
        }

        private void buttonNumb6_Click(object sender, EventArgs e)
        {
            textBoxSTR.Text += 6;
            textBoxSTR.Text = Check(textBoxSTR.Text);
        }

        private void buttonNumb7_Click(object sender, EventArgs e)
        {
            textBoxSTR.Text += 7;
            textBoxSTR.Text = Check(textBoxSTR.Text);
        }

        private void buttonNumb8_Click(object sender, EventArgs e)
        {
            textBoxSTR.Text += 8;
            textBoxSTR.Text = Check(textBoxSTR.Text);
        }

        private void buttonNumb9_Click(object sender, EventArgs e)
        {
            textBoxSTR.Text += 9;
            textBoxSTR.Text = Check(textBoxSTR.Text);
        }

        private void buttonNumb0_Click(object sender, EventArgs e)
        {
            textBoxSTR.Text += 0;
            textBoxSTR.Text = Check(textBoxSTR.Text);
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textBoxSTR.Text += ",";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSTR.Text = "0";
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBoxSTR.Text.Length > 0)
                textBoxSTR.Text = textBoxSTR.Text.Remove(textBoxSTR.TextLength - 1, 1);
            else
            {
                MessageBox.Show("Введите число");
                textBoxSTR.Text = "0";
            }
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            textBoxSTR.Text += "+";
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            textBoxSTR.Text += "-";
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            textBoxSTR.Text += "*";
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            textBoxSTR.Text += "/";

        }
    }
}
