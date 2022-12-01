using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class SuDung
    {
        private string idKH;
        private string idVoucher;
    

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
        public SuDung(string idKH, string idVoucher)
        {
            IDKH = idKH;
            IDVoucher = idVoucher;
        }
        public SuDung(DataRow row)
        {
            IDVoucher = row["IDVOUCHER"].ToString();
            IDKH = row["IDKH"].ToString();
        }
    }
}
