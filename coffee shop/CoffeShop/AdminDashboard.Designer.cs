namespace CoffeShop
{
    partial class AdminDashboard
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnLogout = new System.Windows.Forms.LinkLabel();
            this.BtnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.BtnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_UpdateProducts1 = new CoffeShop.AllUserControls.UC_UpdateProducts();
            this.uC_AddProducts1 = new CoffeShop.AllUserControls.UC_AddProducts();
            this.uC_Welcome1 = new CoffeShop.AllUserControls.UC_Welcome();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.btnClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_RemoveProducts1 = new CoffeShop.AllUserControls.UC_RemoveProducts();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.BtnLogout);
            this.guna2Panel1.Controls.Add(this.BtnRemove);
            this.guna2Panel1.Controls.Add(this.BtnUpdate);
            this.guna2Panel1.Controls.Add(this.BtnAdd);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 54);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(241, 400);
            this.guna2Panel1.TabIndex = 0;
            // 
            // BtnLogout
            // 
            this.BtnLogout.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.BtnLogout, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BtnLogout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.LinkColor = System.Drawing.Color.White;
            this.BtnLogout.Location = new System.Drawing.Point(38, 381);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(52, 16);
            this.BtnLogout.TabIndex = 3;
            this.BtnLogout.TabStop = true;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnLogout_LinkClicked);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BorderColor = System.Drawing.Color.Transparent;
            this.BtnRemove.BorderRadius = 10;
            this.BtnRemove.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.BtnRemove.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnRemove.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnRemove.CheckedState.ForeColor = System.Drawing.Color.RosyBrown;
            this.BtnRemove.CheckedState.Parent = this.BtnRemove;
            this.BtnRemove.CustomImages.Parent = this.BtnRemove;
            this.guna2Transition1.SetDecoration(this.BtnRemove, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BtnRemove.FillColor = System.Drawing.Color.RosyBrown;
            this.BtnRemove.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.ForeColor = System.Drawing.Color.White;
            this.BtnRemove.HoverState.Parent = this.BtnRemove;
            this.BtnRemove.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnRemove.Location = new System.Drawing.Point(12, 81);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.ShadowDecoration.Parent = this.BtnRemove;
            this.BtnRemove.Size = new System.Drawing.Size(170, 25);
            this.BtnRemove.TabIndex = 9;
            this.BtnRemove.Text = "Remove Products";
            this.BtnRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BorderColor = System.Drawing.Color.Transparent;
            this.BtnUpdate.BorderRadius = 10;
            this.BtnUpdate.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.BtnUpdate.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnUpdate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnUpdate.CheckedState.ForeColor = System.Drawing.Color.RosyBrown;
            this.BtnUpdate.CheckedState.Parent = this.BtnUpdate;
            this.BtnUpdate.CustomImages.Parent = this.BtnUpdate;
            this.guna2Transition1.SetDecoration(this.BtnUpdate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BtnUpdate.FillColor = System.Drawing.Color.RosyBrown;
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.HoverState.Parent = this.BtnUpdate;
            this.BtnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnUpdate.Location = new System.Drawing.Point(12, 41);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.ShadowDecoration.Parent = this.BtnUpdate;
            this.BtnUpdate.Size = new System.Drawing.Size(170, 25);
            this.BtnUpdate.TabIndex = 8;
            this.BtnUpdate.Text = "Update Products";
            this.BtnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnAdd.BorderColor = System.Drawing.Color.Transparent;
            this.BtnAdd.BorderRadius = 10;
            this.BtnAdd.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.BtnAdd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnAdd.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAdd.CheckedState.ForeColor = System.Drawing.Color.RosyBrown;
            this.BtnAdd.CheckedState.Parent = this.BtnAdd;
            this.BtnAdd.CustomImages.Parent = this.BtnAdd;
            this.guna2Transition1.SetDecoration(this.BtnAdd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BtnAdd.FillColor = System.Drawing.Color.RosyBrown;
            this.BtnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.HoverState.Parent = this.BtnAdd;
            this.BtnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAdd.Location = new System.Drawing.Point(12, 0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.ShadowDecoration.Parent = this.BtnAdd;
            this.BtnAdd.Size = new System.Drawing.Size(170, 25);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Add Products";
            this.BtnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2Panel2.BorderRadius = 18;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel2.Controls.Add(this.uC_RemoveProducts1);
            this.guna2Panel2.Controls.Add(this.uC_UpdateProducts1);
            this.guna2Panel2.Controls.Add(this.uC_AddProducts1);
            this.guna2Panel2.Controls.Add(this.uC_Welcome1);
            this.guna2Transition1.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel2.Location = new System.Drawing.Point(156, 51);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(588, 400);
            this.guna2Panel2.TabIndex = 1;
            // 
            // uC_UpdateProducts1
            // 
            this.uC_UpdateProducts1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2Transition1.SetDecoration(this.uC_UpdateProducts1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_UpdateProducts1.Location = new System.Drawing.Point(2, -1);
            this.uC_UpdateProducts1.Name = "uC_UpdateProducts1";
            this.uC_UpdateProducts1.Size = new System.Drawing.Size(588, 400);
            this.uC_UpdateProducts1.TabIndex = 2;
            // 
            // uC_AddProducts1
            // 
            this.uC_AddProducts1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2Transition1.SetDecoration(this.uC_AddProducts1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_AddProducts1.ForeColor = System.Drawing.Color.White;
            this.uC_AddProducts1.Location = new System.Drawing.Point(1, 2);
            this.uC_AddProducts1.Name = "uC_AddProducts1";
            this.uC_AddProducts1.Size = new System.Drawing.Size(588, 400);
            this.uC_AddProducts1.TabIndex = 1;
            this.uC_AddProducts1.Load += new System.EventHandler(this.uC_AddProducts1_Load);
            // 
            // uC_Welcome1
            // 
            this.uC_Welcome1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_Welcome1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Welcome1.Location = new System.Drawing.Point(66, 18);
            this.uC_Welcome1.Name = "uC_Welcome1";
            this.uC_Welcome1.Size = new System.Drawing.Size(456, 364);
            this.uC_Welcome1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.guna2Panel2;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2Panel3.BorderRadius = 18;
            this.guna2Panel3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Transition1.SetDecoration(this.guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel3.Location = new System.Drawing.Point(136, 54);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(117, 35);
            this.guna2Panel3.TabIndex = 2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.guna2Panel2;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // btnClose
            // 
            this.guna2Transition1.SetDecoration(this.btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(10, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(26, 26);
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.uC_Welcome1;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.guna2Panel2;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this.guna2Panel2;
            // 
            // uC_RemoveProducts1
            // 
            this.uC_RemoveProducts1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2Transition1.SetDecoration(this.uC_RemoveProducts1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_RemoveProducts1.Location = new System.Drawing.Point(0, 2);
            this.uC_RemoveProducts1.Name = "uC_RemoveProducts1";
            this.uC_RemoveProducts1.Size = new System.Drawing.Size(588, 400);
            this.uC_RemoveProducts1.TabIndex = 3;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel3);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button BtnRemove;
        private Guna.UI2.WinForms.Guna2Button BtnUpdate;
        private Guna.UI2.WinForms.Guna2Button BtnAdd;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.LinkLabel BtnLogout;
        private AllUserControls.UC_Welcome uC_Welcome1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AllUserControls.UC_AddProducts uC_AddProducts1;
        private Guna.UI2.WinForms.Guna2PictureBox btnClose;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private AllUserControls.UC_UpdateProducts uC_UpdateProducts1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private AllUserControls.UC_RemoveProducts uC_RemoveProducts1;
    }
}