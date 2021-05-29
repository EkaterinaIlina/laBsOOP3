using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace labsOOP
{
    public partial class FormLab8 : Form
    {
        public FormLab8()
        {
            InitializeComponent();
            comboBoxPicture.SelectedIndex = 0;
        }
        Graphics graphics;

        private Point[] star5(int x, int y, int r)  // звезда
        {
            Point point1 = new Point(x, y - 6 * r);
            Point point2 = new Point(x + 2 * r, y - 3 * r);
            Point point3 = new Point(x + 6 * r, y - 2 * r);
            Point point4 = new Point(x + 3 * r, y + r);
            Point point5 = new Point(x + 4 * r, y + 5 * r);
            Point point6 = new Point(x, y + 3 * r);
            Point point7 = new Point(x - 4 * r, y + 5 * r);
            Point point8 = new Point(x - 3 * r, y + r);
            Point point9 = new Point(x - 6 * r, y - 2 * r);
            Point point10 = new Point(x - 2 * r, y - 3 * r);
            Point[] pm =
            { point1,point2,point3,point4,point5,
             point6,point7,point8,point9,point10 };
            return pm;
        }

        private void comboBoxPicture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPicture.SelectedIndex == 0)
                numericUpDownDepth.Enabled = true;
            else if (comboBoxPicture.SelectedIndex == 1)
                numericUpDownDepth.Enabled = false;
            else if (comboBoxPicture.SelectedIndex == 2)
                numericUpDownDepth.Enabled = true;
        }
    

        private void buttonClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.WhiteSmoke);
        }

        private void buttonPaint_Click(object sender, EventArgs e)
        {
            graphics = this.CreateGraphics();
            graphics.Clear(Color.WhiteSmoke);
            if (comboBoxPicture.SelectedIndex == 0)
            {
                ColorDialog colorDialogStar = new ColorDialog();
                MessageBox.Show("Выберите цвет звезды");
                Pen pen;
                if (colorDialogStar.ShowDialog() == DialogResult.OK)
                    pen = new Pen(colorDialogStar.Color, (float)numericUpDownDepth.Value);
                else
                    pen = new Pen(Color.Yellow, (float)numericUpDownDepth.Value);
                // Задание 10 точек, определяющих замкнутую область "звезда"
                Point[] pm = star5(110, 100, 12);
                // Рисование замкнутой ломаной из отрезков
                graphics.DrawClosedCurve(pen, pm, 0, FillMode.Alternate);
            }
            else if (comboBoxPicture.SelectedIndex == 1)
            {
                SolidBrush solidBrush;
                ColorDialog colorDialogSnowman = new ColorDialog();
                MessageBox.Show("Выберите цвет снеговика");
                if (colorDialogSnowman.ShowDialog() == DialogResult.OK)
                    solidBrush = new SolidBrush(colorDialogSnowman.Color);
                else solidBrush = new SolidBrush(Color.Azure);
                int size = 40;
                graphics.FillEllipse(solidBrush, 40, 10, Convert.ToSingle(size * 1.5), Convert.ToSingle(size * 1.5));
                graphics.FillEllipse(solidBrush, (int)(50 - size / 2), 20 + size, 2 * size, 2 * size);
                graphics.FillEllipse(solidBrush, 50 - size, 3 * size, 3 * size, 3 * size);
                var points = new[]{new Point (35, 40 ), new Point(60, 35), new Point(60,  45) };
                 solidBrush = new SolidBrush(Color.Orange);
                graphics.FillPolygon(solidBrush, points);
            }
            else if (comboBoxPicture.SelectedIndex == 2)
            {
                ColorDialog colorDialogHouse = new ColorDialog();
                MessageBox.Show("Выберите цвет дома");
                Pen pen;
                if (colorDialogHouse.ShowDialog() == DialogResult.OK)
                  pen = new Pen(colorDialogHouse.Color, (float)numericUpDownDepth.Value);
                else
                    pen = new Pen(Color.Black, (float)numericUpDownDepth.Value);
                graphics.DrawLine(pen, 45, 20, 15, 70);
                graphics.DrawLine(pen, 45, 20, 75, 70);
                graphics.DrawLine(pen, 15, 70, 75, 70);
                graphics.DrawLine(pen, 45, 20, 150, 20);
                graphics.DrawLine(pen, 150, 20, 185, 70);
                graphics.DrawLine(pen, 75, 70, 185, 70);
                graphics.DrawRectangle(pen, 15, 70, 60, 80);
                graphics.DrawRectangle(pen, 75, 70, 110, 80);
            }
        }
    }
}
