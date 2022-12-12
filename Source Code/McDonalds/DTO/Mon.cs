using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class Mon
    {
        private string idMon;
        private string tenMon;
        private int giaMon;
        private string trangThai;
        private string img;

        public string IDMon
        {
            get { return idMon; }
            set { idMon = value; }
        }
        public string TenMon
        {
            get { return tenMon; }
            set { tenMon = value; }
        }
        public int GiaMon
        {
            get { return giaMon; }
            set { giaMon = value; }
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
        public Mon(string idMon, string tenMon, int giaMon, string trangThai, string img)
        {
            IDMon = idMon;
            TenMon = tenMon;
            GiaMon = giaMon;
            TrangThai = trangThai;
            Img = img;
        }
        public Mon(DataRow row)
        {
            IDMon = row["IDMON"].ToString();
            TenMon = row["TENMON"].ToString();
            GiaMon = (int)row["GIAMON"];
            TrangThai = row["TRANGTHAI"].ToString();
            Img = row["IMG"].ToString();
        }
    }
}
