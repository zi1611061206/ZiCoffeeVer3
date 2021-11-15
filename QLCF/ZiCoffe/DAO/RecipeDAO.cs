using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCoffe.DTO;

namespace ZiCoffe.DAO
{
    public class RecipeDAO
    {
        #region Package_RecipeDAO
        private static RecipeDAO instance;

        public static RecipeDAO Instance
        {
            get { if (instance == null) instance = new RecipeDAO(); return RecipeDAO.instance; }
            private set { RecipeDAO.instance = value; }
        }

        private RecipeDAO() { }
        #endregion

        public List<RecipeDTO> GetRecipeList()
        {
            List<RecipeDTO> lst = new List<RecipeDTO>();
            string query = "select d.TenDichVu, n.TenNguyenLieu, c.SoLuongPha, n.SoLuongTon from congthucphache as c, nguyenlieu as n, DichVu as d where c.manguyenlieu=n.manguyenlieu and c.MaDichVu=d.MaDichVu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                RecipeDTO dataLine = new RecipeDTO(item);
                lst.Add(dataLine);
            }
            return lst;
        }

        public List<RecipeDTO> GetRecipeFilter(int maDichVu)
        {
            List<RecipeDTO> lst = new List<RecipeDTO>();
            string query = "select d.TenDichVu, n.TenNguyenLieu, c.SoLuongPha, n.SoLuongTon from congthucphache as c, nguyenlieu as n, DichVu as d where c.manguyenlieu=n.manguyenlieu and c.MaDichVu=d.MaDichVu and d.madichvu= @madichvu ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maDichVu });
            foreach (DataRow item in data.Rows)
            {
                RecipeDTO dataLine = new RecipeDTO(item);
                lst.Add(dataLine);
            }
            return lst;
        }

        public bool AddRecipe(int maDichVu, int maNguyenLieu, float soLuongPha)
        {
            string query = "insert into congthucphache (madichvu, manguyenlieu, soluongpha) values ( @madichvu , @manguyenlieu , @soluongpha )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maDichVu, maNguyenLieu, soLuongPha }) > 0;
        }

        public bool CheckExistedRecipe(int maDichVu)
        {
            string query = "select count(*) from congthucphache where madichvu= @madichvu ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maDichVu }) > 0;
        }

        public bool DeleteRecipe(int maNguyenLieu)
        {
            string query = "delete dbo.congthucphache where manguyenlieu = @manguyenlieu ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNguyenLieu }) > 0;
        }
    }
}
