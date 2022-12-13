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
            List<HoaDon> data = HoaDonDAO.Instance.getHoaDon();
            var list = new itemDonHang[data.Count];
            int i = 0;
            
            foreach (HoaDon item in data)
            {
                list[i] = new itemDonHang();
                list[i].HoaDon = item;

                

                i++;
            }
            flowLayoutPanel1.Controls.AddRange(list);
        }
    }

    
}
