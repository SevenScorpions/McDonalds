using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class HDCTMon
    {
        private string idHD;
        private string idCTMon;
        private int soLuong;

        public string IDHD
        {
            get { return idHD; }
            set { idHD = value; }
        }
        public string IDCTMon
        {
            get { return idCTMon; }
            set { idCTMon = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public HDCTMon(string idHD, string idCTMon, int soLuong)
        {
            IDHD = idHD;
            idCTMon = idCTMon;
            SoLuong = soLuong;
        }
        public HDCTMon(DataRow row)
        {
            IDHD = row["IDHD"].ToString();
            IDCTMon = row["IDCTMON"].ToString();
            SoLuong = (int)row["SOLUONG"];
        }
    }
}
