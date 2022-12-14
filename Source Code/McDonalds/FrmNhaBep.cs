using McDonalds.DAO;
using McDonalds.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace McDonalds
{
    public partial class FrmNhaBep : Form
    {
        public FrmNhaBep()
        {
            InitializeComponent();
        }
        private void FrmNhaBep_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadMon();
            LoadCombo();
        }
        private void LoadMon()
        {
            List<Mon> mons = MonDAO.Instance.getMon();
            foreach (Mon mon in mons)
            {
                flowLayoutPanel1.Controls.Add(new MenuBep(mon));
            }
        }
        private void LoadCombo()
        {
            List<Combo> combos = ComboDAO.Instance.getCombo();
            foreach (Combo combo in combos)
            {
                flowLayoutPanel1.Controls.Add(new MenuBep(combo));
            }
        }
    }
}
