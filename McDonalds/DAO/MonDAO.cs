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
    public class MonDAO
    {
        private static MonDAO instance;
        public static MonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MonDAO();
                return instance;
            }
            private set => instance = value;
        }
        private MonDAO() { }
        public List<Mon> getMon(string idMon)
        {
            List<Mon> list = new List<Mon>();
            string query = @"Select * from MON where IDMON = '" + idMon + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Mon(row));
            }
            return list;
        }

        public List<Mon> getMon()
        {
            List<Mon> list = new List<Mon>();
            string query = string.Format(@"Select * from MON");
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Mon(row));
            }
            return list;
        }
    }
}
