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

        public void taoTaiKhoan(string firstName, string lastName, string gioiTinh, string ngaySinh, string sdt,
                                string mk, string email, string diaChi)
        {
            string query = @"INSERT INTO TAIKHOANKH VALUES('KH" + sdt + "', N'" + firstName + "', N'" + lastName + "', '" + gioiTinh + "', '" + ngaySinh + "', '" + sdt + "', '" + mk + "', '" + email + "', N'" + diaChi + "', N'Đồng', 0)";
            DataProvider.Instance.ExcuteQuery(query);
        }
        public void updateTaiKhoanKH(string id,string firstName, string lastName, string gioiTinh, string ngaySinh, string sdt, string email, string diaChi)
        {
            string query = String.Format(@"UPDATE TAIKHOANKH SET SDT = N'{0}',TEN = N'{1}',HO = N'{2}',NGAYSINH=N'{3}',EMAIL=N'{4}',DIACHI=N'{5}',gioitinh='{6}' WHERE IDKH = '{7}'",sdt,firstName,lastName,ngaySinh,email,diaChi,gioiTinh,id);
            DataProvider.Instance.ExcuteQuery(query);
        }
        public void updateDiemThuong(string id,int diemthuong)
        {
            string query = String.Format(@"UPDATE TAIKHOANKH SET DIEMTHUONG = {0} WHERE IDKH = '{1}'", diemthuong, id);
            DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
