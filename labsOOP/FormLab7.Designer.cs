namespace labsOOP
{
    partial class FormLab7
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
            this.textBoxSTR = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonNumb1 = new System.Windows.Forms.Button();
            this.buttonNumb2 = new System.Windows.Forms.Button();
            this.buttonNumb3 = new System.Windows.Forms.Button();
            this.buttonSubtraction = new System.Windows.Forms.Button();
            this.buttonNumb4 = new System.Windows.Forms.Button();
            this.buttonNumb5 = new System.Windows.Forms.Button();
            this.buttonNumb6 = new System.Windows.Forms.Button();
            this.buttonNumb9 = new System.Windows.Forms.Button();
            this.buttonNumb8 = new System.Windows.Forms.Button();
            this.buttonNumb7 = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonNumb0 = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonRezult = new System.Windows.Forms.Button();
            this.panelOperation = new System.Windows.Forms.Panel();
            this.panelOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSTR
            // 
            this.textBoxSTR.HideSelection = false;
            this.textBoxSTR.Location = new System.Drawing.Point(12, 12);
            this.textBoxSTR.Multiline = true;
            this.textBoxSTR.Name = "textBoxSTR";
            this.textBoxSTR.ReadOnly = true;
            this.textBoxSTR.Size = new System.Drawing.Size(346, 40);
            this.textBoxSTR.TabIndex = 0;
            this.textBoxSTR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 77);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(130, 33);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Location = new System.Drawing.Point(151, 77);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(130, 33);
            this.buttonBackspace.TabIndex = 2;
            this.buttonBackspace.Text = "<--";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(3, 0);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(55, 33);
            this.buttonSum.TabIndex = 4;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.newOperation);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Location = new System.Drawing.Point(3, 121);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(55, 33);
            this.buttonMultiplication.TabIndex = 5;
            this.buttonMultiplication.Text = "*";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.newOperation);
            // 
            // buttonNumb1
            // 
            this.buttonNumb1.Location = new System.Drawing.Point(12, 132);
            this.buttonNumb1.Name = "buttonNumb1";
            this.buttonNumb1.Size = new System.Drawing.Size(73, 49);
            this.buttonNumb1.TabIndex = 6;
            this.buttonNumb1.Text = "1";
            this.buttonNumb1.UseVisualStyleBackColor = true;
            this.buttonNumb1.Click += new System.EventHandler(this.button_Clic);
            // 
            // buttonNumb2
            // 
            this.buttonNumb2.Location = new System.Drawing.Point(111, 132);
            this.buttonNumb2.Name = "buttonNumb2";
            this.buttonNumb2.Size = new System.Drawing.Size(73, 49);
            this.buttonNumb2.TabIndex = 7;
            this.buttonNumb2.Text = "2";
            this.buttonNumb2.UseVisualStyleBackColor = true;
            this.buttonNumb2.Click += new System.EventHandler(this.button_Clic);
            // 
            // buttonNumb3
            // 
            this.buttonNumb3.Location = new System.Drawing.Point(208, 130);
            this.buttonNumb3.Name = "buttonNumb3";
            this.buttonNumb3.Size = new System.Drawing.Size(73, 51);
            this.buttonNumb3.TabIndex = 8;
            this.buttonNumb3.Text = "3";
            this.buttonNumb3.UseVisualStyleBackColor = true;
            this.buttonNumb3.Click += new System.EventHandler(this.button_Clic);
            // 
            // buttonSubtraction
            // 
            this.buttonSubtraction.Location = new System.Drawing.Point(3, 55);
            this.buttonSubtraction.Name = "buttonSubtraction";
            this.buttonSubtraction.Size = new System.Drawing.Size(55, 33);
            this.buttonSubtraction.TabIndex = 9;
            this.buttonSubtraction.Text = "-";
            this.buttonSubtraction.UseVisualStyleBackColor = true;
            this.buttonSubtraction.Click += new System.EventHandler(this.newOperation);
            // 
            // buttonNumb4
            // 
            this.buttonNumb4.Location = new System.Drawing.Point(12, 198);
            this.buttonNumb4.Name = "buttonNumb4";
            this.buttonNumb4.Size = new System.Drawing.Size(73, 49);
            this.buttonNumb4.TabIndex = 10;
            this.buttonNumb4.Text = "4";
            this.buttonNumb4.UseVisualStyleBackColor = true;
            this.buttonNumb4.Click += new System.EventHandler(this.button_Clic);
            // 
            // buttonNumb5
            // 
            this.buttonNumb5.Location = new System.Drawing.Point(111, 198);
            this.buttonNumb5.Name = "buttonNumb5";
            this.buttonNumb5.Size = new System.Drawing.Size(73, 49);
            this.buttonNumb5.TabIndex = 11;
            this.buttonNumb5.Text = "5";
            this.buttonNumb5.UseVisualStyleBackColor = true;
            this.buttonNumb5.Click += new System.EventHandler(this.button_Clic);
            // 
            // buttonNumb6
            // 
            this.buttonNumb6.Location = new System.Drawing.Point(208, 198);
            this.buttonNumb6.Name = "buttonNumb6";
            this.buttonNumb6.Size = new System.Drawing.Size(73, 49);
            this.buttonNumb6.TabIndex = 12;
            this.buttonNumb6.Text = "6";
            this.buttonNumb6.UseVisualStyleBackColor = true;
            this.buttonNumb6.Click += new System.EventHandler(this.button_Clic);
            // 
            // buttonNumb9
            // 
            this.buttonNumb9.Location = new System.Drawing.Point(208, 264);
            this.buttonNumb9.Name = "buttonNumb9";
            this.buttonNumb9.Size = new System.Drawing.Size(73, 49);
            this.buttonNumb9.TabIndex = 13;
            this.buttonNumb9.Text = "9";
            this.buttonNumb9.UseVisualStyleBackColor = true;
            this.buttonNumb9.Click += new System.EventHandler(this.button_Clic);
            // 
            // buttonNumb8
            // 
            this.buttonNumb8.Location = new System.Drawing.Point(111, 264);
            this.buttonNumb8.Name = "buttonNumb8";
            this.buttonNumb8.Size = new System.Drawing.Size(73, 49);
            this.buttonNumb8.TabIndex = 14;
            this.buttonNumb8.Text = "8";
            this.buttonNumb8.UseVisualStyleBackColor = true;
            this.buttonNumb8.Click += new System.EventHandler(this.button_Clic);
            // 
            // buttonNumb7
            // 
            this.buttonNumb7.Location = new System.Drawing.Point(12, 264);
            this.buttonNumb7.Name = "buttonNumb7";
            this.buttonNumb7.Size = new System.Drawing.Size(73, 49);
            this.buttonNumb7.TabIndex = 15;
            this.buttonNumb7.Text = "7";
            this.buttonNumb7.UseVisualStyleBackColor = true;
            this.buttonNumb7.Click += new System.EventHandler(this.button_Clic);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(0, 187);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(55, 33);
            this.buttonDivision.TabIndex = 16;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.newOperation);
            // 
            // buttonNumb0
            // 
            this.buttonNumb0.Location = new System.Drawing.Point(12, 330);
            this.buttonNumb0.Name = "buttonNumb0";
            this.buttonNumb0.Size = new System.Drawing.Size(73, 33);
            this.buttonNumb0.TabIndex = 17;
            this.buttonNumb0.Text = "0";
            this.buttonNumb0.UseVisualStyleBackColor = true;
            this.buttonNumb0.Click += new System.EventHandler(this.buttonNumb0_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Location = new System.Drawing.Point(111, 330);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(73, 33);
            this.buttonPoint.TabIndex = 18;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // buttonRezult
            // 
            this.buttonRezult.Location = new System.Drawing.Point(208, 330);
            this.buttonRezult.Name = "buttonRezult";
            this.buttonRezult.Size = new System.Drawing.Size(150, 33);
            this.buttonRezult.TabIndex = 19;
            this.buttonRezult.Text = "=";
            this.buttonRezult.UseVisualStyleBackColor = true;
            this.buttonRezult.Click += new System.EventHandler(this.buttonRezult_Click);
            // 
            // panelOperation
            // 
            this.panelOperation.Controls.Add(this.buttonSum);
            this.panelOperation.Controls.Add(this.buttonSubtraction);
            this.panelOperation.Controls.Add(this.buttonMultiplication);
            this.panelOperation.Controls.Add(this.buttonDivision);
            this.panelOperation.Location = new System.Drawing.Point(303, 77);
            this.panelOperation.Name = "panelOperation";
            this.panelOperation.Size = new System.Drawing.Size(63, 228);
            this.panelOperation.TabIndex = 20;
            // 
            // FormLab7
            // 
            this.AcceptButton = this.buttonRezult;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 375);
            this.Controls.Add(this.panelOperation);
            this.Controls.Add(this.buttonRezult);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonNumb0);
            this.Controls.Add(this.buttonNumb7);
            this.Controls.Add(this.buttonNumb8);
            this.Controls.Add(this.buttonNumb9);
            this.Controls.Add(this.buttonNumb6);
            this.Controls.Add(this.buttonNumb5);
            this.Controls.Add(this.buttonNumb4);
            this.Controls.Add(this.buttonNumb3);
            this.Controls.Add(this.buttonNumb2);
            this.Controls.Add(this.buttonNumb1);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxSTR);
            this.Name = "FormLab7";
            this.Text = "Лабораторная работа №7";
            this.panelOperation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSTR;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonNumb1;
        private System.Windows.Forms.Button buttonNumb2;
        private System.Windows.Forms.Button buttonNumb3;
        private System.Windows.Forms.Button buttonSubtraction;
        private System.Windows.Forms.Button buttonNumb4;
        private System.Windows.Forms.Button buttonNumb5;
        private System.Windows.Forms.Button buttonNumb6;
        private System.Windows.Forms.Button buttonNumb9;
        private System.Windows.Forms.Button buttonNumb8;
        private System.Windows.Forms.Button buttonNumb7;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonNumb0;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonRezult;
        private System.Windows.Forms.Panel panelOperation;
    }
}