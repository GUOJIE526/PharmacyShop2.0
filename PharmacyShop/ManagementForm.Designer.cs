namespace PharmacyShop
{
    partial class ManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlMgr = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCustSYS = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnOrdSYS = new System.Windows.Forms.Button();
            this.tabctrl = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabBaby = new System.Windows.Forms.TabPage();
            this.tabBeauty = new System.Windows.Forms.TabPage();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtimg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabMed = new System.Windows.Forms.TabPage();
            this.dataBaby = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataBeauty = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataMed = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlMgr.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.tabctrl.SuspendLayout();
            this.tabBaby.SuspendLayout();
            this.tabBeauty.SuspendLayout();
            this.tabMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBeauty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMed)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnlMgr
            // 
            this.pnlMgr.Controls.Add(this.btnClear);
            this.pnlMgr.Controls.Add(this.btnDelete);
            this.pnlMgr.Controls.Add(this.btnInsert);
            this.pnlMgr.Controls.Add(this.btnUpdate);
            this.pnlMgr.Controls.Add(this.txtimg);
            this.pnlMgr.Controls.Add(this.label2);
            this.pnlMgr.Controls.Add(this.txtQty);
            this.pnlMgr.Controls.Add(this.label1);
            this.pnlMgr.Controls.Add(this.txtid);
            this.pnlMgr.Controls.Add(this.lblid);
            this.pnlMgr.Controls.Add(this.txtPrice);
            this.pnlMgr.Controls.Add(this.lblphone);
            this.pnlMgr.Controls.Add(this.txtProdName);
            this.pnlMgr.Controls.Add(this.lbluser);
            this.pnlMgr.Controls.Add(this.tabctrl);
            this.pnlMgr.Controls.Add(this.panel1);
            this.pnlMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMgr.Location = new System.Drawing.Point(0, 0);
            this.pnlMgr.Name = "pnlMgr";
            this.pnlMgr.Size = new System.Drawing.Size(1150, 700);
            this.pnlMgr.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btnOrdSYS);
            this.panel1.Controls.Add(this.btnCustSYS);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 120);
            this.panel1.TabIndex = 1;
            // 
            // btnCustSYS
            // 
            this.btnCustSYS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustSYS.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCustSYS.Location = new System.Drawing.Point(114, 59);
            this.btnCustSYS.Name = "btnCustSYS";
            this.btnCustSYS.Size = new System.Drawing.Size(111, 45);
            this.btnCustSYS.TabIndex = 1;
            this.btnCustSYS.Text = "會員管理";
            this.btnCustSYS.UseVisualStyleBackColor = true;
            this.btnCustSYS.Click += new System.EventHandler(this.btnCustSYS_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1102, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 50);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOrdSYS
            // 
            this.btnOrdSYS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdSYS.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrdSYS.Location = new System.Drawing.Point(288, 59);
            this.btnOrdSYS.Name = "btnOrdSYS";
            this.btnOrdSYS.Size = new System.Drawing.Size(111, 45);
            this.btnOrdSYS.TabIndex = 2;
            this.btnOrdSYS.Text = "訂單管理";
            this.btnOrdSYS.UseVisualStyleBackColor = true;
            this.btnOrdSYS.Click += new System.EventHandler(this.btnOrdSYS_Click);
            // 
            // tabctrl
            // 
            this.tabctrl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabctrl.Controls.Add(this.tabBaby);
            this.tabctrl.Controls.Add(this.tabBeauty);
            this.tabctrl.Controls.Add(this.tabMed);
            this.tabctrl.ItemSize = new System.Drawing.Size(180, 40);
            this.tabctrl.Location = new System.Drawing.Point(410, 171);
            this.tabctrl.Name = "tabctrl";
            this.tabctrl.SelectedIndex = 0;
            this.tabctrl.Size = new System.Drawing.Size(728, 485);
            this.tabctrl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabctrl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabctrl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabctrl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabctrl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabctrl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabctrl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabctrl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabctrl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabctrl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabctrl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabctrl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabctrl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabctrl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabctrl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabctrl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabctrl.TabIndex = 2;
            this.tabctrl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabBaby
            // 
            this.tabBaby.Controls.Add(this.dataBaby);
            this.tabBaby.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabBaby.Location = new System.Drawing.Point(184, 4);
            this.tabBaby.Name = "tabBaby";
            this.tabBaby.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaby.Size = new System.Drawing.Size(540, 477);
            this.tabBaby.TabIndex = 0;
            this.tabBaby.Text = "婦幼";
            this.tabBaby.UseVisualStyleBackColor = true;
            // 
            // tabBeauty
            // 
            this.tabBeauty.Controls.Add(this.dataBeauty);
            this.tabBeauty.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabBeauty.Location = new System.Drawing.Point(184, 4);
            this.tabBeauty.Name = "tabBeauty";
            this.tabBeauty.Padding = new System.Windows.Forms.Padding(3);
            this.tabBeauty.Size = new System.Drawing.Size(540, 477);
            this.tabBeauty.TabIndex = 1;
            this.tabBeauty.Text = "美顏";
            this.tabBeauty.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtid.Location = new System.Drawing.Point(114, 236);
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
            this.lblid.Location = new System.Drawing.Point(36, 239);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(27, 21);
            this.lblid.TabIndex = 76;
            this.lblid.Text = "ID";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(114, 354);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(186, 29);
            this.txtPrice.TabIndex = 75;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblphone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblphone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblphone.ForeColor = System.Drawing.Color.Black;
            this.lblphone.Location = new System.Drawing.Point(36, 357);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(42, 21);
            this.lblphone.TabIndex = 74;
            this.lblphone.Text = "價格";
            // 
            // txtProdName
            // 
            this.txtProdName.BackColor = System.Drawing.Color.White;
            this.txtProdName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProdName.Location = new System.Drawing.Point(114, 295);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(285, 29);
            this.txtProdName.TabIndex = 71;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbluser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbluser.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbluser.ForeColor = System.Drawing.Color.Black;
            this.lbluser.Location = new System.Drawing.Point(34, 298);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(74, 21);
            this.lbluser.TabIndex = 68;
            this.lbluser.Text = "商品名稱";
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.White;
            this.txtQty.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtQty.Location = new System.Drawing.Point(114, 413);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(186, 29);
            this.txtQty.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 78;
            this.label1.Text = "數量";
            // 
            // txtimg
            // 
            this.txtimg.BackColor = System.Drawing.Color.White;
            this.txtimg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtimg.Location = new System.Drawing.Point(114, 472);
            this.txtimg.Name = "txtimg";
            this.txtimg.Size = new System.Drawing.Size(186, 29);
            this.txtimg.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 80;
            this.label2.Text = "照片";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(201, 537);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 34);
            this.btnDelete.TabIndex = 84;
            this.btnDelete.Text = "下架";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert.Location = new System.Drawing.Point(114, 537);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(81, 34);
            this.btnInsert.TabIndex = 83;
            this.btnInsert.Text = "上架";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(27, 537);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 34);
            this.btnUpdate.TabIndex = 82;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tabMed
            // 
            this.tabMed.Controls.Add(this.dataMed);
            this.tabMed.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabMed.Location = new System.Drawing.Point(184, 4);
            this.tabMed.Name = "tabMed";
            this.tabMed.Size = new System.Drawing.Size(540, 477);
            this.tabMed.TabIndex = 2;
            this.tabMed.Text = "保健";
            this.tabMed.UseVisualStyleBackColor = true;
            // 
            // dataBaby
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dataBaby.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataBaby.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataBaby.ColumnHeadersHeight = 30;
            this.dataBaby.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataBaby.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataBaby.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataBaby.Location = new System.Drawing.Point(3, 3);
            this.dataBaby.Name = "dataBaby";
            this.dataBaby.ReadOnly = true;
            this.dataBaby.RowHeadersVisible = false;
            this.dataBaby.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataBaby.RowTemplate.Height = 30;
            this.dataBaby.Size = new System.Drawing.Size(534, 468);
            this.dataBaby.TabIndex = 0;
            this.dataBaby.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataBaby.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataBaby.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataBaby.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataBaby.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataBaby.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataBaby.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataBaby.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataBaby.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataBaby.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataBaby.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataBaby.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataBaby.ThemeStyle.HeaderStyle.Height = 30;
            this.dataBaby.ThemeStyle.ReadOnly = true;
            this.dataBaby.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataBaby.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataBaby.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataBaby.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataBaby.ThemeStyle.RowsStyle.Height = 30;
            this.dataBaby.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataBaby.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataBaby.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBaby_CellContentClick);
            // 
            // dataBeauty
            // 
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.dataBeauty.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataBeauty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataBeauty.ColumnHeadersHeight = 30;
            this.dataBeauty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataBeauty.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataBeauty.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataBeauty.Location = new System.Drawing.Point(3, 4);
            this.dataBeauty.Name = "dataBeauty";
            this.dataBeauty.ReadOnly = true;
            this.dataBeauty.RowHeadersVisible = false;
            this.dataBeauty.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataBeauty.RowTemplate.Height = 30;
            this.dataBeauty.Size = new System.Drawing.Size(534, 468);
            this.dataBeauty.TabIndex = 1;
            this.dataBeauty.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataBeauty.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataBeauty.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataBeauty.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataBeauty.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataBeauty.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataBeauty.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataBeauty.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataBeauty.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataBeauty.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataBeauty.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataBeauty.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataBeauty.ThemeStyle.HeaderStyle.Height = 30;
            this.dataBeauty.ThemeStyle.ReadOnly = true;
            this.dataBeauty.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataBeauty.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataBeauty.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataBeauty.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataBeauty.ThemeStyle.RowsStyle.Height = 30;
            this.dataBeauty.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataBeauty.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataBeauty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBeauty_CellContentClick);
            // 
            // dataMed
            // 
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.dataMed.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dataMed.ColumnHeadersHeight = 30;
            this.dataMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataMed.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataMed.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataMed.Location = new System.Drawing.Point(3, 4);
            this.dataMed.Name = "dataMed";
            this.dataMed.ReadOnly = true;
            this.dataMed.RowHeadersVisible = false;
            this.dataMed.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataMed.RowTemplate.Height = 30;
            this.dataMed.Size = new System.Drawing.Size(534, 468);
            this.dataMed.TabIndex = 1;
            this.dataMed.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataMed.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataMed.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataMed.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataMed.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataMed.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataMed.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataMed.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataMed.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataMed.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataMed.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataMed.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataMed.ThemeStyle.HeaderStyle.Height = 30;
            this.dataMed.ThemeStyle.ReadOnly = true;
            this.dataMed.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataMed.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataMed.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataMed.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataMed.ThemeStyle.RowsStyle.Height = 30;
            this.dataMed.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataMed.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataMed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMed_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(288, 537);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 34);
            this.btnClear.TabIndex = 85;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(186)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1150, 700);
            this.Controls.Add(this.pnlMgr);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagementForm";
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.pnlMgr.ResumeLayout(false);
            this.pnlMgr.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.tabctrl.ResumeLayout(false);
            this.tabBaby.ResumeLayout(false);
            this.tabBeauty.ResumeLayout(false);
            this.tabMed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBeauty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel pnlMgr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOrdSYS;
        private System.Windows.Forms.Button btnCustSYS;
        private System.Windows.Forms.PictureBox btnClose;
        private Guna.UI2.WinForms.Guna2TabControl tabctrl;
        private System.Windows.Forms.TabPage tabBaby;
        private System.Windows.Forms.TabPage tabBeauty;
        private System.Windows.Forms.TextBox txtimg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private Guna.UI2.WinForms.Guna2DataGridView dataBaby;
        private Guna.UI2.WinForms.Guna2DataGridView dataBeauty;
        private System.Windows.Forms.TabPage tabMed;
        private Guna.UI2.WinForms.Guna2DataGridView dataMed;
        private System.Windows.Forms.Button btnClear;
    }
}