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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHistory = new System.Windows.Forms.Label();
            this.btnCallus = new System.Windows.Forms.Label();
            this.btnCustInfo = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.PictureBox();
            this.DataHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ShowPass = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnHistory.Location = new System.Drawing.Point(193, 107);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(125, 37);
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
            this.btnCallus.Location = new System.Drawing.Point(355, 107);
            this.btnCallus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnCallus.Name = "btnCallus";
            this.btnCallus.Size = new System.Drawing.Size(125, 37);
            this.btnCallus.TabIndex = 3;
            this.btnCallus.Text = "聯絡客服";
            this.btnCallus.Click += new System.EventHandler(this.btnCallus_Click);
            // 
            // btnCustInfo
            // 
            this.btnCustInfo.AutoSize = true;
            this.btnCustInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCustInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustInfo.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCustInfo.ForeColor = System.Drawing.Color.White;
            this.btnCustInfo.Location = new System.Drawing.Point(518, 107);
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
            this.btnReturn.Location = new System.Drawing.Point(44, 13);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(133, 62);
            this.btnReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReturn.TabIndex = 16;
            this.btnReturn.TabStop = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // DataHistory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataHistory.ColumnHeadersHeight = 30;
            this.DataHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataHistory.Location = new System.Drawing.Point(595, 314);
            this.DataHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataHistory.Name = "DataHistory";
            this.DataHistory.ReadOnly = true;
            this.DataHistory.RowHeadersVisible = false;
            this.DataHistory.RowHeadersWidth = 51;
            this.DataHistory.RowTemplate.Height = 50;
            this.DataHistory.RowTemplate.ReadOnly = true;
            this.DataHistory.Size = new System.Drawing.Size(955, 549);
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
            // ShowPass
            // 
            this.ShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPass.Image = ((System.Drawing.Image)(resources.GetObject("ShowPass.Image")));
            this.ShowPass.Location = new System.Drawing.Point(1027, 186);
            this.ShowPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(48, 36);
            this.ShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPass.TabIndex = 19;
            this.ShowPass.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(693, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "會員資料";
            // 
            // CustCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1603, 930);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.DataHistory);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCustInfo);
            this.Controls.Add(this.btnCallus);
            this.Controls.Add(this.btnHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label btnHistory;
        private System.Windows.Forms.Label btnCallus;
        private System.Windows.Forms.Label btnCustInfo;
        private System.Windows.Forms.PictureBox btnReturn;
        private Guna.UI2.WinForms.Guna2DataGridView DataHistory;
        private System.Windows.Forms.PictureBox ShowPass;
        private System.Windows.Forms.Label label1;
    }
}