namespace ZiCoffe.PartrialGUI
{
    partial class DrinkRecipe
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
            this.pnlInput = new System.Windows.Forms.Panel();
            this.pnlStep2 = new System.Windows.Forms.Panel();
            this.btnRequest = new System.Windows.Forms.Button();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.lbStep2 = new System.Windows.Forms.Label();
            this.cbMenu = new System.Windows.Forms.ComboBox();
            this.lbStep1 = new System.Windows.Forms.Label();
            this.lstTempRecipe = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlController = new System.Windows.Forms.Panel();
            this.picReload = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPushUp = new System.Windows.Forms.Button();
            this.picFilter = new System.Windows.Forms.PictureBox();
            this.cbRecipe = new System.Windows.Forms.ComboBox();
            this.pnlData = new System.Windows.Forms.Panel();
            this.lstRecipe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlInput.SuspendLayout();
            this.pnlStep2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.pnlController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).BeginInit();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlInput.Controls.Add(this.pnlStep2);
            this.pnlInput.Controls.Add(this.cbMenu);
            this.pnlInput.Controls.Add(this.lbStep1);
            this.pnlInput.Controls.Add(this.lstTempRecipe);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlInput.Location = new System.Drawing.Point(0, 446);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(1128, 226);
            this.pnlInput.TabIndex = 0;
            this.pnlInput.VisibleChanged += new System.EventHandler(this.pnlInput_VisibleChanged);
            // 
            // pnlStep2
            // 
            this.pnlStep2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlStep2.Controls.Add(this.btnRequest);
            this.pnlStep2.Controls.Add(this.nudAmount);
            this.pnlStep2.Controls.Add(this.cbMaterial);
            this.pnlStep2.Controls.Add(this.lbStep2);
            this.pnlStep2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStep2.Location = new System.Drawing.Point(0, 89);
            this.pnlStep2.Name = "pnlStep2";
            this.pnlStep2.Size = new System.Drawing.Size(488, 137);
            this.pnlStep2.TabIndex = 0;
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
            this.btnRequest.Location = new System.Drawing.Point(343, 68);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(139, 32);
            this.btnRequest.TabIndex = 7;
            this.btnRequest.Text = "Yêu cầu";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmount.Location = new System.Drawing.Point(16, 73);
            this.nudAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(321, 26);
            this.nudAmount.TabIndex = 6;
            // 
            // cbMaterial
            // 
            this.cbMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(16, 41);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(321, 26);
            this.cbMaterial.Sorted = true;
            this.cbMaterial.TabIndex = 5;
            // 
            // lbStep2
            // 
            this.lbStep2.AutoSize = true;
            this.lbStep2.Location = new System.Drawing.Point(12, 19);
            this.lbStep2.Name = "lbStep2";
            this.lbStep2.Size = new System.Drawing.Size(188, 19);
            this.lbStep2.TabIndex = 0;
            this.lbStep2.Text = "Bước 2: Lập công thức";
            // 
            // cbMenu
            // 
            this.cbMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMenu.FormattingEnabled = true;
            this.cbMenu.Location = new System.Drawing.Point(202, 10);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(135, 26);
            this.cbMenu.Sorted = true;
            this.cbMenu.TabIndex = 4;
            this.cbMenu.SelectionChangeCommitted += new System.EventHandler(this.cbMenu_SelectionChangeCommitted);
            // 
            // lbStep1
            // 
            this.lbStep1.AutoSize = true;
            this.lbStep1.Location = new System.Drawing.Point(12, 13);
            this.lbStep1.Name = "lbStep1";
            this.lbStep1.Size = new System.Drawing.Size(178, 19);
            this.lbStep1.TabIndex = 0;
            this.lbStep1.Text = "Bước 1: Chọn dịch vụ";
            // 
            // lstTempRecipe
            // 
            this.lstTempRecipe.BackColor = System.Drawing.Color.White;
            this.lstTempRecipe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lstTempRecipe.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstTempRecipe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTempRecipe.GridLines = true;
            this.lstTempRecipe.Location = new System.Drawing.Point(488, 0);
            this.lstTempRecipe.Name = "lstTempRecipe";
            this.lstTempRecipe.Size = new System.Drawing.Size(640, 226);
            this.lstTempRecipe.TabIndex = 0;
            this.lstTempRecipe.UseCompatibleStateImageBehavior = false;
            this.lstTempRecipe.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dịch vụ";
            this.columnHeader5.Width = 213;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nguyên Liệu";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 253;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số lượng";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 85;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã dịch vụ";
            this.columnHeader8.Width = 0;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Mã nguyên liệu";
            this.columnHeader9.Width = 0;
            // 
            // pnlController
            // 
            this.pnlController.Controls.Add(this.picReload);
            this.pnlController.Controls.Add(this.btnAdd);
            this.pnlController.Controls.Add(this.btnCancel);
            this.pnlController.Controls.Add(this.btnPushUp);
            this.pnlController.Controls.Add(this.picFilter);
            this.pnlController.Controls.Add(this.cbRecipe);
            this.pnlController.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlController.Location = new System.Drawing.Point(0, 394);
            this.pnlController.Name = "pnlController";
            this.pnlController.Size = new System.Drawing.Size(1128, 52);
            this.pnlController.TabIndex = 0;
            // 
            // picReload
            // 
            this.picReload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReload.Image = global::ZiCoffe.Properties.Resources.btnreload;
            this.picReload.Location = new System.Drawing.Point(437, 6);
            this.picReload.Name = "picReload";
            this.picReload.Size = new System.Drawing.Size(25, 25);
            this.picReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReload.TabIndex = 30;
            this.picReload.TabStop = false;
            this.picReload.Click += new System.EventHandler(this.picReload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(573, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 32);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Lập công thức";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnCancel.TabIndex = 2;
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
            this.btnPushUp.TabIndex = 3;
            this.btnPushUp.Text = "Đẩy lên";
            this.btnPushUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPushUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPushUp.UseVisualStyleBackColor = false;
            this.btnPushUp.Click += new System.EventHandler(this.btnPushUp_Click);
            // 
            // picFilter
            // 
            this.picFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFilter.ErrorImage = null;
            this.picFilter.Image = global::ZiCoffe.Properties.Resources.funnel;
            this.picFilter.Location = new System.Drawing.Point(406, 6);
            this.picFilter.Name = "picFilter";
            this.picFilter.Size = new System.Drawing.Size(25, 25);
            this.picFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFilter.TabIndex = 28;
            this.picFilter.TabStop = false;
            this.picFilter.Click += new System.EventHandler(this.picFilter_Click);
            // 
            // cbRecipe
            // 
            this.cbRecipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRecipe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRecipe.FormattingEnabled = true;
            this.cbRecipe.Location = new System.Drawing.Point(3, 6);
            this.cbRecipe.Name = "cbRecipe";
            this.cbRecipe.Size = new System.Drawing.Size(397, 26);
            this.cbRecipe.Sorted = true;
            this.cbRecipe.TabIndex = 1;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.lstRecipe);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(1128, 394);
            this.pnlData.TabIndex = 2;
            // 
            // lstRecipe
            // 
            this.lstRecipe.BackColor = System.Drawing.Color.White;
            this.lstRecipe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRecipe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecipe.GridLines = true;
            this.lstRecipe.Location = new System.Drawing.Point(0, 0);
            this.lstRecipe.Name = "lstRecipe";
            this.lstRecipe.Size = new System.Drawing.Size(1128, 394);
            this.lstRecipe.TabIndex = 0;
            this.lstRecipe.UseCompatibleStateImageBehavior = false;
            this.lstRecipe.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dịch vụ";
            this.columnHeader1.Width = 317;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Thành phần nguyên liệu";
            this.columnHeader2.Width = 357;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng sử dụng trong một lần";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 275;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng tồn thực tế";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 175;
            // 
            // DrinkRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 672);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlController);
            this.Controls.Add(this.pnlInput);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DrinkRecipe";
            this.Text = "DrinkRecipe";
            this.Load += new System.EventHandler(this.DrinkRecipe_Load);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlStep2.ResumeLayout(false);
            this.pnlStep2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.pnlController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlController;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.ListView lstRecipe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cbRecipe;
        private System.Windows.Forms.PictureBox picFilter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPushUp;
        private System.Windows.Forms.ListView lstTempRecipe;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel pnlStep2;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Label lbStep2;
        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.Label lbStep1;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox picReload;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}