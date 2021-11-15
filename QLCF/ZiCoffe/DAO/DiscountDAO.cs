using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCoffe.DTO;

namespace ZiCoffe.DAO
{
    public class DiscountDAO
    {
        #region Package_DiscountDAO
        private static DiscountDAO instance;

        public static DiscountDAO Instance
        {
            get { if (instance == null) instance = new DiscountDAO(); return DiscountDAO.instance; }
            private set { DiscountDAO.instance = value; }
        }

        private DiscountDAO() { }
        #endregion

        public List<DiscountDTO> GetDiscountAvailableList()
        {
            List<DiscountDTO> discountList = new List<DiscountDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from chuongtrinhgiamgia as c, loaichuongtrinh as l where c.maloai = l.maloai and l.maloai = 1");
            foreach (DataRow item in data.Rows)
            {
                DiscountDTO discount = new DiscountDTO(item);
                discountList.Add(discount);
            }
            return discountList;
        }
    }
}
