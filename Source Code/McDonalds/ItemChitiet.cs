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
        public ItemChitiet()
        {
            InitializeComponent();
        }

        public string _lbltitle;

        public string lblTitle
        {
            get { return _lbltitle; }
            set { _lbltitle = value; }
        }

        private string _lblprice;

        public string lblPrice
        {
            get { return _lblprice; }
            set { 
                _lblprice = value;
            }
        }

    }
}
