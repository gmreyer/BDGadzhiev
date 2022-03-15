
namespace AgilCourse
{
    partial class LogisticManagerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.orderListBT = new System.Windows.Forms.Button();
            this.marketListBT = new System.Windows.Forms.Button();
            this.warehouseListBT = new System.Windows.Forms.Button();
            this.createOrder = new System.Windows.Forms.Button();
            this.createProductOrderBT = new System.Windows.Forms.Button();
            this.addMarketBT = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Панель управления менеджера по логистике";
            // 
            // orderListBT
            // 
            this.orderListBT.Location = new System.Drawing.Point(15, 58);
            this.orderListBT.Name = "orderListBT";
            this.orderListBT.Size = new System.Drawing.Size(128, 23);
            this.orderListBT.TabIndex = 1;
            this.orderListBT.Text = "Список заказов";
            this.orderListBT.UseVisualStyleBackColor = true;
            this.orderListBT.Click += new System.EventHandler(this.orderListBT_Click);
            // 
            // marketListBT
            // 
            this.marketListBT.Location = new System.Drawing.Point(15, 84);
            this.marketListBT.Name = "marketListBT";
            this.marketListBT.Size = new System.Drawing.Size(128, 23);
            this.marketListBT.TabIndex = 2;
            this.marketListBT.Text = "Список маркетов";
            this.marketListBT.UseVisualStyleBackColor = true;
            this.marketListBT.Click += new System.EventHandler(this.marketListBT_Click);
            // 
            // warehouseListBT
            // 
            this.warehouseListBT.Location = new System.Drawing.Point(15, 110);
            this.warehouseListBT.Name = "warehouseListBT";
            this.warehouseListBT.Size = new System.Drawing.Size(204, 23);
            this.warehouseListBT.TabIndex = 3;
            this.warehouseListBT.Text = "Список продуктов на складе";
            this.warehouseListBT.UseVisualStyleBackColor = true;
            this.warehouseListBT.Click += new System.EventHandler(this.warehouseListBT_Click);
            // 
            // createOrder
            // 
            this.createOrder.Location = new System.Drawing.Point(15, 184);
            this.createOrder.Name = "createOrder";
            this.createOrder.Size = new System.Drawing.Size(128, 23);
            this.createOrder.TabIndex = 4;
            this.createOrder.Text = "Создать заказ";
            this.createOrder.UseVisualStyleBackColor = true;
            this.createOrder.Click += new System.EventHandler(this.createOrder_Click);
            // 
            // createProductOrderBT
            // 
            this.createProductOrderBT.Location = new System.Drawing.Point(15, 213);
            this.createProductOrderBT.Name = "createProductOrderBT";
            this.createProductOrderBT.Size = new System.Drawing.Size(301, 23);
            this.createProductOrderBT.TabIndex = 5;
            this.createProductOrderBT.Text = "Создать запрос на производство продукта";
            this.createProductOrderBT.UseVisualStyleBackColor = true;
            this.createProductOrderBT.Click += new System.EventHandler(this.createProductOrderBT_Click);
            // 
            // addMarketBT
            // 
            this.addMarketBT.Location = new System.Drawing.Point(15, 242);
            this.addMarketBT.Name = "addMarketBT";
            this.addMarketBT.Size = new System.Drawing.Size(128, 23);
            this.addMarketBT.TabIndex = 6;
            this.addMarketBT.Text = "Добавить маркет";
            this.addMarketBT.UseVisualStyleBackColor = true;
            this.addMarketBT.Click += new System.EventHandler(this.addMarketBT_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Запросы";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Таблицы";
            // 
            // LogisticManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 394);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addMarketBT);
            this.Controls.Add(this.createProductOrderBT);
            this.Controls.Add(this.createOrder);
            this.Controls.Add(this.warehouseListBT);
            this.Controls.Add(this.marketListBT);
            this.Controls.Add(this.orderListBT);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogisticManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LogisticManagerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button orderListBT;
        private System.Windows.Forms.Button marketListBT;
        private System.Windows.Forms.Button warehouseListBT;
        private System.Windows.Forms.Button createOrder;
        private System.Windows.Forms.Button createProductOrderBT;
        private System.Windows.Forms.Button addMarketBT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}