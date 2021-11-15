using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiCoffe.DAO
{
    public class ImportDAO
    {
        #region Package_ImportDAO
        private static ImportDAO instance;

        public static ImportDAO Instance
        {
            get { if (instance == null) instance = new ImportDAO(); return ImportDAO.instance; }
            private set { ImportDAO.instance = value; }
        }

        private ImportDAO() { }
        #endregion

        public DataTable GetImportCard()
        {
            string query = "select p.maphieu as [Mã phiếu], n.tennhacungcap as [Nhà cung cấp], p.ngay as [Ngày] from phieunhap as p, nhacungcap as n where p.manhacungcap=n.manhacungcap";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetImportInfo(int maPhieu)
        {
            string query = "select c.maphieu as [Mã phiếu], n.tennguyenlieu as [Tên nguyên liệu], c.soluongnhap as [Số lượng nhập], c.dongianhap as [Đơn giá nhập] from chitietphieunhap as c, nguyenlieu as n where c.manguyenlieu=n.manguyenlieu and maphieu= @maphieu ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maPhieu });
        }

        public bool AddImport(int maNhaCungCap)
        {
            string query = "insert into dbo.phieunhap (manhacungcap) values ( @manhacungcap )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNhaCungCap });
            return result > 0;
        }

        public int GetMaxImportID()
        {
            try
            {
                string query = "select max(maphieu) from phieunhap";
                int maxID = (int)DataProvider.Instance.ExecuteScalar(query);
                return maxID;
            }
            catch
            {
                return 0;
            }
        }

        public bool AddImportInfo(int maPhieu, int maNguyenLieu, int soLuongNhap, float donGiaNhap)
        {
            string query = "insert into dbo.chitietphieunhap (maphieu, manguyenlieu, soluongnhap, dongianhap) values ( @maphieu , @manguyenlieu , @soluongnhap , @dongianhap )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maPhieu, maNguyenLieu, soLuongNhap, donGiaNhap });
            return result > 0;
        }

        public bool DeleteImport(int maPhieu)
        {
            string query = "delete dbo.phieunhap where maphieu = @maphieu ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maPhieu }) > 0;
        }

        public bool DeleteImportInfo(int maPhieu)
        {
            string query = "delete dbo.chitietphieunhap where maphieu = @maphieu ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maPhieu }) > 0;
        }

        public bool DeleteImportInfo2(int maNguyenLieu)
        {
            string query = "delete dbo.chitietphieunhap where manguyenlieu = @manguyenlieu ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNguyenLieu }) > 0;
        }

        public bool DeleteImport2(int maNhaCungCap)
        {
            string query = "delete dbo.phieunhap where manhacungcap = @manhacungcap ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNhaCungCap }) > 0;
        }
    }
}
