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
    public partial class LogisticManagerForm : Form
    {
        private OleDbConnection connection_;
        private User user_;

        public LogisticManagerForm(OleDbConnection connection, User user)
        {
            InitializeComponent();

            connection_ = connection;
            user_ = user;
        }

        private void orderListBT_Click(object sender, EventArgs e)
        {
            Table dataTable = new Table(connection_, "[Order], Markets",
                "select [Order].id_product as [ID продукта], Markets.name as [Название магазина] from [Order], Markets where [Order].id_market = Markets.id_market");
            dataTable.MdiParent = this.MdiParent;
            dataTable.Show();
        }

        private void marketListBT_Click(object sender, EventArgs e)
        {
            Table dataTable = new Table(connection_, "Markets", "select * from Markets");
            dataTable.MdiParent = this.MdiParent;
            dataTable.Show();
        }

        private void warehouseListBT_Click(object sender, EventArgs e)
        {
            Table dataTable = new Table(connection_, "Warehouse", "select * from Warehouse");
            dataTable.MdiParent = this.MdiParent;
            dataTable.Show();
        }

        private void createOrder_Click(object sender, EventArgs e)
        {
            CreateOrderForm form = new CreateOrderForm(connection_, user_);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void createProductOrderBT_Click(object sender, EventArgs e)
        {
            CreateRqstForm form = new CreateRqstForm(connection_);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void addMarketBT_Click(object sender, EventArgs e)
        {
            AddMarketForm form = new AddMarketForm(connection_);
            form.MdiParent = this.MdiParent;
            form.Show();
        }
    }
}
