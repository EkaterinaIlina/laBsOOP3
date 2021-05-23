using System;
using System.Windows.Forms;

namespace labsOOP
{
    public partial class FormLab6 : Form
    {
        int[,] price =  { { 135, 0 }, { 270, 0 }, { 95, 0 }, { 190, 0 }, { 170, 0 }, { 55, 0 }, { 220, 0 }, { 145, 0 }, { 160, 0 }, { 370, 0 }, { 180, 0 }, { 240, 0 }, { 235, 0 }, { 245, 0 }, { 330, 0 }, { 190, 0 }, { 350, 0 }, { 180, 0 }, {290, 0 }, {170, 0 }, {250, 0 }, {170, 0 }, {340, 0 }, {160, 0 },{ 60, 0 },{ 160, 0 }, {65, 0 } };
         
        
        public FormLab6()
        {
            InitializeComponent();
            ToolTip toolTipMenu = new ToolTip();
            toolTipMenu.SetToolTip(labelHelp, "Выберите блюда из списка, \nчто бы посчитать их общую стоимость");
            checkedListBoxMenu.SelectedIndex = 0;
        }

        private void checkedListBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxMenu.CheckedIndices.Contains(checkedListBoxMenu.SelectedIndex) == true)
            {
                if ( price[checkedListBoxMenu.SelectedIndex, 1] == 0)
                    numericUpDownCount.Value = 1;
                else
                    numericUpDownCount.Value = price[checkedListBoxMenu.SelectedIndex, 1];
            }
            else          
                numericUpDownCount.Value = 0;
        }

        private void checkedListBoxMenu_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBoxMenu.CheckedIndices.Contains(e.Index) == false)
                numericUpDownCount.Enabled = true;
            else
                numericUpDownCount.Enabled = false;
        }

        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownCount.Value == 0)
                checkedListBoxMenu.SetItemCheckState(checkedListBoxMenu.SelectedIndex, CheckState.Unchecked);
            if (checkedListBoxMenu.SelectedIndex!=-1)
                price[checkedListBoxMenu.SelectedIndex, 1] = Convert.ToInt32(numericUpDownCount.Value);
            int Sum = 0;
            foreach (int index in checkedListBoxMenu.CheckedIndices)
                Sum += price[index, 0] * price[index, 1];
            labelRezPrice.Text = Sum.ToString();
        }
    }
}
