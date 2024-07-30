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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnChangePass = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Label();
            this.btnCallus = new System.Windows.Forms.Label();
            this.txtChangePass = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCustInfo = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.PictureBox();
            this.DataHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl指示 = new System.Windows.Forms.Label();
            this.ShowPass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPass)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangePass
            // 
            this.btnChangePass.AutoSize = true;
            this.btnChangePass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePass.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Location = new System.Drawing.Point(680, 141);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(98, 28);
            this.btnChangePass.TabIndex = 1;
            this.btnChangePass.Text = "修改密碼";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.AutoSize = true;
            this.btnHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Location = new System.Drawing.Point(314, 141);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(98, 28);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "歷史訂單";
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnCallus
            // 
            this.btnCallus.AutoSize = true;
            this.btnCallus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCallus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCallus.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCallus.ForeColor = System.Drawing.Color.White;
            this.btnCallus.Location = new System.Drawing.Point(436, 141);
            this.btnCallus.Name = "btnCallus";
            this.btnCallus.Size = new System.Drawing.Size(98, 28);
            this.btnCallus.TabIndex = 3;
            this.btnCallus.Text = "聯絡客服";
            this.btnCallus.Click += new System.EventHandler(this.btnCallus_Click);
            // 
            // txtChangePass
            // 
            this.txtChangePass.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChangePass.Location = new System.Drawing.Point(310, 203);
            this.txtChangePass.Name = "txtChangePass";
            this.txtChangePass.PasswordChar = '●';
            this.txtChangePass.Size = new System.Drawing.Size(234, 29);
            this.txtChangePass.TabIndex = 13;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Gray;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.Location = new System.Drawing.Point(558, 201);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(59, 31);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "確認";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCustInfo
            // 
            this.btnCustInfo.AutoSize = true;
            this.btnCustInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCustInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustInfo.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCustInfo.ForeColor = System.Drawing.Color.White;
            this.btnCustInfo.Location = new System.Drawing.Point(558, 141);
            this.btnCustInfo.Name = "btnCustInfo";
            this.btnCustInfo.Size = new System.Drawing.Size(98, 28);
            this.btnCustInfo.TabIndex = 15;
            this.btnCustInfo.Text = "會員資料";
            this.btnCustInfo.Click += new System.EventHandler(this.btnCustInfo_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(225, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 50);
            this.btnReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReturn.TabIndex = 16;
            this.btnReturn.TabStop = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // DataHistory
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DataHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataHistory.ColumnHeadersHeight = 30;
            this.DataHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataHistory.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataHistory.Location = new System.Drawing.Point(310, 256);
            this.DataHistory.Name = "DataHistory";
            this.DataHistory.ReadOnly = true;
            this.DataHistory.RowHeadersVisible = false;
            this.DataHistory.RowTemplate.Height = 50;
            this.DataHistory.RowTemplate.ReadOnly = true;
            this.DataHistory.Size = new System.Drawing.Size(652, 379);
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
            // 
            // lbl指示
            // 
            this.lbl指示.AutoSize = true;
            this.lbl指示.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl指示.Location = new System.Drawing.Point(310, 179);
            this.lbl指示.Name = "lbl指示";
            this.lbl指示.Size = new System.Drawing.Size(270, 21);
            this.lbl指示.TabIndex = 18;
            this.lbl指示.Text = "請輸入欲更改的密碼,輸入後請按確認";
            // 
            // ShowPass
            // 
            this.ShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPass.Image = ((System.Drawing.Image)(resources.GetObject("ShowPass.Image")));
            this.ShowPass.Location = new System.Drawing.Point(268, 201);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(36, 29);
            this.ShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPass.TabIndex = 19;
            this.ShowPass.TabStop = false;
            this.ShowPass.MouseLeave += new System.EventHandler(this.ShowPass_MouseLeave);
            this.ShowPass.MouseHover += new System.EventHandler(this.ShowPass_MouseHover);
            // 
            // CustCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1202, 744);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.lbl指示);
            this.Controls.Add(this.DataHistory);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCustInfo);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtChangePass);
            this.Controls.Add(this.btnCallus);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnChangePass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustCenter";
            this.Text = "CustCenter";
            this.Load += new System.EventHandler(this.CustCenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label btnChangePass;
        private System.Windows.Forms.Label btnHistory;
        private System.Windows.Forms.Label btnCallus;
        private System.Windows.Forms.TextBox txtChangePass;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label btnCustInfo;
        private System.Windows.Forms.PictureBox btnReturn;
        private Guna.UI2.WinForms.Guna2DataGridView DataHistory;
        private System.Windows.Forms.Label lbl指示;
        private System.Windows.Forms.PictureBox ShowPass;
    }
}