
namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    partial class frm_home_settings
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
            this.pleft = new System.Windows.Forms.Panel();
            this.psubsyslog = new System.Windows.Forms.Panel();
            this.buploadcounter = new Guna.UI2.WinForms.Guna2Button();
            this.bdataconfig = new Guna.UI2.WinForms.Guna2Button();
            this.bdbsettings = new Guna.UI2.WinForms.Guna2Button();
            this.psubuser = new System.Windows.Forms.Panel();
            this.bfilehistory = new Guna.UI2.WinForms.Guna2Button();
            this.buserhistory = new Guna.UI2.WinForms.Guna2Button();
            this.baccountsignup = new Guna.UI2.WinForms.Guna2Button();
            this.baccountreg = new Guna.UI2.WinForms.Guna2Button();
            this.baccounts = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbicon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pdata = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbody = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pleft.SuspendLayout();
            this.psubsyslog.SuspendLayout();
            this.psubuser.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).BeginInit();
            this.pbody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pleft
            // 
            this.pleft.BackColor = System.Drawing.Color.White;
            this.pleft.Controls.Add(this.psubsyslog);
            this.pleft.Controls.Add(this.bdbsettings);
            this.pleft.Controls.Add(this.psubuser);
            this.pleft.Controls.Add(this.baccounts);
            this.pleft.Controls.Add(this.panel1);
            this.pleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pleft.Location = new System.Drawing.Point(0, 0);
            this.pleft.Name = "pleft";
            this.pleft.Size = new System.Drawing.Size(215, 761);
            this.pleft.TabIndex = 16;
            // 
            // psubsyslog
            // 
            this.psubsyslog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.psubsyslog.Controls.Add(this.buploadcounter);
            this.psubsyslog.Controls.Add(this.bdataconfig);
            this.psubsyslog.Dock = System.Windows.Forms.DockStyle.Top;
            this.psubsyslog.Location = new System.Drawing.Point(0, 294);
            this.psubsyslog.Name = "psubsyslog";
            this.psubsyslog.Size = new System.Drawing.Size(215, 77);
            this.psubsyslog.TabIndex = 43;
            // 
            // buploadcounter
            // 
            this.buploadcounter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buploadcounter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buploadcounter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buploadcounter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buploadcounter.Dock = System.Windows.Forms.DockStyle.Top;
            this.buploadcounter.FillColor = System.Drawing.Color.Transparent;
            this.buploadcounter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buploadcounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buploadcounter.Location = new System.Drawing.Point(0, 35);
            this.buploadcounter.Name = "buploadcounter";
            this.buploadcounter.Size = new System.Drawing.Size(215, 35);
            this.buploadcounter.TabIndex = 3;
            this.buploadcounter.Text = "ERMS Action Center";
            this.buploadcounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buploadcounter.TextOffset = new System.Drawing.Point(20, 0);
            this.toolTip1.SetToolTip(this.buploadcounter, "Request Help to ERMS Server");
            this.buploadcounter.Click += new System.EventHandler(this.bermsaction_Click);
            // 
            // bdataconfig
            // 
            this.bdataconfig.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bdataconfig.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bdataconfig.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bdataconfig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bdataconfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.bdataconfig.FillColor = System.Drawing.Color.Transparent;
            this.bdataconfig.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdataconfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bdataconfig.Location = new System.Drawing.Point(0, 0);
            this.bdataconfig.Name = "bdataconfig";
            this.bdataconfig.Size = new System.Drawing.Size(215, 35);
            this.bdataconfig.TabIndex = 0;
            this.bdataconfig.Text = "Data Input Configuration";
            this.bdataconfig.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bdataconfig.TextOffset = new System.Drawing.Point(20, 0);
            this.toolTip1.SetToolTip(this.bdataconfig, "Data Input Config Settings");
            this.bdataconfig.Click += new System.EventHandler(this.bdataconfig_Click);
            // 
            // bdbsettings
            // 
            this.bdbsettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bdbsettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bdbsettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bdbsettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bdbsettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.bdbsettings.FillColor = System.Drawing.Color.White;
            this.bdbsettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdbsettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(119)))), ((int)(((byte)(192)))));
            this.bdbsettings.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.icons8_database_administrator_48;
            this.bdbsettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bdbsettings.ImageOffset = new System.Drawing.Point(10, 0);
            this.bdbsettings.ImageSize = new System.Drawing.Size(25, 25);
            this.bdbsettings.Location = new System.Drawing.Point(0, 249);
            this.bdbsettings.Name = "bdbsettings";
            this.bdbsettings.Size = new System.Drawing.Size(215, 45);
            this.bdbsettings.TabIndex = 42;
            this.bdbsettings.Text = "Database Settings";
            this.bdbsettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bdbsettings.TextOffset = new System.Drawing.Point(15, 0);
            this.toolTip1.SetToolTip(this.bdbsettings, "Modify Database Settings");
            this.bdbsettings.Click += new System.EventHandler(this.bdbsettings_Click);
            // 
            // psubuser
            // 
            this.psubuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.psubuser.Controls.Add(this.bfilehistory);
            this.psubuser.Controls.Add(this.buserhistory);
            this.psubuser.Controls.Add(this.baccountsignup);
            this.psubuser.Controls.Add(this.baccountreg);
            this.psubuser.Dock = System.Windows.Forms.DockStyle.Top;
            this.psubuser.Location = new System.Drawing.Point(0, 103);
            this.psubuser.Name = "psubuser";
            this.psubuser.Size = new System.Drawing.Size(215, 146);
            this.psubuser.TabIndex = 41;
            // 
            // bfilehistory
            // 
            this.bfilehistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bfilehistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bfilehistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bfilehistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bfilehistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.bfilehistory.FillColor = System.Drawing.Color.Transparent;
            this.bfilehistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfilehistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bfilehistory.Location = new System.Drawing.Point(0, 105);
            this.bfilehistory.Name = "bfilehistory";
            this.bfilehistory.Size = new System.Drawing.Size(215, 35);
            this.bfilehistory.TabIndex = 3;
            this.bfilehistory.Text = "File History";
            this.bfilehistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bfilehistory.TextOffset = new System.Drawing.Point(20, 0);
            this.toolTip1.SetToolTip(this.bfilehistory, "View File Upload History");
            this.bfilehistory.Click += new System.EventHandler(this.bfilehistory_Click);
            // 
            // buserhistory
            // 
            this.buserhistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buserhistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buserhistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buserhistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buserhistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.buserhistory.FillColor = System.Drawing.Color.Transparent;
            this.buserhistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buserhistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buserhistory.Location = new System.Drawing.Point(0, 70);
            this.buserhistory.Name = "buserhistory";
            this.buserhistory.Size = new System.Drawing.Size(215, 35);
            this.buserhistory.TabIndex = 2;
            this.buserhistory.Text = "Users History";
            this.buserhistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buserhistory.TextOffset = new System.Drawing.Point(20, 0);
            this.toolTip1.SetToolTip(this.buserhistory, "View User Log in - Log out History");
            this.buserhistory.Click += new System.EventHandler(this.buserhistory_Click);
            // 
            // baccountsignup
            // 
            this.baccountsignup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.baccountsignup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.baccountsignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.baccountsignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.baccountsignup.Dock = System.Windows.Forms.DockStyle.Top;
            this.baccountsignup.FillColor = System.Drawing.Color.Transparent;
            this.baccountsignup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baccountsignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.baccountsignup.Location = new System.Drawing.Point(0, 35);
            this.baccountsignup.Name = "baccountsignup";
            this.baccountsignup.Size = new System.Drawing.Size(215, 35);
            this.baccountsignup.TabIndex = 1;
            this.baccountsignup.Text = "Signed up Accounts";
            this.baccountsignup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.baccountsignup.TextOffset = new System.Drawing.Point(20, 0);
            this.toolTip1.SetToolTip(this.baccountsignup, "View ERMS Signed up Users");
            this.baccountsignup.Click += new System.EventHandler(this.baccountsignup_Click);
            // 
            // baccountreg
            // 
            this.baccountreg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.baccountreg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.baccountreg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.baccountreg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.baccountreg.Dock = System.Windows.Forms.DockStyle.Top;
            this.baccountreg.FillColor = System.Drawing.Color.Transparent;
            this.baccountreg.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.baccountreg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.baccountreg.Location = new System.Drawing.Point(0, 0);
            this.baccountreg.Name = "baccountreg";
            this.baccountreg.Size = new System.Drawing.Size(215, 35);
            this.baccountreg.TabIndex = 0;
            this.baccountreg.Text = "Registered Accounts";
            this.baccountreg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.baccountreg.TextOffset = new System.Drawing.Point(20, 0);
            this.toolTip1.SetToolTip(this.baccountreg, "Vew Registered Accounts");
            this.baccountreg.Click += new System.EventHandler(this.baccountreg_Click);
            // 
            // baccounts
            // 
            this.baccounts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.baccounts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.baccounts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.baccounts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.baccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.baccounts.FillColor = System.Drawing.Color.White;
            this.baccounts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baccounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(119)))), ((int)(((byte)(192)))));
            this.baccounts.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.icons8_admin_settings_male_48;
            this.baccounts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.baccounts.ImageOffset = new System.Drawing.Point(10, 0);
            this.baccounts.ImageSize = new System.Drawing.Size(25, 25);
            this.baccounts.Location = new System.Drawing.Point(0, 58);
            this.baccounts.Name = "baccounts";
            this.baccounts.Size = new System.Drawing.Size(215, 45);
            this.baccounts.TabIndex = 40;
            this.baccounts.Text = "Accounts";
            this.baccounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.baccounts.TextOffset = new System.Drawing.Point(15, 0);
            this.toolTip1.SetToolTip(this.baccounts, "View Account Settings");
            this.baccounts.Click += new System.EventHandler(this.baccounts_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pbicon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 58);
            this.panel1.TabIndex = 0;
            // 
            // pbicon
            // 
            this.pbicon.BackColor = System.Drawing.Color.Transparent;
            this.pbicon.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.admin;
            this.pbicon.ImageRotate = 0F;
            this.pbicon.Location = new System.Drawing.Point(14, 14);
            this.pbicon.Name = "pbicon";
            this.pbicon.Size = new System.Drawing.Size(30, 30);
            this.pbicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbicon.TabIndex = 16;
            this.pbicon.TabStop = false;
            this.pbicon.UseTransparentBackground = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(119)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(49, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Settings";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(215, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 761);
            this.panel6.TabIndex = 35;
            // 
            // pdata
            // 
            this.pdata.BackColor = System.Drawing.SystemColors.Control;
            this.pdata.Dock = System.Windows.Forms.DockStyle.Top;
            this.pdata.Location = new System.Drawing.Point(220, 0);
            this.pdata.Name = "pdata";
            this.pdata.Size = new System.Drawing.Size(1014, 5);
            this.pdata.TabIndex = 36;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1229, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 756);
            this.panel7.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(220, 756);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1009, 5);
            this.panel3.TabIndex = 38;
            // 
            // pbody
            // 
            this.pbody.BackColor = System.Drawing.Color.White;
            this.pbody.Controls.Add(this.pictureBox1);
            this.pbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbody.Location = new System.Drawing.Point(220, 5);
            this.pbody.Name = "pbody";
            this.pbody.Size = new System.Drawing.Size(1009, 751);
            this.pbody.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.logobw;
            this.pictureBox1.Location = new System.Drawing.Point(392, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox2.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.logobw;
            this.pictureBox2.Location = new System.Drawing.Point(613, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // frm_home_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 761);
            this.Controls.Add(this.pbody);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pdata);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_home_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frm_home_settings_Load);
            this.pleft.ResumeLayout(false);
            this.psubsyslog.ResumeLayout(false);
            this.psubuser.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).EndInit();
            this.pbody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pleft;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pbicon;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button baccounts;
        private Guna.UI2.WinForms.Guna2Button bdbsettings;
        private System.Windows.Forms.Panel psubuser;
        private Guna.UI2.WinForms.Guna2Button bfilehistory;
        private Guna.UI2.WinForms.Guna2Button buserhistory;
        private Guna.UI2.WinForms.Guna2Button baccountsignup;
        private Guna.UI2.WinForms.Guna2Button baccountreg;
        private System.Windows.Forms.Panel psubsyslog;
        private Guna.UI2.WinForms.Guna2Button buploadcounter;
        private Guna.UI2.WinForms.Guna2Button bdataconfig;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Panel pdata;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Panel pbody;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}