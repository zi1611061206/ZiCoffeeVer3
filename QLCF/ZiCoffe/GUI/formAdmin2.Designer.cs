namespace ZiCoffe.GUI
{
    partial class formAdmin2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdmin2));
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnPreparation = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnOnline = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.lbAdmin = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.picMenuBar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbCompany = new System.Windows.Forms.Label();
            this.pnlControlers = new System.Windows.Forms.Panel();
            this.toolTipForButton = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipForPictureBox = new System.Windows.Forms.ToolTip(this.components);
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlToolbar.Controls.Add(this.btnPreparation);
            this.pnlToolbar.Controls.Add(this.btnImport);
            this.pnlToolbar.Controls.Add(this.btnContact);
            this.pnlToolbar.Controls.Add(this.btnOnline);
            this.pnlToolbar.Controls.Add(this.btnTable);
            this.pnlToolbar.Controls.Add(this.btnStaff);
            this.pnlToolbar.Controls.Add(this.btnSupplier);
            this.pnlToolbar.Controls.Add(this.btnMaterial);
            this.pnlToolbar.Controls.Add(this.btnDrinks);
            this.pnlToolbar.Controls.Add(this.btnRevenue);
            this.pnlToolbar.Controls.Add(this.pnlLine);
            this.pnlToolbar.Controls.Add(this.lbAdmin);
            this.pnlToolbar.Controls.Add(this.picLogo);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlToolbar.ForeColor = System.Drawing.Color.White;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(205, 710);
            this.pnlToolbar.TabIndex = 0;
            // 
            // btnPreparation
            // 
            this.btnPreparation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnPreparation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreparation.FlatAppearance.BorderSize = 0;
            this.btnPreparation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPreparation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPreparation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreparation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreparation.ForeColor = System.Drawing.Color.White;
            this.btnPreparation.Image = global::ZiCoffe.Properties.Resources.bartender2;
            this.btnPreparation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreparation.Location = new System.Drawing.Point(12, 322);
            this.btnPreparation.Name = "btnPreparation";
            this.btnPreparation.Size = new System.Drawing.Size(193, 32);
            this.btnPreparation.TabIndex = 0;
            this.btnPreparation.TabStop = false;
            this.btnPreparation.Tag = "";
            this.btnPreparation.Text = "       Pha chế";
            this.btnPreparation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipForButton.SetToolTip(this.btnPreparation, "Thông tin liên hệ");
            this.btnPreparation.UseVisualStyleBackColor = false;
            this.btnPreparation.Click += new System.EventHandler(this.btnPreparation_Click);
            this.btnPreparation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allButton_MouseDown);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Image = global::ZiCoffe.Properties.Resources.whitecart;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(12, 284);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(193, 32);
            this.btnImport.TabIndex = 0;
            this.btnImport.TabStop = false;
            this.btnImport.Tag = "";
            this.btnImport.Text = "       Phiếu nhập";
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipForButton.SetToolTip(this.btnImport, "Quản lý thông tin trực tuyến");
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            this.btnImport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allButton_MouseDown);
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContact.FlatAppearance.BorderSize = 0;
            this.btnContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.ForeColor = System.Drawing.Color.White;
            this.btnContact.Image = global::ZiCoffe.Properties.Resources.contactwhite;
            this.btnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.Location = new System.Drawing.Point(12, 398);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(193, 32);
            this.btnContact.TabIndex = 0;
            this.btnContact.TabStop = false;
            this.btnContact.Tag = "";
            this.btnContact.Text = "       Liên hệ";
            this.btnContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipForButton.SetToolTip(this.btnContact, "Thông tin liên hệ");
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            this.btnContact.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allButton_MouseDown);
            // 
            // btnOnline
            // 
            this.btnOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnOnline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnline.FlatAppearance.BorderSize = 0;
            this.btnOnline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOnline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnline.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnline.ForeColor = System.Drawing.Color.White;
            this.btnOnline.Image = global::ZiCoffe.Properties.Resources.internetwhite;
            this.btnOnline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnline.Location = new System.Drawing.Point(12, 360);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(193, 32);
            this.btnOnline.TabIndex = 0;
            this.btnOnline.TabStop = false;
            this.btnOnline.Tag = "";
            this.btnOnline.Text = "       Trực tuyến";
            this.btnOnline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipForButton.SetToolTip(this.btnOnline, "Quản lý thông tin trực tuyến");
            this.btnOnline.UseVisualStyleBackColor = false;
            this.btnOnline.Click += new System.EventHandler(this.btnOnline_Click);
            this.btnOnline.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allButton_MouseDown);
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.ForeColor = System.Drawing.Color.White;
            this.btnTable.Image = global::ZiCoffe.Properties.Resources.tablewhite;
            this.btnTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTable.Location = new System.Drawing.Point(12, 170);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(193, 32);
            this.btnTable.TabIndex = 0;
            this.btnTable.TabStop = false;
            this.btnTable.Tag = "";
            this.btnTable.Text = "       Bàn";
            this.btnTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipForButton.SetToolTip(this.btnTable, "Quản lý danh sách bàn");
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            this.btnTable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allButton_MouseDown);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = global::ZiCoffe.Properties.Resources.staffwhite;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(12, 132);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(193, 32);
            this.btnStaff.TabIndex = 0;
            this.btnStaff.TabStop = false;
            this.btnStaff.Tag = "";
            this.btnStaff.Text = "       Nhân viên";
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipForButton.SetToolTip(this.btnStaff, "Quản lý nhân viên");
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            this.btnStaff.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allButton_MouseDown);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.Image = global::ZiCoffe.Properties.Resources.supplierwhite;
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.Location = new System.Drawing.Point(12, 208);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(193, 32);
            this.btnSupplier.TabIndex = 0;
            this.btnSupplier.TabStop = false;
            this.btnSupplier.Tag = "";
            this.btnSupplier.Text = "       Nhà cung cấp";
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipForButton.SetToolTip(this.btnSupplier, "Quản lý thông tin nhà cung cấp");
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            this.btnSupplier.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allButton_MouseDown);
            // 
            // btnMaterial
            // 
            this.btnMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaterial.FlatAppearance.BorderSize = 0;
            this.btnMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterial.ForeColor = System.Drawing.Color.White;
            this.btnMaterial.Image = global::ZiCoffe.Properties.Resources.preparetionwhite;
            this.btnMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterial.Location = new System.Drawing.Point(12, 246);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(193, 32);
            this.btnMaterial.TabIndex = 0;
            this.btnMaterial.TabStop = false;
            this.btnMaterial.Tag = "";
            this.btnMaterial.Text = "       Nguyên Liệu";
            this.btnMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipForButton.SetToolTip(this.btnMaterial, "Quản lý nguyên liệu");
            this.btnMaterial.UseVisualStyleBackColor = false;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            this.btnMaterial.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allButton_MouseDown);
            // 
            // btnDrinks
            // 
            this.btnDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnDrinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrinks.FlatAppearance.BorderSize = 0;
            this.btnDrinks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDrinks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrinks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrinks.ForeColor = System.Drawing.Color.White;
            this.btnDrinks.Image = global::ZiCoffe.Properties.Resources.drinkswhite;
            this.btnDrinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrinks.Location = new System.Drawing.Point(12, 94);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(193, 32);
            this.btnDrinks.TabIndex = 0;
            this.btnDrinks.TabStop = false;
            this.btnDrinks.Tag = "";
            this.btnDrinks.Text = "       Thực đơn";
            this.btnDrinks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipForButton.SetToolTip(this.btnDrinks, "Quản lý Thực đơn");
            this.btnDrinks.UseVisualStyleBackColor = false;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            this.btnDrinks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allButton_MouseDown);
            // 
            // btnRevenue
            // 
            this.btnRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnRevenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevenue.FlatAppearance.BorderSize = 0;
            this.btnRevenue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRevenue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.ForeColor = System.Drawing.Color.White;
            this.btnRevenue.Image = global::ZiCoffe.Properties.Resources.revenuewhite;
            this.btnRevenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevenue.Location = new System.Drawing.Point(12, 56);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(193, 32);
            this.btnRevenue.TabIndex = 0;
            this.btnRevenue.TabStop = false;
            this.btnRevenue.Tag = "";
            this.btnRevenue.Text = "       Doanh thu";
            this.btnRevenue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipForButton.SetToolTip(this.btnRevenue, "Thống kê doanh thu");
            this.btnRevenue.UseVisualStyleBackColor = false;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            this.btnRevenue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allButton_MouseDown);
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlLine.Location = new System.Drawing.Point(0, 49);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(205, 1);
            this.pnlLine.TabIndex = 0;
            // 
            // lbAdmin
            // 
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lbAdmin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdmin.ForeColor = System.Drawing.Color.White;
            this.lbAdmin.Location = new System.Drawing.Point(61, 14);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(128, 22);
            this.lbAdmin.TabIndex = 0;
            this.lbAdmin.Text = "Quản trị viên";
            this.lbAdmin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::ZiCoffe.Properties.Resources.logox;
            this.picLogo.Location = new System.Drawing.Point(4, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(45, 45);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 23;
            this.picLogo.TabStop = false;
            this.picLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlTitle.Controls.Add(this.lbTitle);
            this.pnlTitle.Controls.Add(this.picMenuBar);
            this.pnlTitle.Controls.Add(this.pictureBox3);
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Controls.Add(this.pictureBox4);
            this.pnlTitle.Controls.Add(this.pictureBox2);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.ForeColor = System.Drawing.Color.White;
            this.pnlTitle.Location = new System.Drawing.Point(205, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1015, 50);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(338, 14);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(338, 22);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Zi Coffee Shop Managerment - CSM";
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // picMenuBar
            // 
            this.picMenuBar.Image = global::ZiCoffe.Properties.Resources.menuwhite1;
            this.picMenuBar.Location = new System.Drawing.Point(5, 2);
            this.picMenuBar.Name = "picMenuBar";
            this.picMenuBar.Size = new System.Drawing.Size(45, 45);
            this.picMenuBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuBar.TabIndex = 24;
            this.picMenuBar.TabStop = false;
            this.toolTipForPictureBox.SetToolTip(this.picMenuBar, "Danh sách quản trị");
            this.picMenuBar.Click += new System.EventHandler(this.picMenuBar_Click);
            this.picMenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allButton_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::ZiCoffe.Properties.Resources.minimizeWhite;
            this.pictureBox3.Location = new System.Drawing.Point(938, 4);
            this.pictureBox3.MaximumSize = new System.Drawing.Size(25, 25);
            this.pictureBox3.MinimumSize = new System.Drawing.Size(20, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            this.toolTipForPictureBox.SetToolTip(this.pictureBox3, "Minimize");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ZiCoffe.Properties.Resources.closewhite;
            this.pictureBox1.Location = new System.Drawing.Point(990, 4);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(25, 25);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.toolTipForPictureBox.SetToolTip(this.pictureBox1, "Close");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::ZiCoffe.Properties.Resources.normal_screen;
            this.pictureBox4.Location = new System.Drawing.Point(964, 3);
            this.pictureBox4.MaximumSize = new System.Drawing.Size(25, 25);
            this.pictureBox4.MinimumSize = new System.Drawing.Size(20, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            this.toolTipForPictureBox.SetToolTip(this.pictureBox4, "Nomal");
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::ZiCoffe.Properties.Resources.fullscreenwhite;
            this.pictureBox2.Location = new System.Drawing.Point(964, 4);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(25, 25);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(20, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.toolTipForPictureBox.SetToolTip(this.pictureBox2, "Maximize");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlFooter.Controls.Add(this.lbVersion);
            this.pnlFooter.Controls.Add(this.lbCompany);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.ForeColor = System.Drawing.Color.White;
            this.pnlFooter.Location = new System.Drawing.Point(205, 687);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1015, 23);
            this.pnlFooter.TabIndex = 0;
            // 
            // lbVersion
            // 
            this.lbVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.Location = new System.Drawing.Point(568, 1);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(75, 16);
            this.lbVersion.TabIndex = 0;
            this.lbVersion.Text = "ZI Coffee v3.0";
            // 
            // lbCompany
            // 
            this.lbCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCompany.AutoSize = true;
            this.lbCompany.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompany.Location = new System.Drawing.Point(867, 1);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(145, 16);
            this.lbCompany.TabIndex = 0;
            this.lbCompany.Text = "Copyright © 2020 ZiTech Co";
            this.lbCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlControlers
            // 
            this.pnlControlers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControlers.Location = new System.Drawing.Point(205, 50);
            this.pnlControlers.Name = "pnlControlers";
            this.pnlControlers.Size = new System.Drawing.Size(1015, 637);
            this.pnlControlers.TabIndex = 1;
            // 
            // formAdmin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 710);
            this.Controls.Add(this.pnlControlers);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlToolbar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formAdmin2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.formAdmin2_Load);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Label lbAdmin;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnOnline;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picMenuBar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbCompany;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlControlers;
        private System.Windows.Forms.ToolTip toolTipForButton;
        private System.Windows.Forms.ToolTip toolTipForPictureBox;
        private System.Windows.Forms.Button btnPreparation;
        private System.Windows.Forms.Button btnImport;
    }
}