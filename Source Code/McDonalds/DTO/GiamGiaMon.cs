using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class GiamGiaMon
    {
        private string idGGMon;
        private int giaBan;
        private DateTime tgBatDau;
        private DateTime tgKetThuc;
        private string idMon;

        public string IDGGMon
        {
            get { return idGGMon; }
            set { idGGMon = value; }
        }
        public int GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }
        public DateTime TGBatDau
        {
            get { return tgBatDau; }
            set { tgBatDau = value; }
        }
        public DateTime TGKetThuc
        {
            get { return tgKetThuc; }
            set { tgKetThuc = value; }
        }
        public string IDMon
        {
            get { return idMon; }
            set { idMon = value; }
        }
        public GiamGiaMon(string idGGMon, int giaBan, DateTime tgBatDau, DateTime tgKetThuc, string idMon)
        {
            IDGGMon = idGGMon;
            GiaBan = giaBan;
            TGBatDau = tgBatDau;
            TGKetThuc = tgKetThuc;
            IDMon = idMon;
        }
        public GiamGiaMon(DataRow row)
        {
            IDGGMon = row["IDGGMON"].ToString();
            GiaBan = (int)row["GIABAN"];
            TGBatDau = (DateTime)row["TGBATDAU"];
            TGKetThuc = (DateTime)row["TGKETTHUC"];
            IDMon = row["IDMON"].ToString();
        }
    }
}
