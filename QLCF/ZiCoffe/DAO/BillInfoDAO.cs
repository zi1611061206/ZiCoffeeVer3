using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCoffe.DTO;

namespace ZiCoffe.DAO
{
    public class BillInfoDAO
    {
        #region Package_Billinfo_DAO
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO() { }
        #endregion

        public void InsertBillInfo(int maHoaDon, int maDichVu, int soLuong)
        {
            string query = "exec UpdateIntoExistedBill @mahoadon , @madichvu , @soluong";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { maHoaDon, maDichVu, soLuong});
        }

        public bool DeleteBillInfo2(int maDichVu)
        {
            return DataProvider.Instance.ExecuteNonQuery("delete dbo.chitiethoadon where madichvu= " + maDichVu) > 0;
        }

        public bool DeleteBillInfo(int maHoaDonNguon)
        {
            return DataProvider.Instance.ExecuteNonQuery("delete dbo.chitiethoadon where mahoadon= " + maHoaDonNguon) > 0;
        }

        public List<GatherDTO> GetBillInfo(int maHoaDonNguon)
        {
            List<GatherDTO> billInfo = new List<GatherDTO>();
            string query = "select * from chitiethoadon where mahoadon= @mahoadonnguon ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maHoaDonNguon });
            foreach (DataRow item in data.Rows)
            {
                GatherDTO dataLine = new GatherDTO(item);
                billInfo.Add(dataLine);
            }
            return billInfo;
        }

        public DataTable GetBillInfo2(int maHoaDon)
        {
            string query = "select c.mahoadon as [Mã hóa đơn], d.tendichvu as [Dịch vụ], c.soluong as [Số lượng], c.thanhtien as [Thành tiền] from chitiethoadon as c, dichvu as d where c.madichvu=d.madichvu and mahoadon= @mahoadon ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maHoaDon });
        }

        public int CountBillInfo()
        {
            return (int)DataProvider.Instance.ExecuteScalar("select count(*) from dbo.chitiethoadon");
        }
    }
}
