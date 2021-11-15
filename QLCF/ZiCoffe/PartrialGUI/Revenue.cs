using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiCoffe.DAO;

namespace ZiCoffe.PartrialGUI
{
    public partial class Revenue : Form
    {
        public Revenue()
        {
            InitializeComponent();
        }

        private void Revenue_Load(object sender, EventArgs e)
        {
            LoadGlobal();
            LoadDateTimePicker();
            LoadRevenue(dtpStart.Value, dtpEnd.Value);
            DisplayNumRows();
            pnlChart.Width = 0;
            picMax.Visible = true;
            picMin.Visible = false;
        }

        private void LoadGlobal()
        {
            btnReport.BackColor
                = btnView.BackColor
                = Properties.Settings.Default.typeBack2;
            btnReport.ForeColor
                = btnView.ForeColor
                = Properties.Settings.Default.typeFore2;
        }

        void LoadDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dtpStart.Value = new DateTime(today.Year, today.Month, 1);
            dtpEnd.Value = dtpStart.Value.AddMonths(1).AddDays(-1);
        }

        void LoadRevenue(DateTime start, DateTime end)
        {
            int pageNumber = Convert.ToInt32(txbPageNumber.Text);
            int maxNumRows = Convert.ToInt32(txbMaxNumRows.Text);
            dtgRevenue.DataSource = BillDAO.Instance.GetRevenue(start, end, pageNumber, maxNumRows);
        }

        void DisplayNumRows()
        {
            DateTime start = dtpStart.Value;
            DateTime end = dtpEnd.Value;
            int pageNum = Convert.ToInt32(txbPageNumber.Text);
            int maxNumRows = Convert.ToInt32(txbMaxNumRows.Text);
            txbDisplayNumRows.Text = BillDAO.Instance.GetDisPlayRecord(start, end, pageNum, maxNumRows).ToString();
        }

        public int GetLastPage()
        {
            int totalRecord = BillDAO.Instance.GetRevenueRecordNum(dtpStart.Value, dtpEnd.Value);
            int maxRow = Convert.ToInt32(txbMaxNumRows.Text);
            int lastPage = totalRecord / maxRow;
            if (totalRecord % maxRow != 0)
                lastPage++;
            return lastPage;
        }

        #region [E] Revenue
        private void btnView_Click(object sender, EventArgs e)
        {
            LoadRevenue(dtpStart.Value, dtpEnd.Value);
            DisplayNumRows();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            txbPageNumber.Text = "1";
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            int currentPage = Convert.ToInt32(txbPageNumber.Text);
            if (currentPage > 1)
                currentPage--;
            txbPageNumber.Text = currentPage.ToString();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int currentPage = Convert.ToInt32(txbPageNumber.Text);
            int lastPage = GetLastPage();
            if (currentPage < lastPage)
                currentPage++;
            txbPageNumber.Text = currentPage.ToString();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            int lastPage = GetLastPage();
            txbPageNumber.Text = lastPage.ToString();
        }

        private void txbPageNumber_TextChanged(object sender, EventArgs e)
        {
            dtgRevenue.DataSource = BillDAO.Instance.GetRevenue(dtpStart.Value, dtpEnd.Value, Convert.ToInt32(txbPageNumber.Text), Convert.ToInt32(txbMaxNumRows.Text));
        }

        private void pnlChart_SizeChanged(object sender, EventArgs e)
        {
            if(pnlChart.Width==0)
            {
                picMax.Visible = true;
                picMin.Visible = false;
                chart1.Visible = false;
                chart2.Visible = false;
            }
            else
            {
                picMax.Visible = false;
                picMin.Visible = true;
                chart1.Visible = true;
                chart2.Visible = true;
            }
        }

        private void picMax_Click(object sender, EventArgs e)
        {
            pnlChart.Width = 475;
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            pnlChart.Width = 0;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            PartrialGUI.Report f = new PartrialGUI.Report(dtpStart.Value, dtpEnd.Value);
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void dtgRevenue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex==-1)
            {
                return;
            }
            DataGridViewRow dataLine = dtgRevenue.Rows[e.RowIndex];
            int billID = int.Parse(dataLine.Cells[0].Value + "");
            dtgBillInfo.DataSource = BillInfoDAO.Instance.GetBillInfo2(billID);
        }
        #endregion
    }
}
