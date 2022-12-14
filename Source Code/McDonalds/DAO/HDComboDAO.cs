using McDonalds.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<HDCombo> GetHDCombos()
        {
            List<HDCombo> list = new List<HDCombo>();
            string query = @"Select * from HDCombo";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new HDCombo(row));
            }
            return list;
        }
        public void insertHDCombo(string idhd, string idcombo, int soluong)
        {
            string query = @"INSERT INTO Hdcombo VALUES('" + idhd + "','" + idcombo + "'," + soluong + ")";
            DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
