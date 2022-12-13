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
        public ItemChitiet(CTMon cTMon)
        {
            InitializeComponent();
            CTMon = cTMon;
            
        }
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
    }
}
