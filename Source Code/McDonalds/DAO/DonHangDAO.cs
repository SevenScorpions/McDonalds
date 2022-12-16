using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McDonalds.DTO;

namespace McDonalds.DAO
{
    public class DonHangDAO
    {
        private static DonHangDAO instance;
        public static DonHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DonHangDAO();
                return instance;
            }
            private set => instance = value;
        }
        private DonHangDAO() { }
        public List<DonHang> getListDonHangByMaHD(string idDH)
        {
            List<DonHang> listDonHang = new List<DonHang>();
            string query = @"SELECT DISTINCT TENMON as TEN, SOLUONG, GIAMON AS DONGIA,GIAMON * SOLUONG AS THANHTIEN FROM MON, HDMON WHERE (MON.IDMON IN (SELECT IDMON FROM HDMON WHERE IDHD = '"+ idDH +"')) AND (MON.IDMON = HDMON.IDMON) Union SELECT DISTINCT TENCOMBO as TEN, SOLUONG,GIACOMBO AS DONGIA, GIACOMBO * SOLUONG AS THANHTIEN FROM COMBO, HDCOMBO WHERE (COMBO.IDCOMBO IN (SELECT IDCOMBO FROM HDCOMBO WHERE IDHD = '"+idDH+"')) AND (COMBO.IDCOMBO = HDCOMBO.IDCOMBO) Union SELECT DISTINCT TENCTM as TEN, SOLUONG, TIENTHEM AS DONGIA,TIENTHEM * SOLUONG AS THANHTIEN FROM CTMON, HDCTMON WHERE (CTMON.IDCTMON IN (SELECT IDCTMON FROM HDCTMON WHERE IDHD = '"+ idDH+"')) AND (CTMON.IDCTMON = HDCTMON.IDCTMON)";
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow dr in dataTable.Rows)
            {
                listDonHang.Add(new DonHang(dr));
            }
            return listDonHang;
        }

    }
}
