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
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //load ảnh
        public string _urimonan;
        public string uri_monan
        {
            set
            {
                Object rm = McDonalds.Properties.Resources.ResourceManager.GetObject(value);
                Bitmap myImage = (Bitmap)rm;
                Image image = myImage;
                this._urimonan = value;
                pic_food.BackgroundImage = image;
            }
            get { return _urimonan; }
        }

        //load tên
        public string _name;
        public string name
        {
            set
            {
                _name = value;
                lbl_name.Text = value;
            }
            get { return this._name; }
        }

        //load giá
        public int _price;
        public int price
        {
            set
            {
                _price = value;
                lbl_price.Text = "₫" + value.ToString("#,#");
            }
            get { return this._price; }
        }

        //int i = 0;
        //FrmMain frmMain;
        private void button1_Click(object sender, EventArgs e)
        {
            //i++;
            //frmMain.tabCart.Text = "hello";
        }

        private void lbl_price_Click(object sender, EventArgs e)
        {

        }
    }
}
