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
    public class GiamGiaComboDAO
    {
        private static GiamGiaComboDAO instance;
        public static GiamGiaComboDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GiamGiaComboDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private GiamGiaComboDAO() { }
        public List<GiamGiaCombo> getGiamGiaCombo()
        {
            List<GiamGiaCombo> list = new List<GiamGiaCombo>();
            string query = string.Format(@"SELECT * FROM GIAMGIACOMBO");
            DataTable table = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                list.Add(new GiamGiaCombo(row));
            }
            return list;
        }
        public List<GiamGiaCombo> getCurrentGiamGiaComboByID(string idcombo)
        {
            List<GiamGiaCombo> list = new List<GiamGiaCombo>();
            string query = string.Format(@"SELECT * FROM GIAMGIACOMBO WHERE IDCOMBO={0} AND {1} BETWEEN TGBATDAU AND TGKETTHUC",idcombo,DateTime.Now);
            DataTable table = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                list.Add(new GiamGiaCombo(row));
            }
            return list;
        }
    }
}
