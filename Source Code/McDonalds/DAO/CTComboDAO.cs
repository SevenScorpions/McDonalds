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
    public class CTComboDAO
    {
        private static CTComboDAO instance;
        public static CTComboDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTComboDAO();
                return instance;
            }
            private set => instance = value;
        }
        private CTComboDAO() { }

        public List<CTCombo> getCTCombo(string idCombo)
        {
            List<CTCombo> list = new List<CTCombo>();
            string query = @"Select * from CTCOMBO where IDCOMBO = '" + idCombo + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new CTCombo(row));
            }
            return list;
        }

        public List<CTCombo> getCTCombofromCTMon(string idCTMon)
        {
            List<CTCombo> list = new List<CTCombo>();
            string query = @"Select * from CTCOMBO where IDCTMON = '" + idCTMon + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new CTCombo(row));
            }
            return list;
        }

        public List<CTCombo> getCTCombo()
        {
            List<CTCombo> list = new List<CTCombo>();
            string query = @"Select * from CTCOMBO";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new CTCombo(row));
            }
            return list;
        }
    }
}
