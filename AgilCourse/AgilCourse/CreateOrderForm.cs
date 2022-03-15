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
    public partial class CreateOrderForm : Form
    {
        User user_;
        OleDbConnection connection_;

        SortedDictionary<int, string> products = new SortedDictionary<int, string>();
        SortedDictionary<int, string> markets = new SortedDictionary<int, string>();

        public CreateOrderForm(OleDbConnection connection, User user)
        {
            InitializeComponent();

            user_ = user;
            connection_ = connection;

            OleDbCommand cmd = new OleDbCommand("select Markets.id_market, Markets.name" +
                " from Markets", connection_);
            OleDbCommand cmd1 = new OleDbCommand("select Product.id_product, Brand.name, Tobacco.type" +
                " from Product, Brand, Tobacco" +
                " where Tobacco.id_tobacco = Product.id_tobacco and Brand.id_brand = Product.id_brand", connection_);
            OleDbDataReader reader = cmd.ExecuteReader();
            OleDbDataReader reader1 = cmd1.ExecuteReader();

            while (reader.Read())
            {
                int idMarket;
                string market;
                idMarket = (int)reader.GetValue(0);
                market = reader.GetString(1);
                markets.Add(idMarket, market);
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
            marketsList.DataSource = markets.Values.ToList<string>();
        }

        private void createOrderBT_Click(object sender, EventArgs e)
        {
            if (marketsList.SelectedItems.Count == 0 || productsList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите запрос", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            OleDbCommand cmd = new OleDbCommand("CreateOrder", connection_);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_product", products.ElementAt<KeyValuePair<int, string>>(productsList.SelectedIndex).Key);
            cmd.Parameters.AddWithValue("@id_market", markets.ElementAt<KeyValuePair<int, string>>(productsList.SelectedIndex).Key);
            cmd.Parameters.AddWithValue("@id_worker", user_.id_worker_);

            if (cmd.ExecuteNonQuery() <= 0)
            {
                MessageBox.Show("Ошибка выполнения запроса SQL", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Заказ успешно добавлен", "Успех", MessageBoxButtons.OK);
            }
        }
    }
}
