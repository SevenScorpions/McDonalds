using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class NhapHang
    {
        private string idNH;
        private DateTime tgNhap;
        private string ncc;
        public string IDNH { get { return idNH; } set { idNH = value; } }
        public DateTime TGNhap { get { return tgNhap; } set { tgNhap = value; } }
        public string NCC { get { return ncc; } set { ncc = value; } }
        public NhapHang(string iDNH, DateTime tGNhap, string nCC)
        {
            IDNH = iDNH;
            TGNhap = tGNhap;
            NCC = nCC;
        }
        public NhapHang(DataRow row)
        {
            IDNH = row["IDNH"].ToString();
            TGNhap = (DateTime)row["TGNHAP"];
            NCC = row["NCC"].ToString();
        }
    }
}
