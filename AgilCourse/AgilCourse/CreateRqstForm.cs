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
    public partial class CreateRqstForm : Form
    {
        OleDbConnection connection_;

        SortedDictionary<int, string> products = new SortedDictionary<int, string>();
        SortedDictionary<int, string> managers = new SortedDictionary<int, string>();

        public CreateRqstForm(OleDbConnection connection)
        {
            InitializeComponent();
            connection_ = connection;

            OleDbCommand cmd = new OleDbCommand("select Worker.id_worker, Worker.name" +
                " from Worker where Worker.id_post = 2", connection_);
            OleDbCommand cmd1 = new OleDbCommand("select Product.id_product, Brand.name, Tobacco.type" +
                " from Product, Brand, Tobacco" +
                " where Tobacco.id_tobacco = Product.id_tobacco and Brand.id_brand = Product.id_brand", connection_);
            OleDbDataReader reader = cmd.ExecuteReader();
            OleDbDataReader reader1 = cmd1.ExecuteReader();

            while (reader.Read())
            {
                int idManager;
                string manager;
                idManager = (int)reader.GetValue(0);
                manager = reader.GetString(1);
                managers.Add(idManager, manager);
            }

            while (reader1.Read())
            {
                int idProduct;
                string product;
                idProduct = (int)reader1.GetValue(0);
                product = reader1.GetString(1) + ' ' + reader1.GetString(2);
                products.Add(idProduct, product);

            }

            productsList.DataSource = products.Values.ToList<string>();
            managersList.DataSource = managers.Values.ToList<string>();
        }

        private void createRqstBT_Click(object sender, EventArgs e)
        {
            if (managersList.SelectedItems.Count == 0 ||
                productsList.SelectedItems.Count == 0 ||
                quantityTB.Text.Length == 0)
            {
                MessageBox.Show("Выберите продукт, менеджера по продажам и необходимое количество товара", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            SortedDictionary<int, int> warehouseSlots = new SortedDictionary<int, int>();

            OleDbCommand cmd = new OleDbCommand("select Warehouse.id_warehouse, Warehouse.id_product" +
                " from Warehouse", connection_);
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int idWarehouse;
                int idProduct;
                idWarehouse = (int)reader.GetValue(0);
                idProduct = (int)reader.GetValue(1);
                warehouseSlots.Add(idWarehouse, idProduct);
            }

            OleDbCommand cmd1;
            int id_warehouse = -1;

            if (!warehouseSlots.ContainsValue(products.ElementAt<KeyValuePair<int, string>>(productsList.SelectedIndex).Key))
            {
                cmd1 = new OleDbCommand("AddWarehouseSlot", connection_);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@id_product", products.ElementAt<KeyValuePair<int, string>>(productsList.SelectedIndex).Key);
                cmd1.Parameters.AddWithValue("@quantity", 0);

                if (cmd1.ExecuteNonQuery() <= 0)
                {
                    MessageBox.Show("Ошибка выполнения запроса SQL (добавление ячейки склада)", "Ошибка", MessageBoxButtons.OK);
                }
                else
                {
                    id_warehouse = warehouseSlots.Count + 1;
                }
            }
            else
            {
                foreach (KeyValuePair<int, int> element in warehouseSlots)
                {
                    if (element.Value == products.ElementAt<KeyValuePair<int, string>>(productsList.SelectedIndex).Key)
                    {
                        id_warehouse = element.Key;
                        break;
                    }
                }
            }

            if (id_warehouse == -1)
            {
                MessageBox.Show("Ошибка выполнения запроса SQL", "Ошибка", MessageBoxButtons.OK);
            }

            cmd = new OleDbCommand("AddRequest", connection_);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_worker", managers.ElementAt<KeyValuePair<int, string>>(managersList.SelectedIndex).Key);
            cmd.Parameters.AddWithValue("@id_warehouse", id_warehouse);
            cmd.Parameters.AddWithValue("@quantity", Int32.Parse(quantityTB.Text));

            if (cmd.ExecuteNonQuery() <= 0)
            {
                MessageBox.Show("Ошибка выполнения запроса SQL", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Заказ успешно добавлен", "Успех", MessageBoxButtons.OK);
            }
        }

        private void quantityTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}
