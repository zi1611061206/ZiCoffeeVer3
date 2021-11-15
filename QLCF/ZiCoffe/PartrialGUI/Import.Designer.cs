namespace ZiCoffe.PartrialGUI
{
    partial class Import
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.grbImportInfo = new System.Windows.Forms.GroupBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.lbAmount = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lbPrice = new System.Windows.Forms.Label();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.lbMaterial = new System.Windows.Forms.Label();
            this.grbImport = new System.Windows.Forms.GroupBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.lbSupplier = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lstTempImport = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlData = new System.Windows.Forms.Panel();
            this.dtgImport = new System.Windows.Forms.DataGridView();
            this.dtgImportInfo = new System.Windows.Forms.DataGridView();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPushUp = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlInput.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.grbImportInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.grbImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgImportInfo)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.pnlInfo);
            this.pnlInput.Controls.Add(this.lstTempImport);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlInput.Location = new System.Drawing.Point(0, 459);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(1128, 213);
            this.pnlInput.TabIndex = 0;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlInfo.Controls.Add(this.grbImportInfo);
            this.pnlInfo.Controls.Add(this.grbImport);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(573, 213);
            this.pnlInfo.TabIndex = 0;
            // 
            // grbImportInfo
            // 
            this.grbImportInfo.Controls.Add(this.btnRequest);
            this.grbImportInfo.Controls.Add(this.nudAmount);
            this.grbImportInfo.Controls.Add(this.lbAmount);
            this.grbImportInfo.Controls.Add(this.nudPrice);
            this.grbImportInfo.Controls.Add(this.lbPrice);
            this.grbImportInfo.Controls.Add(this.cbMaterial);
            this.grbImportInfo.Controls.Add(this.lbMaterial);
            this.grbImportInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbImportInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbImportInfo.Location = new System.Drawing.Point(0, 106);
            this.grbImportInfo.Name = "grbImportInfo";
            this.grbImportInfo.Size = new System.Drawing.Size(573, 107);
            this.grbImportInfo.TabIndex = 0;
            this.grbImportInfo.TabStop = false;
            this.grbImportInfo.Text = "Chi tiết phiếu nhập";
            // 
            // btnRequest
            // 
            this.btnRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnRequest.ForeColor = System.Drawing.Color.White;
            this.btnRequest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRequest.Location = new System.Drawing.Point(422, 60);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(139, 32);
            this.btnRequest.TabIndex = 6;
            this.btnRequest.Text = "Yêu cầu";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmount.Location = new System.Drawing.Point(422, 29);
            this.nudAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(139, 26);
            this.nudAmount.TabIndex = 4;
            this.nudAmount.ValueChanged += new System.EventHandler(this.nudAmount_ValueChanged);
            // 
            // lbAmount
            // 
            this.lbAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(329, 31);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(87, 19);
            this.lbAmount.TabIndex = 0;
            this.lbAmount.Text = "Số lượng:";
            // 
            // nudPrice
            // 
            this.nudPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrice.Location = new System.Drawing.Point(133, 65);
            this.nudPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(187, 26);
            this.nudPrice.TabIndex = 5;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(6, 67);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(118, 19);
            this.lbPrice.TabIndex = 0;
            this.lbPrice.Text = "Đơn giá nhập:";
            // 
            // cbMaterial
            // 
            this.cbMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(133, 28);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(187, 26);
            this.cbMaterial.Sorted = true;
            this.cbMaterial.TabIndex = 3;
            // 
            // lbMaterial
            // 
            this.lbMaterial.AutoSize = true;
            this.lbMaterial.Location = new System.Drawing.Point(6, 31);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(106, 19);
            this.lbMaterial.TabIndex = 0;
            this.lbMaterial.Text = "Nguyên liệu:";
            // 
            // grbImport
            // 
            this.grbImport.Controls.Add(this.picDelete);
            this.grbImport.Controls.Add(this.picAdd);
            this.grbImport.Controls.Add(this.cbSupplier);
            this.grbImport.Controls.Add(this.lbSupplier);
            this.grbImport.Controls.Add(this.panel2);
            this.grbImport.Controls.Add(this.txbID);
            this.grbImport.Controls.Add(this.lbID);
            this.grbImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbImport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbImport.Location = new System.Drawing.Point(0, 0);
            this.grbImport.Name = "grbImport";
            this.grbImport.Size = new System.Drawing.Size(573, 106);
            this.grbImport.TabIndex = 0;
            this.grbImport.TabStop = false;
            this.grbImport.Text = "Phiếu nhập";
            // 
            // picDelete
            // 
            this.picDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDelete.ErrorImage = null;
            this.picDelete.Image = global::ZiCoffe.Properties.Resources.btndelete;
            this.picDelete.Location = new System.Drawing.Point(536, 25);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(25, 25);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 27;
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            // 
            // picAdd
            // 
            this.picAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAdd.Image = global::ZiCoffe.Properties.Resources.btnadd;
            this.picAdd.Location = new System.Drawing.Point(536, 65);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(25, 25);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd.TabIndex = 26;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // cbSupplier
            // 
            this.cbSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(133, 64);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(397, 26);
            this.cbSupplier.Sorted = true;
            this.cbSupplier.TabIndex = 2;
            // 
            // lbSupplier
            // 
            this.lbSupplier.AutoSize = true;
            this.lbSupplier.Location = new System.Drawing.Point(6, 67);
            this.lbSupplier.Name = "lbSupplier";
            this.lbSupplier.Size = new System.Drawing.Size(121, 19);
            this.lbSupplier.TabIndex = 0;
            this.lbSupplier.Text = "Nhà cung cấp:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(10, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 1);
            this.panel2.TabIndex = 0;
            // 
            // txbID
            // 
            this.txbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbID.Cursor = System.Windows.Forms.Cursors.No;
            this.txbID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txbID.Location = new System.Drawing.Point(133, 31);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(397, 19);
            this.txbID.TabIndex = 1;
            this.txbID.TabStop = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(6, 31);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(84, 19);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã phiếu:";
            // 
            // lstTempImport
            // 
            this.lstTempImport.BackColor = System.Drawing.Color.White;
            this.lstTempImport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstTempImport.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstTempImport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTempImport.GridLines = true;
            this.lstTempImport.Location = new System.Drawing.Point(573, 0);
            this.lstTempImport.Name = "lstTempImport";
            this.lstTempImport.Size = new System.Drawing.Size(555, 213);
            this.lstTempImport.TabIndex = 0;
            this.lstTempImport.UseCompatibleStateImageBehavior = false;
            this.lstTempImport.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã phiếu";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên nguyên liệu";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 223;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng nhập";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 129;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá nhập";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã nguyên liệu";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dtgImport);
            this.pnlData.Controls.Add(this.dtgImportInfo);
            this.pnlData.Controls.Add(this.pnlButton);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(1128, 459);
            this.pnlData.TabIndex = 0;
            // 
            // dtgImport
            // 
            this.dtgImport.AllowUserToAddRows = false;
            this.dtgImport.AllowUserToDeleteRows = false;
            this.dtgImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgImport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgImport.Location = new System.Drawing.Point(0, 0);
            this.dtgImport.Name = "dtgImport";
            this.dtgImport.ReadOnly = true;
            this.dtgImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgImport.Size = new System.Drawing.Size(577, 413);
            this.dtgImport.TabIndex = 0;
            this.dtgImport.TabStop = false;
            this.dtgImport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgImport_CellClick);
            this.dtgImport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgImport_KeyDown);
            // 
            // dtgImportInfo
            // 
            this.dtgImportInfo.AllowUserToAddRows = false;
            this.dtgImportInfo.AllowUserToDeleteRows = false;
            this.dtgImportInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgImportInfo.BackgroundColor = System.Drawing.Color.White;
            this.dtgImportInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgImportInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgImportInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgImportInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtgImportInfo.Location = new System.Drawing.Point(577, 0);
            this.dtgImportInfo.Name = "dtgImportInfo";
            this.dtgImportInfo.ReadOnly = true;
            this.dtgImportInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgImportInfo.Size = new System.Drawing.Size(551, 413);
            this.dtgImportInfo.TabIndex = 0;
            this.dtgImportInfo.TabStop = false;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnCancel);
            this.pnlButton.Controls.Add(this.btnPushUp);
            this.pnlButton.Controls.Add(this.btnDelete);
            this.pnlButton.Controls.Add(this.btnAdd);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButton.Location = new System.Drawing.Point(0, 413);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(1128, 46);
            this.pnlButton.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::ZiCoffe.Properties.Resources.remove_button;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(841, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPushUp
            // 
            this.btnPushUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPushUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnPushUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPushUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPushUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnPushUp.ForeColor = System.Drawing.Color.White;
            this.btnPushUp.Image = global::ZiCoffe.Properties.Resources.check;
            this.btnPushUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPushUp.Location = new System.Drawing.Point(986, 6);
            this.btnPushUp.Name = "btnPushUp";
            this.btnPushUp.Size = new System.Drawing.Size(139, 32);
            this.btnPushUp.TabIndex = 4;
            this.btnPushUp.Text = "Đẩy lên";
            this.btnPushUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPushUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPushUp.UseVisualStyleBackColor = false;
            this.btnPushUp.Click += new System.EventHandler(this.btnPushUp_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(148, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa phiếu nhập";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(3, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Tạo phiếu mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 672);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlInput);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Import";
            this.Text = "Import";
            this.Load += new System.EventHandler(this.Import_Load);
            this.pnlInput.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.grbImportInfo.ResumeLayout(false);
            this.grbImportInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.grbImport.ResumeLayout(false);
            this.grbImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgImportInfo)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.GroupBox grbImportInfo;
        private System.Windows.Forms.GroupBox grbImport;
        private System.Windows.Forms.ListView lstTempImport;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DataGridView dtgImport;
        private System.Windows.Forms.DataGridView dtgImportInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Label lbMaterial;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label lbSupplier;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnPushUp;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnCancel;
    }
}