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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace McDonalds
{
    public partial class FrmMainStaff : Form
    {
        private TaiKhoan taiKhoan;
        public TaiKhoan TaiKhoan { get { return taiKhoan; } set { taiKhoan = value; } }
        public FrmMainStaff(TaiKhoan taiKhoan)
        {
            this.taiKhoan = taiKhoan;
            InitializeComponent();
        }

        public List<quanlynhanvien> listNhanvien;
        private void FrmMainStaff_Load(object sender, EventArgs e)
        {
            List<NhanVien> data = NhanVienDAO.Instance.getNhanVien();
            var list = new quanlynhanvien[data.Count];
            int i = 0;
            listNhanvien = new List<quanlynhanvien>();
            foreach (NhanVien item in data)
            {
                list[i] = new quanlynhanvien();
                list[i].NhanVien = item;

                listNhanvien.Add(list[i]);

                i++;
            }
            flowLayoutPanel1.Controls.AddRange(list);

            listViewHoaDon.Items.Clear();
            List<HoaDon> listDonHang = HoaDonDAO.Instance.getHoaDon();
            int tongTien = 0;
            int tongTienNhan = 0;
            int tongTienTra = 0;
            int tongHD = 0;
            foreach (HoaDon hoaDon in listDonHang)
            {
                ListViewItem listViewItem = new ListViewItem(hoaDon.IDHD.ToString());
                listViewItem.SubItems.Add(hoaDon.TongTien.ToString());
                listViewItem.SubItems.Add(hoaDon.TienNhan.ToString());
                listViewItem.SubItems.Add(hoaDon.TienTra.ToString());
                listViewItem.SubItems.Add(hoaDon.TGLap.ToString());

                tongHD++;
                tongTien = tongTien + hoaDon.TongTien;
                tongTienNhan = tongTienNhan + hoaDon.TienNhan;
                tongTienTra = tongTienTra + hoaDon.TienTra;
                listViewHoaDon.Items.Add(listViewItem);
            }

            lblTongHD.Text = "Tổng hóa đơn: " + tongHD;
            lblTongTien.Text = "Tổng tiền: " + tongTien + "VND";
            lblTienNhan.Text = "Tổng tiền nhận: " + tongTienNhan + "VND";
            lblTienTra.Text = "Tổng tiền trả: " + tongTienTra + "VND";
            lblNgay.Text = "Thời gian lập: " + System.DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
