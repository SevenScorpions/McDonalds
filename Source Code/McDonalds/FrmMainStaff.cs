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
    public partial class FrmMainStaff : Form
    {
        private TaiKhoan taiKhoan;
        public TaiKhoan TaiKhoan { get { return taiKhoan; } set { taiKhoan = value; } }
        public FrmMainStaff(TaiKhoan taiKhoan)
        {
            this.taiKhoan = taiKhoan;
            InitializeComponent();
        }
    }
}
