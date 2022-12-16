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
    public partial class ItemChitiet : UserControl
    {
        public ItemChitiet(CTMon cTMon,string img, EventHandler eve)
        {
            InitializeComponent();
            CTMon = cTMon;
            Object rm = McDonalds.Properties.Resources.ResourceManager.GetObject(img);
            Bitmap myImage = (Bitmap)rm;
            Image image = myImage;
            pic_Food.BackgroundImage = image;
            button1.Tag = CTMon;
            button1.Click += eve;
        }
        public bool check=false;
        private CTMon cTMon;
        public CTMon CTMon { get { return cTMon; } 
            set { 
                cTMon = value;
                lbl_title.Text = CTMon.TenCTM;
                lbl_price.Text = "+ " + CTMon.TienThem.ToString() + " ₫";
            } 
        }

        private void ItemChitiet_Load(object sender, EventArgs e)
        {

        }

        private void pic_Food_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public bool Check { get { return check; } 
            set {
                if (value == true)
                {
                    check = true;
                    button1.Text = "Đã Chọn";
                    button1.Enabled = false;
                    button1.BackColor = Color.White;
                }
                else
                {
                    check= false;
                    button1.Text = "Chọn";
                    button1.Enabled = true;
                    button1.BackColor = Color.Firebrick;
                }
            } 
        }

        private void lbl_price_Click(object sender, EventArgs e)
        {

        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }
    }
}
