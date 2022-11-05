using McDonalds.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DAO
{
    public class NguyenLieuDAO
    {
        private static NguyenLieuDAO instance;
        public static NguyenLieuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NguyenLieuDAO();
                return instance;
            }
            private set => instance = value;
        }
        private NguyenLieuDAO() { }
        public List<NguyenLieu> getNguyenLieu()
        {
            List<NguyenLieu> list = new List<NguyenLieu>();
            string query = @"Select * from NGUYENLIEU";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new NguyenLieu(row));
            }
            return list;
        }
        public List<NguyenLieu> getNguyenLieu(string id)
        {
            List<NguyenLieu> list = new List<NguyenLieu>();
            string query = @"Select * from NGUYENLIEU where idnl='"+id+"'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new NguyenLieu(row));
            }
            return list;
        }
    }
}
