namespace PharmacyShop
{
    partial class CustCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustCenter));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHistory = new System.Windows.Forms.Label();
            this.btnCustInfo = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.PictureBox();
            this.DataHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ShowPass = new System.Windows.Forms.PictureBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPass)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHistory
            // 
            this.btnHistory.AutoSize = true;
            this.btnHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Location = new System.Drawing.Point(193, 108);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(125, 37);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "歷史訂單";
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnCustInfo
            // 
            this.btnCustInfo.AutoSize = true;
            this.btnCustInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCustInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustInfo.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCustInfo.ForeColor = System.Drawing.Color.White;
            this.btnCustInfo.Location = new System.Drawing.Point(375, 108);
            this.btnCustInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnCustInfo.Name = "btnCustInfo";
            this.btnCustInfo.Size = new System.Drawing.Size(125, 37);
            this.btnCustInfo.TabIndex = 15;
            this.btnCustInfo.Text = "會員資料";
            this.btnCustInfo.Click += new System.EventHandler(this.btnCustInfo_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(44, 12);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(133, 62);
            this.btnReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReturn.TabIndex = 16;
            this.btnReturn.TabStop = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // DataHistory
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.DataHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DataHistory.ColumnHeadersHeight = 30;
            this.DataHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataHistory.DefaultCellStyle = dataGridViewCellStyle12;
            this.DataHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataHistory.Location = new System.Drawing.Point(529, 229);
            this.DataHistory.Margin = new System.Windows.Forms.Padding(4);
            this.DataHistory.Name = "DataHistory";
            this.DataHistory.ReadOnly = true;
            this.DataHistory.RowHeadersVisible = false;
            this.DataHistory.RowHeadersWidth = 51;
            this.DataHistory.RowTemplate.Height = 50;
            this.DataHistory.RowTemplate.ReadOnly = true;
            this.DataHistory.Size = new System.Drawing.Size(850, 549);
            this.DataHistory.TabIndex = 17;
            this.DataHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataHistory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataHistory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataHistory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DataHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataHistory.ThemeStyle.HeaderStyle.Height = 30;
            this.DataHistory.ThemeStyle.ReadOnly = true;
            this.DataHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataHistory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DataHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataHistory.ThemeStyle.RowsStyle.Height = 50;
            this.DataHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataHistory.Visible = false;
            // 
            // ShowPass
            // 
            this.ShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPass.Image = ((System.Drawing.Image)(resources.GetObject("ShowPass.Image")));
            this.ShowPass.Location = new System.Drawing.Point(399, 492);
            this.ShowPass.Margin = new System.Windows.Forms.Padding(4);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(48, 36);
            this.ShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPass.TabIndex = 19;
            this.ShowPass.TabStop = false;
            this.ShowPass.Visible = false;
            this.ShowPass.MouseLeave += new System.EventHandler(this.ShowPass_MouseLeave);
            this.ShowPass.MouseHover += new System.EventHandler(this.ShowPass_MouseHover);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Location = new System.Drawing.Point(39, 329);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(33, 25);
            this.lblid.TabIndex = 20;
            this.lblid.Text = "ID";
            this.lblid.Visible = false;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbluser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbluser.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbluser.ForeColor = System.Drawing.Color.White;
            this.lbluser.Location = new System.Drawing.Point(39, 412);
            this.lbluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(72, 25);
            this.lbluser.TabIndex = 21;
            this.lbluser.Text = "用戶名";
            this.lbluser.Visible = false;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblpass.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblpass.ForeColor = System.Drawing.Color.White;
            this.lblpass.Location = new System.Drawing.Point(39, 496);
            this.lblpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(52, 25);
            this.lblpass.TabIndex = 22;
            this.lblpass.Text = "密碼";
            this.lblpass.Visible = false;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblemail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblemail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblemail.ForeColor = System.Drawing.Color.White;
            this.lblemail.Location = new System.Drawing.Point(39, 664);
            this.lblemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(65, 25);
            this.lblemail.TabIndex = 23;
            this.lblemail.Text = "Email";
            this.lblemail.Visible = false;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbladdress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbladdress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbladdress.ForeColor = System.Drawing.Color.White;
            this.lbladdress.Location = new System.Drawing.Point(39, 748);
            this.lbladdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(52, 25);
            this.lbladdress.TabIndex = 24;
            this.lbladdress.Text = "地址";
            this.lbladdress.Visible = false;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.DarkGray;
            this.txtid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtid.Location = new System.Drawing.Point(143, 325);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(101, 34);
            this.txtid.TabIndex = 25;
            this.txtid.Visible = false;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.DarkGray;
            this.txtUser.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUser.Location = new System.Drawing.Point(143, 409);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(247, 34);
            this.txtUser.TabIndex = 26;
            this.txtUser.Visible = false;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.DarkGray;
            this.txtPass.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPass.Location = new System.Drawing.Point(143, 492);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(247, 34);
            this.txtPass.TabIndex = 27;
            this.txtPass.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.DarkGray;
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(143, 660);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(361, 34);
            this.txtEmail.TabIndex = 28;
            this.txtEmail.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.DarkGray;
            this.txtAddress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddress.Location = new System.Drawing.Point(143, 744);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(361, 34);
            this.txtAddress.TabIndex = 29;
            this.txtAddress.Visible = false;
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.DarkGray;
            this.txtphone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtphone.Location = new System.Drawing.Point(143, 576);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4);
            this.txtphone.Name = "txtphone";
            this.txtphone.ReadOnly = true;
            this.txtphone.Size = new System.Drawing.Size(247, 34);
            this.txtphone.TabIndex = 31;
            this.txtphone.Visible = false;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblphone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblphone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblphone.ForeColor = System.Drawing.Color.White;
            this.lblphone.Location = new System.Drawing.Point(39, 580);
            this.lblphone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(52, 25);
            this.lblphone.TabIndex = 30;
            this.lblphone.Text = "電話";
            this.lblphone.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Silver;
            this.btnConfirm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.Location = new System.Drawing.Point(279, 235);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(81, 35);
            this.btnConfirm.TabIndex = 33;
            this.btnConfirm.Text = "確認";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(44, 235);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 35);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "修改會員資料";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // CustCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1813, 930);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.DataHistory);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCustInfo);
            this.Controls.Add(this.btnHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustCenter";
            this.Load += new System.EventHandler(this.CustCenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label btnHistory;
        private System.Windows.Forms.Label btnCustInfo;
        private System.Windows.Forms.PictureBox btnReturn;
        private Guna.UI2.WinForms.Guna2DataGridView DataHistory;
        private System.Windows.Forms.PictureBox ShowPass;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnUpdate;
    }
}