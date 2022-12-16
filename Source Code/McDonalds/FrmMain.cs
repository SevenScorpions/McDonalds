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
        int sum = 0;
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
                label12.Text = "Điểm thưởng: " + taiKhoanKH.DiemThuong; 
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
            List<object> objs = new List<object>();
            Button button = sender as Button;
            objs = button.Tag as List<object>;
            object m = e;
            List<CTMon> ctms = new List<CTMon>();
            foreach(object obj in objs)
            {
                if(obj is CTMon)
                {
                    CTMon ctmon = (CTMon)obj;
                    ctms.Add(ctmon);
                }
                else
                {
                    m = obj; 
                }
            }
            List<Mon> mons = new List<Mon>();
            if (m is Combo)
            {
                List<CTMon> ctmons = new List<CTMon>();
                Combo combo = (Combo)m;
                ctmons = CTMonDAO.Instance.getCTMonByIdCombo(combo.IDCombo);
                
                foreach (CTMon ctmon in ctmons)
                {
                    Mon mon = MonDAO.Instance.getMon(ctmon.IDMon)[0];
                    bool valid = true;
                    foreach (Mon mon1 in mons)
                    {
                        if (mon1.IDMon == mon.IDMon)
                        {
                            valid = false; break;
                        }
                    }
                    if (valid)
                    {
                        mons.Add(mon);
                    }
                }
            }
            else if(m is Mon)
            {
                Mon mon = (Mon)m;
                mons.Add(mon);
            }
            if(((m is Mon) || (m is Combo)) && ctms.Count == mons.Count)
            {
                foreach (CTMon ctmon in ctms)
                {
                    CTMons.Add(ctmon);
                }
                addCart(m,ctms);
                
            }
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
        }
        private void bttnSave_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if(tbRePassword.Text!=taiKhoanKH.MatKhau)
            {
                valid = false;
            }
            string gender;
            if (rbttnFemale.Enabled)
            {
                gender = "F";
            }
            else
            {
                gender = "M";
            }

            if (!tbEmail.Text.Contains("@gmail.com"))
            {
                valid = false;
            }
            if (-dtpBirthday.Value.Year + DateTime.Now.Year < 13)
            {
                valid = false;
            }
            if (valid)
            {
                TaiKhoanKHDAO.Instance.updateTaiKhoanKH(taiKhoanKH.IDKH, tbName.Text, textBox1.Text, gender, dtpBirthday.Value.ToString(), tbPhone.Text, tbEmail.Text, tbAddress.Text);
                MessageBox.Show("Cập nhật thông tin thành công");
            }
            if (!valid)
            {
                MessageBox.Show("Nhập sai mật khẩu hoặc sai thông tin chỉnh sửa");
            }
            taiKhoanKH = TaiKhoanKHDAO.Instance.getTaiKhoanKH(taiKhoanKH.IDKH)[0];
        }
        private void bttnXoaMon(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = (int) button.Tag;
            object obj = e;
            List<CTMon> ctms = new List<CTMon>();
            foreach(Control control in flowLayoutPanel2.Controls)
            {
                if(((MenuCart)control).Index==index)
                {
                    MenuCart menuCart = (MenuCart)control;
                    ctms = menuCart.CTMons;
                    obj = menuCart.Obj;
                    flowLayoutPanel2.Controls.Remove(control);
                    break;
                }
            }
            foreach(CTMon cTMon in ctms)
            {
                foreach(CTMon ctmon in CTMons)
                {
                    if(cTMon.IDCTMon==ctmon.IDCTMon)
                    {
                        CTMons.Remove(ctmon);
                        break;
                    }
                }
            }    
            if(obj is Mon)
            {
                foreach(Mon mon in Mons)
                {
                    if(mon.IDMon==((Mon)obj).IDMon)
                    {
                        Mons.Remove(mon);
                        break;
                    }
                }
            }
            else
            {
                foreach (Combo combo in Combos)
                {
                    if (combo.IDCombo == ((Combo)obj).IDCombo)
                    {
                        Combos.Remove(combo);
                        break;
                    }
                }
            }
            loadTT();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public void addCart(object obj,List<CTMon> cTMons)
        {
            flowLayoutPanel2.Controls.Add(new MenuCart(obj,cTMons,bttnXoaMon,flowLayoutPanel2.Controls.Count));
            sum = 0;
            loadTT();
        }
        void loadTT()
        {
            sum = 0;
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
            label2.Text = "Tổng tiền: " + sum.ToString() + " VNĐ";
        }
        private void bttnOrder_Click(object sender, EventArgs e)
        {
            if(CTMons.Count==0)
            {
                MessageBox.Show("Giỏ hàng trống");
                return;
            }

            int count = HoaDonDAO.Instance.getHoaDon().Count+1;
            string id = "HD" + count.ToString("D7");
            int stt = count % 100;
            if(comboBox1.Text=="")
            {
                MessageBox.Show("Chưa chọn phương thức thanh toán");
                return;
            }
            else if(comboBox1.Text=="Tiền mặt")
            {
                HoaDonDAO.Instance.createHD(id, DateTime.Now, 1, stt, sum, taiKhoanKH.IDKH, sum, 0, 0,comboBox1.Text);
            }
            else
            {
                HoaDonDAO.Instance.createHDDATHANHTOAN(id, DateTime.Now, 1, stt, sum, taiKhoanKH.IDKH, sum, sum, sum, comboBox1.Text);
            }    
            List<string> list = new List<string>();
            foreach (Mon mon in Mons)
            {
                if(!list.Contains(mon.IDMon))
                {
                    int count1 = 0;
                    foreach(Mon mon2 in Mons)
                    {
                        if(mon2.IDMon==mon.IDMon)
                        {
                            count1++;
                        }
                    }
                    HDMonDAO.Instance.insertHDMon(id, mon.IDMon,count1);
                    list.Add(mon.IDMon);
                }
            }
            foreach (Combo combo in Combos)
            {
                if (!list.Contains(combo.IDCombo))
                {
                    int count1 = 0;
                    foreach (Combo combo2 in Combos)
                    {
                        if (combo2.IDCombo == combo.IDCombo)
                        {
                            count1++;
                        }
                    }
                    HDComboDAO.Instance.insertHDCombo(id, combo.IDCombo, count1);
                    list.Add(combo.IDCombo);
                }
            }
            foreach (CTMon ctmon in CTMons)
            {
                if (!list.Contains(ctmon.IDCTMon))
                {
                    int count1 = 0;
                    foreach (CTMon ctmon2 in CTMons)
                    {
                        if (ctmon.IDCTMon == ctmon2.IDCTMon)
                        {
                            count1++;
                        }
                    }
                    HDCTMonDAO.Instance.insertHDCTMon(id, ctmon.IDCTMon, count1);
                    list.Add(ctmon.IDCTMon);
                }
            }
            flowLayoutPanel2.Controls.Clear();
            CTMons.Clear();
            Mons.Clear();
            Combos.Clear();
            label2.Text = "Tổng tiền: ";
            if (!(taiKhoanKH.IDKH == "KH0000000000"))
            {
                taiKhoanKH.DiemThuong = taiKhoanKH.DiemThuong + sum / 1000;
                TaiKhoanKHDAO.Instance.updateDiemThuong(taiKhoanKH.IDKH, taiKhoanKH.DiemThuong);
                label12.Text = "Điểm thưởng: " + taiKhoanKH.DiemThuong;
            }
            loadTT();    
            MessageBox.Show("Đặt hàng thành công");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            if(dtpBirthday.Value!=taiKhoanKH.NgaySinh)
            {
                bttnSave.Enabled = true;
            }
            else
            { bttnSave.Enabled = false; }
        }
    }
}
