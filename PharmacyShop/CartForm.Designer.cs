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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dataCart = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnReturn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrinter = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl結帳數量 = new System.Windows.Forms.Label();
            this.lblTotalPay = new System.Windows.Forms.Label();
            this.btnPay = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataCart)).BeginInit();
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
            // dataCart
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataCart.ColumnHeadersHeight = 4;
            this.dataCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCart.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataCart.Location = new System.Drawing.Point(31, 96);
            this.dataCart.Name = "dataCart";
            this.dataCart.RowHeadersVisible = false;
            this.dataCart.RowTemplate.Height = 24;
            this.dataCart.Size = new System.Drawing.Size(536, 321);
            this.dataCart.TabIndex = 5;
            this.dataCart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataCart.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataCart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataCart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataCart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataCart.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataCart.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataCart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataCart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataCart.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataCart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataCart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataCart.ThemeStyle.HeaderStyle.Height = 4;
            this.dataCart.ThemeStyle.ReadOnly = false;
            this.dataCart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataCart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataCart.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataCart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataCart.ThemeStyle.RowsStyle.Height = 24;
            this.dataCart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataCart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl結帳數量);
            this.panel2.Controls.Add(this.lblTotalPay);
            this.panel2.Location = new System.Drawing.Point(24, 437);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 77);
            this.panel2.TabIndex = 17;
            // 
            // lbl結帳數量
            // 
            this.lbl結帳數量.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl結帳數量.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl結帳數量.ForeColor = System.Drawing.Color.DimGray;
            this.lbl結帳數量.Location = new System.Drawing.Point(292, 0);
            this.lbl結帳數量.Name = "lbl結帳數量";
            this.lbl結帳數量.Size = new System.Drawing.Size(136, 77);
            this.lbl結帳數量.TabIndex = 1;
            this.lbl結帳數量.Text = "共0件商品";
            this.lbl結帳數量.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnPay.Location = new System.Drawing.Point(195, 520);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(203, 48);
            this.btnPay.TabIndex = 16;
            this.btnPay.Text = "立即結帳";
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrinter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dataCart);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinter)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnReturn;
        private Guna.UI2.WinForms.Guna2DataGridView dataCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnPrinter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl結帳數量;
        private System.Windows.Forms.Label lblTotalPay;
        public Guna.UI2.WinForms.Guna2GradientButton btnPay;
    }
}