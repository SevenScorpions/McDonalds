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
        public Task<Image> LoadImageFromFileAsync(string uri)
        {
            return Task.Run(() => {
                return Image.FromFile(uri);
            });
        }

        public string _urimonan;
        public string uri_monan
        {
            set
            {
                this._urimonan = value;
            }
            get { return _urimonan; }
        }

        public async void LoadImageAsync()
        {
            var image = await LoadImageFromFileAsync(this.uri_monan);
            pic_food.Image = image;

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
    }
}
