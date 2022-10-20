using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class SoHuu
    {
        private string idKH;
        private string idVoucher;
        private int soLanSD;

        public string IDKH
        {
            get { return idKH; }
            set { idKH = value; }
        }
        public string IDVoucher
        {
            get { return idVoucher; }
            set { idVoucher = value; }
        }
        public int SoLanSD
        {
            get { return soLanSD; }
            set { soLanSD = value; }
        }
        public SoHuu(string idKH, string idVoucher, int soLanSD)
        {
            IDKH = idKH;
            IDVoucher = idVoucher;
            SoLanSD = soLanSD;
        }
        public SoHuu(DataRow row)
        {
            IDVoucher = row["IDVOUCHER"].ToString();
            IDKH = row["IDKH"].ToString();
            SoLanSD = (int)row["SOLANSD"];
        }
    }
}
