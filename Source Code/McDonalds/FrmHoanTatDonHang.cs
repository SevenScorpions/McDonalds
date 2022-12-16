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
    public partial class FrmHoanTatDonHang : Form
    {
        public FrmHoanTatDonHang()
        {
            InitializeComponent();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            loadHD();
        }
        public void loadHD()
        {
            List<HoaDon> data = HoaDonDAO.Instance.getHoaDon();

            foreach (HoaDon item in data)
            {
                //list[i] = new itemDonHang();
                if (item.HoanTat != true && item.ThanhToan!=true)
                {
                    itemDonHang itemdonhang = new itemDonHang(item,Frm_Load);
                    flowLayoutPanel1.Controls.Add(itemdonhang);
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    
}
