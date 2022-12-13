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

        private void menuMain_Click(object sender, EventArgs e)
        {

        }

        public List<Menu> menu;
        public List<Menu> menuFilter;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            List<CTMon> data = CTMonDAO.Instance.getCTMon();
            var list = new Menu[data.Count];
            int i = 0;
            menu = new List<Menu>();
            menuFilter = new List<Menu>();
            foreach (CTMon item in data)
            {
                list[i] = new Menu();
                //list[i].uri_monan = item.Img;
                list[i].name = item.TenCTM;
                list[i].price = item.TienThem;
                //list[i].LoadImageAsync();
                menu.Add(list[i]);
                menuFilter.Add(list[i]);

                i++;
            }
            flowLayoutPanel1.Controls.AddRange(list);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Mon> data = MonDAO.Instance.getMon();
            var list = new Menu[data.Count];
            int i = 0;
            menu = new List<Menu>();
            menuFilter = new List<Menu>();
            foreach (Mon item in data)
            {
                list[i] = new Menu();
                list[i].uri_monan = item.Img;
                list[i].name = item.TenMon;
                list[i].price = item.GiaMon;
                list[i].LoadImageAsync();
                menu.Add(list[i]);
                menuFilter.Add(list[i]);

                i++;
            }
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(list);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Combo> data = ComboDAO.Instance.getCombo();
            var list = new Menu[data.Count];
            int i = 0;
            menu = new List<Menu>();
            menuFilter = new List<Menu>();
            foreach (Combo item in data)
            {
                list[i] = new Menu();
                list[i].uri_monan = item.Img;
                list[i].name = item.TenCombo;
                list[i].price = item.GiaCombo;
                list[i].LoadImageAsync();
                menu.Add(list[i]);
                menuFilter.Add(list[i]);

                i++;
            }
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(list);
        }
    }
}
