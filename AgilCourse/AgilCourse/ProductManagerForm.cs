using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgilCourse
{
    public partial class ProductManagerForm : Form
    {
        private OleDbConnection connection_;
        private User user_;
        public ProductManagerForm(OleDbConnection connection, User user)
        {
            InitializeComponent();
            connection_ = connection;
            user_ = user;
        }

        private void ProductTable_Click(object sender, EventArgs e)
        {
            ProductSortForm form = new ProductSortForm(connection_);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void productionRqst_Click(object sender, EventArgs e)
        {
            string from = "ProductionOrder, Warehouse, Product, Worker, Brand, Tobacco";
            string data = "select ProductionOrder.id_order as [ID запроса], " +
                          "Warehouse.id_product as [ID продукта], " +
                          "Brand.name as [Бренд], " +
                          "Tobacco.taste as [Вкус табака], " +
                          "Warehouse.id_warehouse as [Ячейка на складе], " +
                          "Worker.name as [Имя ответственного сотрудника], " +
                          "ProductionOrder.quantity as [шт. для производства], " +
                          "Warehouse.quantity as [шт. на складе] " +
                          "from " + from +
                          " where ProductionOrder.id_warehouse = Warehouse.id_warehouse and " +
                          "Warehouse.id_product = Product.id_product and " +
                          "Brand.id_brand = Product.id_brand and " +
                          "Tobacco.id_tobacco = Product.id_tobacco and " +
                          "ProductionOrder.id_worker = Worker.id_worker";

            Table dataTable = new Table(connection_, from, data);
            dataTable.MdiParent = this.MdiParent;
            dataTable.Show();
        }

        private void brands_Click(object sender, EventArgs e)
        {
            Table dataTable = new Table(connection_, "Brand", "select * from Brand");
            dataTable.MdiParent = this.MdiParent;
            dataTable.Show();
        }

        private void tobaccos_Click(object sender, EventArgs e)
        {
            Table dataTable = new Table(connection_, "Tobacco", "select * from Tobacco");
            dataTable.MdiParent = this.MdiParent;
            dataTable.Show();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm(connection_);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void addBrand_Click(object sender, EventArgs e)
        {
            AddBrandForm form = new AddBrandForm(connection_);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void addTobacco_Click(object sender, EventArgs e)
        {
            AddTobaccoForm form = new AddTobaccoForm(connection_);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void acceptProdRqst_Click(object sender, EventArgs e)
        {
            AcceptRqstForm form = new AcceptRqstForm(connection_);
            form.MdiParent = this.MdiParent;
            form.Show();
        }
    }
}
