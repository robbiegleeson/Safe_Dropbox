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
using System.Text.RegularExpressions;

namespace Safe_Dropbox_Version_2._0
{
    /// <summary>
    /// Registration class registers a new user with the application as well as calling the DropboxAccess.cs class that links
    /// the users Dropbox account with the application.
    /// </summary>
    public partial class Register : Form
    {
        public Form MainForm { get; set; }
        bool success = false;

        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserAccountManagerBLL accountBLL = new UserAccountManagerBLL();
            Users newUser = new Users();

            newUser.FirstName = txtFname.Text;
            newUser.Surname = txtSname.Text;
            newUser.Email = txtEmail.Text;
            // Userpassword is encrypted using SHA1();
            if (txtPassword.Text == txtConfirmPass.Text)
            {
                newUser.Password = txtConfirmPass.Text; //EncryptPassword.Encrypt(txtConfirmPass.Text);

                if (accountBLL.NewUser(newUser))
                {
                    MessageBox.Show("Registration Successful", "Success");
                    pbDropBox.Visible = true;
                    lblLinkDropBox.Visible = true;
                    btnDone.Visible = true; 
                    btnRegister.Visible = false;
                    success = true;
                }
            }
            else
            {
                MessageBox.Show("Your passwords don't match!", "Error");
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            
            DropTray dTray = new DropTray();
            dTray.Email = txtEmail.Text;
            dTray.UserPassword = txtConfirmPass.Text;
            dTray.ShowDialog();
            this.Hide();
            
        }

        private void pbDropBox_Click(object sender, EventArgs e)
        {
            DropboxAccess dAccess = new DropboxAccess();
            dAccess.Email = txtEmail.Text;

            if (dAccess.LinkDrpbox())
            {
                MessageBox.Show("Dropbox Link Successful", "Success");
                if (success == true)
                {
                    this.Hide();
                }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainForm.Show();
            this.Close();

        }      
       
    }
}
