
namespace AgilCourse
{
    partial class ProductManagerForm
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
            this.ProductTable = new System.Windows.Forms.Button();
            this.productionRqst = new System.Windows.Forms.Button();
            this.tobaccos = new System.Windows.Forms.Button();
            this.brands = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.addBrand = new System.Windows.Forms.Button();
            this.addTobacco = new System.Windows.Forms.Button();
            this.acceptProdRqst = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Панель управления менеджера по продуктам";
            // 
            // ProductTable
            // 
            this.ProductTable.Location = new System.Drawing.Point(15, 64);
            this.ProductTable.Name = "ProductTable";
            this.ProductTable.Size = new System.Drawing.Size(94, 23);
            this.ProductTable.TabIndex = 1;
            this.ProductTable.Text = "Продукты";
            this.ProductTable.UseVisualStyleBackColor = true;
            this.ProductTable.Click += new System.EventHandler(this.ProductTable_Click);
            // 
            // productionRqst
            // 
            this.productionRqst.Location = new System.Drawing.Point(15, 93);
            this.productionRqst.Name = "productionRqst";
            this.productionRqst.Size = new System.Drawing.Size(214, 23);
            this.productionRqst.TabIndex = 2;
            this.productionRqst.Text = "Запросы на производство";
            this.productionRqst.UseVisualStyleBackColor = true;
            this.productionRqst.Click += new System.EventHandler(this.productionRqst_Click);
            // 
            // tobaccos
            // 
            this.tobaccos.Location = new System.Drawing.Point(15, 151);
            this.tobaccos.Name = "tobaccos";
            this.tobaccos.Size = new System.Drawing.Size(214, 23);
            this.tobaccos.TabIndex = 3;
            this.tobaccos.Text = "Табаки";
            this.tobaccos.UseVisualStyleBackColor = true;
            this.tobaccos.Click += new System.EventHandler(this.tobaccos_Click);
            // 
            // brands
            // 
            this.brands.Location = new System.Drawing.Point(15, 122);
            this.brands.Name = "brands";
            this.brands.Size = new System.Drawing.Size(214, 23);
            this.brands.TabIndex = 4;
            this.brands.Text = "Бренды";
            this.brands.UseVisualStyleBackColor = true;
            this.brands.Click += new System.EventHandler(this.brands_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(15, 229);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(214, 23);
            this.addProduct.TabIndex = 5;
            this.addProduct.Text = "Добавить продукт";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // addBrand
            // 
            this.addBrand.Location = new System.Drawing.Point(15, 258);
            this.addBrand.Name = "addBrand";
            this.addBrand.Size = new System.Drawing.Size(214, 23);
            this.addBrand.TabIndex = 6;
            this.addBrand.Text = "Добавить бренд";
            this.addBrand.UseVisualStyleBackColor = true;
            this.addBrand.Click += new System.EventHandler(this.addBrand_Click);
            // 
            // addTobacco
            // 
            this.addTobacco.Location = new System.Drawing.Point(15, 287);
            this.addTobacco.Name = "addTobacco";
            this.addTobacco.Size = new System.Drawing.Size(214, 23);
            this.addTobacco.TabIndex = 7;
            this.addTobacco.Text = "Добавить табак";
            this.addTobacco.UseVisualStyleBackColor = true;
            this.addTobacco.Click += new System.EventHandler(this.addTobacco_Click);
            // 
            // acceptProdRqst
            // 
            this.acceptProdRqst.Location = new System.Drawing.Point(15, 316);
            this.acceptProdRqst.Name = "acceptProdRqst";
            this.acceptProdRqst.Size = new System.Drawing.Size(275, 23);
            this.acceptProdRqst.TabIndex = 8;
            this.acceptProdRqst.Text = "Одобрение запросов на производство";
            this.acceptProdRqst.UseVisualStyleBackColor = true;
            this.acceptProdRqst.Click += new System.EventHandler(this.acceptProdRqst_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Таблицы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Запросы";
            // 
            // ProductManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 394);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.acceptProdRqst);
            this.Controls.Add(this.addTobacco);
            this.Controls.Add(this.addBrand);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.brands);
            this.Controls.Add(this.tobaccos);
            this.Controls.Add(this.productionRqst);
            this.Controls.Add(this.ProductTable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ProductManagerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ProductTable;
        private System.Windows.Forms.Button productionRqst;
        private System.Windows.Forms.Button tobaccos;
        private System.Windows.Forms.Button brands;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button addBrand;
        private System.Windows.Forms.Button addTobacco;
        private System.Windows.Forms.Button acceptProdRqst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}