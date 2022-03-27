namespace AgilCourse
{
    partial class CreateRqstForm
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
            this.productsList = new System.Windows.Forms.ListBox();
            this.managersList = new System.Windows.Forms.ListBox();
            this.quantityTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createRqstBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productsList
            // 
            this.productsList.FormattingEnabled = true;
            this.productsList.ItemHeight = 16;
            this.productsList.Location = new System.Drawing.Point(12, 28);
            this.productsList.Name = "productsList";
            this.productsList.Size = new System.Drawing.Size(120, 164);
            this.productsList.TabIndex = 0;
            // 
            // managersList
            // 
            this.managersList.FormattingEnabled = true;
            this.managersList.ItemHeight = 16;
            this.managersList.Location = new System.Drawing.Point(138, 28);
            this.managersList.Name = "managersList";
            this.managersList.Size = new System.Drawing.Size(174, 164);
            this.managersList.TabIndex = 1;
            // 
            // quantityTB
            // 
            this.quantityTB.Location = new System.Drawing.Point(408, 28);
            this.quantityTB.Name = "quantityTB";
            this.quantityTB.Size = new System.Drawing.Size(100, 22);
            this.quantityTB.TabIndex = 2;
            this.quantityTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTB_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Продукты";
            // 
            // createRqstBT
            // 
            this.createRqstBT.Location = new System.Drawing.Point(333, 169);
            this.createRqstBT.Name = "createRqstBT";
            this.createRqstBT.Size = new System.Drawing.Size(75, 23);
            this.createRqstBT.TabIndex = 4;
            this.createRqstBT.Text = "Создать";
            this.createRqstBT.UseVisualStyleBackColor = true;
            this.createRqstBT.Click += new System.EventHandler(this.createRqstBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Менеджеры по продукции";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество";
            // 
            // CreateRqstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 204);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createRqstBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityTB);
            this.Controls.Add(this.managersList);
            this.Controls.Add(this.productsList);
            this.Name = "CreateRqstForm";
            this.Text = "CreateRqstForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productsList;
        private System.Windows.Forms.ListBox managersList;
        private System.Windows.Forms.TextBox quantityTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createRqstBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}