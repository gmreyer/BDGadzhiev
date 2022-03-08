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
    public partial class AddTobaccoForm : Form
    {
        OleDbConnection connection_;
        public AddTobaccoForm(OleDbConnection connection)
        {
            InitializeComponent();
            this.connection_ = connection;
        }

        private void addTobacco_Click(object sender, EventArgs e)
        {
            if (tasteTB.Text.Length == 0 ||
                typeTB.Text.Length == 0 ||
                strengthTB.Text.Length == 0 ||
                countryTB.Text.Length == 0)
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            OleDbCommand cmd = new OleDbCommand("AddTobacco", connection_);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@taste", tasteTB.Text);
            cmd.Parameters.AddWithValue("@type", typeTB.Text);
            cmd.Parameters.AddWithValue("@strength", Int32.Parse(strengthTB.Text));
            cmd.Parameters.AddWithValue("@country", countryTB.Text);

            if (cmd.ExecuteNonQuery() <= 0)
            {
                MessageBox.Show("Ошибка выполнения запроса SQL", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Табак успешно добавлен", "Успех", MessageBoxButtons.OK);
            }
        }
    }
}
