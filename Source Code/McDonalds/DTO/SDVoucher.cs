using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class SDVoucher
    {
        private string idVoucher;
        private string idHD;
        public string IDHD
        {
            get { return idHD; }
            set { idHD = value; }
        }
        public string IDVoucher
        {
            get { return idVoucher; }
            set { idVoucher = value; }
        }
        public SDVoucher(string idHD, string idVoucher)
        {
            IDHD = idHD;
            IDVoucher = idVoucher;
        }
        public SDVoucher(DataRow row)
        {
            IDVoucher = row["IDVOUCHER"].ToString();
            IDHD = row["IDHD"].ToString();
        }
    }


}
