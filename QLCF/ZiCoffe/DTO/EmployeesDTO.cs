using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiCoffe.DTO
{
    public class EmployeesDTO
    {
        private int maNhanVien;
        private string ho;
        private string tenDem;
        private string ten;
        private string diaChi;
        private string soDienThoai;
        private DateTime ngaySinh;
        private int gioiTinh;
        private string chungMinhNhanDan;
        private byte[] anhDaiDien;
        private int maChucVu;

        public int MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }
        public string Ho { get => ho; set => ho = value; }
        public string TenDem { get => tenDem; set => tenDem = value; }
        public string Ten { get => ten; set => ten = value; }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public int GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public string ChungMinhNhanDan
        {
            get { return chungMinhNhanDan; }
            set { chungMinhNhanDan = value; }
        }
        public byte[] AnhDaiDien { get => anhDaiDien; set => anhDaiDien = value; }
        public int MaChucVu
        {
            get { return maChucVu; }
            set { maChucVu = value; }
        }

        public string fullInfo => $"{maNhanVien} - {ho} {tenDem} {ten} - {chungMinhNhanDan}";
        
        public EmployeesDTO(DataRow row)
        {
            this.MaNhanVien = (int)row["manhanvien"];
            this.Ho = row["ho"].ToString();
            this.TenDem = row["tendem"].ToString();
            this.Ten = row["ten"].ToString();
            this.DiaChi = row["diachi"].ToString();
            this.SoDienThoai = row["sodienthoai"].ToString();
            DateTime result;
            if (DateTime.TryParse(row["ngaysinh"].ToString(), out result))
                this.NgaySinh = result;
            this.GioiTinh = Convert.ToInt32(row["gioitinh"]);
            this.ChungMinhNhanDan = row["chungminhnhandan"].ToString();
            this.AnhDaiDien = (byte[])row["anhdaidien"];
            this.MaChucVu = (int)row["machucvu"];
        }

        public EmployeesDTO(int maNhanVien, string ho, string tenDem, string ten, string diaChi, string soDienThoai, DateTime ngaySinh, int gioiTinh, string chungMinhNhanDan, byte[] anhDaiDien, int maChucVu)
        {
            this.maNhanVien = maNhanVien;
            this.Ho = ho;
            this.TenDem = tenDem;
            this.Ten = ten;
            this.DiaChi = diaChi;
            this.SoDienThoai = soDienThoai;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.ChungMinhNhanDan = chungMinhNhanDan;
            this.AnhDaiDien = anhDaiDien;
            this.MaChucVu = maChucVu;
        }
    }
}
