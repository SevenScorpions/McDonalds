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
        private string ho;
        private string ten;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string sdt;
        private string matkhau;
        private string email;
        private string diaChi;
        private string thuHang;
        private int diemThuong;

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
        public string MatKhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        public string Ho
        {
            get { return ho; }
            set { ho = value; }
        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
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
        public DateTime NgaySinh { get { return ngaySinh; } set { ngaySinh = value; } }
        public int DiemThuong { get { return diemThuong; } set { diemThuong = value; } }
        public string GioiTinh { get { return gioiTinh; } set { gioiTinh = value; } }
        public TaiKhoanKH(string idKH, string ho, string ten, string gioiTinh, DateTime ngaySinh, string sdt, string matkhau, string email, string diaChi, string thuHang, int diemThuong, string iDKH, string sDT)
        {
            IDKH = iDKH;
            SDT = sDT;
            Email = email;
            MatKhau = matkhau;
            Ho = ho;
            Ten = ten;
            DiaChi = diaChi;
            ThuHang = thuHang;
            NgaySinh = ngaySinh;
            DiemThuong = diemThuong;
            GioiTinh = gioiTinh;
        }

        public TaiKhoanKH(DataRow row)
        {
            IDKH = row["IDKH"].ToString();
            SDT = row["SDT"].ToString();
            Email = row["EMAIL"].ToString();
            MatKhau = row["MATKHAU"].ToString();
            Ho = row["HO"].ToString();
            DiaChi = row["DIACHI"].ToString();
            ThuHang = row["THUHANG"].ToString();
            Ten = row["TEN"].ToString();
            DiemThuong = (int)row["DIEMTHUONG"];
            NgaySinh = (DateTime)row["NGAYSINH"];
            GioiTinh = row["GIOITINH"].ToString();
        }
    }
}
