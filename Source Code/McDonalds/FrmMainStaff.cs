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
    }
}
