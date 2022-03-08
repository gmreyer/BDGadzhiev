namespace AgilCourse
{
    partial class AddBrandForm
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addBrand = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.countryTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(162, 12);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 22);
            this.nameTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // addBrand
            // 
            this.addBrand.Location = new System.Drawing.Point(81, 76);
            this.addBrand.Name = "addBrand";
            this.addBrand.Size = new System.Drawing.Size(95, 34);
            this.addBrand.TabIndex = 2;
            this.addBrand.Text = "Добавить";
            this.addBrand.UseVisualStyleBackColor = true;
            this.addBrand.Click += new System.EventHandler(this.addBrand_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Страна производства";
            // 
            // countryTB
            // 
            this.countryTB.Location = new System.Drawing.Point(162, 48);
            this.countryTB.Name = "countryTB";
            this.countryTB.Size = new System.Drawing.Size(100, 22);
            this.countryTB.TabIndex = 3;
            // 
            // AddBrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 119);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countryTB);
            this.Controls.Add(this.addBrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTB);
            this.Name = "AddBrandForm";
            this.Text = "AddBrandForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countryTB;
    }
}