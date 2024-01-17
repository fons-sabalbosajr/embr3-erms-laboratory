
namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    partial class frm_home_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_home_login));
            this.pright = new System.Windows.Forms.Panel();
            this.bclose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lconcact = new System.Windows.Forms.Label();
            this.pbgmail = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pstatus = new Guna.UI2.WinForms.Guna2Panel();
            this.lstatus = new System.Windows.Forms.Label();
            this.lwarning = new System.Windows.Forms.Label();
            this.pblogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.blogin = new Guna.UI2.WinForms.Guna2Button();
            this.bsignup = new Guna.UI2.WinForms.Guna2Button();
            this.tpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lheader = new System.Windows.Forms.Label();
            this.lbody = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tfade = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lversion = new System.Windows.Forms.Label();
            this.lip = new System.Windows.Forms.Label();
            this.pright.SuspendLayout();
            this.pstatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pright
            // 
            this.pright.Controls.Add(this.bclose);
            this.pright.Controls.Add(this.lconcact);
            this.pright.Controls.Add(this.pbgmail);
            this.pright.Controls.Add(this.pstatus);
            this.pright.Controls.Add(this.lwarning);
            this.pright.Controls.Add(this.pblogo);
            this.pright.Controls.Add(this.blogin);
            this.pright.Controls.Add(this.bsignup);
            this.pright.Controls.Add(this.tpassword);
            this.pright.Controls.Add(this.tusername);
            this.pright.Controls.Add(this.lheader);
            this.pright.Controls.Add(this.lbody);
            this.pright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pright.Location = new System.Drawing.Point(600, 0);
            this.pright.Name = "pright";
            this.pright.Size = new System.Drawing.Size(400, 700);
            this.pright.TabIndex = 2;
            this.pright.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pright_MouseDown);
            // 
            // bclose
            // 
            this.bclose.BackColor = System.Drawing.Color.Transparent;
            this.bclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bclose.FillColor = System.Drawing.Color.Transparent;
            this.bclose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bclose.ForeColor = System.Drawing.Color.White;
            this.bclose.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.icons8_cancel_48;
            this.bclose.ImageOffset = new System.Drawing.Point(1, 0);
            this.bclose.Location = new System.Drawing.Point(367, 9);
            this.bclose.Name = "bclose";
            this.bclose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.bclose.Size = new System.Drawing.Size(25, 25);
            this.bclose.TabIndex = 50;
            this.bclose.UseTransparentBackground = true;
            this.bclose.Click += new System.EventHandler(this.bclose_Click);
            // 
            // lconcact
            // 
            this.lconcact.AutoSize = true;
            this.lconcact.BackColor = System.Drawing.SystemColors.Control;
            this.lconcact.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lconcact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lconcact.Location = new System.Drawing.Point(31, 474);
            this.lconcact.Name = "lconcact";
            this.lconcact.Size = new System.Drawing.Size(127, 15);
            this.lconcact.TabIndex = 41;
            this.lconcact.Text = "Need help? contact us:";
            // 
            // pbgmail
            // 
            this.pbgmail.BackColor = System.Drawing.Color.Transparent;
            this.pbgmail.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.pbgmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pbgmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pbgmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pbgmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pbgmail.FillColor = System.Drawing.Color.Gainsboro;
            this.pbgmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pbgmail.ForeColor = System.Drawing.Color.White;
            this.pbgmail.Image = ((System.Drawing.Image)(resources.GetObject("pbgmail.Image")));
            this.pbgmail.ImageSize = new System.Drawing.Size(30, 30);
            this.pbgmail.Location = new System.Drawing.Point(33, 495);
            this.pbgmail.Name = "pbgmail";
            this.pbgmail.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbgmail.Size = new System.Drawing.Size(30, 30);
            this.pbgmail.TabIndex = 42;
            this.pbgmail.Click += new System.EventHandler(this.pbgmail_Click);
            // 
            // pstatus
            // 
            this.pstatus.AutoRoundedCorners = true;
            this.pstatus.BackColor = System.Drawing.Color.Transparent;
            this.pstatus.BorderRadius = 13;
            this.pstatus.Controls.Add(this.lstatus);
            this.pstatus.ForeColor = System.Drawing.Color.Black;
            this.pstatus.Location = new System.Drawing.Point(14, 13);
            this.pstatus.Name = "pstatus";
            this.pstatus.Size = new System.Drawing.Size(103, 28);
            this.pstatus.TabIndex = 49;
            // 
            // lstatus
            // 
            this.lstatus.AutoSize = true;
            this.lstatus.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstatus.ForeColor = System.Drawing.Color.Maroon;
            this.lstatus.Location = new System.Drawing.Point(7, 7);
            this.lstatus.Name = "lstatus";
            this.lstatus.Size = new System.Drawing.Size(88, 14);
            this.lstatus.TabIndex = 0;
            this.lstatus.Text = "You are offline!";
            // 
            // lwarning
            // 
            this.lwarning.AutoSize = true;
            this.lwarning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lwarning.Location = new System.Drawing.Point(204, 386);
            this.lwarning.Name = "lwarning";
            this.lwarning.Size = new System.Drawing.Size(134, 30);
            this.lwarning.TabIndex = 48;
            this.lwarning.Text = "Something went wrong.\r\nPlease try again.";
            this.lwarning.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lwarning.Visible = false;
            // 
            // pblogo
            // 
            this.pblogo.BackColor = System.Drawing.Color.Transparent;
            this.pblogo.FillColor = System.Drawing.Color.Transparent;
            this.pblogo.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.logo;
            this.pblogo.ImageRotate = 0F;
            this.pblogo.Location = new System.Drawing.Point(51, 474);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(466, 289);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogo.TabIndex = 44;
            this.pblogo.TabStop = false;
            // 
            // blogin
            // 
            this.blogin.BorderRadius = 5;
            this.blogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.blogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.blogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.blogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.blogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(138)))), ((int)(((byte)(251)))));
            this.blogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blogin.ForeColor = System.Drawing.Color.White;
            this.blogin.Location = new System.Drawing.Point(57, 335);
            this.blogin.Name = "blogin";
            this.blogin.Size = new System.Drawing.Size(127, 40);
            this.blogin.TabIndex = 39;
            this.blogin.Text = "Login Now";
            this.blogin.Click += new System.EventHandler(this.blogin_Click);
            // 
            // bsignup
            // 
            this.bsignup.BackColor = System.Drawing.Color.White;
            this.bsignup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(138)))), ((int)(((byte)(251)))));
            this.bsignup.BorderRadius = 5;
            this.bsignup.BorderThickness = 1;
            this.bsignup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bsignup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bsignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bsignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bsignup.FillColor = System.Drawing.Color.White;
            this.bsignup.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bsignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(138)))), ((int)(((byte)(251)))));
            this.bsignup.Location = new System.Drawing.Point(208, 335);
            this.bsignup.Name = "bsignup";
            this.bsignup.Size = new System.Drawing.Size(128, 40);
            this.bsignup.TabIndex = 40;
            this.bsignup.Text = "Create Account";
            this.bsignup.Click += new System.EventHandler(this.bsignup_Click);
            // 
            // tpassword
            // 
            this.tpassword.BorderRadius = 3;
            this.tpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tpassword.DefaultText = "";
            this.tpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tpassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tpassword.IconLeft = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.icons8_lock_48;
            this.tpassword.IconLeftSize = new System.Drawing.Size(25, 25);
            this.tpassword.Location = new System.Drawing.Point(35, 264);
            this.tpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpassword.Name = "tpassword";
            this.tpassword.PasswordChar = '•';
            this.tpassword.PlaceholderText = "password";
            this.tpassword.SelectedText = "";
            this.tpassword.Size = new System.Drawing.Size(328, 36);
            this.tpassword.TabIndex = 37;
            this.tpassword.TextChanged += new System.EventHandler(this.tpassword_TextChanged);
            this.tpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tpassword_KeyPress);
            // 
            // tusername
            // 
            this.tusername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tusername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tusername.BorderRadius = 3;
            this.tusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tusername.DefaultText = "";
            this.tusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tusername.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tusername.IconLeft = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.icons8_user_48;
            this.tusername.IconLeftSize = new System.Drawing.Size(25, 25);
            this.tusername.Location = new System.Drawing.Point(35, 216);
            this.tusername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tusername.Name = "tusername";
            this.tusername.PasswordChar = '\0';
            this.tusername.PlaceholderText = "username";
            this.tusername.SelectedText = "";
            this.tusername.Size = new System.Drawing.Size(328, 36);
            this.tusername.TabIndex = 38;
            this.tusername.TextChanged += new System.EventHandler(this.tusername_TextChanged);
            this.tusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tusername_KeyPress);
            // 
            // lheader
            // 
            this.lheader.AutoSize = true;
            this.lheader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(71)))), ((int)(((byte)(124)))));
            this.lheader.Location = new System.Drawing.Point(25, 99);
            this.lheader.Name = "lheader";
            this.lheader.Size = new System.Drawing.Size(135, 37);
            this.lheader.TabIndex = 36;
            this.lheader.Text = "Welcome!";
            // 
            // lbody
            // 
            this.lbody.AutoSize = true;
            this.lbody.BackColor = System.Drawing.SystemColors.Control;
            this.lbody.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbody.Location = new System.Drawing.Point(26, 139);
            this.lbody.Name = "lbody";
            this.lbody.Size = new System.Drawing.Size(287, 30);
            this.lbody.TabIndex = 35;
            this.lbody.Text = "Please enter your details to log in or create account\r\nand be a part of our team " +
    "for our records digitization.";
            this.lbody.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tfade
            // 
            this.tfade.Enabled = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.login_copy;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lversion);
            this.panel1.Controls.Add(this.lip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 700);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(12, 669);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Active IP Address:";
            // 
            // lversion
            // 
            this.lversion.AutoSize = true;
            this.lversion.BackColor = System.Drawing.Color.White;
            this.lversion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lversion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lversion.Location = new System.Drawing.Point(93, 91);
            this.lversion.Name = "lversion";
            this.lversion.Size = new System.Drawing.Size(52, 17);
            this.lversion.TabIndex = 6;
            this.lversion.Text = "version";
            // 
            // lip
            // 
            this.lip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lip.AutoSize = true;
            this.lip.BackColor = System.Drawing.Color.White;
            this.lip.ForeColor = System.Drawing.Color.DarkGray;
            this.lip.Location = new System.Drawing.Point(111, 670);
            this.lip.Name = "lip";
            this.lip.Size = new System.Drawing.Size(40, 13);
            this.lip.TabIndex = 43;
            this.lip.Text = "0.0.0.0";
            // 
            // frm_home_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.pright);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_home_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to ERMS Laboratory Sub-System";
            this.Load += new System.EventHandler(this.frm_home_login_Load);
            this.pright.ResumeLayout(false);
            this.pright.PerformLayout();
            this.pstatus.ResumeLayout(false);
            this.pstatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lversion;
        public System.Windows.Forms.Label lip;
        private System.Windows.Forms.Panel pright;
        private Guna.UI2.WinForms.Guna2Panel pstatus;
        private System.Windows.Forms.Label lstatus;
        private System.Windows.Forms.Label lwarning;
        public Guna.UI2.WinForms.Guna2PictureBox pblogo;
        public System.Windows.Forms.Label lconcact;
        public Guna.UI2.WinForms.Guna2CircleButton pbgmail;
        private Guna.UI2.WinForms.Guna2Button blogin;
        private Guna.UI2.WinForms.Guna2Button bsignup;
        public Guna.UI2.WinForms.Guna2TextBox tpassword;
        public Guna.UI2.WinForms.Guna2TextBox tusername;
        private System.Windows.Forms.Label lheader;
        private System.Windows.Forms.Label lbody;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer tfade;
        private Guna.UI2.WinForms.Guna2CircleButton bclose;
    }
}

