using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiCoffe.PartrialGUI
{
    public partial class Report : Form
    {
        public Report(DateTime start, DateTime end)
        {
            InitializeComponent();
            ShowReport(start, end);
        }

        private DataSet GetReport(SqlParameter[] sqlParameters)
        {
            string connectionString = @"" + Properties.Resources.connectionStrDefault;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("GetRevenueForReport", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(sqlParameters);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        private void ShowReport(DateTime start, DateTime end)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@thoigiandau", start.ToString());
            sqlParameters[1] = new SqlParameter("@thoigiancuoi", end.ToString());

            //Tao nguon du lieu cho report
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", GetReport(sqlParameters).Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
