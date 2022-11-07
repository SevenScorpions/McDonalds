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
    public class HDComboDAO
    {
        private static HDComboDAO instance;
        public static HDComboDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HDComboDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private HDComboDAO() { }
        public List<HDCombo> getHDCombo()
        {
            List<HDCombo> list = new List<HDCombo>();
            string query = string.Format(@"SELECT * FROM HDCombo");
            DataTable table = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                list.Add(new HDCombo(row));
            }
            return list;
        }
    }
}
