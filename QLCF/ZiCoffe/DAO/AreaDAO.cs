using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCoffe.DTO;

namespace ZiCoffe.DAO
{
    public class AreaDAO
    {
        #region Package_AreaDAO
        private static AreaDAO instance;

        public static AreaDAO Instance
        {
            get { if (instance == null) instance = new AreaDAO(); return AreaDAO.instance; }
            private set { AreaDAO.instance = value; }
        }

        public static int areaWidth = 133; //Chiều dài
        public static int areaHeigh = 50; //Chiều rộng

        private AreaDAO() { }
        #endregion

        public List<AreaDTO> GetAreaList()
        {
            List<AreaDTO> areaList = new List<AreaDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from khuvuc");
            foreach (DataRow item in data.Rows)
            {
                AreaDTO area = new AreaDTO(item);
                areaList.Add(area);
            }
            return areaList;
        }

        public DataTable GetArea()
        {
            string query = "exec LoadListArea";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchArea(string tenKhuVuc)
        {
            string query = string.Format("exec SearchArea N'{0}'", tenKhuVuc);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public string GetAreaName(int tableId)
        {
            string query = "select tenkhuvuc from ban as b, khuvuc as k where b.makhuvuc = k.makhuvuc and b.maban = " + tableId;
            return DataProvider.Instance.ExecuteScalar(query).ToString();
        }

        public bool AddArea(string tenKhuVuc)
        {
            string query = "insert into khuvuc (tenkhuvuc) values ( @tenkhuvuc )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenKhuVuc }) > 0;
        }

        public bool DeleteArea(int maKhuVuc)
        {
            TableDAO.Instance.DeleteAllTableInArea(maKhuVuc);
            string query = "delete khuvuc where makhuvuc = @makhuvuc ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maKhuVuc })>0;
        }

        public bool EditArea(int maKhuVuc, string tenKhuVuc)
        {
            string query = "update khuvuc set tenkhuvuc= @tenkhuvuc where makhuvuc= @makhuvuc ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenKhuVuc, maKhuVuc }) > 0;
        }
    }
}
