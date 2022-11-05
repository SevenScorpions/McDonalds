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
    public partial class GiaoDienNV : Form
    {
        public TaiKhoan taiKhoan;
        public GiaoDienNV(TaiKhoan taiKhoan)
        {
            this.taiKhoan = taiKhoan;
            InitializeComponent();
            loadComboBox();
        }
        void loadComboBox()
        {
            List<NguyenLieu> nguyenLieus = NguyenLieuDAO.Instance.getNguyenLieu();
            List<NhapHang> nhapHangs = NhapHangDAO.Instance.getNhapHang();
            cbNguyenLieuKK.Items.Add("");
            cbNhapHangKK.Items.Add("");
            cbNhapHangKK.DataSource= nhapHangs;
            cbNhapHangKK.DisplayMember = "TgNhap";
            cbNguyenLieuKK.DataSource = nguyenLieus;
            cbNguyenLieuKK.DisplayMember = "TenNL";
        }

        private void bttnTimKiem_Click(object sender, EventArgs e)
        {
        }
    }
}
