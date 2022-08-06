using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop.AllUserControls
{
    public partial class UC_AddProducts : UserControl
    {
        function fn = new function();
        String query;

        public UC_AddProducts()
        {
            InitializeComponent();
        }

        private void addProductbtn_Click(object sender, EventArgs e)
        {
            query = "insert into products (pname,category,price) values ('"+txtPname.Text+"','"+txtCategory.Text+"',"+txtPrice.Text+")";
            fn.setData(query);
            clearAll();
        }

        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtPname.Clear();
            txtPrice.Clear();
        }
    }
}
