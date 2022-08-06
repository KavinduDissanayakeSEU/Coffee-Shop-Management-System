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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UloginBtn_Click(object sender, EventArgs e)
        {
            UserDashboard ds = new UserDashboard("User");
            ds.Show();
            this.Hide();
        }

        private void AdminLog_Click(object sender, EventArgs e)
        {
            AdminLogin ad = new AdminLogin("AdminLoginPage");
            ad.Show();
            this.Hide();
        }
    }
}
