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
    public partial class ChonCN : Form
    {
        public ChonCN()
        {
            InitializeComponent();
        }

        private void bttnDangNhapNV_Click(object sender, EventArgs e)
        {
            FrmStaff frmStaff = new FrmStaff();
            this.Hide();
            frmStaff.ShowDialog();
            this.Show();
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttnCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer();
            this.Hide();
            frmCustomer.ShowDialog();
            this.Show();
        }
    }
}
