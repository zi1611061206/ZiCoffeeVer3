using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiCoffe.DTO
{
    public class BillInfoDTO
    {
        private int maHoaDon;
        private int maDichVu;
        private int soLuong;
        private float thanhTien;

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
        public float ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

        public BillInfoDTO(int maHoaDon, int maDichVu, int soLuong, float thanhTien)
        {
            this.MaHoaDon = maHoaDon;
            this.MaDichVu = maDichVu;
            this.SoLuong = soLuong;
            this.ThanhTien = ThanhTien;
        }

        public BillInfoDTO(DataRow row)
        {
            this.MaHoaDon = (int)row["mahoadon"];
            this.MaDichVu = (int)row["madichvu"];
            this.SoLuong = (int)row["soluong"];
            this.ThanhTien = (float)row["thanhtien"];
        }
    }
}
