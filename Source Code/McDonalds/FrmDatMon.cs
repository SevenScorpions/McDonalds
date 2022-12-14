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
        public FrmDatMon(object obj)
        {
            InitializeComponent();
            Obj = obj;
            ctmons = new List<CTMon>();
        }
        public List<CTMon> ctmons;
        private object obj;
        public object Obj { get { return obj; } set { obj = value; } }
        private void FrmDatMon_Load(object sender, EventArgs e)
        {
            if(obj is Mon)
            {
                Mon mon = (Mon)obj;
                ctmons = CTMonDAO.Instance.getCTMonByIdMon(mon.IDMon);
                foreach(CTMon ctmon in ctmons)
                {
                    flowLayoutPanel2.Controls.Add(new ItemChitiet(ctmon, mon.Img));
                }
            }
            if(obj is Combo)
            {
                Combo combo = (Combo)obj;
                ctmons = CTMonDAO.Instance.getCTMonByIdCombo(combo.IDCombo);
                List<Mon> mons = new List<Mon>();
                foreach(CTMon ctmon in ctmons)
                {
                    Mon mon = MonDAO.Instance.getMon(ctmon.IDMon)[0];
                    if(!mons.Contains(mon))
                    {
                        mons.Add(mon);
                    }
                }
                foreach(Mon mon in mons)
                {
                    Button btn = new Button();
                    btn.Font = new Font("Roboto", 13);
                    btn.ForeColor = Color.Firebrick;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.Black;
                    btn.Tag = mon;
                    btn.Click += new System.EventHandler(btn_Click);
                    flowLayoutPanel1.Controls.Add(btn);
                }
            }
            
        }
        private void btn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            Button button = sender as Button;
            Mon mon = ((Mon)button.Tag);
            foreach (CTMon ctmon in ctmons)
            {
                if(ctmon.IDMon==mon.IDMon)
                {
                    flowLayoutPanel2.Controls.Add(new ItemChitiet(ctmon, mon.Img));
                }
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
