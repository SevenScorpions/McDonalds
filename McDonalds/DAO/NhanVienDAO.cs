using McDonalds.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
            private set => instance = value;
        }
        private NhanVienDAO() { }
        public List<NhanVien> getNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            string query = @"Select * from NHANVIEN";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new NhanVien(row));
            }
            return list;
        }
    }
}
