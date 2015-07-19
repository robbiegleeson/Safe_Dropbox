namespace Safe_Dropbox_Version_2._0
{
    partial class DropTray
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DropTray));
            this.pnlDropTray = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEncrypt = new System.Windows.Forms.TabPage();
            this.tabDecrpy = new System.Windows.Forms.TabPage();
            this.pnlDecrypt = new System.Windows.Forms.Panel();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btnHide = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabEncrypt.SuspendLayout();
            this.tabDecrpy.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDropTray
            // 
            this.pnlDropTray.AllowDrop = true;
            this.pnlDropTray.Location = new System.Drawing.Point(6, 6);
            this.pnlDropTray.Name = "pnlDropTray";
            this.pnlDropTray.Size = new System.Drawing.Size(220, 167);
            this.pnlDropTray.TabIndex = 0;
            this.pnlDropTray.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDropTray_DragDrop);
            this.pnlDropTray.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDropTray_DragEnter);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Azure;
            this.btnQuit.Location = new System.Drawing.Point(122, 206);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "I\'m still logged in!";
            this.notifyIcon1.BalloonTipTitle = "Safe-Dropbox";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Safe-Dropbox";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseMove);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEncrypt);
            this.tabControl1.Controls.Add(this.tabDecrpy);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(238, 200);
            this.tabControl1.TabIndex = 4;
            // 
            // tabEncrypt
            // 
            this.tabEncrypt.Controls.Add(this.pnlDropTray);
            this.tabEncrypt.Location = new System.Drawing.Point(4, 22);
            this.tabEncrypt.Name = "tabEncrypt";
            this.tabEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabEncrypt.Size = new System.Drawing.Size(230, 174);
            this.tabEncrypt.TabIndex = 1;
            this.tabEncrypt.Text = "Encrypt";
            this.tabEncrypt.UseVisualStyleBackColor = true;
            // 
            // tabDecrpy
            // 
            this.tabDecrpy.Controls.Add(this.pnlDecrypt);
            this.tabDecrpy.Location = new System.Drawing.Point(4, 22);
            this.tabDecrpy.Name = "tabDecrpy";
            this.tabDecrpy.Size = new System.Drawing.Size(222, 174);
            this.tabDecrpy.TabIndex = 2;
            this.tabDecrpy.Text = "Decrypt";
            this.tabDecrpy.UseVisualStyleBackColor = true;
            // 
            // pnlDecrypt
            // 
            this.pnlDecrypt.AllowDrop = true;
            this.pnlDecrypt.Location = new System.Drawing.Point(-4, 0);
            this.pnlDecrypt.Name = "pnlDecrypt";
            this.pnlDecrypt.Size = new System.Drawing.Size(226, 178);
            this.pnlDecrypt.TabIndex = 0;
            this.pnlDecrypt.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDecrypt_DragDrop);
            this.pnlDecrypt.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDecrypt_DragEnter);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Azure;
            this.btnHide.Location = new System.Drawing.Point(13, 206);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(100, 23);
            this.btnHide.TabIndex = 5;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // DropTray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(234, 236);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnQuit);
            this.Name = "DropTray";
            this.Load += new System.EventHandler(this.DropTray_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabEncrypt.ResumeLayout(false);
            this.tabDecrpy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDropTray;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEncrypt;
        private System.Windows.Forms.TabPage tabDecrpy;
        private System.Windows.Forms.Panel pnlDecrypt;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btnHide;
    }
}

