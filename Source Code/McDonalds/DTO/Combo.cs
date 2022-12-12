using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class Combo
    {
        private string idCombo;
        private int giaCombo;
        private string tenCombo;
        private string trangThai;
        private string img;
        public string IDCombo
        {
            get { return idCombo; }
            set { idCombo = value; }
        }
        public int GiaCombo
        {
            get { return giaCombo; }
            set { giaCombo = value; }
        }
        public string TenCombo
        {
            get { return tenCombo; }
            set { tenCombo = value; }
        }
        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        public string Img
        {
            get { return img; }
            set { img = value; }
        }
        public Combo(string idCombo, int giaCombo, string tenCombo, string trangThai, string img) { 
            IDCombo = idCombo;
            GiaCombo = giaCombo;
            TenCombo = tenCombo;
            TrangThai = trangThai;
            Img = img;
        }
        public Combo(DataRow row)
        {
            IDCombo = row["IDCOMBO"].ToString();
            GiaCombo = (int)row["GIACOMBO"];
            TenCombo = row["TENCOMBO"].ToString();
            TrangThai = row["TRANGTHAI"].ToString();
            Img = row["IMG"].ToString();
        }
    }
}
