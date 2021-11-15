using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCoffe.DTO;

namespace ZiCoffe.DAO
{
    public class MenuDAO
    {
        #region Package_MenuDAO
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }
        #endregion

        public List<DrinksDTO> GetDrinkList(int maDanhMuc)
        {
            List<DrinksDTO> drinksList = new List<DrinksDTO>();
            string query = "select * from dichvu where madanhmuc= @madanhmuc ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maDanhMuc });

            foreach (DataRow item in data.Rows)
            {
                DrinksDTO dataLine = new DrinksDTO(item);
                drinksList.Add(dataLine);
            }
            return drinksList;
        }

        public List<DrinksDTO> GetAllDrinks()
        {
            List<DrinksDTO> drinksList = new List<DrinksDTO>();
            string query = "select * from dichvu ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DrinksDTO dataLine = new DrinksDTO(item);
                drinksList.Add(dataLine);
            }
            return drinksList;
        }

        public List<DrinksDTO> GetDrinkListByCategory(int maDanhMuc)
        {
            List<DrinksDTO> drinksList = new List<DrinksDTO>();
            string query = "select * from dichvu where madanhmuc= @madanhmuc ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maDanhMuc });

            foreach (DataRow item in data.Rows)
            {
                DrinksDTO dataLine = new DrinksDTO(item);
                drinksList.Add(dataLine);
            }
            return drinksList;
        }

        public List<DrinksDTO> SearchDrinks(string tenDichVu)
        {
            List<DrinksDTO> drinksList = new List<DrinksDTO>();
            string query = string.Format("select * from dbo.DichVu where dbo.fuConvertToUnsign1(TenDichVu) like N'%'+dbo.fuConvertToUnsign1( '{0}' )+'%'", tenDichVu);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DrinksDTO dataLine = new DrinksDTO(item);
                drinksList.Add(dataLine);
            }
            return drinksList;
        }

        public List<DrinksDTO> GetServiceList()
        {
            List<DrinksDTO> drinksList = new List<DrinksDTO>();
            string query = "select * from dichvu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DrinksDTO dataLine = new DrinksDTO(item);
                drinksList.Add(dataLine);
            }
            return drinksList;
        }

        public DataTable GetMenu()
        {
            string query = "exec LoadListMenu";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetMenuByCategory(int maDanhMuc)
        {
            string query = "exec LoadListMenuByCategory @madanhmuc ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maDanhMuc });
        }

        public DataTable SearchMenu(string tenDichVu)
        {
            string query = string.Format("exec SearchMenu N'{0}'", tenDichVu);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddDrinks(string tenDoUong, int maDanhMuc, float giaBan, byte[] hinhAnh, string moTa, bool tinhTrang)
        {
            string query = "insert into dbo.dichvu (madanhmuc,tendichvu,dongia,hinhanh, mota, tinhtrangsudung) values ( @madanhmuc , @tendichvu , @dongia , @hinhanh , @mota , @tinhtrangsudung )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maDanhMuc, tenDoUong, giaBan, hinhAnh, moTa, tinhTrang });
            return result > 0;
        }

        public bool DeleteDrinks(int maDichVu)
        {
            BillInfoDAO.Instance.DeleteBillInfo2(maDichVu);
            string query = "delete dbo.dichvu where madichvu= @madichvu";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maDichVu });
            return result > 0;
        }

        public bool DeleteDrinksByCategory(int maDanhMuc)
        {
            string query = "delete dbo.dichvu where madanhmuc= @madanhmuc";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maDanhMuc });
            return result > 0;
        }

        public bool ChangeDrinks(string tenDichVu, int maDanhMuc, float donGia, byte[] hinhAnh, int maDichVu, string moTa, bool tinhTrang)
        {
            string query = "update dbo.dichvu set tendichvu= @tendichvu , madanhmuc= @madanhmuc ,  dongia=  @dongia , hinhanh= @hinhanh , mota= @mota , tinhtrangsudung= @tinhtrang where madichvu= @madichvu";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDichVu, maDanhMuc, donGia, hinhAnh, moTa, tinhTrang, maDichVu,  });
            return result > 0;
        }

        public bool ChangeDrinks2(string tenDichVu, int maDanhMuc, float donGia, int maDichVu, string moTa, bool tinhTrang)
        {
            string query = "update dbo.dichvu set tendichvu= @tendichvu , madanhmuc= @madanhmuc ,  dongia=  @dongia , mota= @mota , tinhtrangsudung= @tinhtrang where madichvu= @madichvu";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDichVu, maDanhMuc, donGia, moTa, tinhTrang, maDichVu });
            return result > 0;
        }

        public bool GetStatus(int maDichVu)
        {
            string query = "select tinhtrangsudung from dichvu where madichvu = @madichvu ";
            Object ob = DataProvider.Instance.ExecuteScalar(query, new object[] { maDichVu });
            return (bool)ob;
        }
    }
}
