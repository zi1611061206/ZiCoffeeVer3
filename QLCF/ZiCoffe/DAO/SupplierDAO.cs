using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCoffe.DTO;

namespace ZiCoffe.DAO
{
    public class SupplierDAO
    {
        #region package_SupplierDAO
        private static SupplierDAO instance;
        public static SupplierDAO Instance
        {
            get { if (instance == null) instance = new SupplierDAO(); return instance; }
            private set { instance = value; }
        }
        private SupplierDAO() { }
        #endregion

        public List<SupplierDTO> GetSupplierList()
        {
            List<SupplierDTO> supplierList = new List<SupplierDTO>();
            string query = "select * from nhacungcap";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SupplierDTO dataLine = new SupplierDTO(item);
                supplierList.Add(dataLine);
            }
            return supplierList;
        }

        public DataTable GetSupplier()
        {
            string query = "exec LoadListSupplier";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchSupplier(string tenNhaCungCap)
        {
            string query = string.Format("exec SearchSupplier N'{0}'", tenNhaCungCap);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddSupplier(string tenNhaCungCap, string diaChi, string soDienThoai, string email)
        {
            string query = "insert into dbo.nhacungcap (tennhacungcap, diachi, sodienthoai, email) values ( @tennhacungcap , @diachi , @sodienthoai , @email )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenNhaCungCap, diaChi, soDienThoai, email });
            return result > 0;
        }

        public bool DeleteSupplier(int maNhaCungCap)
        {
            string query = "delete dbo.nhacungcap where manhacungcap= @manhacungcap ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNhaCungCap });
            return result > 0;
        }

        public bool ChangeSupplier(string tenNhaCungCap, string diaChi, string soDienThoai, string email, int maNhaCungCap)
        {
            string query = "update dbo.nhacungcap set tennhacungcap= @tennhacungcap , diachi= @diachi , sodienthoai= @sodienthoai , email= @email where manhacungcap= @manhacungcap ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenNhaCungCap, diaChi, soDienThoai, email, maNhaCungCap });
            return result > 0;
        }
    }
}
