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
    public partial class quanlynhanvien : UserControl
    {
        public quanlynhanvien()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private NhanVien nhanVien;
        public NhanVien NhanVien
        {
            get { return nhanVien; }

            set { 
                nhanVien = value;
                hoVaTen.Text = nhanVien.Ho.ToString() + nhanVien.Ten.ToString();
                chucVu.Text = nhanVien.ChucVu.ToString();
                soDienThoai.Text = nhanVien.Sdt.ToString();
                maNhanVien.Text = nhanVien.IDNV.ToString();
            }
        }

        //load họ và tên
        private string _HovaTen;

        public string hovaten
        {
            get { return _HovaTen; }
            set { _HovaTen = value; }
        }


        //load chức vụ
        public string _chucVu;

        public string chucvu
        {
            get { return _chucVu; }
            set { _chucVu = value; }
        }

        //load số điện thoại 
        public int _soDienThoai;

        public int sodienthoai 
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; }
        }

        //load mã nhân viên 
        public int _maNhanVien;

        public int manhanvien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }

        private void maNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void soDienThoai_Click(object sender, EventArgs e)
        {

        }
    }
}
