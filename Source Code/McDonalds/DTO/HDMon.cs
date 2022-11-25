using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class HDMon
    {
        private string idHD;
        private string idMon;
        private int soLuong;

        public string IDHD
        {
            get { return idHD; }
            set { idHD = value; }
        }
        public string IDMon
        {
            get { return idMon; }
            set { idMon = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public HDMon(string idHD, string idMon, int soLuong)
        {
            IDHD = idHD;
            IDMon = idMon;
            SoLuong = soLuong;
        }
        public HDMon(DataRow row)
        {
            IDHD = row["IDHD"].ToString();
            IDMon = row["IDMON"].ToString();
            SoLuong = (int)row["SOLUONG"];
        }
    }
}
