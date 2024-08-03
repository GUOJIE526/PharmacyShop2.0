namespace PharmacyShop
{
    partial class OrdItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdItemForm));
            this.DGVOrdItem = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtLV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShip = new System.Windows.Forms.Button();
            this.btnDrop = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.DGVFinishItem = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.txtProdID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrdItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFinishItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVOrdItem
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVOrdItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVOrdItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVOrdItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVOrdItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVOrdItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVOrdItem.Location = new System.Drawing.Point(477, 12);
            this.DGVOrdItem.Name = "DGVOrdItem";
            this.DGVOrdItem.RowHeadersVisible = false;
            this.DGVOrdItem.RowTemplate.Height = 24;
            this.DGVOrdItem.Size = new System.Drawing.Size(661, 253);
            this.DGVOrdItem.TabIndex = 1;
            this.DGVOrdItem.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVOrdItem.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVOrdItem.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVOrdItem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVOrdItem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVOrdItem.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVOrdItem.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVOrdItem.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVOrdItem.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVOrdItem.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DGVOrdItem.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVOrdItem.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOrdItem.ThemeStyle.HeaderStyle.Height = 4;
            this.DGVOrdItem.ThemeStyle.ReadOnly = false;
            this.DGVOrdItem.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVOrdItem.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVOrdItem.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DGVOrdItem.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVOrdItem.ThemeStyle.RowsStyle.Height = 24;
            this.DGVOrdItem.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVOrdItem.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtLV
            // 
            this.txtLV.BackColor = System.Drawing.Color.White;
            this.txtLV.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLV.Location = new System.Drawing.Point(121, 241);
            this.txtLV.Name = "txtLV";
            this.txtLV.ReadOnly = true;
            this.txtLV.Size = new System.Drawing.Size(77, 29);
            this.txtLV.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 78;
            this.label1.Text = "會員等級";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.DarkGray;
            this.txtid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtid.Location = new System.Drawing.Point(121, 70);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(77, 29);
            this.txtid.TabIndex = 77;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblid.ForeColor = System.Drawing.Color.Black;
            this.lblid.Location = new System.Drawing.Point(43, 73);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(27, 21);
            this.lblid.TabIndex = 76;
            this.lblid.Text = "ID";
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.White;
            this.txtphone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtphone.Location = new System.Drawing.Point(121, 138);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(186, 29);
            this.txtphone.TabIndex = 75;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblphone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblphone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblphone.ForeColor = System.Drawing.Color.Black;
            this.lblphone.Location = new System.Drawing.Point(43, 141);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(42, 21);
            this.lblphone.TabIndex = 74;
            this.lblphone.Text = "電話";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddress.Location = new System.Drawing.Point(121, 206);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(272, 29);
            this.txtAddress.TabIndex = 73;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(121, 172);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(272, 29);
            this.txtEmail.TabIndex = 72;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUser.Location = new System.Drawing.Point(121, 104);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(186, 29);
            this.txtUser.TabIndex = 71;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbladdress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbladdress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbladdress.ForeColor = System.Drawing.Color.Black;
            this.lbladdress.Location = new System.Drawing.Point(43, 209);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(42, 21);
            this.lbladdress.TabIndex = 70;
            this.lbladdress.Text = "地址";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblemail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblemail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblemail.ForeColor = System.Drawing.Color.Black;
            this.lblemail.Location = new System.Drawing.Point(43, 175);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(51, 21);
            this.lblemail.TabIndex = 69;
            this.lblemail.Text = "Email";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbluser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbluser.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbluser.ForeColor = System.Drawing.Color.Black;
            this.lbluser.Location = new System.Drawing.Point(43, 107);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(58, 21);
            this.lbluser.TabIndex = 68;
            this.lbluser.Text = "用戶名";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(144, 297);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 34);
            this.btnDelete.TabIndex = 83;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnShip
            // 
            this.btnShip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShip.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShip.Location = new System.Drawing.Point(47, 297);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(81, 34);
            this.btnShip.TabIndex = 82;
            this.btnShip.Text = "出貨";
            this.btnShip.UseVisualStyleBackColor = true;
            // 
            // btnDrop
            // 
            this.btnDrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrop.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDrop.Location = new System.Drawing.Point(144, 521);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(81, 34);
            this.btnDrop.TabIndex = 81;
            this.btnDrop.Text = "刪除";
            this.btnDrop.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(45, 521);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 34);
            this.btnUpdate.TabIndex = 80;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // DGVFinishItem
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGVFinishItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVFinishItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVFinishItem.ColumnHeadersHeight = 4;
            this.DGVFinishItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVFinishItem.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVFinishItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVFinishItem.Location = new System.Drawing.Point(477, 297);
            this.DGVFinishItem.Name = "DGVFinishItem";
            this.DGVFinishItem.RowHeadersVisible = false;
            this.DGVFinishItem.RowTemplate.Height = 24;
            this.DGVFinishItem.Size = new System.Drawing.Size(661, 258);
            this.DGVFinishItem.TabIndex = 85;
            this.DGVFinishItem.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVFinishItem.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVFinishItem.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVFinishItem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVFinishItem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVFinishItem.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVFinishItem.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVFinishItem.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVFinishItem.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVFinishItem.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DGVFinishItem.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVFinishItem.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVFinishItem.ThemeStyle.HeaderStyle.Height = 4;
            this.DGVFinishItem.ThemeStyle.ReadOnly = false;
            this.DGVFinishItem.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVFinishItem.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVFinishItem.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DGVFinishItem.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVFinishItem.ThemeStyle.RowsStyle.Height = 24;
            this.DGVFinishItem.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVFinishItem.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.White;
            this.txtQty.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtQty.Location = new System.Drawing.Point(121, 470);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(186, 29);
            this.txtQty.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(43, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 92;
            this.label2.Text = "數量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(43, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 21);
            this.label3.TabIndex = 90;
            this.label3.Text = "ID";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(121, 435);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(186, 29);
            this.txtPrice.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(43, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 88;
            this.label4.Text = "價格";
            // 
            // txtProdName
            // 
            this.txtProdName.BackColor = System.Drawing.Color.White;
            this.txtProdName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProdName.Location = new System.Drawing.Point(121, 400);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(285, 29);
            this.txtProdName.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(41, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 86;
            this.label5.Text = "商品名稱";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 37);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 94;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtProdID
            // 
            this.txtProdID.BackColor = System.Drawing.Color.DarkGray;
            this.txtProdID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProdID.Location = new System.Drawing.Point(121, 365);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.ReadOnly = true;
            this.txtProdID.Size = new System.Drawing.Size(77, 29);
            this.txtProdID.TabIndex = 95;
            // 
            // OrdItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(186)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1150, 580);
            this.Controls.Add(this.txtProdID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGVFinishItem);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShip);
            this.Controls.Add(this.btnDrop);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtLV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.DGVOrdItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdItemForm";
            this.Text = "OrdItemForm";
            this.Load += new System.EventHandler(this.OrdItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrdItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFinishItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DGVOrdItem;
        private System.Windows.Forms.TextBox txtLV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShip;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Button btnUpdate;
        private Guna.UI2.WinForms.Guna2DataGridView DGVFinishItem;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.TextBox txtProdID;
    }
}