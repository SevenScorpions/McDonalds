using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class HDCombo
    {
        private string idHD;
        private string idCombo;
        private int soLuong;

        public string IDHD
        {
            get { return idHD; }
            set { idHD = value; }
        }
        public string IDCombo
        {
            get { return idCombo; }
            set { idCombo = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public HDCombo(string idHD, string idCombo, int soLuong)
        {
            IDHD = idHD;
            IDCombo = idCombo;
            SoLuong = soLuong;
        }
        public HDCombo(DataRow row)
        {
            IDHD = row["IDHD"].ToString();
            IDCombo = row["IDCOMBO"].ToString();
            SoLuong = (int)row["SOLUONG"];
        }
    }
}
