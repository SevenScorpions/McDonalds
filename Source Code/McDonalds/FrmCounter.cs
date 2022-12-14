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
        }
        void loadHoaDon()
        {
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
        void showHoaDon(string idHD) 
        {
            listViewDonHang.Items.Clear();
            List<DonHang> listDonHang = DonHangDAO.Instance.getListDonHangByMaHD(idHD);
            foreach(DonHang donHang in listDonHang)
            {
                ListViewItem listViewItem = new ListViewItem(donHang.Ten.ToString());
                listViewItem.SubItems.Add(donHang.SoLuong.ToString());
                listViewItem.SubItems.Add(donHang.GiaMon.ToString());
                listViewItem.SubItems.Add(donHang.ThanhTien.ToString());

                listViewDonHang.Items.Add(listViewItem);            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            string idHD = ((sender as Button).Tag as HoaDon).IDHD;
            showHoaDon(idHD);
        }
        private void FrmCounter_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
