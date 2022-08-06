using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        public AdminLogin(String user)
        {
            InitializeComponent();

            if (user == "AdminLoginPage")
            {
                this.Show();
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            if(AdminUsernametxt.Text == "admin" && AdminPwdTxt.Text == "admin")
            {
                AdminDashboard ds = new AdminDashboard("Admin");
                ds.Show();
                this.Hide();     
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            WelcomePage fm = new WelcomePage();
            this.Hide();
            fm.Show();
        }
    }
}
