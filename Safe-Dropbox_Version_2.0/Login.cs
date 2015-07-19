using DataModels;
using SafeDropBoxBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safe_Dropbox_Version_2._0
{
    public partial class Login : Form
    {
        UserAccountManagerBLL accountManager = new UserAccountManagerBLL();
        Users currentUser = new Users();
        EncryptPassword decryptor = new EncryptPassword();
        public Form MainForm { get; set; }
        string userToken;
        string userSecret;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            Users cUser = new Users();

            if (UserLogin(cUser))
            {
                userToken = accountManager.GetToken(txtEmail.Text);
                userSecret = accountManager.GetSecret(txtEmail.Text);

                MessageBox.Show("Login Successful");

                DropTray dTray = new DropTray();
                dTray.Email = txtEmail.Text;
                dTray.UserToken = userToken;
                dTray.UserSecret = userSecret;
                dTray.UserPassword = txtPassword.Text;
                dTray.Show();

                this.Hide();
                return;
            }
            else
            {
                MessageBox.Show("Login Unsuccessful" + Environment.NewLine + "Please check your details and internet connection!","Error");
            }
        }

        bool UserLogin(Users currentUsers)
        {
            currentUser.Email = txtEmail.Text;
            currentUser.Password = txtPassword.Text;// EncryptPassword.Encrypt(txtPassword.Text);

            return accountManager.UserLogin(currentUser);
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainForm.Show();
            this.Close();            
        }

        private void cbRemember_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
