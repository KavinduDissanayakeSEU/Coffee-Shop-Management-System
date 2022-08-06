using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace CoffeShop.AllUserControls
{
    public partial class UC_PlaceOrder : UserControl
    {
        function fn = new function();
        String query;

        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        private void categorybox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = categorybox.Text;
            query = "select pname from products where category = '" + category + "'";
            showItemList(query);
            
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {        
            String category = categorybox.Text;
            query = "select pname from products where category = '" + category + "' and pname like '"+ SearchTxt.Text + "%'";
            showItemList(query);
        }

        private void showItemList(String query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantityUpDown1.ResetText();
            totalTextBox.Clear();

            String text = listBox1.GetItemText(listBox1.SelectedItem);
            pnametxtbox.Text = text;

            query = "select price from products where pname = '" + text + "'";
            DataSet ds = fn.getData(query);

            try
            {
                priceTextBox.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {

            }
        }

        private void quantityUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(quantityUpDown1.Value.ToString());
            Int64 price = Int64.Parse(priceTextBox.Text);
            totalTextBox.Text = (quan * price).ToString();

        }

        


        int amount;
        private void Cart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(Cart.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {

            }
        }

        protected int n, gtotal = 0;

        private void addtocartBtn_Click(object sender, EventArgs e)
        {
            if(totalTextBox.Text != "0" && totalTextBox.Text != "")
            {
                n = Cart.Rows.Add();
                Cart.Rows[n].Cells[0].Value = pnametxtbox.Text;
                Cart.Rows[n].Cells[1].Value = priceTextBox.Text;
                Cart.Rows[n].Cells[2].Value = quantityUpDown1.Value;
                Cart.Rows[n].Cells[3].Value = totalTextBox.Text;

                gtotal += int.Parse(totalTextBox.Text);
                gtotaltxtbox.Text = "Rs. " + gtotal;


                quantityUpDown1.ResetText();
                totalTextBox.Clear();
                priceTextBox.Clear();
                pnametxtbox.Clear();


            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(Cart);


            gtotal = 0;
            Cart.Rows.Clear();
            gtotaltxtbox.Text = "Rs. " + gtotal;
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Cart.Rows.RemoveAt(this.Cart.SelectedRows[0].Index);
            }
            catch { }

            gtotal -= amount;
            gtotaltxtbox.Text = "Rs. " + gtotal;



        }
    }
}
