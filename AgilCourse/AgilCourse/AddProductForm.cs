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
    public partial class AddProductForm : Form
    {
        OleDbConnection connection_;
        public AddProductForm(OleDbConnection connection)
        {
            InitializeComponent();
            this.connection_ = connection;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (tobaccoTB.Text.Length == 0 ||
                brandTB.Text.Length == 0 ||
                priceTB.Text.Length == 0 ||
                grammTB.Text.Length == 0)
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            decimal price = Decimal.Parse(priceTB.Text);

            OleDbCommand cmd = new OleDbCommand("AddProduct", connection_);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_tobacco", Int32.Parse(tobaccoTB.Text));
            cmd.Parameters.AddWithValue("@id_brand", Int32.Parse(brandTB.Text));
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@gramm", Int32.Parse(grammTB.Text));

            if (cmd.ExecuteNonQuery() <= 0)
            {
                MessageBox.Show("Ошибка выполнения запроса SQL", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Продукт успешно добавлен", "Успех", MessageBoxButtons.OK);
            }
        }
    }
}
