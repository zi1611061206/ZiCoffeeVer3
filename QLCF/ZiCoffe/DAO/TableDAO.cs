using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCoffe.DTO;

namespace ZiCoffe.DAO
{
    public class TableDAO
    {
        #region Package_TableDAO
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        private TableDAO() { }
        #endregion

        public List<TableDTO> GetTableList()
        {
            List<TableDTO> tablelist = new List<TableDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from ban");
            foreach (DataRow item in data.Rows)
            {
                TableDTO table = new TableDTO(item);
                tablelist.Add(table);
            }
            return tablelist;
        }

        public List<TableDTO> GetTableListByArea(int maKhuVuc)
        {
            List<TableDTO> tablelist = new List<TableDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from ban where makhuvuc= @makhuvuc", new object[] { maKhuVuc });
            foreach (DataRow item in data.Rows)
            {
                TableDTO table = new TableDTO(item);
                tablelist.Add(table);
            }
            return tablelist;
        }

        public List<TableDTO> GetTempTableList()
        {
            List<TableDTO> tempTableList = new List<TableDTO>();
            string query = "select * from dbo.ban where trangthaisudung = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TableDTO dataLine = new TableDTO(item);
                tempTableList.Add(dataLine);
            }
            return tempTableList;
        }

        public List<TableDTO> GetFullTableList()
        {
            List<TableDTO> fullTableList = new List<TableDTO>();
            string query = "select * from dbo.ban where trangthaisudung = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TableDTO dataLine = new TableDTO(item);
                fullTableList.Add(dataLine);
            }
            return fullTableList;
        }

        internal List<TableDTO> SearchTableByName(string tenBan)
        {
            List<TableDTO> tableList = new List<TableDTO>();
            string query = string.Format("exec SearchTable N'{0}'", tenBan);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TableDTO dataLine = new TableDTO(item);
                tableList.Add(dataLine);
            }
            return tableList;
        }

        public string GetTableName(int maban)
        {
            string query = "select tenban from ban where maban = " + maban;
            return DataProvider.Instance.ExecuteScalar(query).ToString();
        }

        public int CountTableTotal()//check
        {
            string query = "select count(*) from dbo.ban";
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public int CountFullTable()//check
        {
            string query = "select count(*) from dbo.ban where trangthaisudung = 1";
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public bool AddTable(string tenBan, int maKhuVuc)
        {
            string query = string.Format("insert into dbo.ban (tenban, makhuvuc) values ( N'{0}', {1})", tenBan, maKhuVuc);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool EditTable(int maBan, int maKhuVuc, string tenBan)
        {
            string query = "update dbo.ban set tenban = @tenban , makhuvuc= @makhuvuc where maban = @maban ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenBan, maKhuVuc, maBan });
            return result > 0;
        }

        public bool DeleteTable(int maBan)
        {
            string query = "delete dbo.ban where maban = @maban ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maBan });
            return result > 0;
        }

        public bool DeleteAllTableInArea(int maKhuVuc)
        {
            string query = "delete dbo.ban where makhuvuc = @makhuvuc ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maKhuVuc });
            return result > 0;
        }

        public List<TableDTO> SearchTable(string tenBan, int maKhuVuc)
        {
            List<TableDTO> tablelist = new List<TableDTO>();
            string query = string.Format("exec SearchTable N'{0}', {1}", tenBan, maKhuVuc);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TableDTO table = new TableDTO(item);
                tablelist.Add(table);
            }
            return tablelist;
        }

        internal bool DeleteAllTable()
        {
            string query = "delete dbo.ban";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
