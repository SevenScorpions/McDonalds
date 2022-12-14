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
        public ItemChitiet(CTMon cTMon,string img)
        {
            InitializeComponent();
            CTMon = cTMon;
            Object rm = McDonalds.Properties.Resources.ResourceManager.GetObject(img);
            Bitmap myImage = (Bitmap)rm;
            Image image = myImage;
            pic_Food.BackgroundImage = image;
        }
        private string img;
        private CTMon cTMon;
        public CTMon CTMon { get { return cTMon; } 
            set { 
                cTMon = value;
                lbl_title.Text = CTMon.TenCTM;
                lbl_price.Text = "+ " + CTMon.TienThem.ToString();
            } 
        }

        private void ItemChitiet_Load(object sender, EventArgs e)
        {

        }

        private void pic_Food_Click(object sender, EventArgs e)
        {

        }
    }
}
