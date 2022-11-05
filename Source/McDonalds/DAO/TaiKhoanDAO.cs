using McDonalds.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
            private set => instance = value;
        }
        private TaiKhoanDAO() { }
        public List<TaiKhoan> getTaiKhoan(string username,string password)
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            string query = @"Select * from TAIKHOAN where USERNAME = '" + username + "' AND PASSWORD = '" + password + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new TaiKhoan(row));
            }
            return list;
        }
        public void createTaiKhoan(string username, string password, string chucvu)
        {
            string query = string.Format(@"insert into TAIKHOAN VALUE({0},{1},{2})",username,password,chucvu);
            DataProvider.Instance.ExcuteQuery(query);
        }
        public void createTaiKhoan(TaiKhoan taiKhoan)
        {
            string query = string.Format(@"insert into TAIKHOAN VALUE({0},{1},{2})", taiKhoan.Username, taiKhoan.Password, taiKhoan.ChucVu);
            DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
