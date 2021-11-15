using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiCoffe.DTO
{
    public class SupplierDTO
    {
        private int maNhaCungCap;
        private string tenNhaCungCap;
        private string diaChi;
        private string soDienThoai;
        private string email;

        public int MaNhaCungCap
        {
            get { return maNhaCungCap; }
            set { maNhaCungCap = value; }
        }
        public string TenNhaCungCap
        {
            get { return tenNhaCungCap; }
            set { tenNhaCungCap = value; }
        }
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
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public SupplierDTO(int maNhaCungCap, string tenNhaCungCap, string diaChi, string soDienThoai, string email)
        {
            this.MaNhaCungCap = maNhaCungCap;
            this.TenNhaCungCap = tenNhaCungCap;
            this.DiaChi = diaChi;
            this.SoDienThoai = tenNhaCungCap;
            this.Email = email;
        }

        public SupplierDTO(DataRow row)
        {
            this.MaNhaCungCap = (int)row["manhacungcap"];
            this.TenNhaCungCap = row["tennhacungcap"].ToString();
            this.DiaChi = row["diachi"].ToString();
            this.SoDienThoai = row["sodienthoai"].ToString();
            this.Email = row["email"].ToString();
        }
    }
}
