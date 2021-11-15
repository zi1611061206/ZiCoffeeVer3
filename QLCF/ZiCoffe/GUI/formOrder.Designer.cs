namespace ZiCoffe.GUI
{
    partial class formOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOrder));
            this.pnlOderOption = new System.Windows.Forms.Panel();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.lbCartAmount = new ZiCoffe.Items.LabelItems();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbSearchMenu = new System.Windows.Forms.TextBox();
            this.picCart = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCartConfirm = new System.Windows.Forms.Button();
            this.ttDescription = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.lstViewCart = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.pnlOderOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCart)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.pnlCart.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOderOption
            // 
            this.pnlOderOption.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlOderOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOderOption.Controls.Add(this.txbTotal);
            this.pnlOderOption.Controls.Add(this.lbCartAmount);
            this.pnlOderOption.Controls.Add(this.panel4);
            this.pnlOderOption.Controls.Add(this.txbSearchMenu);
            this.pnlOderOption.Controls.Add(this.picCart);
            this.pnlOderOption.Controls.Add(this.btnCancel);
            this.pnlOderOption.Controls.Add(this.btnCartConfirm);
            this.pnlOderOption.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOderOption.Location = new System.Drawing.Point(0, 661);
            this.pnlOderOption.Name = "pnlOderOption";
            this.pnlOderOption.Size = new System.Drawing.Size(1220, 49);
            this.pnlOderOption.TabIndex = 0;
            // 
            // txbTotal
            // 
            this.txbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbTotal.Cursor = System.Windows.Forms.Cursors.No;
            this.txbTotal.ForeColor = System.Drawing.Color.Red;
            this.txbTotal.Location = new System.Drawing.Point(709, 12);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.ReadOnly = true;
            this.txbTotal.Size = new System.Drawing.Size(154, 26);
            this.txbTotal.TabIndex = 27;
            this.txbTotal.TabStop = false;
            // 
            // lbCartAmount
            // 
            this.lbCartAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCartAmount.AutoSize = true;
            this.lbCartAmount.BackColor = System.Drawing.Color.Red;
            this.lbCartAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCartAmount.ForeColor = System.Drawing.Color.White;
            this.lbCartAmount.Location = new System.Drawing.Point(880, 23);
            this.lbCartAmount.Name = "lbCartAmount";
            this.lbCartAmount.Padding = new System.Windows.Forms.Padding(1);
            this.lbCartAmount.Size = new System.Drawing.Size(28, 20);
            this.lbCartAmount.TabIndex = 26;
            this.lbCartAmount.Text = "10";
            this.lbCartAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCartAmount.Click += new System.EventHandler(this.lbCartAmount_Click);
            this.lbCartAmount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allButton_MouseDown);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(12, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(599, 1);
            this.panel4.TabIndex = 0;
            // 
            // txbSearchMenu
            // 
            this.txbSearchMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbSearchMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbSearchMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSearchMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txbSearchMenu.Location = new System.Drawing.Point(12, 14);
            this.txbSearchMenu.Name = "txbSearchMenu";
            this.txbSearchMenu.Size = new System.Drawing.Size(599, 19);
            this.txbSearchMenu.TabIndex = 0;
            this.txbSearchMenu.Text = "(Nhập kí tự cần tìm kiếm)";
            this.txbSearchMenu.Click += new System.EventHandler(this.txbSearchMenu_Click);
            this.txbSearchMenu.TextChanged += new System.EventHandler(this.txbSearchMenu_TextChanged);
            // 
            // picCart
            // 
            this.picCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCart.Image = ((System.Drawing.Image)(resources.GetObject("picCart.Image")));
            this.picCart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picCart.Location = new System.Drawing.Point(883, 3);
            this.picCart.Name = "picCart";
            this.picCart.Size = new System.Drawing.Size(40, 40);
            this.picCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCart.TabIndex = 25;
            this.picCart.TabStop = false;
            this.picCart.Click += new System.EventHandler(this.picCart_Click);
            this.picCart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allButton_MouseDown);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(1074, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allButton_MouseDown);
            // 
            // btnCartConfirm
            // 
            this.btnCartConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCartConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnCartConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCartConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCartConfirm.ForeColor = System.Drawing.Color.White;
            this.btnCartConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCartConfirm.Location = new System.Drawing.Point(929, 8);
            this.btnCartConfirm.Name = "btnCartConfirm";
            this.btnCartConfirm.Size = new System.Drawing.Size(139, 32);
            this.btnCartConfirm.TabIndex = 1;
            this.btnCartConfirm.TabStop = false;
            this.btnCartConfirm.Text = "Xác Nhận";
            this.btnCartConfirm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCartConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCartConfirm.UseVisualStyleBackColor = false;
            this.btnCartConfirm.Click += new System.EventHandler(this.btnCartConfirm_Click);
            this.btnCartConfirm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allButton_MouseDown);
            // 
            // ttDescription
            // 
            this.ttDescription.OwnerDraw = true;
            this.ttDescription.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttDescription.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.tipButtons_Draw);
            this.ttDescription.Popup += new System.Windows.Forms.PopupEventHandler(this.tipButtons_Popup);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlTitle.Controls.Add(this.lbTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.ForeColor = System.Drawing.Color.White;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1220, 28);
            this.pnlTitle.TabIndex = 7;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1220, 28);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Dịch vụ";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseDown);
            // 
            // pnlCart
            // 
            this.pnlCart.Controls.Add(this.lstViewCart);
            this.pnlCart.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCart.Location = new System.Drawing.Point(796, 28);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(424, 633);
            this.pnlCart.TabIndex = 8;
            // 
            // lstViewCart
            // 
            this.lstViewCart.BackColor = System.Drawing.Color.White;
            this.lstViewCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstViewCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewCart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lstViewCart.ForeColor = System.Drawing.Color.Black;
            this.lstViewCart.GridLines = true;
            this.lstViewCart.HideSelection = false;
            this.lstViewCart.Location = new System.Drawing.Point(0, 0);
            this.lstViewCart.Name = "lstViewCart";
            this.lstViewCart.Size = new System.Drawing.Size(424, 633);
            this.lstViewCart.TabIndex = 0;
            this.lstViewCart.UseCompatibleStateImageBehavior = false;
            this.lstViewCart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên đồ uống";
            this.columnHeader1.Width = 157;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 96;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã dịch vụ";
            this.columnHeader5.Width = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.tcMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 28);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(796, 633);
            this.pnlMenu.TabIndex = 9;
            // 
            // tcMenu
            // 
            this.tcMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMenu.Location = new System.Drawing.Point(0, 0);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.ShowToolTips = true;
            this.tcMenu.Size = new System.Drawing.Size(796, 633);
            this.tcMenu.TabIndex = 2;
            // 
            // formOrder
            // 
            this.AcceptButton = this.btnCartConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1220, 710);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlCart);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlOderOption);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formOrder";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formOrder";
            this.Load += new System.EventHandler(this.formOrder_Load);
            this.pnlOderOption.ResumeLayout(false);
            this.pnlOderOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCart)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlCart.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOderOption;
        private System.Windows.Forms.ToolTip ttDescription;
        private System.Windows.Forms.Button btnCartConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picCart;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbSearchMenu;
        private Items.LabelItems lbCartAmount;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.ListView lstViewCart;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.TabControl tcMenu;
    }
}