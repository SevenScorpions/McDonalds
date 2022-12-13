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
    public class ComboDAO
    {
        private static ComboDAO instance;
        public static ComboDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ComboDAO();
                return instance;
            }
            private set => instance = value;
        }
        private ComboDAO() { }

        public List<Combo> getCombo(string idCombo)
        {
            List<Combo> list = new List<Combo>();
            string query = @"Select * from COMBO where IDCOMBO = '" + idCombo + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Combo(row));
            }
            return list;
        }

        public List<Combo> getCombo()
        {
            List<Combo> list = new List<Combo>();
            string query = string.Format(@"Select * from COMBO Where TRANGTHAI <> N'NGƯNG BÁN'");
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Combo(row));
            }
            return list;
        }
    }
}
