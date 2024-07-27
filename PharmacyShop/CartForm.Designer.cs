namespace PharmacyShop
{
    partial class CartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrinter = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxOnSale = new System.Windows.Forms.ComboBox();
            this.lblTotalPay = new System.Windows.Forms.Label();
            this.btnPay = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDeleteAll = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.購物清單 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinter)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(167, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "PAPA Pharmacy";
            // 
            // btnReturn
            // 
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(12, 9);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(66, 51);
            this.btnReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReturn.TabIndex = 6;
            this.btnReturn.TabStop = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(497, 573);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "訂單明細";
            // 
            // btnPrinter
            // 
            this.btnPrinter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrinter.Image = ((System.Drawing.Image)(resources.GetObject("btnPrinter.Image")));
            this.btnPrinter.Location = new System.Drawing.Point(500, 520);
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(54, 50);
            this.btnPrinter.TabIndex = 18;
            this.btnPrinter.TabStop = false;
            this.btnPrinter.Click += new System.EventHandler(this.btnPrinter_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbxOnSale);
            this.panel2.Controls.Add(this.lblTotalPay);
            this.panel2.Location = new System.Drawing.Point(24, 437);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 77);
            this.panel2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "促銷活動";
            // 
            // cbxOnSale
            // 
            this.cbxOnSale.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxOnSale.FormattingEnabled = true;
            this.cbxOnSale.Location = new System.Drawing.Point(24, 34);
            this.cbxOnSale.Name = "cbxOnSale";
            this.cbxOnSale.Size = new System.Drawing.Size(170, 24);
            this.cbxOnSale.TabIndex = 2;
            this.cbxOnSale.SelectedIndexChanged += new System.EventHandler(this.cbxOnSale_SelectedIndexChanged);
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalPay.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalPay.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalPay.Location = new System.Drawing.Point(428, 0);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(136, 77);
            this.lblTotalPay.TabIndex = 0;
            this.lblTotalPay.Text = "$0";
            this.lblTotalPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPay
            // 
            this.btnPay.BorderRadius = 15;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(49)))));
            this.btnPay.FillColor2 = System.Drawing.Color.DarkGreen;
            this.btnPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(359, 520);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(103, 48);
            this.btnPay.TabIndex = 16;
            this.btnPay.Text = "立即結帳";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BorderRadius = 15;
            this.btnDeleteAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAll.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(49)))));
            this.btnDeleteAll.FillColor2 = System.Drawing.Color.DarkGreen;
            this.btnDeleteAll.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.Location = new System.Drawing.Point(221, 522);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(114, 46);
            this.btnDeleteAll.TabIndex = 21;
            this.btnDeleteAll.Text = "清空購物車";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 15;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(49)))));
            this.btnDelete.FillColor2 = System.Drawing.Color.DarkGreen;
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(96, 520);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 48);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "刪除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // 購物清單
            // 
            this.購物清單.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.購物清單.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.購物清單.ForeColor = System.Drawing.Color.DarkCyan;
            this.購物清單.FormattingEnabled = true;
            this.購物清單.ItemHeight = 26;
            this.購物清單.Location = new System.Drawing.Point(12, 108);
            this.購物清單.Name = "購物清單";
            this.購物清單.Size = new System.Drawing.Size(576, 290);
            this.購物清單.TabIndex = 23;
            this.購物清單.SelectedIndexChanged += new System.EventHandler(this.購物清單_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(396, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Hi";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUser.ForeColor = System.Drawing.Color.Indigo;
            this.lblUser.Location = new System.Drawing.Point(467, 73);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 21);
            this.lblUser.TabIndex = 25;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.購物清單);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrinter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinter)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnPrinter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalPay;
        public Guna.UI2.WinForms.Guna2GradientButton btnPay;
        public Guna.UI2.WinForms.Guna2GradientButton btnDelete;
        public Guna.UI2.WinForms.Guna2GradientButton btnDeleteAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxOnSale;
        private System.Windows.Forms.ListBox 購物清單;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUser;
    }
}