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
    public partial class MenuCart : UserControl
    {
        public MenuCart(object Mon,List<CTMon> ctmons,EventHandler e,int index)
        {
            InitializeComponent();
            button2.Tag= Mon;
            this.ctmons=new List<CTMon>(ctmons);
            Obj = Mon;
            button2.Click+=e;
            Index = index;
            button2.Tag= index;
            int i = 0;
            foreach(CTMon ctmon in CTMons)
            {
                if(i==0)
                {
                    lbMoTa.Text += ctmon.TenCTM;
                    i++;
                }
                else if(i<2)
                {
                    lbMoTa.Text += ", "+ ctmon.TenCTM;
                    i++;
                }
                else
                {
                    lbMoTa.Text += ",...";
                    break;
                }
            }
            int sum = 0;
            if(loai=="Món")
            {
                sum = sum + mon.GiaMon;
                foreach (CTMon ctmon in CTMons)
                {
                    sum += ctmon.TienThem;
                }
            }
            else
            {
                sum = sum + combo.GiaCombo;
                foreach (CTMon ctmon in CTMons)
                {
                    sum += ctmon.TienThem;
                }
            }
            lbl_price.Text = "₫" + sum.ToString("#,#");
        }
        private int index;
        public int Index { get { return index; } set { index = value; } }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public EventHandler eve;
        private object obj;
        private string loai;
        private List<CTMon> ctmons;
        public List<CTMon> CTMons { get { return ctmons; } }    
        private Mon mon;
        private Combo combo;
        public Combo Combo { get { return combo; } set { combo = value; } }
        public string Loai { get { return loai; } set { loai = value; } }
        public Mon Mon
        {
            get { return mon; }
            set { mon = value; }
        }
        public object Obj
        {
            get { return obj; }
            set
            {
                obj = value;
                if (obj is Mon)
                {
                    Loai = "Món";
                    Mon mon = (Mon)obj;
                    this.mon = mon;
                    Object rm = McDonalds.Properties.Resources.ResourceManager.GetObject(mon.Img);
                    Bitmap myImage = (Bitmap)rm;
                    Image image = myImage;
                    pic_food.BackgroundImage = image;
                    lbl_name.Text = mon.TenMon;
                }
                else if (obj is Combo)
                {
                    Loai = "Combo";
                    Combo combo = (Combo)obj;
                    this.combo = combo;
                    Object rm = McDonalds.Properties.Resources.ResourceManager.GetObject(combo.Img);
                    Bitmap myImage = (Bitmap)rm;
                    Image image = myImage;
                    pic_food.BackgroundImage = image;
                    
                    lbl_name.Text = combo.TenCombo;
                }
            }
        }
        private void lbl_price_Click(object sender, EventArgs e)
        {

        }

        private void MenuCart_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
