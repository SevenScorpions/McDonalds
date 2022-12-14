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
    public partial class FrmCounter : Form
    {
        public FrmCounter()
        {
            InitializeComponent();
            loadHoaDon();
            buttonXuatHoaDon.Enabled = false;
        }
        void loadHoaDon()
        {
            flpListHoaDon.Controls.Clear();
            List<HoaDon> hoadonList = HoaDonDAO.Instance.getHoaDon();
            foreach(HoaDon hoaDon in hoadonList)
            {
                Button btn = new Button()
                {
                    Width = 280,
                    Height = 60
                };
                if(hoaDon.ThanhToan != true)
                {
   
                    btn.Text = "Đơn hàng số " + hoaDon.STT.ToString();
                    btn.Font = new Font("Roboto", 13);
                    btn.ForeColor = Color.Firebrick;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.Black;
                    // btn.FlatAppearance.BorderSize = 1;
                    btn.Click += btn_Click;
                    btn.Tag = hoaDon;
                    flpListHoaDon.Controls.Add(btn);
                }
            }
        }

        public int tongTien;
        void showHoaDon(string idHD) 
        {
            tongTien = 0;
            listViewDonHang.Items.Clear();
            List<DonHang> listDonHang = DonHangDAO.Instance.getListDonHangByMaHD(idHD);
            foreach(DonHang donHang in listDonHang)
            {
                ListViewItem listViewItem = new ListViewItem(donHang.Ten.ToString());
                listViewItem.SubItems.Add(donHang.SoLuong.ToString());
                listViewItem.SubItems.Add(donHang.GiaMon.ToString());
                listViewItem.SubItems.Add(donHang.ThanhTien.ToString());
                tongTien = tongTien + donHang.ThanhTien;
                listViewDonHang.Items.Add(listViewItem);
            }
                lbTongTien.Text = tongTien.ToString() + " VND";
        }
        
        void btn_Click(object sender, EventArgs e)
        {
            string idHD = ((sender as Button).Tag as HoaDon).IDHD;
            buttonXuatHoaDon.Tag = idHD;
            showHoaDon(idHD);
            buttonXuatHoaDon.Enabled = true;
            
        }
        private void FrmCounter_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMaNhanVien_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxMaNhanVien_Click(object sender, EventArgs e)
        {
            textBoxMaNhanVien.Text = "";
        }

        private void textBoxTienNhan_Enter(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string tien = textBoxTienNhan.Text;
           
            if (tien != "")
            {
                int tienNhan = int.Parse(tien);
                int tienThua = tienNhan - tongTien;
                if (tienNhan < tongTien)
                {
                    labelTienNhanTrong.Text = "Tiền nhận phải lớn hơn tổng tiền";
                    tienThua = 0;
                }
                labelTienThua.Text = tienThua.ToString() + " VND";
            }
            else
            {
                labelTienNhanTrong.Text = "Tiền nhận không được để trống";
            }
        }

        private void buttonXuatHoaDon_Click(object sender, EventArgs e)
        {
            string idHD = buttonXuatHoaDon.Tag.ToString();
            HoaDonDAO.Instance.updateTinhTrangThanhToan(idHD);
            listViewDonHang.Items.Clear();
            loadHoaDon();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
