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
        public Combo(string idCombo, int giaCombo, string tenCombo, string trangThai) { 
            IDCombo = idCombo;
            GiaCombo = giaCombo;
            TenCombo = tenCombo;
            TrangThai = trangThai;
        }
        public Combo(DataRow row)
        {
            IDCombo = row["IDCOMBO"].ToString();
            GiaCombo = (int)row["GIACOMBO"];
            TenCombo = row["TENCOMBO"].ToString();
            TrangThai = row["TRANGTHAI"].ToString();
        }
    }
}
