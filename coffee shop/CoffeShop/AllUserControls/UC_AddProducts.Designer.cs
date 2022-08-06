namespace CoffeShop.AllUserControls
{
    partial class UC_AddProducts
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.newProductPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NewProduct = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Pname = new System.Windows.Forms.Label();
            this.txtCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.addProductbtn = new Guna.UI2.WinForms.Guna2Button();
            this.availabelPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.AvailableProduct = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.newProductPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.newProductPanel;
            // 
            // newProductPanel
            // 
            this.newProductPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.newProductPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.newProductPanel.BorderRadius = 18;
            this.newProductPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.newProductPanel.Controls.Add(this.addProductbtn);
            this.newProductPanel.Controls.Add(this.txtPrice);
            this.newProductPanel.Controls.Add(this.txtPname);
            this.newProductPanel.Controls.Add(this.txtCategory);
            this.newProductPanel.Controls.Add(this.Pname);
            this.newProductPanel.Controls.Add(this.Price);
            this.newProductPanel.Controls.Add(this.Category);
            this.newProductPanel.Controls.Add(this.NewProduct);
            this.newProductPanel.Controls.Add(this.label2);
            this.newProductPanel.Controls.Add(this.label1);
            this.newProductPanel.Location = new System.Drawing.Point(11, 11);
            this.newProductPanel.Name = "newProductPanel";
            this.newProductPanel.ShadowDecoration.Parent = this.newProductPanel;
            this.newProductPanel.Size = new System.Drawing.Size(564, 175);
            this.newProductPanel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // NewProduct
            // 
            this.NewProduct.AutoSize = true;
            this.NewProduct.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProduct.Location = new System.Drawing.Point(15, 13);
            this.NewProduct.Name = "NewProduct";
            this.NewProduct.Size = new System.Drawing.Size(85, 16);
            this.NewProduct.TabIndex = 1;
            this.NewProduct.Text = "NewProduct";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(162, 34);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(60, 16);
            this.Category.TabIndex = 2;
            this.Category.Text = "Category";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(162, 98);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(38, 16);
            this.Price.TabIndex = 3;
            this.Price.Text = "Price";
            // 
            // Pname
            // 
            this.Pname.AutoSize = true;
            this.Pname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pname.Location = new System.Drawing.Point(162, 68);
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(57, 16);
            this.Pname.TabIndex = 4;
            this.Pname.Text = "P. Name";
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.Transparent;
            this.txtCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategory.FocusedState.Parent = this.txtCategory;
            this.txtCategory.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtCategory.ForeColor = System.Drawing.Color.White;
            this.txtCategory.HoverState.Parent = this.txtCategory;
            this.txtCategory.ItemHeight = 30;
            this.txtCategory.Items.AddRange(new object[] {
            "Coffee",
            "Soft Drinks",
            "Juices",
            "Pastries"});
            this.txtCategory.ItemsAppearance.Parent = this.txtCategory;
            this.txtCategory.Location = new System.Drawing.Point(246, 14);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ShadowDecoration.Parent = this.txtCategory;
            this.txtCategory.Size = new System.Drawing.Size(140, 36);
            this.txtCategory.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCategory.TabIndex = 5;
            // 
            // txtPname
            // 
            this.txtPname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPname.DefaultText = "";
            this.txtPname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPname.DisabledState.Parent = this.txtPname;
            this.txtPname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtPname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPname.FocusedState.Parent = this.txtPname;
            this.txtPname.ForeColor = System.Drawing.Color.White;
            this.txtPname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPname.HoverState.Parent = this.txtPname;
            this.txtPname.Location = new System.Drawing.Point(246, 60);
            this.txtPname.Name = "txtPname";
            this.txtPname.PasswordChar = '\0';
            this.txtPname.PlaceholderText = "";
            this.txtPname.SelectedText = "";
            this.txtPname.ShadowDecoration.Parent = this.txtPname;
            this.txtPname.Size = new System.Drawing.Size(140, 24);
            this.txtPname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPname.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.Location = new System.Drawing.Point(246, 90);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(140, 24);
            this.txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPrice.TabIndex = 7;
            // 
            // addProductbtn
            // 
            this.addProductbtn.CheckedState.Parent = this.addProductbtn;
            this.addProductbtn.CustomImages.Parent = this.addProductbtn;
            this.addProductbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.addProductbtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductbtn.ForeColor = System.Drawing.Color.White;
            this.addProductbtn.HoverState.Parent = this.addProductbtn;
            this.addProductbtn.Location = new System.Drawing.Point(214, 128);
            this.addProductbtn.Name = "addProductbtn";
            this.addProductbtn.ShadowDecoration.Parent = this.addProductbtn;
            this.addProductbtn.Size = new System.Drawing.Size(117, 35);
            this.addProductbtn.TabIndex = 8;
            this.addProductbtn.Text = "Add Product";
            this.addProductbtn.Click += new System.EventHandler(this.addProductbtn_Click);
            // 
            // availabelPanel
            // 
            this.availabelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.availabelPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.availabelPanel.BorderRadius = 18;
            this.availabelPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.availabelPanel.Location = new System.Drawing.Point(14, 222);
            this.availabelPanel.Name = "availabelPanel";
            this.availabelPanel.ShadowDecoration.Parent = this.availabelPanel;
            this.availabelPanel.Size = new System.Drawing.Size(561, 164);
            this.availabelPanel.TabIndex = 10;
            // 
            // AvailableProduct
            // 
            this.AvailableProduct.AutoSize = true;
            this.AvailableProduct.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableProduct.Location = new System.Drawing.Point(26, 197);
            this.AvailableProduct.Name = "AvailableProduct";
            this.AvailableProduct.Size = new System.Drawing.Size(121, 16);
            this.AvailableProduct.TabIndex = 9;
            this.AvailableProduct.Text = "Available Product";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.addProductbtn;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.availabelPanel;
            // 
            // UC_AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.AvailableProduct);
            this.Controls.Add(this.availabelPanel);
            this.Controls.Add(this.newProductPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UC_AddProducts";
            this.Size = new System.Drawing.Size(588, 400);
            this.newProductPanel.ResumeLayout(false);
            this.newProductPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Panel newProductPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel availabelPanel;
        private Guna.UI2.WinForms.Guna2Button addProductbtn;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtPname;
        private Guna.UI2.WinForms.Guna2ComboBox txtCategory;
        private System.Windows.Forms.Label Pname;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label NewProduct;
        private System.Windows.Forms.Label AvailableProduct;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
    }
}
