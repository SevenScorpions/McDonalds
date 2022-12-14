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
    public class HDCTMonDAO
    {
        private static HDCTMonDAO instance;
        public static HDCTMonDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HDCTMonDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private HDCTMonDAO() { }
        public List<HDCTMon> getHDCTMon()
        {
            List<HDCTMon> list = new List<HDCTMon>();
            string query = string.Format(@"SELECT * FROM HDCTMon");
            DataTable table = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                list.Add(new HDCTMon(row));
            }
            return list;
        }
        public void insertHDCTMon(string idhd, string idctmon, int soluong)
        {
            string query = @"INSERT INTO HDCTMON VALUES('" + idhd + "','" + idctmon + "'," + soluong + ")";
            DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
