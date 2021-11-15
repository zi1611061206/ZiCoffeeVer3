using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCoffe.DTO;

namespace ZiCoffe.DAO
{
    public class BillDAO
    {
        #region Package_BillDAO
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }
        #endregion

        public int GetBillID(int maBan)//check
        {
            string query = "select * from dbo.hoadon as h, dbo.phieugoiban as p where h.MaHoaDon=p.MaHoaDon and MaBan= @maban and trangthaithanhtoan = 0 ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maBan });
            if (data.Rows.Count > 0)
            {
                BillDTO bill = new BillDTO(data.Rows[0]);
                return bill.MaHoaDon;
            }
            return -1;
        }

        public int GetMaxBillID()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(mahoadon) from hoadon");
            }
            catch
            {
                return 1;
            }
        }

        public void InsertBill()
        {
            string query = "insert into dbo.hoadon (ngaylap) values ( getdate() )";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertOrderCard(int maBan, int maHoaDon, string tenDangNhap)
        {
            string query = "insert into dbo.phieugoiban (maban, mahoadon, tendangnhap) values ( @maban , @mahoadon , @tendangnhap )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maBan, maHoaDon, tenDangNhap });
            return result > 0;
        }

        public bool DeleteOrderCard(int maHoaDonNguon)
        {
            string query = "delete dbo.phieugoiban where mahoadon = @mahoadonnguon ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maHoaDonNguon });
            return result > 0;
        }

        internal string GetVoucher(int maHoaDon)
        {
            string query = "select maphieugiamgia from hoadon where mahoadon = @mahoadon ";
            return DataProvider.Instance.ExecuteScalar(query, new object[] { maHoaDon }).ToString();
        }

        public bool DeleteBill(int maHoaDonNguon)
        {
            string query = "delete dbo.hoadon where mahoadon = @mahoadonnguon ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maHoaDonNguon });
            return result > 0;
        }

        public bool UpdateBill(float thanhTien, float vat, float giaTriSauThue, int maChuongTrinhKhuyenMai, float thucThu, int maHoaDon)
        {
            string query = "update dbo.hoadon set thanhtien= @thanhtien , vat= @vat ,giatrisauthue= @giatrisauthue ,machuongtrinhkhuyenmai = @machuongtrinhkhuyenmai , thucthu = @thucthu ,trangthaithanhtoan = 1 where mahoadon= @mahoadon and trangthaithanhtoan = 0";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { thanhTien, vat, giaTriSauThue, maChuongTrinhKhuyenMai, thucThu, maHoaDon });
            return result > 0;
        }

        public bool UpdateMoveTable(int maBan, int maHoaDon)
        {
            string query = "update dbo.phieugoiban set maban = @maban where mahoadon= @mahoadon";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maBan, maHoaDon });
            return result > 0;
        }

        public DataTable GetRevenue(DateTime thoiGianDau, DateTime thoiGianCuoi, int soTrang, int soDongTrenTrang)
        {
            string query = "exec GetRevenue @thoigiandau , @thoigiancuoi , @pagenumber , @max_number_rows_ofpage";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { thoiGianDau, thoiGianCuoi, soTrang, soDongTrenTrang });
        }

        public int GetDisPlayRecord(DateTime thoiGianDau, DateTime thoiGianCuoi, int soTrang, int soDongTrenTrang)
        {
            string query = "exec GetDisplayRecord @thoigiandau , @thoigiancuoi , @pagenumber , @max_number_rows_ofpage";
            int display = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { thoiGianDau, thoiGianCuoi, soTrang, soDongTrenTrang });
            return display;
        }

        public int GetRevenueRecordNum(DateTime thoiGianDau, DateTime thoiGianCuoi)
        {
            string query = "exec GetRevenueRecordNum @thoigianlap , @thoigianthanhtoan ";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { thoiGianDau, thoiGianCuoi });
        }

        internal bool UpdateBillNoDiscount(float thanhTien, float vat, float giaTriSauThue, float thucThu, int maHoaDon)
        {
            string query = "update dbo.hoadon set thanhtien= @thanhtien , vat= @vat ,giatrisauthue= @giatrisauthue , thucthu = @thucthu ,trangthaithanhtoan = 1 where mahoadon= @mahoadon and trangthaithanhtoan = 0";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { thanhTien, vat, giaTriSauThue, thucThu, maHoaDon });
            return result > 0;
        }
    }
}
