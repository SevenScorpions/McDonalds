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
        public itemDonHang()
        {
            InitializeComponent();
        }

        public HoaDon hoaDon;
        public HoaDon HoaDon { 
            get { 
                return hoaDon; 
            } 
            set { 
                hoaDon = value; 
                label1.Text= hoaDon.IDHD.ToString();
            } 
        }
    }
}
