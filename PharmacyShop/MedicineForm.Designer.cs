﻿namespace PharmacyShop
{
    partial class MedicineForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineForm));
            this.tabBaby = new System.Windows.Forms.TabControl();
            this.Med = new System.Windows.Forms.TabPage();
            this.dataMed = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MM = new System.Windows.Forms.TabPage();
            this.dataMM = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSumPrice = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.PictureBox();
            this.btnMinus = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.PictureBox();
            this.tabBaby.SuspendLayout();
            this.Med.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMed)).BeginInit();
            this.MM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMM)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBaby
            // 
            this.tabBaby.Controls.Add(this.Med);
            this.tabBaby.Controls.Add(this.MM);
            this.tabBaby.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabBaby.Location = new System.Drawing.Point(286, 215);
            this.tabBaby.Name = "tabBaby";
            this.tabBaby.SelectedIndex = 0;
            this.tabBaby.Size = new System.Drawing.Size(904, 489);
            this.tabBaby.TabIndex = 31;
            // 
            // Med
            // 
            this.Med.Controls.Add(this.dataMed);
            this.Med.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Med.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Med.Location = new System.Drawing.Point(4, 33);
            this.Med.Name = "Med";
            this.Med.Padding = new System.Windows.Forms.Padding(3);
            this.Med.Size = new System.Drawing.Size(896, 452);
            this.Med.TabIndex = 0;
            this.Med.Text = "保健";
            this.Med.UseVisualStyleBackColor = true;
            // 
            // dataMed
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dataMed.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataMed.ColumnHeadersHeight = 30;
            this.dataMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataMed.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataMed.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataMed.Location = new System.Drawing.Point(6, 3);
            this.dataMed.Name = "dataMed";
            this.dataMed.ReadOnly = true;
            this.dataMed.RowHeadersVisible = false;
            this.dataMed.RowTemplate.Height = 50;
            this.dataMed.RowTemplate.ReadOnly = true;
            this.dataMed.Size = new System.Drawing.Size(887, 443);
            this.dataMed.TabIndex = 0;
            this.dataMed.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataMed.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataMed.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataMed.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataMed.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataMed.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataMed.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataMed.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataMed.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataMed.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataMed.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataMed.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataMed.ThemeStyle.HeaderStyle.Height = 30;
            this.dataMed.ThemeStyle.ReadOnly = true;
            this.dataMed.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataMed.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataMed.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataMed.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataMed.ThemeStyle.RowsStyle.Height = 50;
            this.dataMed.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataMed.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataMed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMed_CellContentClick);
            this.dataMed.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataMed_DataBindingComplete);
            // 
            // MM
            // 
            this.MM.Controls.Add(this.dataMM);
            this.MM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MM.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MM.Location = new System.Drawing.Point(4, 33);
            this.MM.Name = "MM";
            this.MM.Padding = new System.Windows.Forms.Padding(3);
            this.MM.Size = new System.Drawing.Size(896, 452);
            this.MM.TabIndex = 1;
            this.MM.Text = "醫材";
            this.MM.UseVisualStyleBackColor = true;
            // 
            // dataMM
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dataMM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataMM.ColumnHeadersHeight = 30;
            this.dataMM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataMM.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataMM.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataMM.Location = new System.Drawing.Point(6, 6);
            this.dataMM.Name = "dataMM";
            this.dataMM.ReadOnly = true;
            this.dataMM.RowHeadersVisible = false;
            this.dataMM.RowTemplate.Height = 50;
            this.dataMM.RowTemplate.ReadOnly = true;
            this.dataMM.Size = new System.Drawing.Size(884, 440);
            this.dataMM.TabIndex = 0;
            this.dataMM.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataMM.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataMM.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataMM.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataMM.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataMM.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataMM.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataMM.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataMM.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataMM.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataMM.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataMM.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataMM.ThemeStyle.HeaderStyle.Height = 30;
            this.dataMM.ThemeStyle.ReadOnly = true;
            this.dataMM.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataMM.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataMM.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataMM.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataMM.ThemeStyle.RowsStyle.Height = 50;
            this.dataMM.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataMM.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataMM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMM_CellContentClick);
            this.dataMM.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataMM_DataBindingComplete);
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
            this.panel1.Size = new System.Drawing.Size(1202, 144);
            this.panel1.TabIndex = 40;
            // 
            // lblSumPrice
            // 
            this.lblSumPrice.AutoSize = true;
            this.lblSumPrice.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSumPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSumPrice.Location = new System.Drawing.Point(970, 73);
            this.lblSumPrice.Name = "lblSumPrice";
            this.lblSumPrice.Size = new System.Drawing.Size(28, 31);
            this.lblSumPrice.TabIndex = 48;
            this.lblSumPrice.Text = "$";
            // 
            // btnAddCart
            // 
            this.btnAddCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCart.Image")));
            this.btnAddCart.Location = new System.Drawing.Point(891, 48);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(55, 50);
            this.btnAddCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddCart.TabIndex = 47;
            this.btnAddCart.TabStop = false;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click_1);
            // 
            // btnMinus
            // 
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.Image = ((System.Drawing.Image)(resources.GetObject("btnMinus.Image")));
            this.btnMinus.Location = new System.Drawing.Point(807, 48);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(55, 50);
            this.btnMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinus.TabIndex = 46;
            this.btnMinus.TabStop = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(647, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 50);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 45;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtqty.Location = new System.Drawing.Point(724, 67);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(60, 25);
            this.txtqty.TabIndex = 44;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged_1);
            // 
            // txtProd
            // 
            this.txtProd.BackColor = System.Drawing.Color.White;
            this.txtProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtProd.Location = new System.Drawing.Point(286, 73);
            this.txtProd.Name = "txtProd";
            this.txtProd.ReadOnly = true;
            this.txtProd.Size = new System.Drawing.Size(288, 22);
            this.txtProd.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 74);
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
            this.btnReturn.Location = new System.Drawing.Point(1148, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(42, 36);
            this.btnReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReturn.TabIndex = 40;
            this.btnReturn.TabStop = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1202, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabBaby);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicineForm";
            this.Text = "MedicineForm";
            this.Load += new System.EventHandler(this.MedicineForm_Load);
            this.tabBaby.ResumeLayout(false);
            this.Med.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMed)).EndInit();
            this.MM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabBaby;
        private System.Windows.Forms.TabPage Med;
        private Guna.UI2.WinForms.Guna2DataGridView dataMed;
        private System.Windows.Forms.TabPage MM;
        private Guna.UI2.WinForms.Guna2DataGridView dataMM;
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