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
    public partial class AddMarketForm : Form
    {
        OleDbConnection connection_;
        public AddMarketForm(OleDbConnection connection)
        {
            InitializeComponent();
            connection_ = connection;
        }

        private void createOrderBT_Click(object sender, EventArgs e)
        {
            if (nameTB.Text.Length == 0 ||
                cityTB.Text.Length == 0)
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            OleDbCommand cmd = new OleDbCommand("CreateMarket", connection_);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", nameTB.Text);
            cmd.Parameters.AddWithValue("@city", cityTB.Text);

            if (cmd.ExecuteNonQuery() <= 0)
            {
                MessageBox.Show("Ошибка выполнения запроса SQL", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Магазин успешно добавлен", "Успех", MessageBoxButtons.OK);
            }
        }
    }
}
