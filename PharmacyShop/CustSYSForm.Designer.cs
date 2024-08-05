namespace PharmacyShop
{
    partial class CustSYSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustSYSForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxSearch = new System.Windows.Forms.ComboBox();
            this.txtkeyword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNoright = new System.Windows.Forms.Button();
            this.btnDrop = new System.Windows.Forms.Button();
            this.btnCustUpdate = new System.Windows.Forms.Button();
            this.dataCust = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtLV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.btnShowAll);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbxSearch);
            this.groupBox1.Controls.Add(this.txtkeyword);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(44, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 179);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "會員管理";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowAll.Location = new System.Drawing.Point(134, 122);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(141, 34);
            this.btnShowAll.TabIndex = 66;
            this.btnShowAll.Text = "顯示全員資料";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(197, 84);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 34);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxSearch
            // 
            this.cbxSearch.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxSearch.FormattingEnabled = true;
            this.cbxSearch.Location = new System.Drawing.Point(184, 48);
            this.cbxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSearch.Name = "cbxSearch";
            this.cbxSearch.Size = new System.Drawing.Size(92, 31);
            this.cbxSearch.TabIndex = 9;
            // 
            // txtkeyword
            // 
            this.txtkeyword.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtkeyword.Location = new System.Drawing.Point(27, 48);
            this.txtkeyword.Margin = new System.Windows.Forms.Padding(2);
            this.txtkeyword.Name = "txtkeyword";
            this.txtkeyword.Size = new System.Drawing.Size(154, 32);
            this.txtkeyword.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(29, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "欄位關鍵字搜尋";
            // 
            // btnNoright
            // 
            this.btnNoright.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoright.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNoright.Location = new System.Drawing.Point(192, 296);
            this.btnNoright.Name = "btnNoright";
            this.btnNoright.Size = new System.Drawing.Size(81, 34);
            this.btnNoright.TabIndex = 49;
            this.btnNoright.Text = "停權";
            this.btnNoright.UseVisualStyleBackColor = true;
            this.btnNoright.Click += new System.EventHandler(this.btnNoright_Click);
            // 
            // btnDrop
            // 
            this.btnDrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrop.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDrop.Location = new System.Drawing.Point(104, 296);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(81, 34);
            this.btnDrop.TabIndex = 48;
            this.btnDrop.Text = "刪除";
            this.btnDrop.UseVisualStyleBackColor = true;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // btnCustUpdate
            // 
            this.btnCustUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustUpdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCustUpdate.Location = new System.Drawing.Point(16, 296);
            this.btnCustUpdate.Name = "btnCustUpdate";
            this.btnCustUpdate.Size = new System.Drawing.Size(81, 34);
            this.btnCustUpdate.TabIndex = 47;
            this.btnCustUpdate.Text = "修改";
            this.btnCustUpdate.UseVisualStyleBackColor = true;
            this.btnCustUpdate.Click += new System.EventHandler(this.btnCustUpdate_Click);
            // 
            // dataCust
            // 
            this.dataCust.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataCust.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCust.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataCust.ColumnHeadersHeight = 30;
            this.dataCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCust.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataCust.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataCust.Location = new System.Drawing.Point(407, 85);
            this.dataCust.Name = "dataCust";
            this.dataCust.ReadOnly = true;
            this.dataCust.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCust.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataCust.RowHeadersVisible = false;
            this.dataCust.RowTemplate.Height = 30;
            this.dataCust.RowTemplate.ReadOnly = true;
            this.dataCust.Size = new System.Drawing.Size(700, 430);
            this.dataCust.TabIndex = 50;
            this.dataCust.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataCust.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataCust.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataCust.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataCust.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataCust.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataCust.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataCust.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.dataCust.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataCust.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataCust.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataCust.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataCust.ThemeStyle.HeaderStyle.Height = 30;
            this.dataCust.ThemeStyle.ReadOnly = true;
            this.dataCust.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataCust.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataCust.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataCust.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataCust.ThemeStyle.RowsStyle.Height = 30;
            this.dataCust.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataCust.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataCust.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCust_CellClick);
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.White;
            this.txtphone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtphone.Location = new System.Drawing.Point(106, 152);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(186, 29);
            this.txtphone.TabIndex = 63;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblphone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblphone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblphone.ForeColor = System.Drawing.Color.Black;
            this.lblphone.Location = new System.Drawing.Point(28, 155);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(42, 21);
            this.lblphone.TabIndex = 62;
            this.lblphone.Text = "電話";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddress.Location = new System.Drawing.Point(106, 220);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(272, 29);
            this.txtAddress.TabIndex = 61;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(106, 186);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(272, 29);
            this.txtEmail.TabIndex = 60;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUser.Location = new System.Drawing.Point(106, 118);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(186, 29);
            this.txtUser.TabIndex = 58;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbladdress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbladdress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbladdress.ForeColor = System.Drawing.Color.Black;
            this.lbladdress.Location = new System.Drawing.Point(28, 223);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(42, 21);
            this.lbladdress.TabIndex = 56;
            this.lbladdress.Text = "地址";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblemail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblemail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblemail.ForeColor = System.Drawing.Color.Black;
            this.lblemail.Location = new System.Drawing.Point(28, 189);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(51, 21);
            this.lblemail.TabIndex = 55;
            this.lblemail.Text = "Email";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbluser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbluser.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbluser.ForeColor = System.Drawing.Color.Black;
            this.lbluser.Location = new System.Drawing.Point(28, 121);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(58, 21);
            this.lbluser.TabIndex = 53;
            this.lbluser.Text = "用戶名";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.DarkGray;
            this.txtid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtid.Location = new System.Drawing.Point(106, 84);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(77, 29);
            this.txtid.TabIndex = 65;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblid.ForeColor = System.Drawing.Color.Black;
            this.lblid.Location = new System.Drawing.Point(28, 87);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(27, 21);
            this.lblid.TabIndex = 64;
            this.lblid.Text = "ID";
            // 
            // txtLV
            // 
            this.txtLV.BackColor = System.Drawing.Color.White;
            this.txtLV.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLV.Location = new System.Drawing.Point(106, 255);
            this.txtLV.Name = "txtLV";
            this.txtLV.ReadOnly = true;
            this.txtLV.Size = new System.Drawing.Size(77, 29);
            this.txtLV.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 66;
            this.label1.Text = "會員等級";
            // 
            // btnNormal
            // 
            this.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNormal.Location = new System.Drawing.Point(280, 296);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(81, 34);
            this.btnNormal.TabIndex = 68;
            this.btnNormal.Text = "回復";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(13, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 37);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 69;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CustSYSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(186)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1150, 580);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.txtLV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNoright);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnDrop);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnCustUpdate);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.dataCust);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustSYSForm";
            this.Text = "CustSYSForm";
            this.Load += new System.EventHandler(this.CustSYSForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNoright;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Button btnCustUpdate;
        private Guna.UI2.WinForms.Guna2DataGridView dataCust;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxSearch;
        private System.Windows.Forms.TextBox txtkeyword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtLV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.PictureBox btnClose;
    }
}