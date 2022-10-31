using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCH.DTO_1;
using MetroFramework.Forms;


namespace QuanLiCH
{
    public partial class fLogin : MetroForm
    {
        public fLogin()
        {
            InitializeComponent();
            txtPassWord.UseSystemPasswordChar = true;
            if (Properties.Settings.Default.UserName != null)
            {
                txtUserName.Text = Properties.Settings.Default.UserName;
                txtPassWord.Text = Properties.Settings.Default.UserPass;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;



            if (Login(userName, passWord))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                fTableManager f = new fTableManager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
            bool Login(string username, string password)
            {
                return AccountDAO.Instance.Login(userName, passWord);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowpass.Checked)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
        }

        private void checkBox1_rmaccount(object sender, EventArgs e)
        {
            if (chkrmAccount.Checked)
            {
                Properties.Settings.Default.UserName = txtUserName.Text;
                Properties.Settings.Default.UserPass = txtPassWord.Text;
                Properties.Settings.Default.Save();
            }
            else {
                Properties.Settings.Default.UserName = " ";
                Properties.Settings.Default.UserPass = " ";
                Properties.Settings.Default.Save();
            }
        }
    }
}
