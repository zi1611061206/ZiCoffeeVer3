using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiCoffe.DTO
{
    public class VoucherDTO
    {
        private int maChuongTrinh;
        private string noiDung;
        private float giaTri;
        private DateTime ngayLap;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private float dieuKienToiThieu;
        private int maLoai;
        private string tenLoai;
        private String maPhieu;
        private int trangThai;

        public VoucherDTO(DataRow row)
        {
            this.MaChuongTrinh = (int)row["machuongtrinh"];
            this.NoiDung = row["noidung"].ToString();
            this.GiaTri = (float)Convert.ToDouble(row["giatri"]);
            DateTime result, result1, result2;
            if (DateTime.TryParse(row["ngaylap"].ToString(), out result))
                this.NgayLap = result;
            if (DateTime.TryParse(row["ngaybatdau"].ToString(), out result1))
                this.NgayBatDau = result1;
            if (DateTime.TryParse(row["ngayketthuc"].ToString(), out result2))
                this.NgayKetThuc = result2;
            this.DieuKienToiThieu = (float)Convert.ToDouble(row["dieukientoithieu"]);
            this.MaLoai = (int)row["maloai"];
            this.TenLoai = row["tenloai"].ToString();
            this.MaPhieu = row["maphieu"].ToString();
            this.TrangThai = Convert.ToInt32(row["trangthai"]);
        }

        public VoucherDTO(int maChuongTrinh, string noiDung, float giaTri, DateTime ngayLap, DateTime ngayBatDau, DateTime ngayKetThuc, float dieuKienToiThieu, int maLoai, string tenLoai, string maPhieu, int trangThai)
        {
            this.MaChuongTrinh = maChuongTrinh;
            this.NoiDung = noiDung;
            this.GiaTri = giaTri;
            this.NgayLap = ngayLap;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.DieuKienToiThieu = dieuKienToiThieu;
            this.MaLoai = maLoai;
            this.TenLoai = tenLoai;
            this.MaPhieu = maPhieu;
            this.TrangThai = trangThai;
        }

        public int MaChuongTrinh { get => maChuongTrinh; set => maChuongTrinh = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public float GiaTri { get => giaTri; set => giaTri = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public float DieuKienToiThieu { get => dieuKienToiThieu; set => dieuKienToiThieu = value; }
        public int MaLoai { get => maLoai; set => maLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
