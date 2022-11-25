using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class Voucher
    {
        private string idVoucher;
        private int soTienGiam;
        private DateTime tgBatDau;
        private DateTime tgKetThuc;
        private string donVi;
        private string dieuKien;
        private int toiDa;

        public string IDVoucher
        {
            get { return idVoucher; }
            set { idVoucher = value; }
        }
        public int SoTienGiam
        {
            get { return soTienGiam; }
            set { soTienGiam = value; }
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
        public string DonVi
        {
            get { return donVi; }
            set { donVi = value; }
        }
        public string DieuKien
        {
            get { return dieuKien; }
            set { dieuKien = value; }
        }
        public int ToiDa
        {
            get { return toiDa; }
            set { toiDa = value; }
        }
        public Voucher(string idVoucher, int soTienGiam, DateTime tgBatDau, DateTime tgKetThuc, string donVi, string dieuKien, int toiDa)
        { 
            IDVoucher = idVoucher;
            SoTienGiam = soTienGiam;
            TGBatDau = tgBatDau;
            TGKetThuc = tgKetThuc;
            DonVi = donVi;
            DieuKien = dieuKien;
            ToiDa = toiDa;
        }
        public Voucher(DataRow row )
        {
            IDVoucher = row["IDVOUCHER"].ToString();
            SoTienGiam = (int)row["SOTIENGIAM"];
            TGBatDau = (DateTime)row["TGBATDAU"];
            TGKetThuc = (DateTime)row["TGKETTHUC"];
            DonVi = row["DONVI"].ToString();
            DieuKien = row["DK"].ToString();
            ToiDa = (int)row["TOIDA"];
        }
    }
}
