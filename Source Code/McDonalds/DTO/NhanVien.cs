using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class NhanVien
    {
        private string idNV;
        private string ho;
        private string ten;
        private string email;
        private string sdt;
        private string phanLoaiNV;
        private string diaChi;
        private string chucVu;
        private string password;
        public string IDNV { get { return idNV; } set { idNV = value; } }
        public string Ho { get { return ho; } set { ho = value; } }
        public string Ten { get { return ten; } set { ten = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Sdt { get { return sdt; } set { sdt = value; } }
        public string PhanLoaiNV { get { return phanLoaiNV; } set { phanLoaiNV = value; } }
        public string DiaChi { get { return diaChi; } set { diaChi = value; } }
        public string ChucVu { get { return chucVu; } set { chucVu = value; } }
        public string Password { get { return password; } set { password = value; } }
        public NhanVien(string idNV, string hoTen, string email, string sdt, string phanLoaiNV, string diaChi, string chucVu, string password)
        {
            IDNV = idNV;
            Ho = ho;
            Ten = ten;
            Email = email;
            Sdt = sdt;
            PhanLoaiNV = phanLoaiNV;
            DiaChi = diaChi;
            ChucVu = chucVu;
            Password = password;
        }
        public NhanVien(DataRow row)
        {
            IDNV = row["IDNV"].ToString();
            Ho = row["HO"].ToString();
            Ten = row["TEN"].ToString();
            Email = row["EMAIL"].ToString();
            Sdt = row["SDT"].ToString();
            PhanLoaiNV = row["PHANLOAINV"].ToString();
            DiaChi = row["DIACHI"].ToString();
            ChucVu = row["CHUCVU"].ToString();
            Password = row["Password"].ToString();
        }
    }
}
