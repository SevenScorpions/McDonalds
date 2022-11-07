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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnDangNhapNV_Click(object sender, EventArgs e)
        {
            DangNhapNV dangNhapNV = new DangNhapNV();
            this.Hide();
            dangNhapNV.ShowDialog();
            this.Show();
        }
    }
}
