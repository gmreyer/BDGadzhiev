namespace AgilCourse
{
    partial class AddProductForm
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
            this.tobaccoTB = new System.Windows.Forms.TextBox();
            this.brandTB = new System.Windows.Forms.TextBox();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.grammTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tobaccoTB
            // 
            this.tobaccoTB.Location = new System.Drawing.Point(98, 8);
            this.tobaccoTB.Name = "tobaccoTB";
            this.tobaccoTB.Size = new System.Drawing.Size(100, 22);
            this.tobaccoTB.TabIndex = 0;
            // 
            // brandTB
            // 
            this.brandTB.Location = new System.Drawing.Point(98, 36);
            this.brandTB.Name = "brandTB";
            this.brandTB.Size = new System.Drawing.Size(100, 22);
            this.brandTB.TabIndex = 1;
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(98, 64);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(100, 22);
            this.priceTB.TabIndex = 2;
            // 
            // grammTB
            // 
            this.grammTB.Location = new System.Drawing.Point(98, 92);
            this.grammTB.Name = "grammTB";
            this.grammTB.Size = new System.Drawing.Size(100, 22);
            this.grammTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID табака";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID бренда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Стоимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "гр. в пачке";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(60, 127);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(85, 23);
            this.add.TabIndex = 8;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 162);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grammTB);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.brandTB);
            this.Controls.Add(this.tobaccoTB);
            this.Name = "AddProductForm";
            this.Text = "AddProducrForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tobaccoTB;
        private System.Windows.Forms.TextBox brandTB;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.TextBox grammTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add;
    }
}