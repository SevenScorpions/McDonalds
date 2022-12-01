using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class TaiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;
        private string chucVu;
        public string TenTaiKhoan { get { return tenTaiKhoan; } set { tenTaiKhoan = value; } }
        public string MatKhau { get { return matKhau; } set { matKhau = value; } }
        public string ChucVu { get { return chucVu; } set { chucVu = value; } }
        public TaiKhoan(string tenTaiKhoan, string matKhau, string chucVu)
        {
            TenTaiKhoan = tenTaiKhoan;
            MatKhau = matKhau;
            ChucVu = chucVu;
        }
        public TaiKhoan(DataRow row)
        {
            tenTaiKhoan = row["TENTAIKHOAN"].ToString();
            matKhau = row["MATKHAU"].ToString();
            chucVu = row["CHUCVU"].ToString();
        }
    }
}
