using McDonalds.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Yen
namespace McDonalds.DAO
{
    public class CTMonDAO
    {
        private static CTMonDAO instance;
        public static CTMonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTMonDAO();
                return instance;
            }
            private set => instance = value;
        }
        private CTMonDAO() { }

        public List<CTMon> getCTMon(string idCTMon)
        {
            List<CTMon> list = new List<CTMon>();
            string query = @"Select * from CTMON where IDCTMON = '" + idCTMon + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new CTMon(row));
            }
            return list;
        }

        public List<CTMon> getCTMonByIdMon(string idMon)
        {
            List<CTMon> list = new List<CTMon>();
            string query = @"Select * from CTMON where IDMON = '" + idMon + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new CTMon(row));
            }
            return list;
        }

        public List<CTMon> getCTMon()
        {
            List<CTMon> list = new List<CTMon>();
            string query = @"Select * from CTMON";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new CTMon(row));
            }
            return list;
        }
    }
}
