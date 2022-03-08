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
    public partial class Table : Form
    {
        private OleDbDataAdapter da;
        public Table(OleDbConnection connection, string from, string data)
        {
            InitializeComponent();
            da = new OleDbDataAdapter(data, connection);  
            DataTable dataTable = new DataTable(from);
            ds.Tables.Add(dataTable);
            dgTable.SetDataBinding(ds, from);
            da.Fill(ds, from);
            dgTable.DataMember = from;
        }
    }
}
