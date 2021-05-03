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
    public partial class FormLab6 : Form
    {
        int[] price = new int [] { 135, 270, 95, 190, 170, 55, 220, 145, 160, 370, 180, 240, 235, 245, 330, 190, 350, 180, 290, 170, 250, 170, 340, 160, 60, 160, 65 };
        public FormLab6()
        {
            InitializeComponent();
            ToolTip toolTipMenu = new ToolTip();
            toolTipMenu.SetToolTip(labelHelp, "Выберите блюда из списка, \nчто бы посчитать их общую стоимость");
        }

        private void checkedListBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Sum = 0;
            foreach (int index in checkedListBoxMenu.CheckedIndices)
            {
                Sum += price[index];
            }
            labelRezPrice.Text = Sum.ToString();
        }

        private void checkedListBoxMenu_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
        }
    }
}
