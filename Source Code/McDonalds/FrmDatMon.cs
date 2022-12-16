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
    public partial class FrmDatMon : Form
    {
        public FrmDatMon(object obj,EventHandler eve,EventHandler eve1)
        {
            InitializeComponent();
            Obj = obj;
            ctmons = new List<CTMon>();
            choose = new List<CTMon>();
            loadTongtien();
            button2.Click += eve;
            button3.Click += eve1;
            button3.Tag = obj;
        }
        public List<CTMon> ctmons;
        public List<CTMon> choose;
        private Button selectedButton;
        private object obj;
        public object Obj { get { return obj; } set { obj = value; } }
        private List<Mon> mons;
        private void FrmDatMon_Load(object sender, EventArgs e)
        {
            mons = new List<Mon>();
            if (obj is Mon)
            {
                Mon mon = (Mon)obj;
                ctmons = CTMonDAO.Instance.getCTMonByIdMon(mon.IDMon);
                mons.Add(mon);
                foreach(CTMon ctmon in ctmons)
                {
                    flowLayoutPanel2.Controls.Add(new ItemChitiet(ctmon, mon.Img,clickChoose));
                }
            }
            if(obj is Combo)
            {
                Combo combo = (Combo)obj;
                ctmons = CTMonDAO.Instance.getCTMonByIdCombo(combo.IDCombo);
                
                foreach(CTMon ctmon in ctmons)
                {
                    Mon mon = MonDAO.Instance.getMon(ctmon.IDMon)[0];
                    if(!mons.Contains(mon))
                    {
                        mons.Add(mon);
                    }
                }
                int i = 1;
                foreach(Mon mon in mons)
                {
                    Button btn = new Button();
                    btn.Font = new Font("Roboto", 10);
                    btn.Height = 30;
                    btn.Width = 155;
                    btn.ForeColor = Color.Firebrick;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.White;
                    btn.BackColor=Color.White;
                    btn.Text = mon.TenMon;
                    List<ItemChitiet> ict = new List<ItemChitiet>();
                    foreach (CTMon ctmon in ctmons)
                    {
                        if (ctmon.IDMon == mon.IDMon)
                        {
                            ict.Add(new ItemChitiet(ctmon, mon.Img, clickChoose));
                        }
                    }
                    btn.Tag = ict;
                    btn.Click += new System.EventHandler(btn_Click);
                    flowLayoutPanel1.Controls.Add(btn);
                    if(i==1)
                    {
                        btn.PerformClick();
                        i++;
                    }    
                }
            }
            
        }
        private void btn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            Button button = sender as Button;
            List<ItemChitiet> controls = (List<ItemChitiet>)(button.Tag);
            foreach(ItemChitiet control in controls)
            {
                flowLayoutPanel2.Controls.Add(control);
            }
        }
        public void clickChoose(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            CTMon ctmon = ((CTMon)btn.Tag);
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                ItemChitiet itemChitiet = control as ItemChitiet;
                if (itemChitiet.CTMon.IDCTMon != ctmon.IDCTMon)
                {
                    CTMon ctm = itemChitiet.CTMon;
                    choose.Remove(ctm);
                    itemChitiet.Check = false;
                }
                else
                {
                    itemChitiet.Check = true;
                }
            }
            choose.Add(ctmon);
            loadTongtien();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(mons.Count==choose.Count)
            {
                MessageBox.Show("Thêm vào giỏ hàng thành công");
                button3.PerformClick();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn toàn bộ chi tiết món");
            }
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        void loadTongtien()
        {
            List<object> objs = new List<object>();
            int sum = 0;
            foreach(CTMon ctmon in choose)
            {
                sum += ctmon.TienThem;
                objs.Add(ctmon);
            }
            objs.Add(obj);
            button2.Tag = objs;
            label2.Text ="+ "+ sum.ToString()+"đ";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
