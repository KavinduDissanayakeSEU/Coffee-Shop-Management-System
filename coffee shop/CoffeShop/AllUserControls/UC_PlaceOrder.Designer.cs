namespace CoffeShop.AllUserControls
{
    partial class UC_PlaceOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Place_orderTxt = new System.Windows.Forms.Label();
            this.categorybox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SearchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addcartpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.quantityUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.totalTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.priceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnametxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.addtocartBtn = new Guna.UI2.WinForms.Guna2Button();
            this.totaltxt = new System.Windows.Forms.Label();
            this.Quantitytxt = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.Label();
            this.pnametxt = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.YourCartTxt = new System.Windows.Forms.Label();
            this.Cart = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removebtn = new Guna.UI2.WinForms.Guna2Button();
            this.billBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gTotalTxt = new System.Windows.Forms.Label();
            this.gtotaltxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.addcartpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cart)).BeginInit();
            this.SuspendLayout();
            // 
            // Place_orderTxt
            // 
            this.Place_orderTxt.AutoSize = true;
            this.Place_orderTxt.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Place_orderTxt.ForeColor = System.Drawing.Color.White;
            this.Place_orderTxt.Location = new System.Drawing.Point(12, 8);
            this.Place_orderTxt.Name = "Place_orderTxt";
            this.Place_orderTxt.Size = new System.Drawing.Size(56, 16);
            this.Place_orderTxt.TabIndex = 1;
            this.Place_orderTxt.Text = "Category";
            // 
            // categorybox
            // 
            this.categorybox.BackColor = System.Drawing.Color.Transparent;
            this.categorybox.BorderColor = System.Drawing.Color.White;
            this.categorybox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categorybox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorybox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.categorybox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorybox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorybox.FocusedState.Parent = this.categorybox;
            this.categorybox.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.categorybox.ForeColor = System.Drawing.Color.White;
            this.categorybox.HoverState.Parent = this.categorybox;
            this.categorybox.ItemHeight = 30;
            this.categorybox.Items.AddRange(new object[] {
            "Coffee",
            "Soft Drinks",
            "Juices",
            "Pastries"});
            this.categorybox.ItemsAppearance.Parent = this.categorybox;
            this.categorybox.Location = new System.Drawing.Point(15, 27);
            this.categorybox.Name = "categorybox";
            this.categorybox.ShadowDecoration.Parent = this.categorybox;
            this.categorybox.Size = new System.Drawing.Size(147, 36);
            this.categorybox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.categorybox.TabIndex = 2;
            this.categorybox.SelectedIndexChanged += new System.EventHandler(this.categorybox_SelectedIndexChanged);
            // 
            // SearchTxt
            // 
            this.SearchTxt.BorderColor = System.Drawing.Color.White;
            this.SearchTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTxt.DefaultText = "";
            this.SearchTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTxt.DisabledState.Parent = this.SearchTxt;
            this.SearchTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SearchTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTxt.FocusedState.Parent = this.SearchTxt;
            this.SearchTxt.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.SearchTxt.ForeColor = System.Drawing.Color.White;
            this.SearchTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTxt.HoverState.Parent = this.SearchTxt;
            this.SearchTxt.Location = new System.Drawing.Point(15, 67);
            this.SearchTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.PasswordChar = '\0';
            this.SearchTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.SearchTxt.PlaceholderText = "Search Here";
            this.SearchTxt.SelectedText = "";
            this.SearchTxt.ShadowDecoration.Parent = this.SearchTxt;
            this.SearchTxt.Size = new System.Drawing.Size(147, 38);
            this.SearchTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SearchTxt.TabIndex = 3;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(15, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 276);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // addcartpanel
            // 
            this.addcartpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.addcartpanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.addcartpanel.BorderRadius = 18;
            this.addcartpanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.addcartpanel.Controls.Add(this.quantityUpDown1);
            this.addcartpanel.Controls.Add(this.totalTextBox);
            this.addcartpanel.Controls.Add(this.priceTextBox);
            this.addcartpanel.Controls.Add(this.pnametxtbox);
            this.addcartpanel.Controls.Add(this.addtocartBtn);
            this.addcartpanel.Controls.Add(this.totaltxt);
            this.addcartpanel.Controls.Add(this.Quantitytxt);
            this.addcartpanel.Controls.Add(this.priceTxt);
            this.addcartpanel.Controls.Add(this.pnametxt);
            this.addcartpanel.Location = new System.Drawing.Point(181, 8);
            this.addcartpanel.Name = "addcartpanel";
            this.addcartpanel.ShadowDecoration.Parent = this.addcartpanel;
            this.addcartpanel.Size = new System.Drawing.Size(393, 155);
            this.addcartpanel.TabIndex = 11;
            // 
            // quantityUpDown1
            // 
            this.quantityUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.quantityUpDown1.BorderColor = System.Drawing.Color.White;
            this.quantityUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityUpDown1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantityUpDown1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantityUpDown1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityUpDown1.DisabledState.Parent = this.quantityUpDown1;
            this.quantityUpDown1.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.quantityUpDown1.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.quantityUpDown1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.quantityUpDown1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityUpDown1.FocusedState.Parent = this.quantityUpDown1;
            this.quantityUpDown1.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.quantityUpDown1.ForeColor = System.Drawing.Color.White;
            this.quantityUpDown1.Location = new System.Drawing.Point(162, 50);
            this.quantityUpDown1.Name = "quantityUpDown1";
            this.quantityUpDown1.ShadowDecoration.Parent = this.quantityUpDown1;
            this.quantityUpDown1.Size = new System.Drawing.Size(162, 30);
            this.quantityUpDown1.TabIndex = 22;
            this.quantityUpDown1.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.quantityUpDown1.UpDownButtonForeColor = System.Drawing.Color.White;
            this.quantityUpDown1.UseTransparentBackground = true;
            this.quantityUpDown1.ValueChanged += new System.EventHandler(this.quantityUpDown1_ValueChanged);
            // 
            // totalTextBox
            // 
            this.totalTextBox.BorderColor = System.Drawing.Color.White;
            this.totalTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalTextBox.DefaultText = "";
            this.totalTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalTextBox.DisabledState.Parent = this.totalTextBox;
            this.totalTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.totalTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalTextBox.FocusedState.Parent = this.totalTextBox;
            this.totalTextBox.ForeColor = System.Drawing.Color.White;
            this.totalTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalTextBox.HoverState.Parent = this.totalTextBox;
            this.totalTextBox.Location = new System.Drawing.Point(162, 85);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.PasswordChar = '\0';
            this.totalTextBox.PlaceholderText = "";
            this.totalTextBox.SelectedText = "";
            this.totalTextBox.ShadowDecoration.Parent = this.totalTextBox;
            this.totalTextBox.Size = new System.Drawing.Size(162, 20);
            this.totalTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.totalTextBox.TabIndex = 21;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BorderColor = System.Drawing.Color.White;
            this.priceTextBox.BorderThickness = 0;
            this.priceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTextBox.DefaultText = "";
            this.priceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextBox.DisabledState.Parent = this.priceTextBox;
            this.priceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.priceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTextBox.FocusedState.Parent = this.priceTextBox;
            this.priceTextBox.ForeColor = System.Drawing.Color.White;
            this.priceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTextBox.HoverState.Parent = this.priceTextBox;
            this.priceTextBox.Location = new System.Drawing.Point(162, 30);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.PasswordChar = '\0';
            this.priceTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.priceTextBox.PlaceholderText = "";
            this.priceTextBox.SelectedText = "";
            this.priceTextBox.ShadowDecoration.Parent = this.priceTextBox;
            this.priceTextBox.Size = new System.Drawing.Size(162, 20);
            this.priceTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.priceTextBox.TabIndex = 20;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // pnametxtbox
            // 
            this.pnametxtbox.BorderColor = System.Drawing.Color.White;
            this.pnametxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnametxtbox.DefaultText = "";
            this.pnametxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pnametxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pnametxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pnametxtbox.DisabledState.Parent = this.pnametxtbox;
            this.pnametxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pnametxtbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pnametxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pnametxtbox.FocusedState.Parent = this.pnametxtbox;
            this.pnametxtbox.ForeColor = System.Drawing.Color.White;
            this.pnametxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pnametxtbox.HoverState.Parent = this.pnametxtbox;
            this.pnametxtbox.Location = new System.Drawing.Point(162, 6);
            this.pnametxtbox.Name = "pnametxtbox";
            this.pnametxtbox.PasswordChar = '\0';
            this.pnametxtbox.PlaceholderText = "";
            this.pnametxtbox.SelectedText = "";
            this.pnametxtbox.ShadowDecoration.Parent = this.pnametxtbox;
            this.pnametxtbox.Size = new System.Drawing.Size(162, 20);
            this.pnametxtbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.pnametxtbox.TabIndex = 19;
            // 
            // addtocartBtn
            // 
            this.addtocartBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.addtocartBtn.CheckedState.Parent = this.addtocartBtn;
            this.addtocartBtn.CustomImages.Parent = this.addtocartBtn;
            this.addtocartBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.addtocartBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtocartBtn.ForeColor = System.Drawing.Color.White;
            this.addtocartBtn.HoverState.Parent = this.addtocartBtn;
            this.addtocartBtn.Location = new System.Drawing.Point(142, 115);
            this.addtocartBtn.Name = "addtocartBtn";
            this.addtocartBtn.ShadowDecoration.Parent = this.addtocartBtn;
            this.addtocartBtn.Size = new System.Drawing.Size(110, 35);
            this.addtocartBtn.TabIndex = 17;
            this.addtocartBtn.Text = "Add to cart";
            this.addtocartBtn.Click += new System.EventHandler(this.addtocartBtn_Click);
            // 
            // totaltxt
            // 
            this.totaltxt.AutoSize = true;
            this.totaltxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltxt.ForeColor = System.Drawing.Color.White;
            this.totaltxt.Location = new System.Drawing.Point(65, 92);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(39, 16);
            this.totaltxt.TabIndex = 16;
            this.totaltxt.Text = "Total";
            // 
            // Quantitytxt
            // 
            this.Quantitytxt.AutoSize = true;
            this.Quantitytxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantitytxt.ForeColor = System.Drawing.Color.White;
            this.Quantitytxt.Location = new System.Drawing.Point(65, 65);
            this.Quantitytxt.Name = "Quantitytxt";
            this.Quantitytxt.Size = new System.Drawing.Size(61, 16);
            this.Quantitytxt.TabIndex = 15;
            this.Quantitytxt.Text = "Quantity";
            // 
            // priceTxt
            // 
            this.priceTxt.AutoSize = true;
            this.priceTxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.ForeColor = System.Drawing.Color.White;
            this.priceTxt.Location = new System.Drawing.Point(65, 39);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(41, 16);
            this.priceTxt.TabIndex = 14;
            this.priceTxt.Text = "Price";
            // 
            // pnametxt
            // 
            this.pnametxt.AutoSize = true;
            this.pnametxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnametxt.ForeColor = System.Drawing.Color.White;
            this.pnametxt.Location = new System.Drawing.Point(65, 13);
            this.pnametxt.Name = "pnametxt";
            this.pnametxt.Size = new System.Drawing.Size(98, 16);
            this.pnametxt.TabIndex = 13;
            this.pnametxt.Text = "Product Name";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.addcartpanel;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.addtocartBtn;
            // 
            // YourCartTxt
            // 
            this.YourCartTxt.AutoSize = true;
            this.YourCartTxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourCartTxt.ForeColor = System.Drawing.Color.White;
            this.YourCartTxt.Location = new System.Drawing.Point(178, 165);
            this.YourCartTxt.Name = "YourCartTxt";
            this.YourCartTxt.Size = new System.Drawing.Size(66, 16);
            this.YourCartTxt.TabIndex = 17;
            this.YourCartTxt.Text = "Your Cart";
            // 
            // Cart
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.Cart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.Cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Cart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Cart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Cart.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.Cart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Cart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.Cart.ColumnHeadersHeight = 21;
            this.Cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Cart.DefaultCellStyle = dataGridViewCellStyle19;
            this.Cart.EnableHeadersVisualStyles = false;
            this.Cart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Cart.Location = new System.Drawing.Point(181, 184);
            this.Cart.Name = "Cart";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Cart.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.Cart.RowHeadersVisible = false;
            this.Cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Cart.Size = new System.Drawing.Size(393, 122);
            this.Cart.TabIndex = 18;
            this.Cart.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.Cart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Cart.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Cart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Cart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Cart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Cart.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Cart.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Cart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Cart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Cart.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Cart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Cart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Cart.ThemeStyle.HeaderStyle.Height = 21;
            this.Cart.ThemeStyle.ReadOnly = false;
            this.Cart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Cart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Cart.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Cart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Cart.ThemeStyle.RowsStyle.Height = 22;
            this.Cart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Cart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Cart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cart_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 141.0674F;
            this.Column1.HeaderText = "Product Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 101.5228F;
            this.Column2.HeaderText = "Unit Price";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 81.45461F;
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 75.95518F;
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // removebtn
            // 
            this.removebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.removebtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.removebtn.CheckedState.Parent = this.removebtn;
            this.removebtn.CustomImages.Parent = this.removebtn;
            this.removebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.removebtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebtn.ForeColor = System.Drawing.Color.White;
            this.removebtn.HoverState.Parent = this.removebtn;
            this.removebtn.Location = new System.Drawing.Point(187, 355);
            this.removebtn.Name = "removebtn";
            this.removebtn.ShadowDecoration.Parent = this.removebtn;
            this.removebtn.Size = new System.Drawing.Size(110, 35);
            this.removebtn.TabIndex = 23;
            this.removebtn.Text = "Remove";
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // billBtn
            // 
            this.billBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.billBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.billBtn.CheckedState.Parent = this.billBtn;
            this.billBtn.CustomImages.Parent = this.billBtn;
            this.billBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.billBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billBtn.ForeColor = System.Drawing.Color.White;
            this.billBtn.HoverState.Parent = this.billBtn;
            this.billBtn.Location = new System.Drawing.Point(464, 354);
            this.billBtn.Name = "billBtn";
            this.billBtn.ShadowDecoration.Parent = this.billBtn;
            this.billBtn.Size = new System.Drawing.Size(110, 35);
            this.billBtn.TabIndex = 24;
            this.billBtn.Text = "Get the bill";
            this.billBtn.Click += new System.EventHandler(this.billBtn_Click);
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.removebtn;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.billBtn;
            // 
            // gTotalTxt
            // 
            this.gTotalTxt.AutoSize = true;
            this.gTotalTxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTotalTxt.ForeColor = System.Drawing.Color.White;
            this.gTotalTxt.Location = new System.Drawing.Point(397, 323);
            this.gTotalTxt.Name = "gTotalTxt";
            this.gTotalTxt.Size = new System.Drawing.Size(90, 16);
            this.gTotalTxt.TabIndex = 25;
            this.gTotalTxt.Text = "Grand Total :";
            // 
            // gtotaltxtbox
            // 
            this.gtotaltxtbox.BorderColor = System.Drawing.Color.White;
            this.gtotaltxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtotaltxtbox.DefaultText = "";
            this.gtotaltxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtotaltxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtotaltxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtotaltxtbox.DisabledState.Parent = this.gtotaltxtbox;
            this.gtotaltxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtotaltxtbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gtotaltxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtotaltxtbox.FocusedState.Parent = this.gtotaltxtbox;
            this.gtotaltxtbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.gtotaltxtbox.ForeColor = System.Drawing.Color.White;
            this.gtotaltxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtotaltxtbox.HoverState.Parent = this.gtotaltxtbox;
            this.gtotaltxtbox.Location = new System.Drawing.Point(490, 313);
            this.gtotaltxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtotaltxtbox.Name = "gtotaltxtbox";
            this.gtotaltxtbox.PasswordChar = '\0';
            this.gtotaltxtbox.PlaceholderForeColor = System.Drawing.Color.White;
            this.gtotaltxtbox.PlaceholderText = "";
            this.gtotaltxtbox.SelectedText = "";
            this.gtotaltxtbox.ShadowDecoration.Parent = this.gtotaltxtbox;
            this.gtotaltxtbox.Size = new System.Drawing.Size(76, 26);
            this.gtotaltxtbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.gtotaltxtbox.TabIndex = 26;
            // 
            // UC_PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.gtotaltxtbox);
            this.Controls.Add(this.gTotalTxt);
            this.Controls.Add(this.billBtn);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.Cart);
            this.Controls.Add(this.YourCartTxt);
            this.Controls.Add(this.addcartpanel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.categorybox);
            this.Controls.Add(this.Place_orderTxt);
            this.Name = "UC_PlaceOrder";
            this.Size = new System.Drawing.Size(588, 400);
            this.addcartpanel.ResumeLayout(false);
            this.addcartpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2TextBox SearchTxt;
        private Guna.UI2.WinForms.Guna2ComboBox categorybox;
        private System.Windows.Forms.Label Place_orderTxt;
        private Guna.UI2.WinForms.Guna2Panel addcartpanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button addtocartBtn;
        private System.Windows.Forms.Label totaltxt;
        private System.Windows.Forms.Label Quantitytxt;
        private System.Windows.Forms.Label priceTxt;
        private System.Windows.Forms.Label pnametxt;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label YourCartTxt;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2NumericUpDown quantityUpDown1;
        private Guna.UI2.WinForms.Guna2TextBox totalTextBox;
        private Guna.UI2.WinForms.Guna2TextBox priceTextBox;
        private Guna.UI2.WinForms.Guna2TextBox pnametxtbox;
        private System.Windows.Forms.Label gTotalTxt;
        private Guna.UI2.WinForms.Guna2Button billBtn;
        private Guna.UI2.WinForms.Guna2Button removebtn;
        private Guna.UI2.WinForms.Guna2DataGridView Cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2TextBox gtotaltxtbox;
    }
}
