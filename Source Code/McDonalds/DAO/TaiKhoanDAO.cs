﻿using McDonalds.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
            private set => instance = value;
        }
        private TaiKhoanDAO() { }
        public TaiKhoan getTaiKhoan(string username,string password)
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            string query = @"Select * from TAIKHOAN where TENTAIKHOAN = '" + username + "' AND MATKHAU = '" + password + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new TaiKhoan(row));
            }
            if(list.Count > 0)
            {
                return list[0];
            }
            return null;
        }
        public void createTaiKhoan(string username, string password, string chucvu)
        {
            string query = string.Format(@"insert into TAIKHOAN VALUE({0},{1},{2})",username,password,chucvu);
            DataProvider.Instance.ExcuteQuery(query);
        }
        public void createTaiKhoan(TaiKhoan taiKhoan)
        {
            string query = string.Format(@"insert into TAIKHOAN VALUE({0},{1},{2})", taiKhoan.TenTaiKhoan, taiKhoan.MatKhau, taiKhoan.ChucVu);
            DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
