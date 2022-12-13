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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public List<quanlynhanvien> listNhanvien;
        private void FrmMainStaff_Load(object sender, EventArgs e)
        {
            List<NhanVien> data = NhanVienDAO.Instance.getNhanVien();
            var list = new quanlynhanvien[data.Count];
            int i = 0;
            listNhanvien = new List<quanlynhanvien>();
            foreach (NhanVien item in data)
            {
                list[i] = new quanlynhanvien();
                list[i].NhanVien = item;

                listNhanvien.Add(list[i]);

                i++;
            }
            flowLayoutPanel1.Controls.AddRange(list);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
