namespace AgilCourse
{
    partial class AddTobaccoForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.countryTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.strengthTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typeTB = new System.Windows.Forms.TextBox();
            this.addTobacco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tasteTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Страна";
            // 
            // countryTB
            // 
            this.countryTB.Location = new System.Drawing.Point(81, 87);
            this.countryTB.Name = "countryTB";
            this.countryTB.Size = new System.Drawing.Size(100, 22);
            this.countryTB.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Крепость";
            // 
            // strengthTB
            // 
            this.strengthTB.Location = new System.Drawing.Point(81, 59);
            this.strengthTB.Name = "strengthTB";
            this.strengthTB.Size = new System.Drawing.Size(100, 22);
            this.strengthTB.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Сорт";
            // 
            // typeTB
            // 
            this.typeTB.Location = new System.Drawing.Point(81, 31);
            this.typeTB.Name = "typeTB";
            this.typeTB.Size = new System.Drawing.Size(100, 22);
            this.typeTB.TabIndex = 12;
            // 
            // addTobacco
            // 
            this.addTobacco.Location = new System.Drawing.Point(45, 115);
            this.addTobacco.Name = "addTobacco";
            this.addTobacco.Size = new System.Drawing.Size(100, 23);
            this.addTobacco.TabIndex = 11;
            this.addTobacco.Text = "Добавить";
            this.addTobacco.UseVisualStyleBackColor = true;
            this.addTobacco.Click += new System.EventHandler(this.addTobacco_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Вкус";
            // 
            // tasteTB
            // 
            this.tasteTB.Location = new System.Drawing.Point(81, 3);
            this.tasteTB.Name = "tasteTB";
            this.tasteTB.Size = new System.Drawing.Size(100, 22);
            this.tasteTB.TabIndex = 9;
            // 
            // AddTobaccoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 151);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countryTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.strengthTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeTB);
            this.Controls.Add(this.addTobacco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tasteTB);
            this.Name = "AddTobaccoForm";
            this.Text = "AddTobaccoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox countryTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox strengthTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox typeTB;
        private System.Windows.Forms.Button addTobacco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tasteTB;
    }
}