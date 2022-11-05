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
    public class SoHuuDAO
    {
        private static SoHuuDAO instance;
        public static SoHuuDAO Instance
        {
            get { 
                if(instance == null)
                {
                    instance = new SoHuuDAO();
                }
                return instance; 
            }
            private set => instance = value;
        }
        private SoHuuDAO() { }
        public List<SoHuu> getSoHuu()
        {
            List<SoHuu> list = new List<SoHuu>();
            string query = @"Select * from SOHUU";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow dataRow in data.Rows)
            {
                list.Add(new SoHuu(dataRow));
            }
            return list;
        }
        public List<SoHuu> getSoHuu(string idKH)
        {
            List<SoHuu> list = new List<SoHuu>();
            string query = @"Select * from SOHUU where IDKH = '" + idKH + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow dataRow in data.Rows)
            {
                list.Add(new SoHuu(dataRow));
            }
            return list;
        }
        public List<SoHuu> getSoHuu(string idKH, string idVoucher)
        {
            List<SoHuu> list = new List<SoHuu>();
            string query = @"Select * from SOHUU where IDKH = '" + idKH + "' and IDVOUCHER = '" + idVoucher + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow dataRow in data.Rows)
            {
                list.Add(new SoHuu(dataRow));
            }
            return list;
        }


    }
}
