using McDonalds.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DAO
{
    public class LoHangDAO
    {
        private static LoHangDAO instance;
        public static LoHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoHangDAO();
                return instance;
            }
            private set => instance = value;
        }
        private LoHangDAO() { }
        public List<LoHang> getLoHangFromNL(string idNL)
        {
            List<LoHang> list = new List<LoHang>();
            string query = string.Format(@"Select * from LOHANG where IDNL={0}",idNL);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new LoHang(row));
            }
            return list;
        }
        public List<LoHang> getLoHangFromNH(string idNH)
        {
            List<LoHang> list = new List<LoHang>();
            string query = string.Format(@"Select * from LOHANG where IDNH={0}", idNH);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new LoHang(row));
            }
            return list;
        }
        public List<LoHang> getLoHang(string idNL,string idNH)
        {
            List<LoHang> list = new List<LoHang>();
            string query = string.Format(@"Select * from LOHANG where IDNL={0} and IDNH={1}", idNL,idNH);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new LoHang(row));
            }
            return list;
        }
        public List<LoHang> getLoHang()
        {
            List<LoHang> list = new List<LoHang>();
            string query = string.Format(@"Select * from LOHANG");
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new LoHang(row));
            }
            return list;
        }
    }
}
