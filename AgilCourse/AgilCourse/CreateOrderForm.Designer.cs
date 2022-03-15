namespace AgilCourse
{
    partial class CreateOrderForm
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
            this.marketsList = new System.Windows.Forms.ListBox();
            this.createOrderBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productsList
            // 
            this.productsList.FormattingEnabled = true;
            this.productsList.ItemHeight = 16;
            this.productsList.Location = new System.Drawing.Point(0, 0);
            this.productsList.Name = "productsList";
            this.productsList.Size = new System.Drawing.Size(234, 212);
            this.productsList.TabIndex = 0;
            // 
            // marketsList
            // 
            this.marketsList.FormattingEnabled = true;
            this.marketsList.ItemHeight = 16;
            this.marketsList.Location = new System.Drawing.Point(240, 0);
            this.marketsList.Name = "marketsList";
            this.marketsList.Size = new System.Drawing.Size(166, 212);
            this.marketsList.TabIndex = 1;
            // 
            // createOrderBT
            // 
            this.createOrderBT.Location = new System.Drawing.Point(412, 90);
            this.createOrderBT.Name = "createOrderBT";
            this.createOrderBT.Size = new System.Drawing.Size(75, 23);
            this.createOrderBT.TabIndex = 2;
            this.createOrderBT.Text = "Создать";
            this.createOrderBT.UseVisualStyleBackColor = true;
            this.createOrderBT.Click += new System.EventHandler(this.createOrderBT_Click);
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 212);
            this.Controls.Add(this.createOrderBT);
            this.Controls.Add(this.marketsList);
            this.Controls.Add(this.productsList);
            this.Name = "CreateOrderForm";
            this.Text = "CreateOrderForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox productsList;
        private System.Windows.Forms.ListBox marketsList;
        private System.Windows.Forms.Button createOrderBT;
    }
}