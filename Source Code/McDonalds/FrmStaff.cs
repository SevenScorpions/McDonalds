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
    public partial class FrmStaff : Form
    {
        public FrmStaff()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmStaff_Load(object sender, EventArgs e)
        {

        }

        private void bttnSignIn_Click(object sender, EventArgs e)
        {
            lbWrongPassword.Text = "";
            TaiKhoan taiKhoan = TaiKhoanDAO.Instance.getTaiKhoan(tbUsername.Text, tbPassword.Text);
            if (taiKhoan != null)
            {
                FrmMainStaff frmMainStaff = new FrmMainStaff(taiKhoan);
                this.Hide();
                tbPassword.Text = "";
                frmMainStaff.ShowDialog();
                this.Show();
            }
            else
            {
                lbWrongPassword.Text = "Tên đăng nhập hoặc mật khẩu không chính xác";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbWrongPassword.Text = "";
        }
    }
}
