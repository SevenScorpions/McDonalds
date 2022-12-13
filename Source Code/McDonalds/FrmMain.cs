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
                menu.Add(list[i]);
                menuFilter.Add(list[i]);

                i++;
            }

            List<Combo> data1 = ComboDAO.Instance.getCombo();
            var list1 = new Menu[data.Count];
            int j = 0;
            menu = new List<Menu>();
            menuFilter = new List<Menu>();
            foreach (Combo item in data1)
            {
                list1[j] = new Menu();
                list1[j].uri_monan = item.Img;
                list1[j].name = item.TenCombo;
                list1[j].price = item.GiaCombo;
                menu.Add(list1[j]);
                menuFilter.Add(list1[j]);

                j++;
            }
            flowLayoutPanel1.Controls.AddRange(list);
            flowLayoutPanel1.Controls.AddRange(list1);
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
                menu.Add(list[i]);
                menuFilter.Add(list[i]);

                i++;
            }
            //((Control)this.tabProfile).Enabled = false;
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
                menu.Add(list[i]);
                menuFilter.Add(list[i]);

                i++;
            }
            //((Control)this.tabProfile).Enabled = false;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(list);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                menu.Add(list[i]);
                menuFilter.Add(list[i]);

                i++;
            }

            List<Combo> data1 = ComboDAO.Instance.getCombo();
            var list1 = new Menu[data.Count];
            int j = 0;
            menu = new List<Menu>();
            menuFilter = new List<Menu>();
            foreach (Combo item in data1)
            {
                list1[j] = new Menu();
                list1[j].uri_monan = item.Img;
                list1[j].name = item.TenCombo;
                list1[j].price = item.GiaCombo;
                menu.Add(list1[j]);
                menuFilter.Add(list1[j]);

                j++;
            }
            flowLayoutPanel1.Controls.AddRange(list);
            flowLayoutPanel1.Controls.AddRange(list1);
        }
    }
}
