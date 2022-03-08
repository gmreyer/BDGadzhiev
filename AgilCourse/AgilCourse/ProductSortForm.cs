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
    public partial class ProductSortForm : Form
    {
        OleDbConnection connection_;

        string[] reqSelect = { "Brand.name as [Название Бренда]",
                               "Tobacco.taste as [Вкус]",
                               "Tobacco.strength as [Крепость]",
                               "Product.price as [Стоимость]",
                               "Product.gramm as [Граммовка]"};
        string[] reqFrom = { "Brand",
                             "Tobacco",
                             "Tobacco",
                             "",
                             ""};
        string[] reqWhere = { "Brand.id_brand = Product.id_brand",
                              "Tobacco.id_tobacco = Product.id_tobacco",
                              "Tobacco.id_tobacco = Product.id_tobacco",
                              "",
                              ""};

        public ProductSortForm(OleDbConnection connection)
        {
            InitializeComponent();
            connection_ = connection;
        }

        private void getBtn_Click(object sender, EventArgs e)
        {
            string select = "select Product.id_product as [ID], ";
            string from = "from Product, ";
            string where = "where ";

            foreach (int index in itemsList.CheckedIndices)
            {
                select += reqSelect[index] + ", ";
                
                if (reqFrom[index] != "" && (from.Length == 0 || from.IndexOf("Tobacco") == -1))
                {
                    from += reqFrom[index] + ", ";
                }

                if (reqWhere[index] != "" && (where.Length == 0 || where.IndexOf("Tobacco.id_tobacco = Product.id_tobacco") == -1))
                {
                    where += reqWhere[index] + " and ";
                }
            }

            select = select.Remove(select.Length - 2, 2);
            from = from.Remove(from.Length - 2, 2);
            if (where == "where ")
            {
                where = "";
            }
            else
            {
                where = where.Remove(where.Length - 5, 5);
            }

            string request = select + " " + from + " " + where;

            Table dataTable = new Table(connection_, from, request);
            dataTable.MdiParent = this.MdiParent;
            dataTable.Show();
        }
    }
}
