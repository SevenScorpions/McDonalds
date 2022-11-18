using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McDonalds
{
    public partial class frmLogin : Form
    {
        #region method
        public frmLogin()
        {
            InitializeComponent();
            if (!IsServerConnected(@"Data Source=.\sqlexpress;Initial Catalog=GALAXY;Integrated Security=True"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = @"/C sqlcmd -E -S .\SQLExpress -i script.sql";
                process.StartInfo = startInfo;
                process.Start();
            }

        }
        private static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        private bool CheckError()
        {
            string temp = "";
            if (tbUserName.Text == "")
                temp += "Username is empty\n";
            if (tbPassWord.Text == "")
                temp += "Password is empty";
            if (temp == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(temp);
                return false;
            }
        }
        #endregion
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var window = MessageBox.Show("Do you want to exit?", "Exit?", MessageBoxButtons.OKCancel);
            if (window == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
