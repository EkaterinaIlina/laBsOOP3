using System;
using System.Windows.Forms;

namespace labsOOP
{
    public partial class FormLab7 : Form
    {
        float a=0, b=0, rez=0;
        int operation;

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
        public void calculate()
        {
            if (rez != 0 && b != 0) {
             if (rez == a)
                    b = rez;
                a = rez;
            }
            else
                b = Convert.ToSingle(textBoxSTR.Text);
            switch (operation)
            {
                case 1:
                    rez = a + b;
                    break;
                case 2:
                    rez = a - b;
                    break;
                case 3:
                    rez = a * b;
                    break;

                case 4:
                    if (b != 0)
                        rez = a / b;
                    else
                        MessageBox.Show("Делить на 0 невозможно!");
                    break;
            }
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
            rez = 0;
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBoxSTR.Text.Length > 0)
                textBoxSTR.Text = textBoxSTR.Text.Remove(textBoxSTR.TextLength - 1, 1);
            else
            {
                MessageBox.Show("Введите число");
                textBoxSTR.Text = "0";
                rez = 0;
            }
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            a = Convert.ToSingle(textBoxSTR.Text);
           textBoxSTR.Text = "0";
            operation = 1;
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            a = Convert.ToSingle(textBoxSTR.Text);
           textBoxSTR.Text = "0";
            operation = 2;
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            a = Convert.ToSingle(textBoxSTR.Text);
           textBoxSTR.Text = "0";
            operation = 3;
        }

        private void buttonRezult_Click(object sender, EventArgs e)
        {
            calculate();
            textBoxSTR.Text = rez.ToString();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            a = Convert.ToSingle(textBoxSTR.Text);
            textBoxSTR.Text = "0";
            operation = 4;
        }
    }
}
