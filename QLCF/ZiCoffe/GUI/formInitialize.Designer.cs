namespace ZiCoffe.GUI
{
    partial class formInitialize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInitialize));
            this.pnlProcsess = new System.Windows.Forms.Panel();
            this.prgInitialize = new System.Windows.Forms.ProgressBar();
            this.lbInitialize = new System.Windows.Forms.Label();
            this.pnlGif = new System.Windows.Forms.Panel();
            this.picIntro = new System.Windows.Forms.PictureBox();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxRoundItems1 = new ZiCoffe.Items.PictureBoxRoundItems();
            this.pnlProcsess.SuspendLayout();
            this.pnlGif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIntro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoundItems1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProcsess
            // 
            this.pnlProcsess.Controls.Add(this.prgInitialize);
            this.pnlProcsess.Controls.Add(this.lbInitialize);
            this.pnlProcsess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProcsess.Location = new System.Drawing.Point(0, 438);
            this.pnlProcsess.Name = "pnlProcsess";
            this.pnlProcsess.Size = new System.Drawing.Size(750, 62);
            this.pnlProcsess.TabIndex = 0;
            // 
            // prgInitialize
            // 
            this.prgInitialize.BackColor = System.Drawing.SystemColors.Control;
            this.prgInitialize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prgInitialize.Location = new System.Drawing.Point(0, 32);
            this.prgInitialize.Name = "prgInitialize";
            this.prgInitialize.Size = new System.Drawing.Size(750, 30);
            this.prgInitialize.TabIndex = 0;
            // 
            // lbInitialize
            // 
            this.lbInitialize.AutoSize = true;
            this.lbInitialize.ForeColor = System.Drawing.Color.White;
            this.lbInitialize.Location = new System.Drawing.Point(3, 10);
            this.lbInitialize.Name = "lbInitialize";
            this.lbInitialize.Size = new System.Drawing.Size(102, 19);
            this.lbInitialize.TabIndex = 0;
            this.lbInitialize.Text = "Initializing ...";
            // 
            // pnlGif
            // 
            this.pnlGif.Controls.Add(this.pictureBoxRoundItems1);
            this.pnlGif.Controls.Add(this.picIntro);
            this.pnlGif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGif.Location = new System.Drawing.Point(0, 0);
            this.pnlGif.Margin = new System.Windows.Forms.Padding(0);
            this.pnlGif.Name = "pnlGif";
            this.pnlGif.Size = new System.Drawing.Size(750, 438);
            this.pnlGif.TabIndex = 1;
            // 
            // picIntro
            // 
            this.picIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picIntro.Image = ((System.Drawing.Image)(resources.GetObject("picIntro.Image")));
            this.picIntro.Location = new System.Drawing.Point(0, 0);
            this.picIntro.Name = "picIntro";
            this.picIntro.Size = new System.Drawing.Size(750, 438);
            this.picIntro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIntro.TabIndex = 0;
            this.picIntro.TabStop = false;
            // 
            // timerProgress
            // 
            this.timerProgress.Enabled = true;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // pictureBoxRoundItems1
            // 
            this.pictureBoxRoundItems1.Image = global::ZiCoffe.Properties.Resources.logox;
            this.pictureBoxRoundItems1.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxRoundItems1.Name = "pictureBoxRoundItems1";
            this.pictureBoxRoundItems1.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxRoundItems1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRoundItems1.TabIndex = 1;
            this.pictureBoxRoundItems1.TabStop = false;
            // 
            // formInitialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.pnlGif);
            this.Controls.Add(this.pnlProcsess);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "formInitialize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Innitialize";
            this.Load += new System.EventHandler(this.formInitialize_Load);
            this.pnlProcsess.ResumeLayout(false);
            this.pnlProcsess.PerformLayout();
            this.pnlGif.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIntro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoundItems1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProcsess;
        private System.Windows.Forms.Panel pnlGif;
        private System.Windows.Forms.Label lbInitialize;
        private System.Windows.Forms.ProgressBar prgInitialize;
        private System.Windows.Forms.Timer timerProgress;
        private System.Windows.Forms.PictureBox picIntro;
        private Items.PictureBoxRoundItems pictureBoxRoundItems1;
    }
}