
namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    partial class frm_settings_filehistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ptop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lnulldocs = new System.Windows.Forms.Label();
            this.dgvdata = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.brefresh = new Guna.UI2.WinForms.Guna2Button();
            this.bdel = new Guna.UI2.WinForms.Guna2Button();
            this.tsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pleft = new Guna.UI2.WinForms.Guna2Panel();
            this.lcount = new System.Windows.Forms.Label();
            this.lname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.lfileloc = new Guna.UI2.WinForms.Guna2TextBox();
            this.ldateuploaded = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lfclass = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lsize = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lfsn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ptop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.pleft.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptop
            // 
            this.ptop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.ptop.Controls.Add(this.label1);
            this.ptop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptop.Location = new System.Drawing.Point(0, 0);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(1200, 50);
            this.ptop.TabIndex = 139;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 106;
            this.label1.Text = "File History";
            // 
            // lnulldocs
            // 
            this.lnulldocs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnulldocs.AutoSize = true;
            this.lnulldocs.BackColor = System.Drawing.Color.White;
            this.lnulldocs.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lnulldocs.ForeColor = System.Drawing.Color.Black;
            this.lnulldocs.Location = new System.Drawing.Point(732, 155);
            this.lnulldocs.Name = "lnulldocs";
            this.lnulldocs.Size = new System.Drawing.Size(180, 19);
            this.lnulldocs.TabIndex = 146;
            this.lnulldocs.Text = "No matching records found.";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.AllowUserToDeleteRows = false;
            this.dgvdata.AllowUserToResizeColumns = false;
            this.dgvdata.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvdata.ColumnHeadersHeight = 25;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvdata.Location = new System.Drawing.Point(443, 102);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersVisible = false;
            this.dgvdata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvdata.RowTemplate.Height = 50;
            this.dgvdata.Size = new System.Drawing.Size(757, 598);
            this.dgvdata.TabIndex = 145;
            this.dgvdata.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvdata.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvdata.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvdata.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvdata.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvdata.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvdata.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvdata.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvdata.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvdata.ThemeStyle.ReadOnly = true;
            this.dgvdata.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvdata.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvdata.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvdata.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvdata.ThemeStyle.RowsStyle.Height = 50;
            this.dgvdata.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvdata.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellClick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.brefresh);
            this.guna2Panel1.Controls.Add(this.bdel);
            this.guna2Panel1.Controls.Add(this.tsearch);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(443, 50);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(757, 52);
            this.guna2Panel1.TabIndex = 144;
            // 
            // brefresh
            // 
            this.brefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.brefresh.BorderRadius = 3;
            this.brefresh.BorderThickness = 1;
            this.brefresh.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.brefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.brefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.brefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.brefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.brefresh.FillColor = System.Drawing.Color.White;
            this.brefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.brefresh.ForeColor = System.Drawing.Color.White;
            this.brefresh.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.icons8_available_updates_48;
            this.brefresh.ImageSize = new System.Drawing.Size(25, 25);
            this.brefresh.Location = new System.Drawing.Point(582, 9);
            this.brefresh.Name = "brefresh";
            this.brefresh.PressedColor = System.Drawing.Color.LightGray;
            this.brefresh.Size = new System.Drawing.Size(35, 35);
            this.brefresh.TabIndex = 116;
            // 
            // bdel
            // 
            this.bdel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.bdel.BorderRadius = 3;
            this.bdel.BorderThickness = 1;
            this.bdel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.bdel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bdel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bdel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bdel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bdel.FillColor = System.Drawing.Color.White;
            this.bdel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bdel.ForeColor = System.Drawing.Color.White;
            this.bdel.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.icons8_remove_48__2_;
            this.bdel.ImageSize = new System.Drawing.Size(25, 25);
            this.bdel.Location = new System.Drawing.Point(542, 9);
            this.bdel.Name = "bdel";
            this.bdel.PressedColor = System.Drawing.Color.LightGray;
            this.bdel.Size = new System.Drawing.Size(35, 35);
            this.bdel.TabIndex = 115;
            this.bdel.Click += new System.EventHandler(this.bdel_Click);
            // 
            // tsearch
            // 
            this.tsearch.BorderColor = System.Drawing.Color.Gainsboro;
            this.tsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tsearch.DefaultText = "";
            this.tsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsearch.Location = new System.Drawing.Point(12, 8);
            this.tsearch.Name = "tsearch";
            this.tsearch.PasswordChar = '\0';
            this.tsearch.PlaceholderText = "Search Keyword Here";
            this.tsearch.SelectedText = "";
            this.tsearch.Size = new System.Drawing.Size(526, 36);
            this.tsearch.TabIndex = 63;
            this.tsearch.TextChanged += new System.EventHandler(this.tsearch_TextChanged);
            // 
            // pleft
            // 
            this.pleft.BackColor = System.Drawing.Color.White;
            this.pleft.Controls.Add(this.label2);
            this.pleft.Controls.Add(this.label4);
            this.pleft.Controls.Add(this.lcount);
            this.pleft.Controls.Add(this.lname);
            this.pleft.Controls.Add(this.guna2VSeparator1);
            this.pleft.Controls.Add(this.lfileloc);
            this.pleft.Controls.Add(this.ldateuploaded);
            this.pleft.Controls.Add(this.label20);
            this.pleft.Controls.Add(this.label18);
            this.pleft.Controls.Add(this.lfclass);
            this.pleft.Controls.Add(this.label16);
            this.pleft.Controls.Add(this.lsize);
            this.pleft.Controls.Add(this.label14);
            this.pleft.Controls.Add(this.lfsn);
            this.pleft.Controls.Add(this.label3);
            this.pleft.Controls.Add(this.label7);
            this.pleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pleft.Location = new System.Drawing.Point(0, 50);
            this.pleft.Name = "pleft";
            this.pleft.Size = new System.Drawing.Size(443, 650);
            this.pleft.TabIndex = 143;
            // 
            // lcount
            // 
            this.lcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lcount.AutoSize = true;
            this.lcount.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcount.ForeColor = System.Drawing.Color.Gray;
            this.lcount.Location = new System.Drawing.Point(14, 619);
            this.lcount.Name = "lcount";
            this.lcount.Size = new System.Drawing.Size(133, 16);
            this.lcount.TabIndex = 154;
            this.lcount.Text = "0 record out of 0 entries";
            // 
            // lname
            // 
            this.lname.BackColor = System.Drawing.Color.White;
            this.lname.BorderColor = System.Drawing.Color.Silver;
            this.lname.BorderThickness = 0;
            this.lname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lname.DefaultText = "";
            this.lname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lname.Location = new System.Drawing.Point(130, 39);
            this.lname.Multiline = true;
            this.lname.Name = "lname";
            this.lname.PasswordChar = '\0';
            this.lname.PlaceholderText = "File Name";
            this.lname.ReadOnly = true;
            this.lname.SelectedText = "";
            this.lname.Size = new System.Drawing.Size(293, 85);
            this.lname.TabIndex = 88;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2VSeparator1.Location = new System.Drawing.Point(432, 8);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 632);
            this.guna2VSeparator1.TabIndex = 152;
            // 
            // lfileloc
            // 
            this.lfileloc.BackColor = System.Drawing.Color.White;
            this.lfileloc.BorderColor = System.Drawing.Color.Silver;
            this.lfileloc.BorderThickness = 0;
            this.lfileloc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lfileloc.DefaultText = "";
            this.lfileloc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lfileloc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lfileloc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lfileloc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lfileloc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lfileloc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lfileloc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lfileloc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lfileloc.Location = new System.Drawing.Point(130, 283);
            this.lfileloc.Multiline = true;
            this.lfileloc.Name = "lfileloc";
            this.lfileloc.PasswordChar = '\0';
            this.lfileloc.PlaceholderText = "Location";
            this.lfileloc.ReadOnly = true;
            this.lfileloc.SelectedText = "";
            this.lfileloc.Size = new System.Drawing.Size(286, 118);
            this.lfileloc.TabIndex = 88;
            // 
            // ldateuploaded
            // 
            this.ldateuploaded.AutoSize = true;
            this.ldateuploaded.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldateuploaded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ldateuploaded.Location = new System.Drawing.Point(130, 249);
            this.ldateuploaded.Name = "ldateuploaded";
            this.ldateuploaded.Size = new System.Drawing.Size(78, 17);
            this.ldateuploaded.TabIndex = 149;
            this.ldateuploaded.Text = "--------------";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(14, 283);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 17);
            this.label20.TabIndex = 143;
            this.label20.Text = "File Location:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(14, 249);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 17);
            this.label18.TabIndex = 141;
            this.label18.Text = "Date Uploaded:";
            // 
            // lfclass
            // 
            this.lfclass.AutoSize = true;
            this.lfclass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfclass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lfclass.Location = new System.Drawing.Point(130, 215);
            this.lfclass.Name = "lfclass";
            this.lfclass.Size = new System.Drawing.Size(78, 17);
            this.lfclass.TabIndex = 140;
            this.lfclass.Text = "--------------";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(14, 215);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 17);
            this.label16.TabIndex = 139;
            this.label16.Text = "Classification:";
            // 
            // lsize
            // 
            this.lsize.AutoSize = true;
            this.lsize.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lsize.Location = new System.Drawing.Point(130, 182);
            this.lsize.Name = "lsize";
            this.lsize.Size = new System.Drawing.Size(78, 17);
            this.lsize.TabIndex = 138;
            this.lsize.Text = "--------------";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(14, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 17);
            this.label14.TabIndex = 137;
            this.label14.Text = "Size:";
            // 
            // lfsn
            // 
            this.lfsn.AutoSize = true;
            this.lfsn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfsn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lfsn.Location = new System.Drawing.Point(177, 13);
            this.lfsn.Name = "lfsn";
            this.lfsn.Size = new System.Drawing.Size(78, 17);
            this.lfsn.TabIndex = 134;
            this.lfsn.Text = "--------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(14, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 133;
            this.label3.Text = "File Serial Number (FSN):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(14, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 127;
            this.label7.Text = "File Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(130, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 156;
            this.label2.Text = "--------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(14, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 155;
            this.label4.Text = "Document Type:";
            // 
            // frm_settings_filehistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.lnulldocs);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pleft);
            this.Controls.Add(this.ptop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_settings_filehistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File History";
            this.Load += new System.EventHandler(this.frm_settings_filehistory_Load);
            this.ptop.ResumeLayout(false);
            this.ptop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.pleft.ResumeLayout(false);
            this.pleft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ptop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lnulldocs;
        private Guna.UI2.WinForms.Guna2DataGridView dgvdata;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button brefresh;
        private Guna.UI2.WinForms.Guna2Button bdel;
        private Guna.UI2.WinForms.Guna2TextBox tsearch;
        private Guna.UI2.WinForms.Guna2Panel pleft;
        private System.Windows.Forms.Label lcount;
        private Guna.UI2.WinForms.Guna2TextBox lname;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2TextBox lfileloc;
        private System.Windows.Forms.Label ldateuploaded;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lfclass;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lsize;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lfsn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}