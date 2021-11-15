namespace ZiCoffe.GUI
{
    partial class formChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formChangePassword));
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlEnter = new System.Windows.Forms.Panel();
            this.pnlReEnter = new System.Windows.Forms.Panel();
            this.pnlLine3 = new System.Windows.Forms.Panel();
            this.txbReEnter = new System.Windows.Forms.TextBox();
            this.lbReEnter = new System.Windows.Forms.Label();
            this.pnlNewPass = new System.Windows.Forms.Panel();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.pnlOldPass = new System.Windows.Forms.Panel();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.txbOldPass = new System.Windows.Forms.TextBox();
            this.lbOldPass = new System.Windows.Forms.Label();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.pnlEnter.SuspendLayout();
            this.pnlReEnter.SuspendLayout();
            this.pnlNewPass.SuspendLayout();
            this.pnlOldPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnCancel);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 256);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(469, 65);
            this.pnlButton.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnCancel.Location = new System.Drawing.Point(286, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 44);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allButton_MouseDown);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            this.btnCancel.MouseHover += new System.EventHandler(this.btnCancel_MouseHover);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSave.Location = new System.Drawing.Point(13, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 44);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allButton_MouseDown);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(154, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(150, 22);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "ĐỔI MẬT KHẨU";
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::ZiCoffe.Properties.Resources.minimizeWhite;
            this.pictureBox2.Location = new System.Drawing.Point(412, 9);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(25, 25);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(20, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Minimize");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ZiCoffe.Properties.Resources.closewhite;
            this.pictureBox1.Location = new System.Drawing.Point(438, 9);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(25, 25);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Close");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlTitle.Controls.Add(this.lbTitle);
            this.pnlTitle.Controls.Add(this.pictureBox2);
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(469, 39);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // pnlEnter
            // 
            this.pnlEnter.Controls.Add(this.pnlReEnter);
            this.pnlEnter.Controls.Add(this.pnlNewPass);
            this.pnlEnter.Controls.Add(this.pnlOldPass);
            this.pnlEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEnter.Location = new System.Drawing.Point(0, 39);
            this.pnlEnter.Name = "pnlEnter";
            this.pnlEnter.Size = new System.Drawing.Size(469, 217);
            this.pnlEnter.TabIndex = 0;
            // 
            // pnlReEnter
            // 
            this.pnlReEnter.Controls.Add(this.pnlLine3);
            this.pnlReEnter.Controls.Add(this.txbReEnter);
            this.pnlReEnter.Controls.Add(this.lbReEnter);
            this.pnlReEnter.Location = new System.Drawing.Point(12, 140);
            this.pnlReEnter.Name = "pnlReEnter";
            this.pnlReEnter.Size = new System.Drawing.Size(445, 51);
            this.pnlReEnter.TabIndex = 13;
            // 
            // pnlLine3
            // 
            this.pnlLine3.BackColor = System.Drawing.Color.White;
            this.pnlLine3.Location = new System.Drawing.Point(6, 37);
            this.pnlLine3.Name = "pnlLine3";
            this.pnlLine3.Size = new System.Drawing.Size(435, 1);
            this.pnlLine3.TabIndex = 0;
            // 
            // txbReEnter
            // 
            this.txbReEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txbReEnter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbReEnter.ForeColor = System.Drawing.Color.White;
            this.txbReEnter.Location = new System.Drawing.Point(116, 12);
            this.txbReEnter.Name = "txbReEnter";
            this.txbReEnter.Size = new System.Drawing.Size(326, 19);
            this.txbReEnter.TabIndex = 3;
            this.txbReEnter.UseSystemPasswordChar = true;
            // 
            // lbReEnter
            // 
            this.lbReEnter.AutoSize = true;
            this.lbReEnter.Location = new System.Drawing.Point(3, 15);
            this.lbReEnter.Name = "lbReEnter";
            this.lbReEnter.Size = new System.Drawing.Size(69, 18);
            this.lbReEnter.TabIndex = 0;
            this.lbReEnter.Text = "Nhập lại:";
            // 
            // pnlNewPass
            // 
            this.pnlNewPass.Controls.Add(this.pnlLine2);
            this.pnlNewPass.Controls.Add(this.txbNewPass);
            this.pnlNewPass.Controls.Add(this.lbNewPass);
            this.pnlNewPass.Location = new System.Drawing.Point(12, 83);
            this.pnlNewPass.Name = "pnlNewPass";
            this.pnlNewPass.Size = new System.Drawing.Size(445, 51);
            this.pnlNewPass.TabIndex = 12;
            // 
            // pnlLine2
            // 
            this.pnlLine2.BackColor = System.Drawing.Color.White;
            this.pnlLine2.Location = new System.Drawing.Point(6, 36);
            this.pnlLine2.Name = "pnlLine2";
            this.pnlLine2.Size = new System.Drawing.Size(435, 1);
            this.pnlLine2.TabIndex = 0;
            // 
            // txbNewPass
            // 
            this.txbNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txbNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNewPass.ForeColor = System.Drawing.Color.White;
            this.txbNewPass.Location = new System.Drawing.Point(116, 12);
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.Size = new System.Drawing.Size(326, 19);
            this.txbNewPass.TabIndex = 2;
            this.txbNewPass.UseSystemPasswordChar = true;
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.Location = new System.Drawing.Point(3, 15);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(107, 18);
            this.lbNewPass.TabIndex = 0;
            this.lbNewPass.Text = "Mật khẩu mới:";
            // 
            // pnlOldPass
            // 
            this.pnlOldPass.Controls.Add(this.pnlLine1);
            this.pnlOldPass.Controls.Add(this.txbOldPass);
            this.pnlOldPass.Controls.Add(this.lbOldPass);
            this.pnlOldPass.Location = new System.Drawing.Point(12, 26);
            this.pnlOldPass.Name = "pnlOldPass";
            this.pnlOldPass.Size = new System.Drawing.Size(445, 51);
            this.pnlOldPass.TabIndex = 11;
            // 
            // pnlLine1
            // 
            this.pnlLine1.BackColor = System.Drawing.Color.White;
            this.pnlLine1.Location = new System.Drawing.Point(6, 36);
            this.pnlLine1.Name = "pnlLine1";
            this.pnlLine1.Size = new System.Drawing.Size(435, 1);
            this.pnlLine1.TabIndex = 0;
            // 
            // txbOldPass
            // 
            this.txbOldPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txbOldPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbOldPass.ForeColor = System.Drawing.Color.White;
            this.txbOldPass.Location = new System.Drawing.Point(104, 12);
            this.txbOldPass.Name = "txbOldPass";
            this.txbOldPass.Size = new System.Drawing.Size(338, 19);
            this.txbOldPass.TabIndex = 1;
            this.txbOldPass.UseSystemPasswordChar = true;
            // 
            // lbOldPass
            // 
            this.lbOldPass.AutoSize = true;
            this.lbOldPass.Location = new System.Drawing.Point(3, 15);
            this.lbOldPass.Name = "lbOldPass";
            this.lbOldPass.Size = new System.Drawing.Size(95, 18);
            this.lbOldPass.TabIndex = 0;
            this.lbOldPass.Text = "Mật khẩu cũ:";
            // 
            // formChangePassword
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(469, 321);
            this.Controls.Add(this.pnlEnter);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlButton);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formChangePassword";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlEnter.ResumeLayout(false);
            this.pnlReEnter.ResumeLayout(false);
            this.pnlReEnter.PerformLayout();
            this.pnlNewPass.ResumeLayout(false);
            this.pnlNewPass.PerformLayout();
            this.pnlOldPass.ResumeLayout(false);
            this.pnlOldPass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlEnter;
        private System.Windows.Forms.Panel pnlReEnter;
        private System.Windows.Forms.Panel pnlLine3;
        private System.Windows.Forms.TextBox txbReEnter;
        private System.Windows.Forms.Label lbReEnter;
        private System.Windows.Forms.Panel pnlNewPass;
        private System.Windows.Forms.Panel pnlLine2;
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.Panel pnlOldPass;
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.TextBox txbOldPass;
        private System.Windows.Forms.Label lbOldPass;
    }
}