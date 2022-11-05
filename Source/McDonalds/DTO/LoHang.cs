using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class LoHang
    {
        private string idLH;
        private float soLuong;
        private DateTime hanSD;
        private string idNL;
        private string idNH;
        public string IDLH { get { return idLH; } set { idLH = value; } }
        public string IDNL { get { return idNL; } set { idNL = value; } }
        public DateTime HanSD { get { return hanSD; } set { hanSD = value; } }
        public float SoLuong { get { return soLuong; } set { soLuong = value; } }
        public string IDNH { get { return idNH; } set { idNH = value; } }
        public LoHang(string idLH, float soLuong, DateTime hanSD, string idNL, string idNH)
        {
            IDLH = idLH;
            IDNL = idNL;
            HanSD = hanSD;
            SoLuong = soLuong;
            IDNH = idNH;
        }
        public LoHang(DataRow row)
        {
            IDLH = row["IDLH"].ToString();
            IDNL = row["IDNL"].ToString();
            HanSD = (DateTime)row["HANSD"];
            SoLuong = float.Parse(row["SOLUONG"].ToString());
            IDNH = row["IDNH"].ToString();
        }
    }
}
