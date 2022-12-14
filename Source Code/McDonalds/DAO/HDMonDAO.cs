using McDonalds.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Anh
namespace McDonalds.DAO
{
    public class HDMonDAO
    {
        private static HDMonDAO instance;
        public static HDMonDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HDMonDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private HDMonDAO() { }
        public List<HDMon> getHDMon()
        {
            List<HDMon> list = new List<HDMon>();
            string query = string.Format(@"SELECT * FROM HDMon");
            DataTable table = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                list.Add(new HDMon(row));
            }
            return list;
        }
        public void insertHDMon(string idhd, string idmon, int soluong)
        {
            string query = @"INSERT INTO HDMON VALUES('" + idhd + "','" + idmon + "'," + soluong + ")";
            DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
