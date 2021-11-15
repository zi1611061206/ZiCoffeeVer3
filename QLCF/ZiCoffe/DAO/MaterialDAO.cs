using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCoffe.DTO;

namespace ZiCoffe.DAO
{
    public class MaterialDAO
    {
        #region package_MaterialDAO
        private static MaterialDAO instance;

        public static MaterialDAO Instance
        {
            get { if (instance == null) instance = new MaterialDAO(); return MaterialDAO.instance; }
            private set { MaterialDAO.instance = value; }
        }

        private MaterialDAO() { }
        #endregion

        public DataTable GetMaterial()
        {
            string query = "exec LoadListMaterial";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<MaterialDTO> GetMaterialList()
        {
            List<MaterialDTO> materialList = new List<MaterialDTO>();
            string query = "select * from nguyenlieu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MaterialDTO dataLine = new MaterialDTO(item);
                materialList.Add(dataLine);
            }
            return materialList;
        }

        public DataTable SearchMaterial(string tenNguyenLieu)
        {
            string query = string.Format("exec SearchMaterial N'{0}'", tenNguyenLieu);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddMaterial(string tenNguyenLieu, int soLuongTon, string donViTinh)
        {
            string query = "insert into dbo.nguyenlieu (tennguyenlieu, soluongton, donvitinh) values ( @tennguyenlieu , @soluongton , @donvitinh )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenNguyenLieu, soLuongTon, donViTinh });
            return result > 0;
        }

        public bool DeleteMaterial(int maNguyenLieu)
        {
            string query = "delete dbo.nguyenlieu where manguyenlieu= @manguyenlieu";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNguyenLieu });
            return result > 0;
        }

        public bool ChangeMaterial(string tenNguyenLieu, int soLuongTon, string donViTinh, int maNguyenLieu)
        {
            string query = "update dbo.nguyenlieu set tennguyenlieu= @tennguyenlieu , soluongton= @soluongton , donvitinh= @soluongtinh where manguyenlieu= @manguyenlieu ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenNguyenLieu, soLuongTon, donViTinh, maNguyenLieu });
            return result > 0;
        }
    }
}
