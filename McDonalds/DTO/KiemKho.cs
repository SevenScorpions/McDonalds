using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class KiemKho
    {
        private string idKK;
        private DateTime tgKiemTra;
        private float soLuong;
        private string idLH;

        public string IDKK { get { return idKK; } set { idKK = value; } }
        public DateTime TGKiemTra { get { return tgKiemTra; } set { tgKiemTra = value; } }
        public float SoLuong { get { return soLuong; } set { soLuong = value; } }
        public string IDLH { get { return idLH; } set { idLH = value; } }
        public KiemKho(string idKK, DateTime tgKiemTra, float soLuong, string idLH)
        {
            this.idKK = idKK;
            this.tgKiemTra = tgKiemTra;
            this.soLuong = soLuong;
            this.idLH = idLH;
        }
        public KiemKho(DataRow row)
        {
            IDKK = row["IDKK"].ToString();
            TGKiemTra = (DateTime)row["TGKIEMTRA"];
            SoLuong = (float)row["SOLUONG"];
            IDLH = row["IDLH"].ToString();
        }
    }
}
