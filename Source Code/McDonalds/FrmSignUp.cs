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
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void bttnSignUp_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            if(firstName == "" || lastName == "")
            {
                valid = false;
                lbWrongName.Text = "Tên không hợp lê";
            }
            string phone = tbPhone.Text;
            if(phone=="")
            {
                valid=false;
                lbWrongPhone.Text = "";
            }
        }
    }
}
