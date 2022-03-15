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
    public partial class UserForm : Form
    {
        private OleDbConnection connection_;
        public UserForm(User user, OleDbConnection connection)
        {
            InitializeComponent();

            connection_ = connection;

            UserInfoForm userInfoForm = new UserInfoForm(user);
            initForm(userInfoForm);
            userInfoForm.Location = new Point(0, 0);

            switch (user.id_post_)
            {
                case 0:
                case 1:
                    LogisticManagerForm LMForm = new LogisticManagerForm(connection_, user);
                    initForm(LMForm);
                    LMForm.Location = new Point(0, 160);

                    if (user.id_post_ == 0) goto case 2;
                    
                    break;

                case 2:
                    ProductManagerForm PMForm = new ProductManagerForm(connection_, user);
                    initForm(PMForm);

                    Point location = new Point(0, 160);

                    if (user.id_post_ == 0)
                    {
                        location.Y = 480;
                    }

                    PMForm.Location = location;

                    break;
            }
        }

        private void initForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }
    }
}
