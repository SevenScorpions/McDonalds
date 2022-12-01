using McDonalds.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Hoa
namespace McDonalds.DAO
{
    public class SDVoucherDAO
    {
        private static SDVoucherDAO instance;
        public static SDVoucherDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SDVoucherDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private SDVoucherDAO() { }
        public List<SDVoucher> getSDVouchers()
        {
            List<SDVoucher> list = new List<SDVoucher>();
            string query = @"Select * from SDVOUCHER";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow dataRow in data.Rows)
            {
                list.Add(new SDVoucher(dataRow));
            }
            return list;
        }

    }
}
