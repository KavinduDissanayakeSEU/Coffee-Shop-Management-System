namespace CoffeShop.AllUserControls
{
    partial class UC_RemoveProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SearchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.AvailableProducts = new System.Windows.Forms.Label();
            this.availableList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.choosetxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.availableList)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
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
            this.SearchTxt.Location = new System.Drawing.Point(425, 7);
            this.SearchTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.PasswordChar = '\0';
            this.SearchTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.SearchTxt.PlaceholderText = "Search by product name...";
            this.SearchTxt.SelectedText = "";
            this.SearchTxt.ShadowDecoration.Parent = this.SearchTxt;
            this.SearchTxt.Size = new System.Drawing.Size(147, 21);
            this.SearchTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SearchTxt.TabIndex = 7;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // AvailableProducts
            // 
            this.AvailableProducts.AutoSize = true;
            this.AvailableProducts.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableProducts.ForeColor = System.Drawing.Color.White;
            this.AvailableProducts.Location = new System.Drawing.Point(13, 12);
            this.AvailableProducts.Name = "AvailableProducts";
            this.AvailableProducts.Size = new System.Drawing.Size(127, 16);
            this.AvailableProducts.TabIndex = 8;
            this.AvailableProducts.Text = "Available Products";
            // 
            // availableList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.availableList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.availableList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.availableList.BackgroundColor = System.Drawing.Color.White;
            this.availableList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.availableList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.availableList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.availableList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.availableList.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.availableList.DefaultCellStyle = dataGridViewCellStyle3;
            this.availableList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.availableList.EnableHeadersVisualStyles = false;
            this.availableList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.availableList.Location = new System.Drawing.Point(14, 36);
            this.availableList.Name = "availableList";
            this.availableList.RowHeadersVisible = false;
            this.availableList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availableList.Size = new System.Drawing.Size(558, 286);
            this.availableList.TabIndex = 24;
            this.availableList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.availableList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.availableList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.availableList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.availableList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.availableList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.availableList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.availableList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.availableList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.availableList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.availableList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.availableList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.availableList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.availableList.ThemeStyle.HeaderStyle.Height = 4;
            this.availableList.ThemeStyle.ReadOnly = false;
            this.availableList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.availableList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.availableList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.availableList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.availableList.ThemeStyle.RowsStyle.Height = 22;
            this.availableList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.availableList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.availableList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.availableList_CellClick);
            this.availableList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.availableList_CellContentClick);
            // 
            // choosetxt
            // 
            this.choosetxt.AutoSize = true;
            this.choosetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.choosetxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosetxt.ForeColor = System.Drawing.Color.White;
            this.choosetxt.Location = new System.Drawing.Point(13, 333);
            this.choosetxt.Name = "choosetxt";
            this.choosetxt.Size = new System.Drawing.Size(171, 16);
            this.choosetxt.TabIndex = 25;
            this.choosetxt.Text = "* Click on product to remove";
            // 
            // UC_RemoveProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.choosetxt);
            this.Controls.Add(this.availableList);
            this.Controls.Add(this.AvailableProducts);
            this.Controls.Add(this.SearchTxt);
            this.Name = "UC_RemoveProducts";
            this.Size = new System.Drawing.Size(588, 400);
            this.Load += new System.EventHandler(this.UC_RemoveProducts_Load);
            this.Enter += new System.EventHandler(this.UC_RemoveProducts_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.availableList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2TextBox SearchTxt;
        private System.Windows.Forms.Label AvailableProducts;
        private Guna.UI2.WinForms.Guna2DataGridView availableList;
        private System.Windows.Forms.Label choosetxt;
    }
}
