using McDonalds.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Hoa
namespace McDonalds.DAO
{
    public class TaiKhoanKHDAO
    {
        private static TaiKhoanKHDAO instance;
        public static TaiKhoanKHDAO Instance
        {
            get
            {

                if (instance == null)
                {
                    instance = new TaiKhoanKHDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private TaiKhoanKHDAO() { }
        public List<TaiKhoanKH> getTaiKhoanKH()
        {
            List<TaiKhoanKH> list = new List<TaiKhoanKH>();
            string query = @"Select * from TAIKHOANKH";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new TaiKhoanKH(row));
            }
            return list;
        }
        public List<TaiKhoanKH> getTaiKhoanKH(string IDKH)
        {
            List<TaiKhoanKH> list = new List<TaiKhoanKH>();
            string query = @"Select * from TAIKHOANKH where IDKH = '" + IDKH + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new TaiKhoanKH(row));
            }
            return list;
        }
        public TaiKhoanKH getTaiKhoan(string phone, string password)
        {
            List<TaiKhoanKH> list = new List<TaiKhoanKH>();
            string query = @"Select * from TAIKHOANKH where sdt = '" + phone + "' AND MATKHAU = '" + password + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new TaiKhoanKH(row));
            }
            if (list.Count > 0)
            {
                return list[0];
            }
            return null;
        }
    }
}
