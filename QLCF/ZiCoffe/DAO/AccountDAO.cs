using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCoffe.DTO;

namespace ZiCoffe.DAO
{
    public class AccountDAO
    {
        #region package_AccountDAO
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        #endregion

        public List<AccountDTO> GetAccountList(int maChucVu)
        {
            List<AccountDTO> accountList = new List<AccountDTO>();
            string query = "select * from taikhoan where machucvu= @machucvu ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maChucVu });

            foreach (DataRow item in data.Rows)
            {
                AccountDTO dataLine = new AccountDTO(item);
                accountList.Add(dataLine);
            }
            return accountList;
        }

        public DataTable GetAccount()
        {
            string query = "exec LoadListAccount";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchAccount(string tenDangNhap)
        {
            string query = string.Format("exec SearchAccount N'{0}'", tenDangNhap);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetAccountByEmployees(int maNhanVien)
        {
            string query = "exec LoadListAccountByEmployees @maNhanVien ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maNhanVien });
        }

        public int CountAccount()
        {
            string query = "select count(*) from taikhoan";
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public bool DeleteAccount(string tenDangNhap)
        {
            string query = "delete dbo.taikhoan where tendangnhap= @tendangnhap";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDangNhap });
            return result > 0;
        }

        public bool UpdatePassword(string tenDangNhap, string matKhau, string matKhauMoi)
        {
            string query = "exec UpdatePassword @tendangnhap , @matkhau , @matkhaumoi ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDangNhap, matKhau, matKhauMoi });
            return result > 0;
        }

        public bool ResetPassword(string tenDangNhap)
        {
            string query = "update dbo.taikhoan set matkhau = 1 where tendangnhap = @tendangnhap";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDangNhap });
            return result > 0;
        }

        public bool CheckExisted(string tenDangNhap)
        {
            string query = "select * from dbo.taikhoan where tendangnhap = @tendangnhap ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenDangNhap });
            return data.Rows.Count > 0;
        }

        public bool AddAccount(string tenDangNhap, int maNhanVien)
        {
            string query = "insert into dbo.taikhoan (tendangnhap, manhanvien) values ( @tendangnhap , @manhanvien )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDangNhap, maNhanVien });
            return result > 0;
        }

        public string GetUsername(int maNhanVien)
        {
            string query = "select * from taikhoan where manhanvien= @manhanvien ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maNhanVien });
            if(data.Rows.Count<=0)
            {
                return "Chưa có tài khoản";
            }
            string usernameList = "";
            foreach (DataRow item in data.Rows)
            {
                AccountDTO dataLine = new AccountDTO(item);
                usernameList += dataLine.TenDangNhap + " ";
            }
            return usernameList;
        }

        public bool DeleteAccountByStaff(int maNhanVien)
        {
            //Xóa phiếu gọi bàn theo manhanvien
            string query = "delete dbo.taikhoan where manhanvien = @manhanvien";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNhanVien });
            return result > 0;
        }
    }
}
