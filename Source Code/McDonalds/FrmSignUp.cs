using McDonalds.DAO;
using McDonalds.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McDonalds
{
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        public bool isNumber(string s)
        {
            return Regex.IsMatch(s, @"^\d+$");
        }

        public bool CheckAccount(string account)
        {
            return Regex.IsMatch(account, @"^[a-zA-Z0-9]{8, 24}$");
        }

        private void bttnSignUp_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string phone = tbPhone.Text;
            string password = tbPassword.Text;
            string rePassword = tbRePassword.Text;
            string email = tbEmail.Text;
            string address = tbAddress.Text;
            string gioiTinh = "";
            string ngaySinh = dtpBirthday.Value.ToString();

            //kiểm tra họ tên
            if (firstName == "" || lastName == "")
            {
                valid = false;
                lbWrongName.Text = "Tên không hợp lệ";
            }
            else { valid = true; lbWrongName.Text = ""; }

            //kiểm tra số điện thoại
            if (phone == "" || phone.Length != 10 || !isNumber(phone))
            {
                valid = false;
                lbWrongPhone.Text = "Số điện thoại không hợp lệ";
            }
            else
            {
                valid = true;
                lbWrongPhone.Text = "";
            }

            //kiểm tra mật khẩu
            if(password == "" || password.Length < 8)
            {
                valid = false;
                lbWrongPassword.Text= "Mật khẩu chứa ít nhất 8 ký tự";
            }
            else { valid= true; lbWrongPassword.Text = ""; }

            //kiểm tra nhập lại mật khẩu
            if (rePassword != password || rePassword == "")
            {
                valid = false;
                lbWrongRePassword.Text = "Mật khẩu không khớp";
            }
            else
            {
                valid = true;
                lbWrongRePassword.Text = "";
            }

            //kiểm tra email
            if (email == "" || email.Contains("@gmail.com") == false)
            {
                valid = false;
                lbWrongEmail.Text = "Email không hợp lệ";
            }
            else
            {
                valid = true;
                lbWrongEmail.Text = "";
            }

            //kiểm tra địa chỉ
            if (address == "")
            {
                valid = false;
                lbWrongAddress.Text = "Địa chỉ không hợp lệ";
            }
            else
            {
                valid = true;
                lbWrongAddress.Text = "";
            }

            //kiểm tra giới tính
            if(rbttnFemale.Checked == false && rbttnMale.Checked == false)
            {
                valid = false;
                lbWrongGender.Text = "Vui lòng chọn giới tính";
            }
            else if(rbttnFemale.Checked == true && rbttnMale.Checked == false)
            {
                gioiTinh = "F";
                lbWrongGender.Text = "";
            }
            else if (rbttnFemale.Checked == false && rbttnMale.Checked == true)
            {
                gioiTinh = "M";
                lbWrongGender.Text = "";
            }

            List<TaiKhoanKH> taiKhoanKHs = TaiKhoanKHDAO.Instance.getTaiKhoanKH();
            foreach(TaiKhoanKH t in taiKhoanKHs)
            {
                if(t.Email == email)
                {
                    valid = false;
                    lbWrongEmail.Text = "Email đã tồn tại!";
                    break;
                }

                if (t.SDT == phone)
                {
                    valid = false;
                    lbWrongPhone.Text = "Số điện thoại đã tồn tại!";
                    break;
                }
            }

            if (valid) {
                TaiKhoanKHDAO.Instance.taoTaiKhoan(firstName, lastName, gioiTinh, ngaySinh, phone, password, email, address);
                MessageBox.Show("Bạn đã đăng ký thành công");
                this.Close();
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
