using System;
using System.Windows.Forms;

namespace labsOOP
{
    public partial class FormLab7 : Form
    {
        float a=0, b=0, rez=0;
        char operation;

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
                case '+':
                    rez = a + b;
                    break;
                case '-':
                    rez = a - b;
                    break;
                case '*':
                    rez = a * b;
                    break;

                case '/':
                    if (b != 0)
                        rez = a / b;
                    else
                        MessageBox.Show("Делить на 0 невозможно!");
                    break;
            }
        }
        private void newOperation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = Convert.ToChar(button.Text);
            a = Convert.ToSingle(textBoxSTR.Text);
            textBoxSTR.Text = "0";
            panelOperation.Enabled = false;
        }
      
       
        private void buttonNumb0_Click(object sender, EventArgs e)
        {
            textBoxSTR.Text += 0;
            textBoxSTR.Text = Check(textBoxSTR.Text);
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if  (textBoxSTR.Text.Contains(",")==false)
            textBoxSTR.Text += ",";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSTR.Text = "0";
            rez = 0;
            panelOperation.Enabled = true;
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBoxSTR.Text != "")
                textBoxSTR.Text = textBoxSTR.Text.Remove(textBoxSTR.TextLength - 1, 1);
            if (textBoxSTR.Text == "")
            {
                textBoxSTR.Text = "0";
                rez = 0;
                panelOperation.Enabled = true;
            }
        }

        private void button_Clic(object sender, EventArgs e            )
        {
            Button button = (Button)sender;
            textBoxSTR.Text += button.Text;
            textBoxSTR.Text = Check(textBoxSTR.Text);
        }

        private void buttonRezult_Click(object sender, EventArgs e)
        {
            calculate();
            textBoxSTR.Text = rez.ToString();
            panelOperation.Enabled = true;
        }
    }
}
