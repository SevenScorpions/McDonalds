using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class TaiKhoanKH
    {
        private string idKH;
        private string sdt;
        private string email;
        private string password;
        private string hoTen;
        private string diaChi;
        private string thuHang;

        public string IDKH
        {
            get { return idKH; }
            set { idKH = value; }
        }
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public string Email
        {
            get { return email; }
            set {  email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string ThuHang
        {
            get { return thuHang; }
            set { thuHang = value; }
        }
        public TaiKhoanKH(string idKH, string sdt, string email, string password, string hoTen, string diaChi, string thuHang)
        {
            IDKH = idKH;
            SDT = sdt;
            Email = email;
            Password = password;
            HoTen = hoTen;
            DiaChi = diaChi;
            ThuHang = thuHang;
        }
        public TaiKhoanKH(DataRow row)
        {
            IDKH = row["IDKH"].ToString();
            SDT = row["SDT"].ToString();
            Email = row["EMAIL"].ToString();
            Password = row["PASSWORD"].ToString();
            HoTen = row["HOTEN"].ToString();
            DiaChi = row["DIACHI"].ToString();
            ThuHang = row["THUHANG"].ToString();
        }
    }
}
