﻿namespace AgilCourse
{
    partial class AddMarketForm
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
            this.createOrderBT = new System.Windows.Forms.Button();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createOrderBT
            // 
            this.createOrderBT.Location = new System.Drawing.Point(190, 36);
            this.createOrderBT.Name = "createOrderBT";
            this.createOrderBT.Size = new System.Drawing.Size(75, 23);
            this.createOrderBT.TabIndex = 0;
            this.createOrderBT.Text = "Создать";
            this.createOrderBT.UseVisualStyleBackColor = true;
            this.createOrderBT.Click += new System.EventHandler(this.createOrderBT_Click);
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(85, 12);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 22);
            this.nameTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Город";
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(85, 40);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(100, 22);
            this.cityTB.TabIndex = 3;
            // 
            // AddMarketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 88);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cityTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.createOrderBT);
            this.Name = "AddMarketForm";
            this.Text = "AddMarketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createOrderBT;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cityTB;
    }
}