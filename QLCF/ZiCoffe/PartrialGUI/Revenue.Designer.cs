namespace ZiCoffe.PartrialGUI
{
    partial class Revenue
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 70D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 30D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 50D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 10D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 70D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 30D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 50D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 10D);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txbDisplayNumRows = new System.Windows.Forms.TextBox();
            this.txbMaxNumRows = new System.Windows.Forms.TextBox();
            this.txbPageNumber = new System.Windows.Forms.TextBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lbEnd = new System.Windows.Forms.Label();
            this.lbStart = new System.Windows.Forms.Label();
            this.pnlBillInfo = new System.Windows.Forms.Panel();
            this.dtgBillInfo = new System.Windows.Forms.DataGridView();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.dtgRevenue = new System.Windows.Forms.DataGridView();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picMax = new System.Windows.Forms.PictureBox();
            this.pnlChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.pnlTime.SuspendLayout();
            this.pnlBillInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBillInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).BeginInit();
            this.SuspendLayout();
            // 
            // txbDisplayNumRows
            // 
            this.txbDisplayNumRows.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txbDisplayNumRows.BackColor = System.Drawing.Color.White;
            this.txbDisplayNumRows.Location = new System.Drawing.Point(524, 7);
            this.txbDisplayNumRows.Name = "txbDisplayNumRows";
            this.txbDisplayNumRows.ReadOnly = true;
            this.txbDisplayNumRows.Size = new System.Drawing.Size(37, 26);
            this.txbDisplayNumRows.TabIndex = 0;
            this.txbDisplayNumRows.TabStop = false;
            this.txbDisplayNumRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txbDisplayNumRows, "Số dòng hiện tại");
            // 
            // txbMaxNumRows
            // 
            this.txbMaxNumRows.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txbMaxNumRows.BackColor = System.Drawing.Color.White;
            this.txbMaxNumRows.Location = new System.Drawing.Point(584, 7);
            this.txbMaxNumRows.Name = "txbMaxNumRows";
            this.txbMaxNumRows.ReadOnly = true;
            this.txbMaxNumRows.Size = new System.Drawing.Size(37, 26);
            this.txbMaxNumRows.TabIndex = 0;
            this.txbMaxNumRows.TabStop = false;
            this.txbMaxNumRows.Text = "25";
            this.txbMaxNumRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txbMaxNumRows, "Số dòng tối đa trên một trang");
            // 
            // txbPageNumber
            // 
            this.txbPageNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbPageNumber.BackColor = System.Drawing.Color.White;
            this.txbPageNumber.Location = new System.Drawing.Point(129, 7);
            this.txbPageNumber.Name = "txbPageNumber";
            this.txbPageNumber.ReadOnly = true;
            this.txbPageNumber.Size = new System.Drawing.Size(100, 26);
            this.txbPageNumber.TabIndex = 0;
            this.txbPageNumber.TabStop = false;
            this.txbPageNumber.Text = "1";
            this.txbPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txbPageNumber, "Trang hiện tại");
            this.txbPageNumber.TextChanged += new System.EventHandler(this.txbPageNumber_TextChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Location = new System.Drawing.Point(55, 41);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(302, 26);
            this.dtpEnd.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dtpEnd, "Chọn thời điểm kết thúc");
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Location = new System.Drawing.Point(55, 9);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(302, 26);
            this.dtpStart.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dtpStart, "Chọn thời điểm bắt đầu");
            // 
            // btnLastPage
            // 
            this.btnLastPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLastPage.BackColor = System.Drawing.Color.White;
            this.btnLastPage.Image = global::ZiCoffe.Properties.Resources.play_next_button;
            this.btnLastPage.Location = new System.Drawing.Point(296, 4);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(55, 31);
            this.btnLastPage.TabIndex = 8;
            this.btnLastPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLastPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnLastPage, "Đến trang cuối");
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNextPage.BackColor = System.Drawing.Color.White;
            this.btnNextPage.Image = global::ZiCoffe.Properties.Resources.play_button;
            this.btnNextPage.Location = new System.Drawing.Point(235, 4);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(55, 31);
            this.btnNextPage.TabIndex = 7;
            this.btnNextPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNextPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnNextPage, "Trang sau");
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPreviousPage.BackColor = System.Drawing.Color.White;
            this.btnPreviousPage.Image = global::ZiCoffe.Properties.Resources.left;
            this.btnPreviousPage.Location = new System.Drawing.Point(68, 4);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(55, 31);
            this.btnPreviousPage.TabIndex = 6;
            this.btnPreviousPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreviousPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnPreviousPage, "Trang trước");
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFirstPage.BackColor = System.Drawing.Color.White;
            this.btnFirstPage.Image = global::ZiCoffe.Properties.Resources.previous_track;
            this.btnFirstPage.Location = new System.Drawing.Point(7, 4);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(55, 31);
            this.btnFirstPage.TabIndex = 5;
            this.btnFirstPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirstPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnFirstPage, "Trở về trang đầu");
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // pnlChart
            // 
            this.pnlChart.Controls.Add(this.chart2);
            this.pnlChart.Controls.Add(this.chart1);
            this.pnlChart.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlChart.Location = new System.Drawing.Point(653, 0);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(475, 672);
            this.pnlChart.TabIndex = 0;
            this.pnlChart.SizeChanged += new System.EventHandler(this.pnlChart_SizeChanged);
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(6, 345);
            this.chart2.Name = "chart2";
            series3.BorderColor = System.Drawing.Color.Silver;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Doanh thu";
            series3.Points.Add(dataPoint9);
            series3.Points.Add(dataPoint10);
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.ShadowOffset = 2;
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(457, 265);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(6, 74);
            this.chart1.Name = "chart1";
            series4.BorderColor = System.Drawing.Color.Silver;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Lime;
            series4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.Legend = "Legend1";
            series4.Name = "Doanh thu";
            series4.Points.Add(dataPoint13);
            series4.Points.Add(dataPoint14);
            series4.Points.Add(dataPoint15);
            series4.Points.Add(dataPoint16);
            series4.ShadowOffset = 2;
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(457, 265);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.picMin);
            this.pnlButton.Controls.Add(this.picMax);
            this.pnlButton.Controls.Add(this.label1);
            this.pnlButton.Controls.Add(this.txbDisplayNumRows);
            this.pnlButton.Controls.Add(this.txbMaxNumRows);
            this.pnlButton.Controls.Add(this.txbPageNumber);
            this.pnlButton.Controls.Add(this.btnLastPage);
            this.pnlButton.Controls.Add(this.btnNextPage);
            this.pnlButton.Controls.Add(this.btnPreviousPage);
            this.pnlButton.Controls.Add(this.btnFirstPage);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 635);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(653, 37);
            this.pnlButton.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "/";
            // 
            // pnlTime
            // 
            this.pnlTime.Controls.Add(this.btnReport);
            this.pnlTime.Controls.Add(this.btnView);
            this.pnlTime.Controls.Add(this.dtpEnd);
            this.pnlTime.Controls.Add(this.lbEnd);
            this.pnlTime.Controls.Add(this.dtpStart);
            this.pnlTime.Controls.Add(this.lbStart);
            this.pnlTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTime.Location = new System.Drawing.Point(0, 0);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(653, 74);
            this.pnlTime.TabIndex = 6;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(508, 9);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(139, 58);
            this.btnReport.TabIndex = 4;
            this.btnReport.TabStop = false;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(363, 9);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(139, 58);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Location = new System.Drawing.Point(9, 44);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(40, 19);
            this.lbEnd.TabIndex = 0;
            this.lbEnd.Text = "Đến";
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Location = new System.Drawing.Point(18, 12);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(31, 19);
            this.lbStart.TabIndex = 0;
            this.lbStart.Text = "Từ";
            // 
            // pnlBillInfo
            // 
            this.pnlBillInfo.Controls.Add(this.dtgBillInfo);
            this.pnlBillInfo.Controls.Add(this.pnlLine);
            this.pnlBillInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBillInfo.Location = new System.Drawing.Point(0, 458);
            this.pnlBillInfo.Name = "pnlBillInfo";
            this.pnlBillInfo.Size = new System.Drawing.Size(653, 177);
            this.pnlBillInfo.TabIndex = 0;
            // 
            // dtgBillInfo
            // 
            this.dtgBillInfo.AllowUserToAddRows = false;
            this.dtgBillInfo.AllowUserToDeleteRows = false;
            this.dtgBillInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBillInfo.BackgroundColor = System.Drawing.Color.White;
            this.dtgBillInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBillInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgBillInfo.Location = new System.Drawing.Point(0, 28);
            this.dtgBillInfo.Name = "dtgBillInfo";
            this.dtgBillInfo.ReadOnly = true;
            this.dtgBillInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBillInfo.Size = new System.Drawing.Size(653, 149);
            this.dtgBillInfo.TabIndex = 1;
            this.dtgBillInfo.TabStop = false;
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine.Location = new System.Drawing.Point(0, 0);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(653, 28);
            this.pnlLine.TabIndex = 0;
            // 
            // dtgRevenue
            // 
            this.dtgRevenue.AllowUserToAddRows = false;
            this.dtgRevenue.AllowUserToDeleteRows = false;
            this.dtgRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgRevenue.BackgroundColor = System.Drawing.Color.White;
            this.dtgRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRevenue.Location = new System.Drawing.Point(0, 74);
            this.dtgRevenue.Name = "dtgRevenue";
            this.dtgRevenue.ReadOnly = true;
            this.dtgRevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRevenue.Size = new System.Drawing.Size(653, 384);
            this.dtgRevenue.TabIndex = 0;
            this.dtgRevenue.TabStop = false;
            this.dtgRevenue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRevenue_CellClick);
            // 
            // picMin
            // 
            this.picMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picMin.BackColor = System.Drawing.Color.Transparent;
            this.picMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMin.Image = global::ZiCoffe.Properties.Resources.right_chevron;
            this.picMin.Location = new System.Drawing.Point(628, 13);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(20, 20);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMin.TabIndex = 10;
            this.picMin.TabStop = false;
            this.toolTip1.SetToolTip(this.picMin, "Thu gọn thanh biểu đồ");
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            // 
            // picMax
            // 
            this.picMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picMax.BackColor = System.Drawing.Color.Transparent;
            this.picMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMax.Image = global::ZiCoffe.Properties.Resources.left_chevron;
            this.picMax.Location = new System.Drawing.Point(628, 13);
            this.picMax.Name = "picMax";
            this.picMax.Size = new System.Drawing.Size(20, 20);
            this.picMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMax.TabIndex = 9;
            this.picMax.TabStop = false;
            this.toolTip1.SetToolTip(this.picMax, "Mở thanh biểu đồ");
            this.picMax.Click += new System.EventHandler(this.picMax_Click);
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 672);
            this.Controls.Add(this.dtgRevenue);
            this.Controls.Add(this.pnlBillInfo);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlTime);
            this.Controls.Add(this.pnlChart);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Revenue";
            this.Text = "Revenue";
            this.Load += new System.EventHandler(this.Revenue_Load);
            this.pnlChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            this.pnlBillInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBillInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDisplayNumRows;
        private System.Windows.Forms.TextBox txbMaxNumRows;
        private System.Windows.Forms.TextBox txbPageNumber;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel pnlBillInfo;
        private System.Windows.Forms.DataGridView dtgBillInfo;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.DataGridView dtgRevenue;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picMax;
    }
}