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
    public partial class AcceptRqstForm : Form
    {
        OleDbConnection connection_;
        List<int> ids = new List<int>();

        public AcceptRqstForm(OleDbConnection connection)
        {
            InitializeComponent();
            this.connection_ = connection;

            OleDbCommand cmd = new OleDbCommand("select ProductionOrder.id_order from ProductionOrder", connection_);
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ids.Add(reader.GetInt32(0));
            }

            list.DataSource = ids;
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите запрос", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            OleDbCommand cmd = new OleDbCommand("AcceptProductionRequest", connection_);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_order", ids[list.SelectedIndex]);

            if (cmd.ExecuteNonQuery() <= 0)
            {
                MessageBox.Show("Ошибка выполнения запроса SQL", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Запрос успешно одобрен", "Успех", MessageBoxButtons.OK);
            }
        }
    }
}
