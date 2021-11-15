namespace ZiCoffe.PartrialGUI
{
    partial class HomeLoad
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
            this.lbHours = new System.Windows.Forms.Label();
            this.lbMinutes = new System.Windows.Forms.Label();
            this.lbSeconds = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.BackColor = System.Drawing.Color.Transparent;
            this.lbHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHours.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHours.ForeColor = System.Drawing.Color.White;
            this.lbHours.Location = new System.Drawing.Point(24, 18);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(107, 78);
            this.lbHours.TabIndex = 0;
            this.lbHours.Text = "00";
            this.lbHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMinutes
            // 
            this.lbMinutes.AutoSize = true;
            this.lbMinutes.BackColor = System.Drawing.Color.Transparent;
            this.lbMinutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMinutes.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinutes.ForeColor = System.Drawing.Color.White;
            this.lbMinutes.Location = new System.Drawing.Point(152, 18);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(107, 78);
            this.lbMinutes.TabIndex = 1;
            this.lbMinutes.Text = "00";
            this.lbMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSeconds
            // 
            this.lbSeconds.AutoSize = true;
            this.lbSeconds.BackColor = System.Drawing.Color.Transparent;
            this.lbSeconds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSeconds.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeconds.ForeColor = System.Drawing.Color.White;
            this.lbSeconds.Location = new System.Drawing.Point(280, 18);
            this.lbSeconds.Name = "lbSeconds";
            this.lbSeconds.Size = new System.Drawing.Size(107, 78);
            this.lbSeconds.TabIndex = 2;
            this.lbSeconds.Text = "00";
            this.lbSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbLocation);
            this.panel1.Controls.Add(this.lbDay);
            this.panel1.Controls.Add(this.lbHours);
            this.panel1.Controls.Add(this.lbSeconds);
            this.panel1.Controls.Add(this.lbMinutes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(97, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 192);
            this.panel1.TabIndex = 3;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.BackColor = System.Drawing.Color.Transparent;
            this.lbLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.ForeColor = System.Drawing.Color.White;
            this.lbLocation.Location = new System.Drawing.Point(37, 148);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(84, 22);
            this.lbLocation.TabIndex = 7;
            this.lbLocation.Text = "location";
            this.lbLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.BackColor = System.Drawing.Color.Transparent;
            this.lbDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDay.ForeColor = System.Drawing.Color.White;
            this.lbDay.Location = new System.Drawing.Point(37, 105);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(122, 22);
            this.lbDay.TabIndex = 6;
            this.lbDay.Text = "dd mm yyyy";
            this.lbDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(238, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 78);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 78);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HomeLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ZiCoffe.Properties.Resources.b2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 672);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeLoad";
            this.Text = "HomeLoad";
            this.Load += new System.EventHandler(this.HomeLoad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.Label lbMinutes;
        private System.Windows.Forms.Label lbSeconds;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Label lbLocation;
    }
}