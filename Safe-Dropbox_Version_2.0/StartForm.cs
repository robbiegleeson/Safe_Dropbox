using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safe_Dropbox_Version_2._0
{
    public partial class StartForm : Form
    {
        /// <summary>
        /// Main entry form for application. Options for login and register as well as register a Dropbox account.
        /// </summary>
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login logIn = new Login();
            logIn.MainForm = this;
            this.Visible = false;
            logIn.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("SafeDropbox requires a valid Dropbox account!" + Environment.NewLine + "Would you like to continue?", "Continue", MessageBoxButtons.YesNo);
            if (dResult == DialogResult.Yes)
            {
                Register newUser = new Register();
                newUser.MainForm = this;
                this.Visible = false;
                newUser.Show();
            }
            
        }

        private void signUpForDropboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe", "http://www.dropbox.com");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Safe-Dropbox Version 2.0", "Version");
        }
    }
}
