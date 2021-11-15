using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiCoffe.DTO
{
    public class DrinksDTO
    {
        private int maDichVu;
        private string tenDichVu;
        private byte[] hinhAnh;
        private float donGia;
        private int tinhTrangSuDung;
        private string moTa;
        private int maDanhMuc;

        public int MaDichVu { get => maDichVu; set => maDichVu = value; }
        public string TenDichVu { get => tenDichVu; set => tenDichVu = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public int TinhTrangSuDung { get => tinhTrangSuDung; set => tinhTrangSuDung = value; }
        public int MaDanhMuc { get => maDanhMuc; set => maDanhMuc = value; }
        public string MoTa { get => moTa; set => moTa = value; }

        public DrinksDTO(int maDichVu, string tenDichVu, byte[] hinhAnh, float donGia, int tinhTrangSuDung, string moTa, int maDanhMuc)
        {
            this.MaDichVu = maDichVu;
            this.TenDichVu = tenDichVu;
            this.HinhAnh = hinhAnh;
            this.DonGia = donGia;
            this.TinhTrangSuDung = tinhTrangSuDung;
            this.MoTa = moTa;
            this.MaDanhMuc = maDanhMuc;
        }

        public DrinksDTO(DataRow row)
        {
            this.MaDichVu = (int)row["madichvu"];
            this.TenDichVu = row["tendichvu"].ToString();
            this.HinhAnh = (byte[])row["hinhanh"];
            this.DonGia = (float)Convert.ToDouble(row["dongia"].ToString());
            this.TinhTrangSuDung = Convert.ToInt32(row["tinhtrangsudung"]);
            this.MoTa = row["mota"].ToString();
            this.MaDanhMuc = (int)row["madanhmuc"];
        }
    }
}
