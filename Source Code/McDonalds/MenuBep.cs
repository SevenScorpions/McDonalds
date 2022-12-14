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
    public partial class MenuBep : UserControl
    {
        public MenuBep(object Mon)
        {
            InitializeComponent();
            Obj = Mon;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
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
                    button1.Text = mon.TrangThai;
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
                    button1.Text=combo.TrangThai;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (loai == "Mon")
            {
                if (button1.Text == "CÒN HÀNG")
                {
                    MonDAO.Instance.changeState(Mon.IDMon, "HẾT HÀNG");
                    button1.Text = "HẾT HÀNG";
                }
                else if(button1.Text == "HẾT HÀNG")
                {
                    MonDAO.Instance.changeState(Mon.IDMon, "NGƯNG BÁN");
                    button1.Text = "NGƯNG BÁN";
                }
                else
                {
                    MonDAO.Instance.changeState(Mon.IDMon, "CÒN HÀNG");
                    button1.Text = "CÒN HÀNG";
                }
            }else{
                if (button1.Text == "CÒN HÀNG")
                {
                    ComboDAO.Instance.changeState(Combo.IDCombo, "HẾT HÀNG");
                    button1.Text = "HẾT HÀNG";
                }
                else if (button1.Text == "HẾT HÀNG")
                {
                    ComboDAO.Instance.changeState(Combo.IDCombo, "NGƯNG BÁN");
                    button1.Text = "NGƯNG BÁN";
                }
                else
                {
                    ComboDAO.Instance.changeState(Combo.IDCombo, "CÒN HÀNG");
                    button1.Text = "CÒN HÀNG";
                }
            }

        }

        private void lbl_price_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
