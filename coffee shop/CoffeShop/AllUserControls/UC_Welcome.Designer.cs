namespace CoffeShop.AllUserControls
{
    partial class UC_Welcome
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
            this.drink_coffee = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.drink_coffee)).BeginInit();
            this.SuspendLayout();
            // 
            // drink_coffee
            // 
            this.drink_coffee.Image = global::CoffeShop.Properties.Resources.fd;
            this.drink_coffee.Location = new System.Drawing.Point(53, 17);
            this.drink_coffee.Name = "drink_coffee";
            this.drink_coffee.Size = new System.Drawing.Size(341, 325);
            this.drink_coffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.drink_coffee.TabIndex = 1;
            this.drink_coffee.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.drink_coffee;
            // 
            // UC_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.drink_coffee);
            this.Name = "UC_Welcome";
            this.Size = new System.Drawing.Size(456, 364);
            ((System.ComponentModel.ISupportInitialize)(this.drink_coffee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drink_coffee;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
