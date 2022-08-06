namespace CoffeShop
{
    partial class AdminLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Admin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminLoginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AdminUsernametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.AdminPwdTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(348, 68);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(100, 101);
            this.guna2ImageButton1.TabIndex = 1;
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Admin.Location = new System.Drawing.Point(288, 155);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(236, 42);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Admin Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(214, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(217, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            // 
            // AdminLoginBtn
            // 
            this.AdminLoginBtn.BorderRadius = 18;
            this.AdminLoginBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.AdminLoginBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.AdminLoginBtn.CheckedState.Parent = this.AdminLoginBtn;
            this.AdminLoginBtn.CustomImages.Parent = this.AdminLoginBtn;
            this.AdminLoginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AdminLoginBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginBtn.ForeColor = System.Drawing.Color.White;
            this.AdminLoginBtn.HoverState.Parent = this.AdminLoginBtn;
            this.AdminLoginBtn.Location = new System.Drawing.Point(331, 324);
            this.AdminLoginBtn.Name = "AdminLoginBtn";
            this.AdminLoginBtn.ShadowDecoration.Parent = this.AdminLoginBtn;
            this.AdminLoginBtn.Size = new System.Drawing.Size(117, 35);
            this.AdminLoginBtn.TabIndex = 7;
            this.AdminLoginBtn.Text = "Login";
            this.AdminLoginBtn.Click += new System.EventHandler(this.AdminLoginBtn_Click);
            // 
            // AdminUsernametxt
            // 
            this.AdminUsernametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminUsernametxt.DefaultText = "";
            this.AdminUsernametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AdminUsernametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AdminUsernametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdminUsernametxt.DisabledState.Parent = this.AdminUsernametxt;
            this.AdminUsernametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdminUsernametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminUsernametxt.FocusedState.Parent = this.AdminUsernametxt;
            this.AdminUsernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.AdminUsernametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AdminUsernametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminUsernametxt.HoverState.Parent = this.AdminUsernametxt;
            this.AdminUsernametxt.Location = new System.Drawing.Point(348, 211);
            this.AdminUsernametxt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.AdminUsernametxt.Name = "AdminUsernametxt";
            this.AdminUsernametxt.PasswordChar = '\0';
            this.AdminUsernametxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AdminUsernametxt.PlaceholderText = "Enter Username";
            this.AdminUsernametxt.SelectedText = "";
            this.AdminUsernametxt.ShadowDecoration.Parent = this.AdminUsernametxt;
            this.AdminUsernametxt.Size = new System.Drawing.Size(210, 35);
            this.AdminUsernametxt.TabIndex = 10;
            this.AdminUsernametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdminUsernametxt.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // AdminPwdTxt
            // 
            this.AdminPwdTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminPwdTxt.DefaultText = "";
            this.AdminPwdTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AdminPwdTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AdminPwdTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdminPwdTxt.DisabledState.Parent = this.AdminPwdTxt;
            this.AdminPwdTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdminPwdTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminPwdTxt.FocusedState.Parent = this.AdminPwdTxt;
            this.AdminPwdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.AdminPwdTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AdminPwdTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminPwdTxt.HoverState.Parent = this.AdminPwdTxt;
            this.AdminPwdTxt.Location = new System.Drawing.Point(348, 260);
            this.AdminPwdTxt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.AdminPwdTxt.Name = "AdminPwdTxt";
            this.AdminPwdTxt.PasswordChar = '*';
            this.AdminPwdTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AdminPwdTxt.PlaceholderText = "Enter Password";
            this.AdminPwdTxt.SelectedText = "";
            this.AdminPwdTxt.ShadowDecoration.Parent = this.AdminPwdTxt;
            this.AdminPwdTxt.Size = new System.Drawing.Size(210, 35);
            this.AdminPwdTxt.TabIndex = 11;
            this.AdminPwdTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdminPwdTxt.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(26, 26);
            this.btnClose.TabIndex = 12;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.AdminPwdTxt);
            this.Controls.Add(this.AdminUsernametxt);
            this.Controls.Add(this.AdminLoginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.guna2ImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button AdminLoginBtn;
        private Guna.UI2.WinForms.Guna2TextBox AdminUsernametxt;
        private Guna.UI2.WinForms.Guna2TextBox AdminPwdTxt;
        private Guna.UI2.WinForms.Guna2PictureBox btnClose;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}