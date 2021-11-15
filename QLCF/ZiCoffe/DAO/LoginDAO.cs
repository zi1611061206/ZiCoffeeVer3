using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCoffe.DTO;

namespace ZiCoffe.DAO
{
    public class LoginDAO
    {
        #region package_LoginDAO
        private static LoginDAO instance;
        public static LoginDAO Instance
        {
            get { if (instance == null) instance = new LoginDAO(); return instance; }
            private set { instance = value; }
        }
        private LoginDAO() { }
        #endregion

        public bool Login(string username, string password)//check
        {
            string query = "exec checklogin @username , @password";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return data.Rows.Count > 0;
        }

        public EmployeesDTO GetEmployees(string tenDangNhap)//check
        {
            string query = "select * from dbo.nhanvien as n, dbo.taikhoan as t where n.manhanvien=t.manhanvien and tendangnhap = @tendangnhap";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenDangNhap });

            foreach (DataRow item in data.Rows)
            {
                return new EmployeesDTO(item);
            }
            return null;
        }
    
        public int GetPositionID(string tenDangNhap)//check
        {
            string query = "select machucvu from nhanvien as n, taikhoan as t where n.manhanvien = t.manhanvien and tendangnhap= '" +tenDangNhap+ "'";
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }
    }
}
