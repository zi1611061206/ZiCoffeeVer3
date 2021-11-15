using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCoffe.DTO;

namespace ZiCoffe.DAO
{
    public class VoucherDAO
    {
        #region package_VoucherDAO
        private static VoucherDAO instance;
        public static VoucherDAO Instance
        {
            get { if (instance == null) instance = new VoucherDAO(); return instance; }
            private set { instance = value; }
        }
        private VoucherDAO() { }
        #endregion

        public VoucherDTO GetVoucher(string maGiamGia)
        {
            string query = "select * from phieugiamgia as p, chuongtrinhgiamgia as c, loaichuongtrinh as l where p.machuongtrinh = c.machuongtrinh and c.maloai = l.maloai and maphieu = @maphieu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maGiamGia });

            foreach (DataRow item in data.Rows)
            {
                return new VoucherDTO(item);
            }
            return null;
        }

        public bool ApplyVoucherToBill(string maPhieu, int maHoaDon)
        {
            string query = "update hoadon set maphieugiamgia = @maphieu  where mahoadon = @mahoadon ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { maPhieu, maHoaDon }) > 0)
                return true;
            return false;
        }

        public bool UpdateVoucherStatus(string maPhieu)
        {
            string query = "update phieugiamgia set trangthai = 1  where maphieu = @maphieu ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { maPhieu }) > 0)
                return true;
            return false;
        }
    }
}
