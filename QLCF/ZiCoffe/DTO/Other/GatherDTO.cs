using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiCoffe.DTO
{
    public class GatherDTO
    {
        private int maHoaDon;
        private int maDichVu;
        private int soLuong;

        public int MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }
        public int MaDichVu
        {
            get { return maDichVu; }
            set { maDichVu = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public GatherDTO(int maHoaDon, int maDichVu, int soLuong, float thanhTien)
        {
            this.MaHoaDon = maHoaDon;
            this.MaDichVu = maDichVu;
            this.SoLuong = soLuong;
        }

        public GatherDTO(DataRow row)
        {
            this.MaHoaDon = (int)row["mahoadon"];
            this.MaDichVu = (int)row["madichvu"];
            this.SoLuong = (int)row["soluong"];
        }
    }
}
