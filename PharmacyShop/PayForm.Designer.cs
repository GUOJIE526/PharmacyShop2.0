namespace PharmacyShop
{
    partial class PayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlPay = new System.Windows.Forms.Panel();
            this.QRCode = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnLinePay = new System.Windows.Forms.PictureBox();
            this.lblselectpay = new System.Windows.Forms.Label();
            this.pnlPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLinePay)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnlPay
            // 
            this.pnlPay.Controls.Add(this.QRCode);
            this.pnlPay.Controls.Add(this.btnClose);
            this.pnlPay.Controls.Add(this.btnLinePay);
            this.pnlPay.Controls.Add(this.lblselectpay);
            this.pnlPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPay.Location = new System.Drawing.Point(0, 0);
            this.pnlPay.Name = "pnlPay";
            this.pnlPay.Size = new System.Drawing.Size(494, 316);
            this.pnlPay.TabIndex = 0;
            this.pnlPay.Click += new System.EventHandler(this.pnlPay_Click);
            // 
            // QRCode
            // 
            this.QRCode.Image = ((System.Drawing.Image)(resources.GetObject("QRCode.Image")));
            this.QRCode.Location = new System.Drawing.Point(132, 94);
            this.QRCode.Name = "QRCode";
            this.QRCode.Size = new System.Drawing.Size(224, 186);
            this.QRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QRCode.TabIndex = 7;
            this.QRCode.TabStop = false;
            this.QRCode.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(425, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 33);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLinePay
            // 
            this.btnLinePay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinePay.Image = ((System.Drawing.Image)(resources.GetObject("btnLinePay.Image")));
            this.btnLinePay.Location = new System.Drawing.Point(145, 117);
            this.btnLinePay.Name = "btnLinePay";
            this.btnLinePay.Size = new System.Drawing.Size(197, 109);
            this.btnLinePay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLinePay.TabIndex = 5;
            this.btnLinePay.TabStop = false;
            this.btnLinePay.Click += new System.EventHandler(this.btnLinePay_Click);
            // 
            // lblselectpay
            // 
            this.lblselectpay.AutoSize = true;
            this.lblselectpay.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblselectpay.Location = new System.Drawing.Point(31, 50);
            this.lblselectpay.Name = "lblselectpay";
            this.lblselectpay.Size = new System.Drawing.Size(182, 31);
            this.lblselectpay.TabIndex = 4;
            this.lblselectpay.Text = "請選擇支付方式";
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 316);
            this.Controls.Add(this.pnlPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayForm";
            this.Load += new System.EventHandler(this.PayForm_Load);
            this.pnlPay.ResumeLayout(false);
            this.pnlPay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLinePay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel pnlPay;
        private System.Windows.Forms.PictureBox QRCode;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnLinePay;
        private System.Windows.Forms.Label lblselectpay;
    }
}