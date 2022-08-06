namespace CoffeShop
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UloginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AdminLog = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CustomerTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AdminLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(238, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(239, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "ENTER YOUR NAME HERE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forte", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(584, 52);
            this.label3.TabIndex = 5;
            this.label3.Text = "JAVA LAVA COFFEE CAFE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // UloginBtn
            // 
            this.UloginBtn.BorderRadius = 18;
            this.UloginBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.UloginBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.UloginBtn.CheckedState.Parent = this.UloginBtn;
            this.UloginBtn.CustomImages.Parent = this.UloginBtn;
            this.UloginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.UloginBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UloginBtn.ForeColor = System.Drawing.Color.White;
            this.UloginBtn.HoverState.Parent = this.UloginBtn;
            this.UloginBtn.Location = new System.Drawing.Point(343, 426);
            this.UloginBtn.Name = "UloginBtn";
            this.UloginBtn.ShadowDecoration.Parent = this.UloginBtn;
            this.UloginBtn.Size = new System.Drawing.Size(117, 35);
            this.UloginBtn.TabIndex = 6;
            this.UloginBtn.Text = "Login";
            this.UloginBtn.Click += new System.EventHandler(this.UloginBtn_Click);
            // 
            // AdminLog
            // 
            this.AdminLog.Image = ((System.Drawing.Image)(resources.GetObject("AdminLog.Image")));
            this.AdminLog.Location = new System.Drawing.Point(737, 24);
            this.AdminLog.Name = "AdminLog";
            this.AdminLog.Size = new System.Drawing.Size(34, 39);
            this.AdminLog.TabIndex = 7;
            this.AdminLog.TabStop = false;
            this.AdminLog.Click += new System.EventHandler(this.AdminLog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 217);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerTxt
            // 
            this.CustomerTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerTxt.DefaultText = "";
            this.CustomerTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerTxt.DisabledState.Parent = this.CustomerTxt;
            this.CustomerTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerTxt.FocusedState.Parent = this.CustomerTxt;
            this.CustomerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CustomerTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CustomerTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerTxt.HoverState.Parent = this.CustomerTxt;
            this.CustomerTxt.Location = new System.Drawing.Point(296, 374);
            this.CustomerTxt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.CustomerTxt.Name = "CustomerTxt";
            this.CustomerTxt.PasswordChar = '\0';
            this.CustomerTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CustomerTxt.PlaceholderText = "Enter Name";
            this.CustomerTxt.SelectedText = "";
            this.CustomerTxt.ShadowDecoration.Parent = this.CustomerTxt;
            this.CustomerTxt.Size = new System.Drawing.Size(212, 42);
            this.CustomerTxt.TabIndex = 9;
            this.CustomerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.CustomerTxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AdminLog);
            this.Controls.Add(this.UloginBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AdminLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button UloginBtn;
        private System.Windows.Forms.PictureBox AdminLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox CustomerTxt;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}

