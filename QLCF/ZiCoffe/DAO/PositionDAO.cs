using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCoffe.DTO;

namespace ZiCoffe.DAO
{
    public class PositionDAO
    {
        #region package_PositionDAO
        private static PositionDAO instance;

        public static PositionDAO Instance
        {
            get { if (instance == null) instance = new PositionDAO(); return PositionDAO.instance; }
            private set { PositionDAO.instance = value; }
        }
        private PositionDAO() { }
        #endregion

        public List<PositionDTO> GetPositionList()
        {
            List<PositionDTO> positionList = new List<PositionDTO>();
            string query = "select * from chucvu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PositionDTO dataLine = new PositionDTO(item);
                positionList.Add(dataLine);
            }
            return positionList;
        }

        public DataTable GetPosition()
        {
            string query = "exec LoadListPosition";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public string GetPositionName(int maChucVu)
        {
            string query = "select tenchucvu from chucvu where machucvu = @machucvu ";
            return DataProvider.Instance.ExecuteScalar(query, new object[] { maChucVu }).ToString();
        }

        public DataTable SearchPosition(string tenChucVu)
        {
            string query = string.Format("exec SearchPosition N'{0}'", tenChucVu);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddPosition(string tenChucVu)
        {
            string query = "insert into dbo.chucvu (tenchucvu) values ( @tenchucvu )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenChucVu });
            return result > 0;
        }

        public bool DeletePosition(int maChucVu)
        {
            EmployeesDAO.Instance.DeleteEmployeesByPosition(maChucVu);
            string query = "delete dbo.chucvu where machucvu = @machucvu ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maChucVu });
            return result > 0;
        }

        public bool ChangePosition(string tenChucVu, int maChucVu)
        {
            string query = "update dbo.chucvu set tenchucvu = @tenchucvu where machucvu = @machucvu ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenChucVu, maChucVu });
            return result > 0;
        }
    }
}
