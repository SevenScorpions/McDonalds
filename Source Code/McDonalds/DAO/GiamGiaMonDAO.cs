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
    public class GiamGiaMonDAO
    {
        private static GiamGiaMonDAO instance;
        public static GiamGiaMonDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GiamGiaMonDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private GiamGiaMonDAO() { }
        public List<GiamGiaMon> getGiamGiaMon()
        {
            List<GiamGiaMon> list = new List<GiamGiaMon>();
            string query = string.Format(@"SELECT * FROM GiamGiaMon");
            DataTable table = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                list.Add(new GiamGiaMon(row));
            }
            return list;
        }
    }
}
