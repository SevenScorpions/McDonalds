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
    public partial class itemDonHang : UserControl
    {
        public itemDonHang(HoaDon hoaDon, EventHandler e)
        {
            InitializeComponent();
            HoaDon=hoaDon;
            button1.Click +=e;
        }

        public HoaDon hoaDon;
        public HoaDon HoaDon { 
            get { 
                return hoaDon; 
            } 
            set { 
                hoaDon = value; 
                label1.Text = "Đơn hàng số " + hoaDon.STT.ToString();
                
            } 
        }

        private void itemDonHang_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idHD = HoaDon.IDHD;
            HoaDonDAO.Instance.updateTinhTrangHoanTat(idHD);
        }
    }
}
