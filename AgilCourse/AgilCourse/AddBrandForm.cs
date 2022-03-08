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
    public partial class AddBrandForm : Form
    {
        OleDbConnection connection_;
        public AddBrandForm(OleDbConnection connection)
        {
            InitializeComponent();
            this.connection_ = connection;
        }

        private void addBrand_Click(object sender, EventArgs e)
        {
            if (nameTB.Text.Length == 0 ||
                countryTB.Text.Length == 0)
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            OleDbCommand cmd = new OleDbCommand("AddBrand", connection_);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", nameTB.Text);
            cmd.Parameters.AddWithValue("@country", countryTB.Text);

            if (cmd.ExecuteNonQuery() <= 0)
            {
                MessageBox.Show("Ошибка выполнения запроса SQL", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Бренд успешно добавлен", "Успех", MessageBoxButtons.OK);
            }
        }
    }
}
