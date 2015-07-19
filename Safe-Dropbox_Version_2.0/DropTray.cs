using DropNet;
using DropNet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Configuration;
using DataModels;
using SafeDropBoxBLL;

namespace Safe_Dropbox_Version_2._0
{
    public partial class DropTray : Form
    {
        public string NameOfFile { get; set; }
        public string UserToken { get; set; }
        public string UserSecret { get; set; }
        public string Email { get; set; }
        public string FileToUpload { get; set; }
        private DropNetClient _Client;
        public string FileToEncrypt { get; set; }
        public string EncryptedFile { get; set; }
        public string UserPassword { get; set; }

        string appKey = ConfigurationManager.AppSettings["appKey"];
        string appSecret = ConfigurationManager.AppSettings["appSecret"];

        DropboxAccess dAccess = new DropboxAccess();
        UserAccountManagerBLL accMan = new UserAccountManagerBLL();

        public DropTray()
        {
            InitializeComponent();
        }

        private void DropTray_Load(object sender, EventArgs e)
        {
            UserToken = accMan.GetToken(Email);
            UserSecret = accMan.GetSecret(Email);

            _Client = new DropNetClient(appKey, appSecret, UserToken, UserSecret);

            if (UserToken == "Error" && UserSecret == "Error")
            {
                MessageBox.Show(returnError());
            }
            else
            {
                Rectangle workingArea = Screen.GetWorkingArea(this);
                this.Location = new Point(workingArea.Right - Size.Width,
                                          workingArea.Bottom - Size.Height);

                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
        }

        private void pnlDropTray_DragDrop(object sender, DragEventArgs e)
        {
            Zip(e);
            EncryptFile();
            UploadFile();
        }

        private void pnlDropTray_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void EncryptFile()
        {                    
            RijndaelManagedEncryption myRij = new RijndaelManagedEncryption();
            myRij.Files = FileToEncrypt;
            myRij.Password = UserPassword;
            myRij.NameOfFile = NameOfFile;
            
            EncryptedFile = myRij.EncryptFile();
        }

        private void UploadFile()
        {
            try
            {
                var fileBytes = File.ReadAllBytes(EncryptedFile);

                
                UserAccountManagerBLL accMan = new UserAccountManagerBLL();
                if (accMan.InsertFile(Email, NameOfFile))
                {
                    _Client.UploadFile("/", NameOfFile + ".sdx", fileBytes);
                    MessageBox.Show("Your file has been uploaded!");
                }
                
                //GET user email for inserting into encryption table
                //ENTER trigger to enter record into DB table

                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void Zip(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    string startPath = Path.GetFullPath(file);
                    
                    NameOfFile = Path.GetFileNameWithoutExtension(file);
                    string zipPath = @"c:\SafeDropbox\" + NameOfFile + ".zip";

                    FileToUpload = startPath;

                    string path = @"c:\SafeDropbpx";

                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(@"c:\SafeDropbox");
                    }

                    startPath.Replace(" ", string.Empty);
                    ZipFile.CreateFromDirectory(startPath, zipPath);
                    
                    FileToEncrypt = zipPath;
                } 
            }
        }

        private string returnError()
        {
            return string.Format("Error loading User Login Token and Secret");
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void notifyIcon1_MouseMove(object sender, MouseEventArgs e)
        {
            //Show();
            //WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void pnlDecrypt_DragDrop(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                sfd.InitialDirectory = @"C:\";
                sfd.DefaultExt = "sdx";
                sfd.Filter = "Safe Dropbox files (*.sdx) | *.sdx";

                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                //Strip out the file into an array
                foreach (string file in files)
                {
                    var ext = Path.GetExtension(file);

                    if (ext != ".sdx")
                    {
                        MessageBox.Show("File must be a Safe Dropbox file (.sdx)");
                    }
                    else
                    {
                        // Get the path of the file and assign to FileToEncrypt property
                        var fileName = Path.GetFullPath(file);
                        FileToEncrypt = fileName;

                        // Call my encryption class and pass the file into the EncryptFile() methof
                        RijndaelManagedEncryption myEncryption = new RijndaelManagedEncryption();
                        sfd.ShowDialog();
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            myEncryption.SaveFileLocation = sfd.FileName;
                        }
                        myEncryption.Files = FileToEncrypt;
                        myEncryption.Password = "Admin";

                        EncryptedFile = myEncryption.DecryptFile();
                    }
                }
            }
        }

        private void pnlDecrypt_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(500);
            this.Hide();
        }
    }
}
