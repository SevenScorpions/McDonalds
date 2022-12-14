using McDonalds.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Hoa
namespace McDonalds.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get { 
                if (instance == null)
                {
                    instance = new HoaDonDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private HoaDonDAO() { }
        public List<HoaDon> getHoaDon()
        {
            List<HoaDon> list = new List<HoaDon>();
            string query = @"Select * from HOADON";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow dr in data.Rows)
            {
                list.Add(new HoaDon(dr));
            }
            return list;
        }
        public List<HoaDon> getHoaDon(string maHoaDon)
        {
            List<HoaDon> list = new List<HoaDon>();
            string query = @"Select * from HOADON where IDHD = '" + maHoaDon + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                list.Add(new HoaDon(dr));
            }
            return list;
        }
        public void updateTinhTrangThanhToan(string idDH)
        {
            string query1 = @"UPDATE HOADON SET THANHTOAN = 'true' Where IDHD = '" + idDH + "'";
            DataProvider.Instance.ExcuteQuery(query1);
        }
        public void updateTinhTrangHoanTat(string idDH)
        {
            string query1 = @"UPDATE HOADON SET HOANTAT = 'true' Where IDHD = '" + idDH + "'";
            DataProvider.Instance.ExcuteQuery(query1);
        }

    }
}
