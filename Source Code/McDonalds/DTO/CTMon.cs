using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class CTMon
    {
        private string idCTMon;
        private int tienThem;
        private string trangThai;
        private string tenCTM;
        private string idMon;

        public string IDCTMon
        {
            get { return idCTMon; }
            set { idCTMon = value; }
        }
        public int TienThem
        {
            get { return tienThem; }
            set { tienThem = value; }
        }
        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        public string TenCTM
        {
            get { return tenCTM; }
            set { tenCTM = value; }
        }
        public string IDMon
        {
            get { return idMon; }
            set { idMon = value; }
        }
        public CTMon(string idCTMon, int tienThem, string trangThai, string tenCTM, string idMon)
        {
            IDCTMon = idCTMon;
            TienThem = tienThem;
            TrangThai = trangThai;
            TenCTM = tenCTM;
            IDMon = idMon;
        }
        public CTMon(DataRow row)
        {
            IDCTMon = row["IDCTMON"].ToString();
            TienThem = (int)row["TIENTHEM"];
            TrangThai = row["TRANGTHAI"].ToString();
            TenCTM = row["TENCTM"].ToString();
            IDMon = row["IDMON"].ToString();
        }
    }
}
