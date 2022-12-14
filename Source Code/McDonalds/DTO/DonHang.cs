using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class DonHang
    {
        private string ten;
        private int soLuong;
        private int giaMon;
        private int thanhTien;
        public string Ten { get => ten; set => ten = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int GiaMon { get => giaMon; set => giaMon = value; }
        
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
 

        public DonHang(string ten, int soLuong, int giaMon, int thanhTien)
        {
            Ten = ten;
            SoLuong = soLuong;
            GiaMon = giaMon;
            ThanhTien = thanhTien;
        }
        public DonHang(DataRow row)
        {
            Ten = row["TEN"].ToString();
            SoLuong = (int)row["SOLUONG"];
            GiaMon = (int)row["DONGIA"];
            ThanhTien = (int)row["THANHTIEN"];
        }
    }
}
