using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiCoffe.DTO
{
    public class TableDTO
    {
        private int maBan;
        private int maKhuVuc;
        private string tenBan;
        private int trangThaiSuDung;

        public int MaBan
        {
            get { return maBan; }
            set { maBan = value; }
        }
        public int MaKhuVuc
        {
            get { return maKhuVuc; }
            set { maKhuVuc = value; }
        }
        public string TenBan
        {
            get { return tenBan; }
            set { tenBan = value; }
        }
        public int TrangThaiSuDung
        {
            get { return trangThaiSuDung; }
            set { trangThaiSuDung = value; }
        }

        public string fullName => $"{tenBan} - khu vực: {maKhuVuc}";

        public TableDTO(int maBan, int maKhuVuc, string tenBan, int trangThaiSuDung)
        {
            this.MaBan = maBan;
            this.MaKhuVuc = maKhuVuc;
            this.TenBan = tenBan;
            this.TrangThaiSuDung = trangThaiSuDung;
        }

        public TableDTO(DataRow row)
        {
            this.MaBan = (int)row["maban"];
            this.MaKhuVuc = (int)row["makhuvuc"];
            this.TenBan = row["tenban"].ToString();
            this.TrangThaiSuDung = Convert.ToInt32(row["trangthaisudung"]);
        }
    }
}
