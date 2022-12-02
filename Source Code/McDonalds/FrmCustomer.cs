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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bttnSignUp_Click(object sender, EventArgs e)
        {
            FrmSignUp frmSignUp = new FrmSignUp();
            this.Hide();
            frmSignUp.ShowDialog();
            this.Show();
        }

        private void bttnSignIn_Click(object sender, EventArgs e)
        {
            lbWrongPassword.Text = "";
            TaiKhoanKH taiKhoanKH = TaiKhoanKHDAO.Instance.getTaiKhoan(tbPhone.Text, tbPassword.Text);
            if (taiKhoanKH != null)
            {
                FrmMain frmMain = new FrmMain(taiKhoanKH);
                this.Hide();
                tbPassword.Text = "";
                frmMain.ShowDialog();
                this.Show();
            }
            else
            {
                lbWrongPassword.Text = "Your Username or Password is incorrect";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            TaiKhoanKH taiKhoanKH = TaiKhoanKHDAO.Instance.getTaiKhoan("", "");
            FrmMain frmMain = new FrmMain(taiKhoanKH);
            this.Hide();
            frmMain.ShowDialog();
            this.Show();
        }
    }
}
