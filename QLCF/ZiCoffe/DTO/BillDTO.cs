using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiCoffe.DTO
{
    public class BillDTO
    {
        private int maHoaDon;
        private DateTime ngayLap;
        private int trangThaiThanhToan;
        private float thucThu;
        private float vat;
        private float thanhTien;
        private float giaTriSauThue;

        public int MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }
        public int TrangThaiThanhToan
        {
            get { return trangThaiThanhToan; }
            set { trangThaiThanhToan = value; }
        }

        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public float ThucThu { get => thucThu; set => thucThu = value; }
        public float Vat { get => vat; set => vat = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
        public float GiaTriSauThue { get => giaTriSauThue; set => giaTriSauThue = value; }

        public BillDTO(DataRow row)
        {
            this.MaHoaDon = (int)row["mahoadon"];
            DateTime result;
            if (DateTime.TryParse(row["ngaylap"].ToString(), out result))
                this.NgayLap = result;
            this.TrangThaiThanhToan = Convert.ToInt32(row["trangthaithanhtoan"]);
            this.ThucThu = float.Parse(row["thucthu"].ToString());
            this.Vat = float.Parse(row["vat"].ToString());
            this.ThanhTien = float.Parse(row["thanhtien"].ToString());
            this.GiaTriSauThue = float.Parse(row["giatrisauthue"].ToString());
        }

        public BillDTO(int maHoaDon, DateTime ngayLap, int trangThaiThanhToan, float thucThu, float vat, float thanhTien, float giaTriSauThue)
        {
            this.MaHoaDon = maHoaDon;
            this.NgayLap = ngayLap;
            this.TrangThaiThanhToan = trangThaiThanhToan;
            this.ThucThu = thucThu;
            this.Vat = vat;
            this.ThanhTien = thanhTien;
            this.GiaTriSauThue = giaTriSauThue;
        }
    }
}
