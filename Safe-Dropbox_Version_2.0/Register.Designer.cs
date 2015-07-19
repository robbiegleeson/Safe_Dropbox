namespace Safe_Dropbox_Version_2._0
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.btnDone = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblLinkDropBox = new System.Windows.Forms.Label();
            this.pbDropBox = new System.Windows.Forms.PictureBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbDropBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(143, 330);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 50;
            this.btnDone.Text = "REGISTER";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(147, 253);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 49;
            this.btnRegister.Text = "SUBMIT";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblLinkDropBox
            // 
            this.lblLinkDropBox.AutoSize = true;
            this.lblLinkDropBox.Location = new System.Drawing.Point(112, 310);
            this.lblLinkDropBox.Name = "lblLinkDropBox";
            this.lblLinkDropBox.Size = new System.Drawing.Size(138, 13);
            this.lblLinkDropBox.TabIndex = 48;
            this.lblLinkDropBox.Text = "CLICK TO LINK DROPBOX";
            this.lblLinkDropBox.Visible = false;
            // 
            // pbDropBox
            // 
            this.pbDropBox.Image = ((System.Drawing.Image)(resources.GetObject("pbDropBox.Image")));
            this.pbDropBox.Location = new System.Drawing.Point(112, 266);
            this.pbDropBox.Name = "pbDropBox";
            this.pbDropBox.Size = new System.Drawing.Size(138, 41);
            this.pbDropBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDropBox.TabIndex = 47;
            this.pbDropBox.TabStop = false;
            this.pbDropBox.Visible = false;
            this.pbDropBox.Click += new System.EventHandler(this.pbDropBox_Click);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(197, 210);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmPass.TabIndex = 46;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(197, 175);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 45;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(197, 142);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 44;
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(197, 110);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(100, 20);
            this.txtSname.TabIndex = 43;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(197, 78);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(100, 20);
            this.txtFname.TabIndex = 42;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Location = new System.Drawing.Point(57, 213);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(125, 13);
            this.lblConfirmPass.TabIndex = 41;
            this.lblConfirmPass.Text = "CONFIRM PASSWORD:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(57, 178);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 13);
            this.lblPassword.TabIndex = 40;
            this.lblPassword.Text = "PASSWORD:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(57, 145);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 13);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "E-MAIL:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(57, 113);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(64, 13);
            this.lblSurname.TabIndex = 38;
            this.lblSurname.Text = "SURNAME:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(57, 81);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(75, 13);
            this.lblFirstName.TabIndex = 37;
            this.lblFirstName.Text = "FIRST NAME:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(120, 39);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(153, 23);
            this.lblHeader.TabIndex = 36;
            this.lblHeader.Text = "SafeDropBox";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(354, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Back";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 390);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblLinkDropBox);
            this.Controls.Add(this.pbDropBox);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pbDropBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblLinkDropBox;
        private System.Windows.Forms.PictureBox pbDropBox;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}