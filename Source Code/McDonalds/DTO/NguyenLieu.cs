using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class NguyenLieu
    {
        private string idNL;
        private string tenNL;
        private string donVi;
        public string IDNL { get { return idNL; } set { idNL = value; } }
        public string TenNL { get { return tenNL; } set { tenNL = value; } }
        public string DonVi { get { return donVi; } set { donVi = value; } }
        public NguyenLieu(string iDNL, string tenNL, string donVi)
        {
            IDNL = iDNL;
            TenNL = tenNL;
            DonVi = donVi;
        }
        public NguyenLieu(DataRow row)
        {
            IDNL = row["IDNL"].ToString();
            TenNL = row["TENNL"].ToString();
            DonVi = row["DONVI"].ToString();
        }
    }
}
