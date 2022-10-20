using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class GiamGiaCombo
    {
        private string idGGCombo;
        private int giaBan;
        private DateTime tgBatDau;
        private DateTime tgKetThuc;
        private string idCombo;

        public string IDGGCombo
        {
            get { return idGGCombo; }
            set { idGGCombo = value; }
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
        public string IDCombo
        {
            get { return idCombo; }
            set { idCombo = value; }
        }
        public GiamGiaCombo(string idGGCombo, int giaBan, DateTime tgBatDau, DateTime tgKetThuc, string idCombo)
        {
            IDGGCombo = idGGCombo;
            GiaBan = giaBan;
            TGBatDau = tgBatDau;
            TGKetThuc = tgKetThuc;
            IDCombo = idCombo;
        }
        public GiamGiaCombo(DataRow row)
        {
            IDGGCombo = row["IDGGCOMBO"].ToString();
            GiaBan = (int)row["GIABAN"];
            TGBatDau = (DateTime)row["TGBATDAU"];
            TGKetThuc = (DateTime)row["TGKETTHUC"];
            IDCombo = row["IDCOMBO"].ToString();
        }
    }
}
