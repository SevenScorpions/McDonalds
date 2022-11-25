using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class HoaDon
    {
        private string _idHd;
        private DateTime _thoiGianLap;
        private int _tongTien;
        private int _soBot;
        private int _stt;
        private int _giaGoc;
        private string _idKH;
        private string _idVoucher;

        public string IDHD
        {
            get { return _idHd; }
            set { _idHd = value; }
        }
        public DateTime ThoiGianLap
        {
            get { return _thoiGianLap; }
            set { _thoiGianLap = value; }
        }
        public int TongTien
        {
            get { return _tongTien; }
            set { _tongTien = value; }
        }
        public int SoBot
        {
            get { return _soBot; }
            set { _soBot = value; }
        }

        public int STT
        {
            get { return _stt; }
            set { _stt = value; }
        }
        public int GiaGoc
        {
            get { return _giaGoc; }
            set { _giaGoc = value; }
        }
        public string IDKH
        {
            get { return _idKH; }
            set { _idKH = value; }
        }
        public string IDVoucher
        {
            get { return _idVoucher; }
            set { _idVoucher = value; }
        }
        public HoaDon(string idHd, DateTime thoiGianLap, int tongTien, int soBot, int stt, int giaGoc, string idKH, string idVoucher)
        {
            IDHD = idHd;
            ThoiGianLap = thoiGianLap;
            TongTien = tongTien;
            SoBot = soBot;
            STT = stt;
            GiaGoc = giaGoc;
            IDKH = idKH;
            IDVoucher = idVoucher;
        }
        public HoaDon(DataRow row)
        {
            IDHD = row["IDHD"].ToString();
            ThoiGianLap = (DateTime)row["THOIGIANLAP"];
            TongTien = (int)row["TONGTIEN"];
            SoBot = (int)row["SOBOT"];
            STT = (int)row["STT"];
            GiaGoc = (int)row["GIAGOC"];
            IDKH = row["IDKH"].ToString();
            IDVoucher = row["IDVOUCHER"].ToString();
        }
    }
}
