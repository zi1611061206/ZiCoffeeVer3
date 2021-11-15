using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCoffe.DTO;

namespace ZiCoffe.DAO
{
    public class CategoryDAO
    {
        #region Package_CateDAO
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }
        #endregion

        public List<CategoryDTO> GetCategoryList()
        {
            List<CategoryDTO> categoryList = new List<CategoryDTO>();
            string query = "select * from danhmuc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CategoryDTO dataLine = new CategoryDTO(item);
                categoryList.Add(dataLine);
            }
            return categoryList;
        }

        public DataTable GetCategory()
        {
            string query = "exec LoadListCategory";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchCategory(string tenDanhMuc)
        {
            string query = string.Format("exec SearchCategory N'{0}'", tenDanhMuc);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddCategory(string tenDanhMuc)
        {
            string query = "insert into dbo.danhmuc (tendanhmuc) values ( @tendanhmuc )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDanhMuc });
            return result > 0;
        }

        public bool DeleteCategory(int maDanhMuc)
        {
            MenuDAO.Instance.DeleteDrinksByCategory(maDanhMuc);
            string query = "delete dbo.danhmuc where madanhmuc = @madanhmuc ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maDanhMuc });
            return result > 0;
        }

        public bool ChangeCategory(string tenDanhMuc, int maDanhMuc)
        {
            string query = "update dbo.danhmuc set tendanhmuc= @tendanhmuc where madanhmuc= @madanhmuc ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDanhMuc, maDanhMuc });
            return result > 0;
        }
    }
}
