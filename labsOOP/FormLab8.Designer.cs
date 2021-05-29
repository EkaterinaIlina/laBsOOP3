namespace labsOOP
{
    partial class FormLab8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxPicture = new System.Windows.Forms.ComboBox();
            this.numericUpDownDepth = new System.Windows.Forms.NumericUpDown();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPaint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPicture
            // 
            this.comboBoxPicture.FormattingEnabled = true;
            this.comboBoxPicture.Items.AddRange(new object[] {
            "Звезда",
            "Снеговик",
            "Дом"});
            this.comboBoxPicture.Location = new System.Drawing.Point(206, 36);
            this.comboBoxPicture.Name = "comboBoxPicture";
            this.comboBoxPicture.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPicture.TabIndex = 0;
            this.comboBoxPicture.SelectedIndexChanged += new System.EventHandler(this.comboBoxPicture_SelectedIndexChanged);
            // 
            // numericUpDownDepth
            // 
            this.numericUpDownDepth.Location = new System.Drawing.Point(206, 87);
            this.numericUpDownDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDepth.Name = "numericUpDownDepth";
            this.numericUpDownDepth.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDepth.TabIndex = 2;
            this.numericUpDownDepth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDepth.ValueChanged += new System.EventHandler(this.comboBoxPicture_SelectedIndexChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(205, 179);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(121, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonPaint
            // 
            this.buttonPaint.Location = new System.Drawing.Point(206, 148);
            this.buttonPaint.Name = "buttonPaint";
            this.buttonPaint.Size = new System.Drawing.Size(121, 23);
            this.buttonPaint.TabIndex = 4;
            this.buttonPaint.Text = "Нарисовать";
            this.buttonPaint.UseVisualStyleBackColor = true;
            this.buttonPaint.Click += new System.EventHandler(this.buttonPaint_Click);
            // 
            // FormLab8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(352, 234);
            this.Controls.Add(this.buttonPaint);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.numericUpDownDepth);
            this.Controls.Add(this.comboBoxPicture);
            this.Name = "FormLab8";
            this.Text = "Лабораторная работа №8";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxPicture;
        private System.Windows.Forms.NumericUpDown numericUpDownDepth;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPaint;
    }
}