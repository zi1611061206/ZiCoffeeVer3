using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiCoffe.DTO
{
    public class RecipeDTO
    {
        private string tenDichVu;
        private string tenNguyenLieu;
        private float soLuongPha;
        private int soLuongTon;

        public string TenDichVu
        {
            get { return tenDichVu; }
            set { tenDichVu = value; }
        }
        public string TenNguyenLieu
        {
            get { return tenNguyenLieu; }
            set { tenNguyenLieu = value; }
        }
        public float SoLuongPha
        {
            get { return soLuongPha; }
            set { soLuongPha = value; }
        }
        public int SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
        }

        public RecipeDTO(string tenDichVu, string tenNguyenLieu, float soLuongPha, int soLuongTon)
        {
            this.TenDichVu = tenDichVu;
            this.TenNguyenLieu = tenNguyenLieu;
            this.SoLuongPha = soLuongPha;
            this.SoLuongTon = soLuongTon;
        }

        public RecipeDTO(DataRow row)
        {
            this.TenDichVu = row["tendichvu"].ToString();
            this.TenNguyenLieu = row["tennguyenlieu"].ToString();
            this.SoLuongPha = float.Parse(row["soluongpha"].ToString());
            this.SoLuongTon = (int)row["soluongton"];
        }
    }
}
