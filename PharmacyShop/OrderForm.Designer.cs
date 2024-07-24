namespace PharmacyShop
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlside = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMedicine = new System.Windows.Forms.PictureBox();
            this.btnBeauty = new System.Windows.Forms.PictureBox();
            this.btnBaby = new System.Windows.Forms.PictureBox();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCart = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl會員中心 = new System.Windows.Forms.Label();
            this.pnlside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBeauty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBaby)).BeginInit();
            this.pnlHome.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnlside
            // 
            this.pnlside.Controls.Add(this.label3);
            this.pnlside.Controls.Add(this.btnMedicine);
            this.pnlside.Controls.Add(this.btnBeauty);
            this.pnlside.Controls.Add(this.btnBaby);
            this.pnlside.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlside.Location = new System.Drawing.Point(0, 0);
            this.pnlside.Name = "pnlside";
            this.pnlside.Size = new System.Drawing.Size(216, 598);
            this.pnlside.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "PAPA Pharmacy";
            // 
            // btnMedicine
            // 
            this.btnMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicine.Image")));
            this.btnMedicine.Location = new System.Drawing.Point(55, 335);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(115, 66);
            this.btnMedicine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMedicine.TabIndex = 2;
            this.btnMedicine.TabStop = false;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // btnBeauty
            // 
            this.btnBeauty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBeauty.Image = ((System.Drawing.Image)(resources.GetObject("btnBeauty.Image")));
            this.btnBeauty.Location = new System.Drawing.Point(55, 235);
            this.btnBeauty.Name = "btnBeauty";
            this.btnBeauty.Size = new System.Drawing.Size(115, 66);
            this.btnBeauty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBeauty.TabIndex = 1;
            this.btnBeauty.TabStop = false;
            this.btnBeauty.Click += new System.EventHandler(this.btnBeauty_Click);
            // 
            // btnBaby
            // 
            this.btnBaby.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaby.Image = ((System.Drawing.Image)(resources.GetObject("btnBaby.Image")));
            this.btnBaby.Location = new System.Drawing.Point(55, 135);
            this.btnBaby.Name = "btnBaby";
            this.btnBaby.Size = new System.Drawing.Size(115, 66);
            this.btnBaby.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBaby.TabIndex = 0;
            this.btnBaby.TabStop = false;
            this.btnBaby.Click += new System.EventHandler(this.btnBaby_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHome.BackgroundImage")));
            this.pnlHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlHome.Controls.Add(this.panel5);
            this.pnlHome.Controls.Add(this.label1);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.Location = new System.Drawing.Point(216, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(765, 598);
            this.pnlHome.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel5.Controls.Add(this.lbl會員中心);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.lblUser);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.btnCart);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnLogout);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 573);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(765, 25);
            this.panel5.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(447, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "歡迎";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUser.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUser.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblUser.Location = new System.Drawing.Point(507, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 25);
            this.lblUser.TabIndex = 7;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(567, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "購物車";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCart
            // 
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.Location = new System.Drawing.Point(627, 0);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(47, 25);
            this.btnCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCart.TabIndex = 5;
            this.btnCart.TabStop = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(674, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "登出";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(726, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(39, 25);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogout.TabIndex = 3;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(175, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to PAPA Pharmacy";
            // 
            // lbl會員中心
            // 
            this.lbl會員中心.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl會員中心.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl會員中心.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl會員中心.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl會員中心.Location = new System.Drawing.Point(367, 0);
            this.lbl會員中心.Name = "lbl會員中心";
            this.lbl會員中心.Size = new System.Drawing.Size(80, 25);
            this.lbl會員中心.TabIndex = 9;
            this.lbl會員中心.Text = "會員中心";
            this.lbl會員中心.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 598);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlside);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.pnlside.ResumeLayout(false);
            this.pnlside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBeauty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBaby)).EndInit();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel pnlside;
        private System.Windows.Forms.PictureBox btnBaby;
        private System.Windows.Forms.PictureBox btnMedicine;
        private System.Windows.Forms.PictureBox btnBeauty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lbl會員中心;
    }
}