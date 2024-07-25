namespace PharmacyShop
{
    partial class BabyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BabyForm));
            this.pnlbaby = new System.Windows.Forms.Panel();
            this.tabBaby = new System.Windows.Forms.TabControl();
            this.Milk = new System.Windows.Forms.TabPage();
            this.dataMilk = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Diaper = new System.Windows.Forms.TabPage();
            this.dataDiaper = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSumPrice = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.PictureBox();
            this.btnMinus = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.PictureBox();
            this.pnlbaby.SuspendLayout();
            this.tabBaby.SuspendLayout();
            this.Milk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMilk)).BeginInit();
            this.Diaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDiaper)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlbaby
            // 
            this.pnlbaby.Controls.Add(this.panel1);
            this.pnlbaby.Controls.Add(this.tabBaby);
            this.pnlbaby.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlbaby.Location = new System.Drawing.Point(0, 0);
            this.pnlbaby.Name = "pnlbaby";
            this.pnlbaby.Size = new System.Drawing.Size(979, 598);
            this.pnlbaby.TabIndex = 0;
            // 
            // tabBaby
            // 
            this.tabBaby.Controls.Add(this.Milk);
            this.tabBaby.Controls.Add(this.Diaper);
            this.tabBaby.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabBaby.Location = new System.Drawing.Point(85, 160);
            this.tabBaby.Name = "tabBaby";
            this.tabBaby.SelectedIndex = 0;
            this.tabBaby.Size = new System.Drawing.Size(882, 426);
            this.tabBaby.TabIndex = 21;
            // 
            // Milk
            // 
            this.Milk.Controls.Add(this.dataMilk);
            this.Milk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Milk.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Milk.Location = new System.Drawing.Point(4, 33);
            this.Milk.Name = "Milk";
            this.Milk.Padding = new System.Windows.Forms.Padding(3);
            this.Milk.Size = new System.Drawing.Size(859, 389);
            this.Milk.TabIndex = 0;
            this.Milk.Text = "奶粉";
            this.Milk.UseVisualStyleBackColor = true;
            // 
            // dataMilk
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataMilk.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMilk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataMilk.ColumnHeadersHeight = 30;
            this.dataMilk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataMilk.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataMilk.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataMilk.Location = new System.Drawing.Point(6, 6);
            this.dataMilk.Name = "dataMilk";
            this.dataMilk.ReadOnly = true;
            this.dataMilk.RowHeadersVisible = false;
            this.dataMilk.RowTemplate.Height = 50;
            this.dataMilk.Size = new System.Drawing.Size(847, 377);
            this.dataMilk.TabIndex = 0;
            this.dataMilk.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataMilk.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataMilk.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataMilk.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataMilk.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataMilk.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataMilk.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataMilk.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataMilk.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataMilk.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataMilk.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataMilk.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataMilk.ThemeStyle.HeaderStyle.Height = 30;
            this.dataMilk.ThemeStyle.ReadOnly = true;
            this.dataMilk.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataMilk.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataMilk.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataMilk.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataMilk.ThemeStyle.RowsStyle.Height = 50;
            this.dataMilk.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataMilk.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataMilk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMilk_CellContentClick);
            this.dataMilk.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataMilk_DataBindingComplete);
            // 
            // Diaper
            // 
            this.Diaper.Controls.Add(this.dataDiaper);
            this.Diaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Diaper.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Diaper.Location = new System.Drawing.Point(4, 33);
            this.Diaper.Name = "Diaper";
            this.Diaper.Padding = new System.Windows.Forms.Padding(3);
            this.Diaper.Size = new System.Drawing.Size(874, 389);
            this.Diaper.TabIndex = 1;
            this.Diaper.Text = "尿布";
            this.Diaper.UseVisualStyleBackColor = true;
            // 
            // dataDiaper
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataDiaper.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDiaper.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataDiaper.ColumnHeadersHeight = 30;
            this.dataDiaper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDiaper.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataDiaper.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataDiaper.Location = new System.Drawing.Point(6, 6);
            this.dataDiaper.Name = "dataDiaper";
            this.dataDiaper.ReadOnly = true;
            this.dataDiaper.RowHeadersVisible = false;
            this.dataDiaper.RowTemplate.Height = 50;
            this.dataDiaper.Size = new System.Drawing.Size(862, 377);
            this.dataDiaper.TabIndex = 0;
            this.dataDiaper.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataDiaper.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataDiaper.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataDiaper.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataDiaper.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataDiaper.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataDiaper.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataDiaper.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataDiaper.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataDiaper.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataDiaper.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataDiaper.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataDiaper.ThemeStyle.HeaderStyle.Height = 30;
            this.dataDiaper.ThemeStyle.ReadOnly = true;
            this.dataDiaper.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataDiaper.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataDiaper.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataDiaper.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataDiaper.ThemeStyle.RowsStyle.Height = 50;
            this.dataDiaper.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataDiaper.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataDiaper.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDiaper_CellContentClick);
            this.dataDiaper.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataDiaper_DataBindingComplete);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSumPrice);
            this.panel1.Controls.Add(this.btnAddCart);
            this.panel1.Controls.Add(this.btnMinus);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtqty);
            this.panel1.Controls.Add(this.txtProd);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 140);
            this.panel1.TabIndex = 1;
            // 
            // lblSumPrice
            // 
            this.lblSumPrice.AutoSize = true;
            this.lblSumPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSumPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSumPrice.Location = new System.Drawing.Point(807, 68);
            this.lblSumPrice.Name = "lblSumPrice";
            this.lblSumPrice.Size = new System.Drawing.Size(25, 26);
            this.lblSumPrice.TabIndex = 38;
            this.lblSumPrice.Text = "$";
            // 
            // btnAddCart
            // 
            this.btnAddCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCart.Image")));
            this.btnAddCart.Location = new System.Drawing.Point(709, 57);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(37, 36);
            this.btnAddCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddCart.TabIndex = 37;
            this.btnAddCart.TabStop = false;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click_1);
            // 
            // btnMinus
            // 
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.Image = ((System.Drawing.Image)(resources.GetObject("btnMinus.Image")));
            this.btnMinus.Location = new System.Drawing.Point(629, 57);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(37, 36);
            this.btnMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinus.TabIndex = 36;
            this.btnMinus.TabStop = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(536, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(37, 36);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 35;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtqty.Location = new System.Drawing.Point(579, 68);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(44, 25);
            this.txtqty.TabIndex = 34;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged_1);
            // 
            // txtProd
            // 
            this.txtProd.BackColor = System.Drawing.Color.LimeGreen;
            this.txtProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtProd.Location = new System.Drawing.Point(186, 68);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(316, 22);
            this.txtProd.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(186, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 1);
            this.panel2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(100, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Prouduct";
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(927, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(40, 32);
            this.btnReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReturn.TabIndex = 30;
            this.btnReturn.TabStop = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // BabyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(979, 598);
            this.Controls.Add(this.pnlbaby);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BabyForm";
            this.Text = "BabyForm";
            this.Load += new System.EventHandler(this.BabyForm_Load);
            this.pnlbaby.ResumeLayout(false);
            this.tabBaby.ResumeLayout(false);
            this.Milk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMilk)).EndInit();
            this.Diaper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDiaper)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlbaby;
        private System.Windows.Forms.TabControl tabBaby;
        private System.Windows.Forms.TabPage Milk;
        private Guna.UI2.WinForms.Guna2DataGridView dataMilk;
        private System.Windows.Forms.TabPage Diaper;
        private Guna.UI2.WinForms.Guna2DataGridView dataDiaper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSumPrice;
        private System.Windows.Forms.PictureBox btnAddCart;
        private System.Windows.Forms.PictureBox btnMinus;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnReturn;
    }
}