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
    public partial class UC_UpdateProducts : UserControl
    {
        function fn = new function();
        String query;

        public UC_UpdateProducts()
        {
            InitializeComponent();
        }

        private void UC_UpdateProducts_Load(object sender, EventArgs e)
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
            query = "select * from products where pname like '" + SearchTxt.Text + "%'";
            DataSet ds = fn.getData(query);
            availableList.DataSource = ds.Tables[0];
        }

        int id;
        private void availableList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(availableList.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = availableList.Rows[e.RowIndex].Cells[2].Value.ToString();
            String pname = availableList.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(availableList.Rows[e.RowIndex].Cells[3].Value.ToString());

            categoryboxtxt.Text = category;
            pnametxtbox.Text = pname;
            priceTextBox.Text = price.ToString();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            query = "update products set pname= '" + pnametxtbox.Text + "', category = '" + categoryboxtxt.Text + "',price = " + priceTextBox.Text + " where pid = " + id + "";
            fn.setData(query);
            loadData();

            pnametxtbox.Clear();
            categoryboxtxt.Clear();
            priceTextBox.Clear();

        }
    }
}

