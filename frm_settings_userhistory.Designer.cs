
namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    partial class frm_settings_userhistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bdelete = new Guna.UI2.WinForms.Guna2Button();
            this.tsearchfilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.bprint = new Guna.UI2.WinForms.Guna2Button();
            this.ptop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvlog = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lcount = new System.Windows.Forms.Label();
            this.luserid = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lrole = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lip = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lembid = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.ldate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rtfunction = new System.Windows.Forms.RichTextBox();
            this.luser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.ptop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlog)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bdelete);
            this.panel2.Controls.Add(this.tsearchfilter);
            this.panel2.Controls.Add(this.bprint);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 61);
            this.panel2.TabIndex = 139;
            // 
            // bdelete
            // 
            this.bdelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.bdelete.BorderRadius = 3;
            this.bdelete.BorderThickness = 1;
            this.bdelete.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.bdelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bdelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bdelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bdelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bdelete.FillColor = System.Drawing.Color.White;
            this.bdelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bdelete.ForeColor = System.Drawing.Color.White;
            this.bdelete.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.icons8_remove_48__2_;
            this.bdelete.ImageSize = new System.Drawing.Size(25, 25);
            this.bdelete.Location = new System.Drawing.Point(718, 13);
            this.bdelete.Name = "bdelete";
            this.bdelete.PressedColor = System.Drawing.Color.LightGray;
            this.bdelete.Size = new System.Drawing.Size(35, 35);
            this.bdelete.TabIndex = 112;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // tsearchfilter
            // 
            this.tsearchfilter.AutoCompleteCustomSource.AddRange(new string[] {
            "Logged In",
            "Logged Out",
            "Viewed a Document"});
            this.tsearchfilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tsearchfilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tsearchfilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tsearchfilter.DefaultText = "";
            this.tsearchfilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tsearchfilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tsearchfilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tsearchfilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tsearchfilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsearchfilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.tsearchfilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsearchfilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsearchfilter.IconLeftSize = new System.Drawing.Size(25, 25);
            this.tsearchfilter.Location = new System.Drawing.Point(11, 12);
            this.tsearchfilter.Name = "tsearchfilter";
            this.tsearchfilter.PasswordChar = '\0';
            this.tsearchfilter.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tsearchfilter.PlaceholderText = "Search any keyword";
            this.tsearchfilter.SelectedText = "";
            this.tsearchfilter.Size = new System.Drawing.Size(661, 36);
            this.tsearchfilter.TabIndex = 35;
            this.tsearchfilter.TextChanged += new System.EventHandler(this.tsearchfilter_TextChanged);
            // 
            // bprint
            // 
            this.bprint.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.bprint.BorderRadius = 3;
            this.bprint.BorderThickness = 1;
            this.bprint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bprint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bprint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bprint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bprint.FillColor = System.Drawing.Color.White;
            this.bprint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bprint.ForeColor = System.Drawing.Color.White;
            this.bprint.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.icons8_print_48__3_;
            this.bprint.ImageSize = new System.Drawing.Size(25, 25);
            this.bprint.Location = new System.Drawing.Point(678, 13);
            this.bprint.Name = "bprint";
            this.bprint.Size = new System.Drawing.Size(35, 35);
            this.bprint.TabIndex = 111;
            this.bprint.Click += new System.EventHandler(this.bprint_Click);
            // 
            // ptop
            // 
            this.ptop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.ptop.Controls.Add(this.label1);
            this.ptop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptop.Location = new System.Drawing.Point(0, 0);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(1200, 50);
            this.ptop.TabIndex = 138;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 106;
            this.label1.Text = "User History";
            // 
            // dgvlog
            // 
            this.dgvlog.AllowUserToAddRows = false;
            this.dgvlog.AllowUserToDeleteRows = false;
            this.dgvlog.AllowUserToResizeColumns = false;
            this.dgvlog.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvlog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvlog.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvlog.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvlog.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvlog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvlog.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvlog.Location = new System.Drawing.Point(387, 111);
            this.dgvlog.Name = "dgvlog";
            this.dgvlog.ReadOnly = true;
            this.dgvlog.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlog.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvlog.RowHeadersVisible = false;
            this.dgvlog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvlog.RowTemplate.Height = 40;
            this.dgvlog.Size = new System.Drawing.Size(813, 689);
            this.dgvlog.TabIndex = 141;
            this.dgvlog.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White;
            this.dgvlog.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvlog.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvlog.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvlog.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvlog.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvlog.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvlog.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvlog.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvlog.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvlog.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvlog.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvlog.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvlog.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvlog.ThemeStyle.ReadOnly = true;
            this.dgvlog.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvlog.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvlog.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvlog.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvlog.ThemeStyle.RowsStyle.Height = 40;
            this.dgvlog.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvlog.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvlog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlog_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lcount);
            this.panel3.Controls.Add(this.luserid);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.lrole);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lip);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lembid);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.guna2Separator2);
            this.panel3.Controls.Add(this.ldate);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.luser);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.guna2Separator1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 689);
            this.panel3.TabIndex = 140;
            // 
            // lcount
            // 
            this.lcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lcount.AutoSize = true;
            this.lcount.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcount.ForeColor = System.Drawing.Color.Gray;
            this.lcount.Location = new System.Drawing.Point(16, 660);
            this.lcount.Name = "lcount";
            this.lcount.Size = new System.Drawing.Size(133, 16);
            this.lcount.TabIndex = 139;
            this.lcount.Text = "0 record out of 0 entries";
            // 
            // luserid
            // 
            this.luserid.AutoSize = true;
            this.luserid.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luserid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.luserid.Location = new System.Drawing.Point(155, 54);
            this.luserid.Name = "luserid";
            this.luserid.Size = new System.Drawing.Size(33, 16);
            this.luserid.TabIndex = 103;
            this.luserid.Text = "-----";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(19, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 17);
            this.label13.TabIndex = 102;
            this.label13.Text = "Log ID:";
            // 
            // lrole
            // 
            this.lrole.AutoSize = true;
            this.lrole.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lrole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.lrole.Location = new System.Drawing.Point(147, 352);
            this.lrole.Name = "lrole";
            this.lrole.Size = new System.Drawing.Size(86, 16);
            this.lrole.TabIndex = 101;
            this.lrole.Text = "no data found.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(18, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 17);
            this.label12.TabIndex = 100;
            this.label12.Text = "Role";
            // 
            // lip
            // 
            this.lip.AutoSize = true;
            this.lip.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.lip.Location = new System.Drawing.Point(147, 328);
            this.lip.Name = "lip";
            this.lip.Size = new System.Drawing.Size(41, 16);
            this.lip.TabIndex = 99;
            this.lip.Text = "0.0.0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(18, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 98;
            this.label7.Text = "IP Address";
            // 
            // lembid
            // 
            this.lembid.AutoSize = true;
            this.lembid.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lembid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.lembid.Location = new System.Drawing.Point(147, 275);
            this.lembid.Name = "lembid";
            this.lembid.Size = new System.Drawing.Size(86, 16);
            this.lembid.TabIndex = 97;
            this.lembid.Text = "no data found.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(18, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 96;
            this.label9.Text = "User ID";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(8, 415);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(368, 14);
            this.guna2Separator2.TabIndex = 95;
            // 
            // ldate
            // 
            this.ldate.AutoSize = true;
            this.ldate.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.ldate.Location = new System.Drawing.Point(147, 302);
            this.ldate.Name = "ldate";
            this.ldate.Size = new System.Drawing.Size(83, 16);
            this.ldate.TabIndex = 94;
            this.ldate.Text = "no date found";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(18, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 93;
            this.label5.Text = "Date";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Controls.Add(this.rtfunction);
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Location = new System.Drawing.Point(10, 112);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(365, 110);
            this.panel6.TabIndex = 92;
            // 
            // rtfunction
            // 
            this.rtfunction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfunction.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfunction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.rtfunction.Location = new System.Drawing.Point(2, 1);
            this.rtfunction.Name = "rtfunction";
            this.rtfunction.ReadOnly = true;
            this.rtfunction.Size = new System.Drawing.Size(362, 107);
            this.rtfunction.TabIndex = 91;
            this.rtfunction.Text = "no data found";
            // 
            // luser
            // 
            this.luser.AutoSize = true;
            this.luser.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.luser.Location = new System.Drawing.Point(147, 248);
            this.luser.Name = "luser";
            this.luser.Size = new System.Drawing.Size(86, 16);
            this.luser.TabIndex = 90;
            this.luser.Text = "no data found.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(18, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 89;
            this.label3.Text = "User Responsible";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(19, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 17);
            this.label10.TabIndex = 87;
            this.label10.Text = "Function Performed";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(7, 37);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(368, 14);
            this.guna2Separator1.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(11, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "History Details";
            // 
            // frm_settings_userhistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.dgvlog);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ptop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_settings_userhistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_settings_userhistory";
            this.Load += new System.EventHandler(this.frm_settings_userhistory_Load);
            this.panel2.ResumeLayout(false);
            this.ptop.ResumeLayout(false);
            this.ptop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlog)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button bdelete;
        public Guna.UI2.WinForms.Guna2TextBox tsearchfilter;
        private Guna.UI2.WinForms.Guna2Button bprint;
        private System.Windows.Forms.Panel ptop;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvlog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lcount;
        private System.Windows.Forms.Label luserid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lrole;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lembid;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label ldate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox rtfunction;
        private System.Windows.Forms.Label luser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label4;
    }
}