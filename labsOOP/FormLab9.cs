using System;
using System.IO;
using System.Windows.Forms;

namespace labsOOP
{
    public partial class FormLab9 : Form
    {
        public FormLab9()
        {
            InitializeComponent();
            comboBoxPosition.SelectedIndex = 0;
            saveFileDialogLab.Filter = "Text file (*.txt)|*.txt";
        }

        
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            string questionary = "ФИО:\t" + textBoxFIO.Text + "\nПол:\t";
            if (radioButtonFemale.Checked == true)
                questionary += "женский";
            else
                questionary += "мужской";
            questionary += "\nДата рождения:\t" + datePickerDateBirth.Value.ToShortDateString() + "\nКурс:\t" + numericUpDownCours.Value.ToString() + "\nЖелаемая должность:\t" + comboBoxPosition.SelectedItem.ToString() + "\nИзучаемые языки:";
            foreach(string str in checkedListBoxLanguage.CheckedItems)
            {
                questionary += "\t" + str;
            }
            richTextBoxForm.Text = questionary;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialogLab.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialogLab.FileName;
            File.WriteAllText(filename, richTextBoxForm.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void buttonUnloading_Click(object sender, EventArgs e)
        {
            if (openFileDialogLab.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialogLab.FileName;
            richTextBoxForm.Text = File.ReadAllText(filename);
            MessageBox.Show("Файл загружен");
        }

        private void ItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStripLab_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            contextMenuStripLab.Visible = false;
            if (e.ClickedItem.Text == "Открыть")
                buttonUnloading_Click(null, null);
            else if (e.ClickedItem.Text == "Сохранить")
                buttonSave_Click(null, null);
            else
                richTextBoxForm.Clear();
        }
    }
}
