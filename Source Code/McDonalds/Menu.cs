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
    public partial class Menu : UserControl
    {
        public Menu(object Mon)
        {
            InitializeComponent();
            Obj = Mon;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private string trangThai;
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
                    button1.Enabled = mon.TrangThai == "Còn Hàng";
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
                    button1.Enabled = combo.TrangThai == "Còn Hàng";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //i++;
            //frmMain.tabCart.Text = "hello";
        }

        private void lbl_price_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
