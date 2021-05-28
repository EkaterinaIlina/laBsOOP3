namespace labsOOP
{
    partial class FormLab9
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
            this.components = new System.ComponentModel.Container();
            this.splitContainerLab = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.checkedListBoxLanguage = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownCours = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datePickerDateBirth = new System.Windows.Forms.DateTimePicker();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.buttonUnloading = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.richTextBoxForm = new System.Windows.Forms.RichTextBox();
            this.menuStripLab = new System.Windows.Forms.MenuStrip();
            this.ItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemUnloading = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogLab = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogLab = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStripLab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClear = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLab)).BeginInit();
            this.splitContainerLab.Panel1.SuspendLayout();
            this.splitContainerLab.Panel2.SuspendLayout();
            this.splitContainerLab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCours)).BeginInit();
            this.menuStripLab.SuspendLayout();
            this.contextMenuStripLab.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerLab
            // 
            this.splitContainerLab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerLab.Location = new System.Drawing.Point(0, 27);
            this.splitContainerLab.Name = "splitContainerLab";
            // 
            // splitContainerLab.Panel1
            // 
            this.splitContainerLab.Panel1.BackColor = System.Drawing.Color.Lavender;
            this.splitContainerLab.Panel1.Controls.Add(this.label7);
            this.splitContainerLab.Panel1.Controls.Add(this.checkedListBoxLanguage);
            this.splitContainerLab.Panel1.Controls.Add(this.label6);
            this.splitContainerLab.Panel1.Controls.Add(this.label5);
            this.splitContainerLab.Panel1.Controls.Add(this.numericUpDownCours);
            this.splitContainerLab.Panel1.Controls.Add(this.label4);
            this.splitContainerLab.Panel1.Controls.Add(this.label3);
            this.splitContainerLab.Panel1.Controls.Add(this.label2);
            this.splitContainerLab.Panel1.Controls.Add(this.label1);
            this.splitContainerLab.Panel1.Controls.Add(this.datePickerDateBirth);
            this.splitContainerLab.Panel1.Controls.Add(this.radioButtonFemale);
            this.splitContainerLab.Panel1.Controls.Add(this.radioButtonMan);
            this.splitContainerLab.Panel1.Controls.Add(this.comboBoxPosition);
            this.splitContainerLab.Panel1.Controls.Add(this.textBoxFIO);
            // 
            // splitContainerLab.Panel2
            // 
            this.splitContainerLab.Panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainerLab.Panel2.Controls.Add(this.buttonUnloading);
            this.splitContainerLab.Panel2.Controls.Add(this.buttonSave);
            this.splitContainerLab.Panel2.Controls.Add(this.buttonCopy);
            this.splitContainerLab.Panel2.Controls.Add(this.richTextBoxForm);
            this.splitContainerLab.Size = new System.Drawing.Size(451, 319);
            this.splitContainerLab.SplitterDistance = 203;
            this.splitContainerLab.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Изучаемые языки";
            // 
            // checkedListBoxLanguage
            // 
            this.checkedListBoxLanguage.CheckOnClick = true;
            this.checkedListBoxLanguage.FormattingEnabled = true;
            this.checkedListBoxLanguage.Items.AddRange(new object[] {
            "английский",
            "французский",
            "итальянский"});
            this.checkedListBoxLanguage.Location = new System.Drawing.Point(12, 265);
            this.checkedListBoxLanguage.Name = "checkedListBoxLanguage";
            this.checkedListBoxLanguage.Size = new System.Drawing.Size(178, 49);
            this.checkedListBoxLanguage.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Желаемая должность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Курс";
            // 
            // numericUpDownCours
            // 
            this.numericUpDownCours.Location = new System.Drawing.Point(12, 180);
            this.numericUpDownCours.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownCours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCours.Name = "numericUpDownCours";
            this.numericUpDownCours.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCours.TabIndex = 11;
            this.numericUpDownCours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пол";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Анкета";
            // 
            // datePickerDateBirth
            // 
            this.datePickerDateBirth.Location = new System.Drawing.Point(12, 137);
            this.datePickerDateBirth.Name = "datePickerDateBirth";
            this.datePickerDateBirth.Size = new System.Drawing.Size(177, 20);
            this.datePickerDateBirth.TabIndex = 6;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(104, 99);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(69, 17);
            this.radioButtonFemale.TabIndex = 5;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "женский";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Checked = true;
            this.radioButtonMan.Location = new System.Drawing.Point(12, 99);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(70, 17);
            this.radioButtonMan.TabIndex = 4;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "мужской";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "аналитик",
            "разработчик",
            "тестировщик"});
            this.comboBoxPosition.Location = new System.Drawing.Point(12, 220);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(178, 21);
            this.comboBoxPosition.TabIndex = 3;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(12, 56);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(178, 20);
            this.textBoxFIO.TabIndex = 0;
            // 
            // buttonUnloading
            // 
            this.buttonUnloading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUnloading.Location = new System.Drawing.Point(3, 291);
            this.buttonUnloading.Name = "buttonUnloading";
            this.buttonUnloading.Size = new System.Drawing.Size(236, 23);
            this.buttonUnloading.TabIndex = 3;
            this.buttonUnloading.Text = "Выгрузить из файла";
            this.buttonUnloading.UseVisualStyleBackColor = true;
            this.buttonUnloading.Click += new System.EventHandler(this.buttonUnloading_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(3, 256);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(236, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить в файл";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopy.Location = new System.Drawing.Point(3, 220);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(236, 23);
            this.buttonCopy.TabIndex = 1;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // richTextBoxForm
            // 
            this.richTextBoxForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxForm.ContextMenuStrip = this.contextMenuStripLab;
            this.richTextBoxForm.Location = new System.Drawing.Point(3, 4);
            this.richTextBoxForm.Name = "richTextBoxForm";
            this.richTextBoxForm.Size = new System.Drawing.Size(236, 213);
            this.richTextBoxForm.TabIndex = 0;
            this.richTextBoxForm.Text = "";
            // 
            // menuStripLab
            // 
            this.menuStripLab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemFile,
            this.ItemExit});
            this.menuStripLab.Location = new System.Drawing.Point(0, 0);
            this.menuStripLab.Name = "menuStripLab";
            this.menuStripLab.Size = new System.Drawing.Size(455, 24);
            this.menuStripLab.TabIndex = 1;
            this.menuStripLab.Text = "menuStripLab9";
            // 
            // ItemFile
            // 
            this.ItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemCopy,
            this.ItemSave,
            this.ItemUnloading});
            this.ItemFile.Name = "ItemFile";
            this.ItemFile.Size = new System.Drawing.Size(48, 20);
            this.ItemFile.Text = "Файл";
            this.ItemFile.Click += new System.EventHandler(this.buttonUnloading_Click);
            // 
            // ItemCopy
            // 
            this.ItemCopy.Name = "ItemCopy";
            this.ItemCopy.Size = new System.Drawing.Size(180, 22);
            this.ItemCopy.Text = "Копировать";
            this.ItemCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // ItemSave
            // 
            this.ItemSave.Name = "ItemSave";
            this.ItemSave.Size = new System.Drawing.Size(180, 22);
            this.ItemSave.Text = "Сохранить в файл";
            this.ItemSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ItemUnloading
            // 
            this.ItemUnloading.Name = "ItemUnloading";
            this.ItemUnloading.Size = new System.Drawing.Size(180, 22);
            this.ItemUnloading.Text = "Выгрузить из файл";
            // 
            // ItemExit
            // 
            this.ItemExit.Name = "ItemExit";
            this.ItemExit.Size = new System.Drawing.Size(54, 20);
            this.ItemExit.Text = "Выход";
            this.ItemExit.Click += new System.EventHandler(this.ItemExit_Click);
            // 
            // contextMenuStripLab
            // 
            this.contextMenuStripLab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemSave,
            this.toolStripMenuItemClear});
            this.contextMenuStripLab.Name = "contextMenuStripLab";
            this.contextMenuStripLab.ShowImageMargin = false;
            this.contextMenuStripLab.Size = new System.Drawing.Size(156, 92);
            this.contextMenuStripLab.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripLab_ItemClicked);
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemOpen.Text = "Открыть";
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemSave.Text = "Сохранить";
            // 
            // toolStripMenuItemClear
            // 
            this.toolStripMenuItemClear.Name = "toolStripMenuItemClear";
            this.toolStripMenuItemClear.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemClear.Text = "Очистить";
            // 
            // FormLab9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 353);
            this.Controls.Add(this.splitContainerLab);
            this.Controls.Add(this.menuStripLab);
            this.Name = "FormLab9";
            this.Text = "Лабораторная работа №9";
            this.splitContainerLab.Panel1.ResumeLayout(false);
            this.splitContainerLab.Panel1.PerformLayout();
            this.splitContainerLab.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLab)).EndInit();
            this.splitContainerLab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCours)).EndInit();
            this.menuStripLab.ResumeLayout(false);
            this.menuStripLab.PerformLayout();
            this.contextMenuStripLab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerLab;
        private System.Windows.Forms.DateTimePicker datePickerDateBirth;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMan;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox checkedListBoxLanguage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownCours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxForm;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonUnloading;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.MenuStrip menuStripLab;
        private System.Windows.Forms.ToolStripMenuItem ItemFile;
        private System.Windows.Forms.ToolStripMenuItem ItemCopy;
        private System.Windows.Forms.ToolStripMenuItem ItemSave;
        private System.Windows.Forms.ToolStripMenuItem ItemUnloading;
        private System.Windows.Forms.ToolStripMenuItem ItemExit;
        private System.Windows.Forms.SaveFileDialog saveFileDialogLab;
        private System.Windows.Forms.OpenFileDialog openFileDialogLab;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLab;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClear;
    }
}