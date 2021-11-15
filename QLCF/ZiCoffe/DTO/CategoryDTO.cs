using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiCoffe.DTO
{
    public class CategoryDTO
    {
        private int maDanhMuc;
        private string tenDanhMuc;

        public int MaDanhMuc
        {
            get { return maDanhMuc; }
            set { maDanhMuc = value; }
        }
        public string TenDanhMuc
        {
            get { return tenDanhMuc; }
            set { tenDanhMuc = value; }
        }

        public CategoryDTO(int maDanhMuc, string tenDanhMuc)
        {
            this.MaDanhMuc = maDanhMuc;
            this.TenDanhMuc = tenDanhMuc;
        }

        public CategoryDTO(DataRow row)
        {
            this.MaDanhMuc = (int)row["madanhmuc"];
            this.TenDanhMuc = row["tendanhmuc"].ToString();
        }
    }
}
