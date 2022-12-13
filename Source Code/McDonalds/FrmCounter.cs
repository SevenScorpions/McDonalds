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
                    flpListHoaDon.Controls.Add(btn);
                }
            }

        }

        private void FrmCounter_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
