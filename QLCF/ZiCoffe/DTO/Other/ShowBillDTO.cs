using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiCoffe.DTO
{
    public class ShowBillDTO
    {
        private string tenDichVu;
        private int soLuong;
        private float donGia;
        private float thanhTien;

        public string TenDichVu
        {
            get { return tenDichVu; }
            set { tenDichVu = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public float ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

        public ShowBillDTO(string tenDichVu, int soLuong, float donGia, float thanhTien)
        {
            this.TenDichVu = tenDichVu;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.ThanhTien = thanhTien;
        }

        public ShowBillDTO(DataRow row)
        {
            this.TenDichVu = row["tendichvu"].ToString();
            this.SoLuong = (int)row["soluong"];
            this.DonGia = (float)Convert.ToDouble(row["dongia"].ToString());
            this.ThanhTien = (float)Convert.ToDouble(row["thanhtien"].ToString());
        }
    }
}
