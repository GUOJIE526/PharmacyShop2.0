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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BabyForm));
            this.lsvBaby = new System.Windows.Forms.ListView();
            this.imglist = new System.Windows.Forms.ImageList(this.components);
            this.btnCell = new System.Windows.Forms.Button();
            this.btnPic = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.txtprodprice = new System.Windows.Forms.TextBox();
            this.txtprodname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.lblSumprice = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.PictureBox();
            this.btnPlus = new System.Windows.Forms.PictureBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtprodQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlus)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvBaby
            // 
            this.lsvBaby.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lsvBaby.HideSelection = false;
            this.lsvBaby.Location = new System.Drawing.Point(429, 40);
            this.lsvBaby.Name = "lsvBaby";
            this.lsvBaby.Size = new System.Drawing.Size(708, 590);
            this.lsvBaby.TabIndex = 0;
            this.lsvBaby.UseCompatibleStateImageBehavior = false;
            this.lsvBaby.ItemActivate += new System.EventHandler(this.lsvBaby_ItemActivate);
            // 
            // imglist
            // 
            this.imglist.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglist.ImageSize = new System.Drawing.Size(16, 16);
            this.imglist.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnCell
            // 
            this.btnCell.BackColor = System.Drawing.Color.LightCoral;
            this.btnCell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCell.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCell.Location = new System.Drawing.Point(66, 168);
            this.btnCell.Margin = new System.Windows.Forms.Padding(2);
            this.btnCell.Name = "btnCell";
            this.btnCell.Size = new System.Drawing.Size(113, 40);
            this.btnCell.TabIndex = 5;
            this.btnCell.Text = "列表模式";
            this.btnCell.UseVisualStyleBackColor = false;
            this.btnCell.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // btnPic
            // 
            this.btnPic.BackColor = System.Drawing.Color.LightCoral;
            this.btnPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPic.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPic.Location = new System.Drawing.Point(66, 111);
            this.btnPic.Margin = new System.Windows.Forms.Padding(2);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(113, 40);
            this.btnPic.TabIndex = 4;
            this.btnPic.Text = "圖片模式";
            this.btnPic.UseVisualStyleBackColor = false;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 44);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 10;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtprodprice
            // 
            this.txtprodprice.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtprodprice.Location = new System.Drawing.Point(141, 378);
            this.txtprodprice.Margin = new System.Windows.Forms.Padding(2);
            this.txtprodprice.Name = "txtprodprice";
            this.txtprodprice.ReadOnly = true;
            this.txtprodprice.Size = new System.Drawing.Size(244, 26);
            this.txtprodprice.TabIndex = 27;
            // 
            // txtprodname
            // 
            this.txtprodname.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtprodname.Location = new System.Drawing.Point(141, 340);
            this.txtprodname.Margin = new System.Windows.Forms.Padding(2);
            this.txtprodname.Name = "txtprodname";
            this.txtprodname.ReadOnly = true;
            this.txtprodname.Size = new System.Drawing.Size(244, 26);
            this.txtprodname.TabIndex = 26;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtid.Location = new System.Drawing.Point(141, 302);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(76, 26);
            this.txtid.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(17, 378);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "商品價格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(17, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "商品資訊";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(17, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "id";
            // 
            // btnAddCart
            // 
            this.btnAddCart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddCart.Location = new System.Drawing.Point(123, 606);
            this.btnAddCart.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(104, 35);
            this.btnAddCart.TabIndex = 30;
            this.btnAddCart.Text = "加入購物車";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // lblSumprice
            // 
            this.lblSumprice.AutoSize = true;
            this.lblSumprice.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSumprice.ForeColor = System.Drawing.Color.Maroon;
            this.lblSumprice.Location = new System.Drawing.Point(39, 533);
            this.lblSumprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSumprice.Name = "lblSumprice";
            this.lblSumprice.Size = new System.Drawing.Size(25, 28);
            this.lblSumprice.TabIndex = 47;
            this.lblSumprice.Text = "$";
            // 
            // btnMinus
            // 
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.Image = ((System.Drawing.Image)(resources.GetObject("btnMinus.Image")));
            this.btnMinus.Location = new System.Drawing.Point(230, 460);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(33, 35);
            this.btnMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinus.TabIndex = 46;
            this.btnMinus.TabStop = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Image = ((System.Drawing.Image)(resources.GetObject("btnPlus.Image")));
            this.btnPlus.Location = new System.Drawing.Point(87, 460);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(33, 35);
            this.btnPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlus.TabIndex = 45;
            this.btnPlus.TabStop = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtqty.Location = new System.Drawing.Point(141, 469);
            this.txtqty.Margin = new System.Windows.Forms.Padding(2);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(68, 26);
            this.txtqty.TabIndex = 44;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged);
            // 
            // txtprodQty
            // 
            this.txtprodQty.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtprodQty.Location = new System.Drawing.Point(141, 416);
            this.txtprodQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtprodQty.Name = "txtprodQty";
            this.txtprodQty.ReadOnly = true;
            this.txtprodQty.Size = new System.Drawing.Size(76, 26);
            this.txtprodQty.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(17, 416);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 48;
            this.label1.Text = "商品庫存量";
            // 
            // BabyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1160, 662);
            this.Controls.Add(this.txtprodQty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSumprice);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.txtprodprice);
            this.Controls.Add(this.txtprodname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCell);
            this.Controls.Add(this.btnPic);
            this.Controls.Add(this.lsvBaby);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BabyForm";
            this.Text = "BabyForm";
            this.Load += new System.EventHandler(this.BabyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imglist;
        private System.Windows.Forms.Button btnCell;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.PictureBox btnClose;
        public System.Windows.Forms.ListView lsvBaby;
        private System.Windows.Forms.TextBox txtprodprice;
        private System.Windows.Forms.TextBox txtprodname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Label lblSumprice;
        private System.Windows.Forms.PictureBox btnMinus;
        private System.Windows.Forms.PictureBox btnPlus;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtprodQty;
        private System.Windows.Forms.Label label1;
    }
}