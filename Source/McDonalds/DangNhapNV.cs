using McDonalds.DAO;
using McDonalds.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McDonalds
{
    public partial class DangNhapNV : Form
    {
        public DangNhapNV()
        {
            InitializeComponent();
        }

        private void bttnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttnDangNhap_Click(object sender, EventArgs e)
        {
            List<TaiKhoan> taiKhoans = TaiKhoanDAO.Instance.getTaiKhoan(tbUsername.Text, tbPassword.Text);
            if (taiKhoans.Count() == 0)
            {
                MessageBox.Show("Tài khoản không hợp lệ");
            }
            else
            {
                GiaoDienNV giaoDienNV = new GiaoDienNV(taiKhoans[0]);
                tbPassword.Clear();
                tbUsername.Clear();
                this.Hide();
                giaoDienNV.ShowDialog();
                this.Show();
            }
        }
    }
}
