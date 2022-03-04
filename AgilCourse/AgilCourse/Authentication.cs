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
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connected failed!", "Connection", MessageBoxButtons.OK);
            }

            if (loginTB.Text == "" || passwordTB.Text == "")
            {
                MessageBox.Show("Введите логин и пароль", "Error", MessageBoxButtons.OK);
                return;
            }

            string login = loginTB.Text;
            int id_worker = 0;
            int id_post = 0;
            string name = "";
            string post = "";
            int age = 0;
            int salary = 0;
            string password = "";
            bool isUserExist = false;

            if (login == "admin" && passwordTB.Text == "admin")
            {
                id_worker = 0;
                id_post = 0;
                name = "Agil";
                post = "Admin";
                age = 20;
                salary = 10000;
                isUserExist = true;
            }
            else
            {
                OleDbCommand command = new OleDbCommand("getByPassword", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@login", loginTB.Text);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    password = reader.GetString(0);
                    id_worker = (int)reader.GetValue(1);
                    id_post = (int)reader.GetValue(2);
                    name = reader.GetString(3);
                    post = reader.GetString(4);
                    age = (int)reader.GetValue(5);
                    salary = (int)reader.GetValue(6);
                }

                if (password == passwordTB.Text)
                {
                    isUserExist = true;
                }
            }

            if (!isUserExist)
            {
                MessageBox.Show("Логин или пароль введены неверно", "Error", MessageBoxButtons.OK);
                return;
            }

            User user = new User(id_worker, id_post, name, post, age, salary);
            UserForm userForm = new UserForm(user, connection);
            this.Hide();
            userForm.ShowDialog();
            this.Close();
        }
    }
}
