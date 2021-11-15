using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiCoffe.DTO
{
    public class MaterialDTO
    {
        private int maNguyenLieu;
        private string tenNguyenLieu;
        private int soLuongTon;
        private string donViTinh;

        public int MaNguyenLieu
        {
            get { return maNguyenLieu; }
            set { maNguyenLieu = value; }
        }
        public string TenNguyenLieu
        {
            get { return tenNguyenLieu; }
            set { tenNguyenLieu = value; }
        }
        public int SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
        }
        public string DonViTinh
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }

        public MaterialDTO(int maNguyenLieu, string tenNguyenLieu, int soLuongTon, string donViTinh)
        {
            this.MaNguyenLieu = maNguyenLieu;
            this.TenNguyenLieu = tenNguyenLieu;
            this.SoLuongTon = soLuongTon;
            this.DonViTinh = donViTinh;
        }

        public MaterialDTO(DataRow row)
        {
            this.MaNguyenLieu = (int)row["manguyenlieu"];
            this.TenNguyenLieu = row["tennguyenlieu"].ToString();
            this.SoLuongTon = (int)row["soluongton"];
            this.DonViTinh = row["donvitinh"].ToString();
        }
    }
}
