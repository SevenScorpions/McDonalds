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
        public MenuCart(object Mon,EventHandler e)
        {
            InitializeComponent();
            button2.Tag= Mon;
            Obj = Mon;
            eve = e;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public EventHandler eve;
        private object obj;
        private string loai;
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
                    Loai = "Mon";
                    Mon mon = (Mon)obj;
                    this.mon = mon;
                    Object rm = McDonalds.Properties.Resources.ResourceManager.GetObject(mon.Img);
                    Bitmap myImage = (Bitmap)rm;
                    Image image = myImage;
                    pic_food.BackgroundImage = image;
                    lbl_price.Text = "₫" + mon.GiaMon.ToString("#,#");
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
                    lbl_price.Text = "₫" + combo.GiaCombo.ToString("#,#");
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
            eve(sender, e);
        }
    }
}
