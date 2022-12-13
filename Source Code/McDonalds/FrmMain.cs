using McDonalds.DAO;
using McDonalds.DTO;
using System;
using System.Collections;
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
            flowLayoutPanel1.Controls.Clear();
            LoadMon();
            LoadCombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadMon();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadCombo();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadMon();
            LoadCombo();
        }
        private void LoadMon()
        {
            List<Mon> mons = MonDAO.Instance.getMon();
            foreach (Mon mon in mons)
            {
                flowLayoutPanel1.Controls.Add(new Menu(mon));
            }
        }
        private void LoadCombo()
        {
            List<Combo> combos = ComboDAO.Instance.getCombo();
            foreach (Combo combo in combos)
            {
                flowLayoutPanel1.Controls.Add(new Menu(combo));
            }
        }
    }
}
