using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class CTCombo
    {
        private string idCombo;
        private string idCTMon;
        private int soLuong;

        public string IDCombo
        {
            get { return idCombo; }
            set { idCombo = value; }
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
        public CTCombo(string idCombo, string idCTMon, int soLuong)
        {
            IDCombo = idCombo;
            IDCTMon = idCTMon;
            SoLuong = soLuong;
        }
        public CTCombo(DataRow row)
        {
            IDCombo = row["IDCOMBO"].ToString();
            IDCTMon = row["IDCTMON"].ToString();
            SoLuong = (int)row["SOLUONG"];
        }

    }
}
