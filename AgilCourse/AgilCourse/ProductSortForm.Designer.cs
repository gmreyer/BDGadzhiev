namespace AgilCourse
{
    partial class ProductSortForm
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
            this.itemsList = new System.Windows.Forms.CheckedListBox();
            this.getBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsList
            // 
            this.itemsList.CheckOnClick = true;
            this.itemsList.FormattingEnabled = true;
            this.itemsList.Items.AddRange(new object[] {
            "Название Бренда",
            "Вкус Табака",
            "Крепость Табака",
            "Цена",
            "Грамм в пачке"});
            this.itemsList.Location = new System.Drawing.Point(12, 28);
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(146, 123);
            this.itemsList.TabIndex = 1;
            // 
            // getBtn
            // 
            this.getBtn.Location = new System.Drawing.Point(164, 75);
            this.getBtn.Name = "getBtn";
            this.getBtn.Size = new System.Drawing.Size(97, 23);
            this.getBtn.TabIndex = 2;
            this.getBtn.Text = "Получить";
            this.getBtn.UseVisualStyleBackColor = true;
            this.getBtn.Click += new System.EventHandler(this.getBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите поля для вывода";
            // 
            // ProductSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 168);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getBtn);
            this.Controls.Add(this.itemsList);
            this.Name = "ProductSortForm";
            this.Text = "Product\'s fields choice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox itemsList;
        private System.Windows.Forms.Button getBtn;
        private System.Windows.Forms.Label label1;
    }
}