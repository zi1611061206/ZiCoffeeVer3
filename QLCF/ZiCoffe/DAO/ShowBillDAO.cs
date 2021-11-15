using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCoffe.DTO;

namespace ZiCoffe.DAO
{
    public class ShowBillDAO
    {
        #region Package_ShowBillDAO
        private static ShowBillDAO instance;

        public static ShowBillDAO Instance
        {
            get { if (instance == null) instance = new ShowBillDAO(); return ShowBillDAO.instance; }
            private set { instance = value; }
        }

        private ShowBillDAO() { }
        #endregion

        public List<ShowBillDTO> GetBill(int maBan)//check
        {
            List<ShowBillDTO> billInfoList = new List<ShowBillDTO>();
            string querry = "exec GetBillByTableID @maban ";
            DataTable data = DataProvider.Instance.ExecuteQuery(querry, new object[] { maBan });
            foreach (DataRow item in data.Rows)
            {
                ShowBillDTO dataLine = new ShowBillDTO(item);
                billInfoList.Add(dataLine);
            }
            return billInfoList;
        }
    }
}
