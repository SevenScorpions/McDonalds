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
    public partial class FrmMain : Form
    {
        private TaiKhoanKH taiKhoanKH;
        public TaiKhoanKH TaiKhoanKH { get { return taiKhoanKH; } set { taiKhoanKH = value; } }
        public FrmMain(TaiKhoanKH taiKhoanKH)
        {
            this.taiKhoanKH = taiKhoanKH;
            InitializeComponent();
        }

        private void mainPanel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
