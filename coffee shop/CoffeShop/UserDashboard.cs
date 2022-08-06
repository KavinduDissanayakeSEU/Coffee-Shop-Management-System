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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        public UserDashboard(String user)
        {
            InitializeComponent();

            if (user == "User")
            {
                BtnPlaceOrder.Show();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
        }

        private void BtnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WelcomePage fm = new WelcomePage();
            this.Hide();
            fm.Show();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            uC_Welcome1.Visible = true;
            uC_Welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_PlaceOrder1);
            uC_PlaceOrder1.Visible = false;
            uC_Welcome1.Visible = true;
        }
    }
}
