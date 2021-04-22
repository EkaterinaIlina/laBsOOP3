namespace labsOOP
{
    partial class Lab1Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab1Form));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxStorA = new System.Windows.Forms.TextBox();
            this.textBoxStorB = new System.Windows.Forms.TextBox();
            this.textBoxStorC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOsn = new System.Windows.Forms.TextBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxStA = new System.Windows.Forms.TextBox();
            this.textBoxStB = new System.Windows.Forms.TextBox();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SquareButton = new System.Windows.Forms.Button();
            this.Rezlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IzmgroupBox = new System.Windows.Forms.GroupBox();
            this.StUngradioButton = new System.Windows.Forms.RadioButton();
            this.StradioButton = new System.Windows.Forms.RadioButton();
            this.OsyHradioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.IzmgroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(593, 345);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.SquareButton);
            this.tabPage1.Controls.Add(this.Rezlabel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.IzmgroupBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(585, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание №1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.textBoxStorA);
            this.panel3.Controls.Add(this.textBoxStorB);
            this.panel3.Controls.Add(this.textBoxStorC);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(12, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 115);
            this.panel3.TabIndex = 5;
            this.panel3.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Сторона b";
            // 
            // textBoxStorA
            // 
            this.textBoxStorA.Location = new System.Drawing.Point(126, 13);
            this.textBoxStorA.Name = "textBoxStorA";
            this.textBoxStorA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStorA.TabIndex = 0;
            this.textBoxStorA.TextChanged += new System.EventHandler(this.textBoxStorA_TextChanged);
            this.textBoxStorA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStorA_KeyPress);
            // 
            // textBoxStorB
            // 
            this.textBoxStorB.Location = new System.Drawing.Point(370, 13);
            this.textBoxStorB.Name = "textBoxStorB";
            this.textBoxStorB.Size = new System.Drawing.Size(100, 20);
            this.textBoxStorB.TabIndex = 4;
            this.textBoxStorB.TextChanged += new System.EventHandler(this.textBoxStorB_TextChanged);
            this.textBoxStorB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStorB_KeyPress);
            // 
            // textBoxStorC
            // 
            this.textBoxStorC.Location = new System.Drawing.Point(254, 52);
            this.textBoxStorC.Name = "textBoxStorC";
            this.textBoxStorC.Size = new System.Drawing.Size(100, 20);
            this.textBoxStorC.TabIndex = 1;
            this.textBoxStorC.TextChanged += new System.EventHandler(this.textBoxStorC_TextChanged);
            this.textBoxStorC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStorC_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(151, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Сторона c";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Сторона a";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxOsn);
            this.panel1.Controls.Add(this.textBoxH);
            this.panel1.Location = new System.Drawing.Point(9, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 85);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Высота";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Основание";
            // 
            // textBoxOsn
            // 
            this.textBoxOsn.Location = new System.Drawing.Point(116, 16);
            this.textBoxOsn.Name = "textBoxOsn";
            this.textBoxOsn.Size = new System.Drawing.Size(100, 20);
            this.textBoxOsn.TabIndex = 0;
            this.textBoxOsn.TextChanged += new System.EventHandler(this.textBoxOsn_TextChanged);
            this.textBoxOsn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOsn_KeyPress);
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(116, 48);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(100, 20);
            this.textBoxH.TabIndex = 1;
            this.textBoxH.TextChanged += new System.EventHandler(this.textBoxH_TextChanged);
            this.textBoxH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxH_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBoxStA);
            this.panel2.Controls.Add(this.textBoxStB);
            this.panel2.Controls.Add(this.textBoxAngle);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 105);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Сторона b";
            // 
            // textBoxStA
            // 
            this.textBoxStA.Location = new System.Drawing.Point(126, 13);
            this.textBoxStA.Name = "textBoxStA";
            this.textBoxStA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStA.TabIndex = 0;
            this.textBoxStA.TextChanged += new System.EventHandler(this.textBoxStA_TextChanged);
            this.textBoxStA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStA_KeyPress);
            // 
            // textBoxStB
            // 
            this.textBoxStB.Location = new System.Drawing.Point(370, 13);
            this.textBoxStB.Name = "textBoxStB";
            this.textBoxStB.Size = new System.Drawing.Size(100, 20);
            this.textBoxStB.TabIndex = 4;
            this.textBoxStB.TextChanged += new System.EventHandler(this.textBoxStB_TextChanged);
            this.textBoxStB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStB_KeyPress);
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Location = new System.Drawing.Point(254, 52);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(100, 20);
            this.textBoxAngle.TabIndex = 1;
            this.textBoxAngle.TextChanged += new System.EventHandler(this.textBoxAngle_TextChanged);
            this.textBoxAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAngle_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Угол между ними";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Сторона a";
            // 
            // SquareButton
            // 
            this.SquareButton.Location = new System.Drawing.Point(502, 288);
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.Size = new System.Drawing.Size(75, 23);
            this.SquareButton.TabIndex = 5;
            this.SquareButton.Text = "Вычислить";
            this.SquareButton.UseVisualStyleBackColor = true;
            this.SquareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // Rezlabel
            // 
            this.Rezlabel.AutoSize = true;
            this.Rezlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rezlabel.Location = new System.Drawing.Point(335, 288);
            this.Rezlabel.Name = "Rezlabel";
            this.Rezlabel.Size = new System.Drawing.Size(0, 24);
            this.Rezlabel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Площадь = ";
            // 
            // IzmgroupBox
            // 
            this.IzmgroupBox.Controls.Add(this.StUngradioButton);
            this.IzmgroupBox.Controls.Add(this.StradioButton);
            this.IzmgroupBox.Controls.Add(this.OsyHradioButton);
            this.IzmgroupBox.Location = new System.Drawing.Point(6, 107);
            this.IzmgroupBox.Name = "IzmgroupBox";
            this.IzmgroupBox.Size = new System.Drawing.Size(568, 57);
            this.IzmgroupBox.TabIndex = 1;
            this.IzmgroupBox.TabStop = false;
            this.IzmgroupBox.Text = "Выберите группу измерений";
            // 
            // StUngradioButton
            // 
            this.StUngradioButton.AutoSize = true;
            this.StUngradioButton.Location = new System.Drawing.Point(184, 19);
            this.StUngradioButton.Name = "StUngradioButton";
            this.StUngradioButton.Size = new System.Drawing.Size(191, 17);
            this.StUngradioButton.TabIndex = 2;
            this.StUngradioButton.Text = "Две стороны и угол между ними";
            this.StUngradioButton.UseVisualStyleBackColor = true;
            this.StUngradioButton.CheckedChanged += new System.EventHandler(this.StUngradioButton_CheckedChanged);
            // 
            // StradioButton
            // 
            this.StradioButton.AutoSize = true;
            this.StradioButton.Location = new System.Drawing.Point(412, 19);
            this.StradioButton.Name = "StradioButton";
            this.StradioButton.Size = new System.Drawing.Size(90, 17);
            this.StradioButton.TabIndex = 2;
            this.StradioButton.Text = "Три стороны";
            this.StradioButton.UseVisualStyleBackColor = true;
            this.StradioButton.CheckedChanged += new System.EventHandler(this.StradioButton_CheckedChanged);
            // 
            // OsyHradioButton
            // 
            this.OsyHradioButton.AutoSize = true;
            this.OsyHradioButton.Location = new System.Drawing.Point(6, 19);
            this.OsyHradioButton.Name = "OsyHradioButton";
            this.OsyHradioButton.Size = new System.Drawing.Size(130, 17);
            this.OsyHradioButton.TabIndex = 0;
            this.OsyHradioButton.Text = "Основание и высота";
            this.OsyHradioButton.UseVisualStyleBackColor = true;
            this.OsyHradioButton.CheckedChanged += new System.EventHandler(this.OsyHradioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(585, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание №2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(571, 73);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(585, 305);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Задание №3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(571, 73);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab1Form
            // 
            this.AcceptButton = this.SquareButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 362);
            this.Controls.Add(this.tabControl1);
            this.Name = "Lab1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.IzmgroupBox.ResumeLayout(false);
            this.IzmgroupBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox IzmgroupBox;
        private System.Windows.Forms.RadioButton StUngradioButton;
        private System.Windows.Forms.RadioButton StradioButton;
        private System.Windows.Forms.RadioButton OsyHradioButton;
        private System.Windows.Forms.Button SquareButton;
        private System.Windows.Forms.Label Rezlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TextBox textBoxOsn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxStB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.TextBox textBoxStA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxStorA;
        private System.Windows.Forms.TextBox textBoxStorB;
        private System.Windows.Forms.TextBox textBoxStorC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

