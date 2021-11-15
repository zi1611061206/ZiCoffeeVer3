using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiCoffe.DTO
{
    public class AreaDTO
    {
        private int maKhuVuc;
        private string tenKhuVuc;

        public int MaKhuVuc
        {
            get { return maKhuVuc; }
            set { maKhuVuc = value; }
        }
        public string TenKhuVuc
        {
            get { return tenKhuVuc; }
            set { tenKhuVuc = value; }
        }

        public AreaDTO(int maHoaDon, int maBan, int trangThaiThanhToan, double khuyenMai, double tongGiaTri)
        {
            this.MaKhuVuc = maKhuVuc;
            this.TenKhuVuc = tenKhuVuc;
        }

        public AreaDTO(DataRow row)
        {
            this.MaKhuVuc = (int)row["makhuvuc"];
            this.TenKhuVuc = row["tenkhuvuc"].ToString(); ;
        }
    }
}
