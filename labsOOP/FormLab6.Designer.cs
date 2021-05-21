namespace labsOOP
{
    partial class FormLab6
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
            this.checkedListBoxMenu = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRezPrice = new System.Windows.Forms.Label();
            this.labelHelp = new System.Windows.Forms.Label();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxMenu
            // 
            this.checkedListBoxMenu.Font = new System.Drawing.Font("Engravers MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBoxMenu.FormattingEnabled = true;
            this.checkedListBoxMenu.Items.AddRange(new object[] {
            "Борщ, 135 руб",
            "Жарёха со свининой, 270 руб",
            "Картофельное пюре, 95 руб",
            "Кесадилия с курицей, 190 руб",
            "Луковые кольца, 170 руб",
            "Макарон с шоколадом, 55 руб",
            "Наггетсы из курочки, 220 руб",
            "Овощи гриль, 145 руб",
            "Орео-Кейк, 160 руб",
            "Паста с морепродуктами, 370 руб",
            "Пита Сицилия, 180 руб",
            "Пицца \"Домашняя\", 240 руб",
            "Пицца \"Маргарита\", 235 руб",
            "Пицца \"Суприм\", 245 руб",
            "Роллы \"Калифорния\", 330 руб",
            "Роллы \"Сяке Маки\", 190 руб",
            "Роллы \"Филадельфия\", 350 руб",
            "Салат Примавера, 180 руб",
            "Салат с угрём и авокадо, 290 руб",
            "Солянка сборная мясная, 170 руб",
            "Спагетти Болоньезе, 250 руб",
            "Тирамису, 170 руб",
            "Филе трески по-милански, 340 руб",
            "Фисташковый торт с малиной, 160 руб",
            "Фокачча с сыром, 60 руб",
            "Чизкейк Нью-Йорк, 160 руб",
            "Эклер, 65 руб"});
            this.checkedListBoxMenu.Location = new System.Drawing.Point(23, 51);
            this.checkedListBoxMenu.Name = "checkedListBoxMenu";
            this.checkedListBoxMenu.Size = new System.Drawing.Size(247, 409);
            this.checkedListBoxMenu.TabIndex = 0;
            this.checkedListBoxMenu.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxMenu_ItemCheck);
            this.checkedListBoxMenu.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxMenu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Меню:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(304, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Итоговая стоимость,\r\nв рублях";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelRezPrice
            // 
            this.labelRezPrice.AutoSize = true;
            this.labelRezPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRezPrice.Location = new System.Drawing.Point(303, 204);
            this.labelRezPrice.Name = "labelRezPrice";
            this.labelRezPrice.Size = new System.Drawing.Size(0, 24);
            this.labelRezPrice.TabIndex = 3;
            this.labelRezPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHelp
            // 
            this.labelHelp.AccessibleDescription = "yer";
            this.labelHelp.AutoSize = true;
            this.labelHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHelp.Location = new System.Drawing.Point(252, 16);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(18, 20);
            this.labelHelp.TabIndex = 4;
            this.labelHelp.Tag = "";
            this.labelHelp.Text = "?";
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Enabled = false;
            this.numericUpDownCount.Location = new System.Drawing.Point(307, 84);
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCount.TabIndex = 5;
            this.numericUpDownCount.ValueChanged += new System.EventHandler(this.numericUpDownCount_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Укажите количество порций \r\nвыбранного блюда";
            // 
            // FormLab6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 472);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.labelRezPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxMenu);
            this.Name = "FormLab6";
            this.Text = "Лабораторная работа №6";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRezPrice;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.CheckedListBox checkedListBoxMenu;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label label3;
    }
}