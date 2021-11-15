using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiCoffe.DTO
{
    public class AccountDTO
    {
        private string tenDangNhap;
        private int maNhanVien;
        private DateTime ngayLap;
        //private string matKhau;

        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }
        public int MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }

        public AccountDTO(string tenDangNhap, int maNhanVien, DateTime ngayLap)
        {
            this.TenDangNhap = tenDangNhap;
            this.MaNhanVien = maNhanVien;
            this.NgayLap = ngayLap;
        }

        public AccountDTO(DataRow row)
        {
            this.TenDangNhap = row["tendangnhap"].ToString();
            this.MaNhanVien = (int)row["manhanvien"];
            DateTime result;
            if (DateTime.TryParse(row["ngaylap"].ToString(), out result))
                this.NgayLap = result;
        }
    }
}
