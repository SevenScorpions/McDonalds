﻿using McDonalds.DTO;
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
        public Menu(object Mon,EventHandler e, EventHandler eve1)
        {
            InitializeComponent();
            Obj = Mon;
            eve = e;
            this.eve1 = eve1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private FrmDatMon frmDatMon;
        public FrmDatMon FrmDatMon { get { return frmDatMon; } }
        public EventHandler eve;
        public EventHandler eve1;
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
                bool enable = true;
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
                    enable = mon.TrangThai == "CÒN HÀNG";
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
                    enable = combo.TrangThai == "CÒN HÀNG";
                }
                button1.Enabled = enable;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmDatMon = new FrmDatMon(obj, eve, eve1);
            frmDatMon.ShowDialog();
        }

        private void lbl_price_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
        private void cartLoad(object sender, EventArgs e)
        {

        }
    }
}
