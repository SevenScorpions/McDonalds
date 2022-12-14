using McDonalds.DAO;
using McDonalds.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace McDonalds
{
    public partial class FrmMain : Form
    {
        public List<Combo> Combos = new List<Combo>();
        public List<Mon> Mons= new List<Mon>();
        public List<CTMon> CTMons= new List<CTMon>();
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
        private void FrmMain_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadMon();
            LoadCombo();
            if (taiKhoanKH.SDT =="0000000000")
            {
                mainPanel.TabPages.Remove(tabProfile);
            }
            else
            {
                tbName.Text = taiKhoanKH.Ho;
                textBox1.Text = taiKhoanKH.Ten;
                tbAddress.Text = taiKhoanKH.DiaChi;
                tbEmail.Text = taiKhoanKH.Email;
                tbPhone.Text = taiKhoanKH.SDT;
                if(taiKhoanKH.GioiTinh == "F")
                {
                    rbttnFemale.Checked = true;
                }
                else
                {
                    rbttnMale.Checked = true;
                }
                dtpBirthday.Value = taiKhoanKH.NgaySinh;
            }
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
                flowLayoutPanel1.Controls.Add(new Menu(mon,btnOrder_Click, btnOrder_ClickMon));
            }
        }
        private void LoadCombo()
        {
            List<Combo> combos = ComboDAO.Instance.getCombo();
            foreach (Combo combo in combos)
            {
                flowLayoutPanel1.Controls.Add(new Menu(combo, btnOrder_Click,btnOrder_ClickMon));
            }
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            if(tbAddress.Text != taiKhoanKH.DiaChi)
            {
                bttnSave.Enabled = true;
            }
            else
            {
                bttnSave.Enabled = false;
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if(tbEmail.Text!=taiKhoanKH.Email)
            {
                bttnSave.Enabled = true;
            }
            else
            {
                bttnSave.Enabled = false;
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if(tbName.Text!=taiKhoanKH.Ho)
            {
                bttnSave.Enabled = true;
            }
            else
            {
                bttnSave.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text!=taiKhoanKH.Ho)
            {
                bttnSave.Enabled = true;
            }
            else
            {
                bttnSave.Enabled = false;
            }
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            if(tbPhone.Text!=taiKhoanKH.SDT)
            {
                bttnSave.Enabled = true;
            }
            else
            {
                bttnSave.Enabled = false;
            }
        }

        private void rbttnMale_CheckedChanged(object sender, EventArgs e)
        {
            if(rbttnMale.Checked!=(taiKhoanKH.GioiTinh=="M"))
            {
                bttnSave.Enabled = true;
            }
            else
            {
                bttnSave.Enabled = false;
            }
        }
        public void btnOrder_Click(object sender, EventArgs e)
        {
            List<CTMon> ctms = new List<CTMon>();
            Button button = sender as Button;
            ctms = button.Tag as List<CTMon>;
            foreach(CTMon ctm in ctms)
            {
                CTMons.Add(ctm);
            }
            loadCart();
        }
        public void btnOrder_ClickMon(object sender, EventArgs e)
        {
            object mon = ((sender as Button).Tag);
            if (mon is Mon)
            { 
                Mons.Add((Mon)mon);
            }
            if (mon is Combo)
            {
                Combos.Add((Combo)mon);
            }
            loadCart();
        }
        private void bttnSave_Click(object sender, EventArgs e)
        {
            if(tbRePassword.Text==taiKhoanKH.MatKhau)
            {
                string gender;
                if(rbttnFemale.Enabled)
                {
                    gender = "F";
                }
                else
                {
                    gender = "M";
                }
                TaiKhoanKHDAO.Instance.updateTaiKhoanKH(taiKhoanKH.IDKH, tbName.Text, textBox1.Text, gender, dtpBirthday.Value.ToString(), tbPhone.Text, tbEmail.Text, tbAddress.Text);
                MessageBox.Show("Cập nhật thông tin thành công");
            }
            else
            {
                MessageBox.Show("Nhập sai mật khẩu");
            }
            taiKhoanKH = TaiKhoanKHDAO.Instance.getTaiKhoanKH(taiKhoanKH.IDKH)[0];
        }
        private void bttnXoaMon(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            object obj = button.Tag;
            foreach(Control control in flowLayoutPanel2.Controls)
            {
                if(((MenuCart)control).Obj==obj)
                {
                    flowLayoutPanel2.Controls.Remove(control);
                    break;
                }
            }    
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public void loadCart()
        {
            flowLayoutPanel2.Controls.Clear();
            foreach (Mon mon in Mons)
            {
                flowLayoutPanel2.Controls.Add(new MenuCart(mon, bttnXoaMon));
            }
            foreach (Combo combo in Combos)
            {
                flowLayoutPanel2.Controls.Add(new MenuCart(combo, bttnXoaMon));
            }
        }

        private void bttnOrder_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (Mon mon in Mons)
            {
                sum += mon.GiaMon;
            }
            foreach (Combo combo in Combos)
            {
                sum += combo.GiaCombo;
            }
            foreach (CTMon cTMon in CTMons)
            {
                sum += cTMon.TienThem;
            }
            int count = HoaDonDAO.Instance.getHoaDon().Count;
            string id = "HD" + count.ToString("D7");
            HoaDon hd = new HoaDon(id, DateTime.Now, sum, 1, 7, sum, taiKhoanKH.IDKH, false, false);
            foreach (Mon mon in Mons)
            {
                
            }

        }
    }
}
