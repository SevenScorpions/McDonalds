using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.DTO
{
    public class TaiKhoan
    {
        private string username;
        private string password;
        private string chucVu;
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string ChucVu { get { return chucVu; } set { chucVu = value; } }
        public TaiKhoan(string username, string password, string chucVu)
        {
            Username = username;
            Password = password;
            ChucVu = chucVu;
        }
        public TaiKhoan(DataRow row)
        {
            username = row["USERNAME"].ToString();
            password = row["PASSWORD"].ToString();
            chucVu = row["CHUCVU"].ToString();
        }
    }
}
