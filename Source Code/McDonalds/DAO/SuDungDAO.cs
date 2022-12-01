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
    public class SuDungDAO
    {
        private static SuDungDAO instance;
        public static SuDungDAO Instance
        {
            get { 
                if(instance == null)
                {
                    instance = new SuDungDAO();
                }
                return instance; 
            }
            private set => instance = value;
        }
        private SuDungDAO() { }
        public List<SuDung> getSoHuu()
        {
            List<SuDung> list = new List<SuDung>();
            string query = @"Select * from SOHUU";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow dataRow in data.Rows)
            {
                list.Add(new SuDung(dataRow));
            }
            return list;
        }
        public List<SuDung> getSoHuu(string idKH)
        {
            List<SuDung> list = new List<SuDung>();
            string query = @"Select * from SOHUU where IDKH = '" + idKH + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow dataRow in data.Rows)
            {
                list.Add(new SuDung(dataRow));
            }
            return list;
        }
        public List<SuDung> getSoHuu(string idKH, string idVoucher)
        {
            List<SuDung> list = new List<SuDung>();
            string query = @"Select * from SOHUU where IDKH = '" + idKH + "' and IDVOUCHER = '" + idVoucher + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow dataRow in data.Rows)
            {
                list.Add(new SuDung(dataRow));
            }
            return list;
        }


    }
}
