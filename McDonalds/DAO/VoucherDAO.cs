using McDonalds.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Hoa
namespace McDonalds.DAO
{
    public class VoucherDAO
    {
        private static VoucherDAO instance;
        public static VoucherDAO Instance
        {
            get { 
                if (instance == null)
                {
                    instance = new VoucherDAO();
                }
                return instance; 
            }
            private set => instance = value;
        }
        private VoucherDAO() { }
        public List<Voucher> getVoucher()
        {
            List<Voucher> list = new List<Voucher>();
            string query = @"Select * from VOUCHER";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                list.Add(new Voucher(dr));
            }
            return list;
        }
        public List<Voucher> getVoucher(string idVoucher)
        {
            List<Voucher> list = new List<Voucher>();
            string query = @"Select * from VOUCHER where IDVOUCHER = '" + idVoucher + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                list.Add(new Voucher(dr));
            }
            return list;
        }
    }
}
