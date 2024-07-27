namespace PharmacyShop
{
    partial class BeautyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeautyForm));
            this.tabBeauty = new System.Windows.Forms.TabControl();
            this.Beauty = new System.Windows.Forms.TabPage();
            this.dataBeauty = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Perfume = new System.Windows.Forms.TabPage();
            this.dataPerfume = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSumPrice = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.PictureBox();
            this.btnMinus = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.PictureBox();
            this.tabBeauty.SuspendLayout();
            this.Beauty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBeauty)).BeginInit();
            this.Perfume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPerfume)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBeauty
            // 
            this.tabBeauty.Controls.Add(this.Beauty);
            this.tabBeauty.Controls.Add(this.Perfume);
            this.tabBeauty.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabBeauty.Location = new System.Drawing.Point(75, 162);
            this.tabBeauty.Name = "tabBeauty";
            this.tabBeauty.SelectedIndex = 0;
            this.tabBeauty.Size = new System.Drawing.Size(887, 426);
            this.tabBeauty.TabIndex = 31;
            // 
            // Beauty
            // 
            this.Beauty.Controls.Add(this.dataBeauty);
            this.Beauty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beauty.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Beauty.Location = new System.Drawing.Point(4, 33);
            this.Beauty.Name = "Beauty";
            this.Beauty.Padding = new System.Windows.Forms.Padding(3);
            this.Beauty.Size = new System.Drawing.Size(879, 389);
            this.Beauty.TabIndex = 0;
            this.Beauty.Text = "美顏";
            this.Beauty.UseVisualStyleBackColor = true;
            // 
            // dataBeauty
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataBeauty.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataBeauty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataBeauty.ColumnHeadersHeight = 30;
            this.dataBeauty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataBeauty.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataBeauty.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataBeauty.Location = new System.Drawing.Point(6, 6);
            this.dataBeauty.Name = "dataBeauty";
            this.dataBeauty.ReadOnly = true;
            this.dataBeauty.RowHeadersVisible = false;
            this.dataBeauty.RowTemplate.Height = 50;
            this.dataBeauty.Size = new System.Drawing.Size(867, 377);
            this.dataBeauty.TabIndex = 0;
            this.dataBeauty.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataBeauty.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataBeauty.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataBeauty.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataBeauty.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataBeauty.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataBeauty.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataBeauty.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataBeauty.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataBeauty.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataBeauty.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataBeauty.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataBeauty.ThemeStyle.HeaderStyle.Height = 30;
            this.dataBeauty.ThemeStyle.ReadOnly = true;
            this.dataBeauty.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataBeauty.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataBeauty.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataBeauty.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataBeauty.ThemeStyle.RowsStyle.Height = 50;
            this.dataBeauty.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataBeauty.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataBeauty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBeauty_CellContentClick);
            this.dataBeauty.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataBeauty_DataBindingComplete);
            // 
            // Perfume
            // 
            this.Perfume.Controls.Add(this.dataPerfume);
            this.Perfume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Perfume.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Perfume.Location = new System.Drawing.Point(4, 33);
            this.Perfume.Name = "Perfume";
            this.Perfume.Padding = new System.Windows.Forms.Padding(3);
            this.Perfume.Size = new System.Drawing.Size(879, 389);
            this.Perfume.TabIndex = 1;
            this.Perfume.Text = "香水";
            this.Perfume.UseVisualStyleBackColor = true;
            // 
            // dataPerfume
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataPerfume.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPerfume.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataPerfume.ColumnHeadersHeight = 30;
            this.dataPerfume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPerfume.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataPerfume.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataPerfume.Location = new System.Drawing.Point(6, 6);
            this.dataPerfume.Name = "dataPerfume";
            this.dataPerfume.ReadOnly = true;
            this.dataPerfume.RowHeadersVisible = false;
            this.dataPerfume.RowTemplate.Height = 50;
            this.dataPerfume.Size = new System.Drawing.Size(872, 377);
            this.dataPerfume.TabIndex = 0;
            this.dataPerfume.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataPerfume.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataPerfume.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataPerfume.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataPerfume.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataPerfume.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataPerfume.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataPerfume.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataPerfume.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataPerfume.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataPerfume.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataPerfume.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataPerfume.ThemeStyle.HeaderStyle.Height = 30;
            this.dataPerfume.ThemeStyle.ReadOnly = true;
            this.dataPerfume.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataPerfume.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataPerfume.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataPerfume.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataPerfume.ThemeStyle.RowsStyle.Height = 50;
            this.dataPerfume.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataPerfume.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataPerfume.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPerfume_CellContentClick);
            this.dataPerfume.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataPerfume_DataBindingComplete);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSumPrice);
            this.panel1.Controls.Add(this.btnAddCart);
            this.panel1.Controls.Add(this.btnMinus);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtqty);
            this.panel1.Controls.Add(this.txtProd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 142);
            this.panel1.TabIndex = 1;
            // 
            // lblSumPrice
            // 
            this.lblSumPrice.AutoSize = true;
            this.lblSumPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSumPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSumPrice.Location = new System.Drawing.Point(845, 72);
            this.lblSumPrice.Name = "lblSumPrice";
            this.lblSumPrice.Size = new System.Drawing.Size(25, 26);
            this.lblSumPrice.TabIndex = 48;
            this.lblSumPrice.Text = "$";
            // 
            // btnAddCart
            // 
            this.btnAddCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCart.Image")));
            this.btnAddCart.Location = new System.Drawing.Point(774, 52);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(51, 47);
            this.btnAddCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddCart.TabIndex = 47;
            this.btnAddCart.TabStop = false;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click_1);
            // 
            // btnMinus
            // 
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.Image = ((System.Drawing.Image)(resources.GetObject("btnMinus.Image")));
            this.btnMinus.Location = new System.Drawing.Point(695, 52);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(51, 47);
            this.btnMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinus.TabIndex = 46;
            this.btnMinus.TabStop = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(550, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 47);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 45;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtqty.Location = new System.Drawing.Point(617, 70);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(62, 25);
            this.txtqty.TabIndex = 44;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged_1);
            // 
            // txtProd
            // 
            this.txtProd.BackColor = System.Drawing.Color.White;
            this.txtProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtProd.Location = new System.Drawing.Point(163, 73);
            this.txtProd.Name = "txtProd";
            this.txtProd.ReadOnly = true;
            this.txtProd.Size = new System.Drawing.Size(342, 22);
            this.txtProd.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Prouduct";
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(981, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(44, 33);
            this.btnReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReturn.TabIndex = 40;
            this.btnReturn.TabStop = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // BeautyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1037, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabBeauty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BeautyForm";
            this.Text = "BeautyForm";
            this.Load += new System.EventHandler(this.BeautyForm_Load);
            this.tabBeauty.ResumeLayout(false);
            this.Beauty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBeauty)).EndInit();
            this.Perfume.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPerfume)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabBeauty;
        private System.Windows.Forms.TabPage Beauty;
        private Guna.UI2.WinForms.Guna2DataGridView dataBeauty;
        private System.Windows.Forms.TabPage Perfume;
        private Guna.UI2.WinForms.Guna2DataGridView dataPerfume;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSumPrice;
        private System.Windows.Forms.PictureBox btnAddCart;
        private System.Windows.Forms.PictureBox btnMinus;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnReturn;
    }
}