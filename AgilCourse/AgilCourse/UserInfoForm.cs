using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgilCourse
{
    public partial class UserInfoForm : Form
    {
        private User user_;
        public UserInfoForm(User user)
        {
            InitializeComponent();

            this.user_ = user;
            nameTB.Text = user_.name_;
            ageTB.Text = user_.age_.ToString();
            postTB.Text = user_.post_;
            salaryTB.Text = user_.salary_.ToString();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Authentication authForm = new Authentication();
            this.MdiParent.Hide();
            authForm.ShowDialog();
            this.MdiParent.Close();
        }
    }
}
