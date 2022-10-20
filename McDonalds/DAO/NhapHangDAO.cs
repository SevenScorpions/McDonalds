using McDonalds.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DAO
{
    public class NhapHangDAO
    {
        private static NhapHangDAO instance;
        public static NhapHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhapHangDAO();
                return instance;
            }
            private set => instance = value;
        }
        private NhapHangDAO() { }
        public List<NhapHang> getNhapHang()
        {
            List<NhapHang> list = new List<NhapHang>();
            string query = @"Select * from NHAPHANG";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new NhapHang(row));
            }
            return list;
        }
    }
}
