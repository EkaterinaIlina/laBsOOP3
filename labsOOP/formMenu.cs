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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void linkLabelLab5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLab5 formLab5 = new FormLab5();
            formLab5.ShowDialog();
        }

        private void linkLabelLab6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLab6 formLab6 = new FormLab6();
            formLab6.ShowDialog();
        }

        private void linkLabelLab7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLab7 formLab7 = new FormLab7();
            formLab7.ShowDialog();
        }

        private void linkLabelLab8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabelLab9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
