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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        public AdminDashboard(String user)
        {
            InitializeComponent();

            if(user == "Admin")
            {
                BtnAdd.Show();
                BtnUpdate.Show();
                BtnRemove.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            WelcomePage fm = new WelcomePage();
            this.Hide();
            fm.Show();
            //Application.Exit();
        }

        private void BtnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WelcomePage fm = new WelcomePage();
            this.Hide();
            fm.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            uC_AddProducts1.Visible = true;
            uC_AddProducts1.BringToFront();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            uC_Welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_AddProducts1);
            uC_AddProducts1.Visible = false;
            uC_Welcome1.Visible = true;
            uC_UpdateProducts1.Visible = false;
            uC_RemoveProducts1.Visible = false;
        }

        private void uC_AddProducts1_Load(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            uC_UpdateProducts1.Visible = true;
            uC_UpdateProducts1.BringToFront();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            uC_RemoveProducts1.Visible = true;
            uC_RemoveProducts1.BringToFront();
        }
    }
}
