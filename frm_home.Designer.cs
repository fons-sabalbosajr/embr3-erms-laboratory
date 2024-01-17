
namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    partial class frm_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_home));
            this.paneltop = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pbphoto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.luser = new System.Windows.Forms.Label();
            this.pleft = new System.Windows.Forms.Panel();
            this.bsettings = new Guna.UI2.WinForms.Guna2Button();
            this.blibrary = new Guna.UI2.WinForms.Guna2Button();
            this.bupload = new Guna.UI2.WinForms.Guna2Button();
            this.bdashboard = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pdata = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pbody = new System.Windows.Forms.Panel();
            this.pblogobw = new System.Windows.Forms.PictureBox();
            this.tslide = new System.Windows.Forms.Timer(this.components);
            this.thome = new System.Windows.Forms.Timer(this.components);
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbphoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.pleft.SuspendLayout();
            this.pbody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogobw)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.paneltop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paneltop.Controls.Add(this.guna2Button1);
            this.paneltop.Controls.Add(this.pbphoto);
            this.paneltop.Controls.Add(this.pblogo);
            this.paneltop.Controls.Add(this.luser);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1284, 70);
            this.paneltop.TabIndex = 2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.icons8_menu_48;
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(15, 21);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(30, 30);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pbphoto
            // 
            this.pbphoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbphoto.FillColor = System.Drawing.Color.LightGray;
            this.pbphoto.ImageRotate = 0F;
            this.pbphoto.Location = new System.Drawing.Point(978, 19);
            this.pbphoto.Name = "pbphoto";
            this.pbphoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbphoto.Size = new System.Drawing.Size(32, 32);
            this.pbphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbphoto.TabIndex = 28;
            this.pbphoto.TabStop = false;
            // 
            // pblogo
            // 
            this.pblogo.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.HOMELOGOadvancedserver;
            this.pblogo.Location = new System.Drawing.Point(54, 9);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(130, 50);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogo.TabIndex = 21;
            this.pblogo.TabStop = false;
            // 
            // luser
            // 
            this.luser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.luser.AutoSize = true;
            this.luser.BackColor = System.Drawing.Color.Transparent;
            this.luser.Font = new System.Drawing.Font("Microsoft Tai Le", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.luser.Location = new System.Drawing.Point(1021, 29);
            this.luser.Name = "luser";
            this.luser.Size = new System.Drawing.Size(35, 16);
            this.luser.TabIndex = 2;
            this.luser.Text = "User";
            this.luser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pleft
            // 
            this.pleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.pleft.Controls.Add(this.bsettings);
            this.pleft.Controls.Add(this.blibrary);
            this.pleft.Controls.Add(this.bupload);
            this.pleft.Controls.Add(this.bdashboard);
            this.pleft.Controls.Add(this.panel4);
            this.pleft.Controls.Add(this.panel1);
            this.pleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pleft.Location = new System.Drawing.Point(0, 70);
            this.pleft.Name = "pleft";
            this.pleft.Size = new System.Drawing.Size(190, 791);
            this.pleft.TabIndex = 3;
            // 
            // bsettings
            // 
            this.bsettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bsettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bsettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bsettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bsettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.bsettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.bsettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsettings.ForeColor = System.Drawing.Color.White;
            this.bsettings.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.admin;
            this.bsettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bsettings.ImageOffset = new System.Drawing.Point(10, 0);
            this.bsettings.Location = new System.Drawing.Point(0, 152);
            this.bsettings.Name = "bsettings";
            this.bsettings.Size = new System.Drawing.Size(190, 45);
            this.bsettings.TabIndex = 42;
            this.bsettings.Text = "Settings";
            this.bsettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bsettings.TextOffset = new System.Drawing.Point(15, 0);
            this.bsettings.Click += new System.EventHandler(this.bsettings_Click);
            // 
            // blibrary
            // 
            this.blibrary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.blibrary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.blibrary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.blibrary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.blibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.blibrary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.blibrary.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blibrary.ForeColor = System.Drawing.Color.White;
            this.blibrary.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.folder;
            this.blibrary.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.blibrary.ImageOffset = new System.Drawing.Point(10, 0);
            this.blibrary.Location = new System.Drawing.Point(0, 107);
            this.blibrary.Name = "blibrary";
            this.blibrary.Size = new System.Drawing.Size(190, 45);
            this.blibrary.TabIndex = 41;
            this.blibrary.Text = "File Library";
            this.blibrary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.blibrary.TextOffset = new System.Drawing.Point(15, 0);
            this.blibrary.Click += new System.EventHandler(this.blibrary_Click);
            // 
            // bupload
            // 
            this.bupload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bupload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bupload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bupload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bupload.Dock = System.Windows.Forms.DockStyle.Top;
            this.bupload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.bupload.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bupload.ForeColor = System.Drawing.Color.White;
            this.bupload.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.upload;
            this.bupload.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bupload.ImageOffset = new System.Drawing.Point(10, 0);
            this.bupload.Location = new System.Drawing.Point(0, 62);
            this.bupload.Name = "bupload";
            this.bupload.Size = new System.Drawing.Size(190, 45);
            this.bupload.TabIndex = 40;
            this.bupload.Text = "Upload";
            this.bupload.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bupload.TextOffset = new System.Drawing.Point(15, 0);
            this.bupload.Click += new System.EventHandler(this.bupload_Click);
            // 
            // bdashboard
            // 
            this.bdashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bdashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bdashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bdashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bdashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.bdashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.bdashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdashboard.ForeColor = System.Drawing.Color.White;
            this.bdashboard.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.dashboard;
            this.bdashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bdashboard.ImageOffset = new System.Drawing.Point(10, 0);
            this.bdashboard.Location = new System.Drawing.Point(0, 17);
            this.bdashboard.Name = "bdashboard";
            this.bdashboard.Size = new System.Drawing.Size(190, 45);
            this.bdashboard.TabIndex = 39;
            this.bdashboard.Text = "Dashboard";
            this.bdashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bdashboard.TextOffset = new System.Drawing.Point(15, 0);
            this.bdashboard.Click += new System.EventHandler(this.bdashboard_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 744);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 47);
            this.panel4.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 17);
            this.panel1.TabIndex = 20;
            // 
            // pdata
            // 
            this.pdata.BackColor = System.Drawing.Color.Gainsboro;
            this.pdata.Dock = System.Windows.Forms.DockStyle.Top;
            this.pdata.Location = new System.Drawing.Point(190, 70);
            this.pdata.Name = "pdata";
            this.pdata.Size = new System.Drawing.Size(1094, 5);
            this.pdata.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1279, 75);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 786);
            this.panel7.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(190, 856);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1089, 5);
            this.panel5.TabIndex = 28;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(190, 75);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 781);
            this.panel6.TabIndex = 29;
            // 
            // pbody
            // 
            this.pbody.BackColor = System.Drawing.Color.White;
            this.pbody.Controls.Add(this.pblogobw);
            this.pbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbody.Location = new System.Drawing.Point(195, 75);
            this.pbody.Name = "pbody";
            this.pbody.Size = new System.Drawing.Size(1084, 781);
            this.pbody.TabIndex = 30;
            // 
            // pblogobw
            // 
            this.pblogobw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pblogobw.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.logobw;
            this.pblogobw.Location = new System.Drawing.Point(444, 218);
            this.pblogobw.Name = "pblogobw";
            this.pblogobw.Size = new System.Drawing.Size(229, 200);
            this.pblogobw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogobw.TabIndex = 30;
            this.pblogobw.TabStop = false;
            // 
            // tslide
            // 
            this.tslide.Interval = 20;
            this.tslide.Tick += new System.EventHandler(this.tslide_Tick);
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 861);
            this.Controls.Add(this.pbody);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pdata);
            this.Controls.Add(this.pleft);
            this.Controls.Add(this.paneltop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMB-ERMS Laboratory Sub-System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_home_FormClosing);
            this.Load += new System.EventHandler(this.frm_home_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbphoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.pleft.ResumeLayout(false);
            this.pbody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pblogobw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        public Guna.UI2.WinForms.Guna2CirclePictureBox pbphoto;
        private System.Windows.Forms.PictureBox pblogo;
        public System.Windows.Forms.Label luser;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel pleft;
        public Guna.UI2.WinForms.Guna2Button bsettings;
        private Guna.UI2.WinForms.Guna2Button blibrary;
        public Guna.UI2.WinForms.Guna2Button bupload;
        private Guna.UI2.WinForms.Guna2Button bdashboard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pdata;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pblogobw;
        private System.Windows.Forms.Panel pbody;
        private System.Windows.Forms.Timer tslide;
        private System.Windows.Forms.Timer thome;
    }
}