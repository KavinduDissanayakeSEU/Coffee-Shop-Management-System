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
    public partial class UC_RemoveProducts : UserControl
    {
        function fn = new function();
        String query;

        public UC_RemoveProducts()
        {
            InitializeComponent();
        }

        private void availableList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            query = "select * from products";
            DataSet ds = fn.getData(query);
            availableList.DataSource = ds.Tables[0];
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            query = "select * from products where pname like '"+SearchTxt.Text+"%'";
            DataSet ds = fn.getData(query);
            availableList.DataSource = ds.Tables[0];
        }

        private void availableList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete product?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(availableList.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from products where pid =" + id + "";
                fn.setData(query);
                loadData();
            }

        }

        private void UC_RemoveProducts_Enter(object sender, EventArgs e)
        {
            
        }

        private void UC_RemoveProducts_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
