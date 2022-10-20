using McDonalds.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DAO
{
    public class KiemKhoDAO
    {
        private static KiemKhoDAO instance;
        public static KiemKhoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KiemKhoDAO();
                return instance;
            }
            private set => instance = value;
        }
        private KiemKhoDAO() { }
        public List<KiemKho> getKiemKho()
        {
            List<KiemKho> list = new List<KiemKho>();
            string query = @"Select * from KIEMKHO";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new KiemKho(row));
            }
            return list;
        }
        public List<KiemKho> getKiemKhoFromSL()
        {
            List<KiemKho> list = new List<KiemKho>();
            string query = @"Select * from KIEMKHO WHERE SOLUONG>0";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new KiemKho(row));
            }
            return list;
        }
        public List<KiemKho> getKiemKhoFromLH(string idLH)
        {
            List<KiemKho> list = new List<KiemKho>();
            string query = string.Format(@"Select * from KIEMKHO WHERE LH={0} and SOLUONG>0",idLH);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new KiemKho(row));
            }
            return list;
        }
    }
}
