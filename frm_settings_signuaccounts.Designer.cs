
namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    partial class frm_settings_signuaccounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsearchfilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.lnorecord = new System.Windows.Forms.Label();
            this.dgvusers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bremove = new Guna.UI2.WinForms.Guna2Button();
            this.bapprove = new Guna.UI2.WinForms.Guna2Button();
            this.brefresh = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.brefresh);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 57);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 30);
            this.label1.TabIndex = 107;
            this.label1.Text = "Signed-Up Accounts";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bremove);
            this.panel1.Controls.Add(this.bapprove);
            this.panel1.Controls.Add(this.tsearchfilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 65);
            this.panel1.TabIndex = 140;
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
            this.tsearchfilter.Location = new System.Drawing.Point(17, 14);
            this.tsearchfilter.Name = "tsearchfilter";
            this.tsearchfilter.PasswordChar = '\0';
            this.tsearchfilter.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tsearchfilter.PlaceholderText = "Search User";
            this.tsearchfilter.SelectedText = "";
            this.tsearchfilter.Size = new System.Drawing.Size(661, 36);
            this.tsearchfilter.TabIndex = 137;
            this.tsearchfilter.TextChanged += new System.EventHandler(this.tsearchfilter_TextChanged);
            // 
            // lnorecord
            // 
            this.lnorecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnorecord.AutoSize = true;
            this.lnorecord.BackColor = System.Drawing.Color.White;
            this.lnorecord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnorecord.ForeColor = System.Drawing.Color.Gray;
            this.lnorecord.Location = new System.Drawing.Point(521, 182);
            this.lnorecord.Name = "lnorecord";
            this.lnorecord.Size = new System.Drawing.Size(110, 17);
            this.lnorecord.TabIndex = 143;
            this.lnorecord.Text = "No record found.";
            // 
            // dgvusers
            // 
            this.dgvusers.AllowUserToAddRows = false;
            this.dgvusers.AllowUserToDeleteRows = false;
            this.dgvusers.AllowUserToResizeColumns = false;
            this.dgvusers.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.dgvusers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvusers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvusers.ColumnHeadersHeight = 30;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvusers.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvusers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvusers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvusers.Location = new System.Drawing.Point(0, 122);
            this.dgvusers.Name = "dgvusers";
            this.dgvusers.ReadOnly = true;
            this.dgvusers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvusers.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvusers.RowHeadersVisible = false;
            this.dgvusers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvusers.RowTemplate.Height = 80;
            this.dgvusers.Size = new System.Drawing.Size(1200, 678);
            this.dgvusers.TabIndex = 142;
            this.dgvusers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White;
            this.dgvusers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvusers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvusers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvusers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvusers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvusers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvusers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvusers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvusers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvusers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvusers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvusers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvusers.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvusers.ThemeStyle.ReadOnly = true;
            this.dgvusers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvusers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvusers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvusers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvusers.ThemeStyle.RowsStyle.Height = 80;
            this.dgvusers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvusers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvusers.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvusers_DataBindingComplete);
            // 
            // bremove
            // 
            this.bremove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bremove.BorderRadius = 3;
            this.bremove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bremove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bremove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bremove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bremove.FillColor = System.Drawing.Color.Brown;
            this.bremove.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bremove.ForeColor = System.Drawing.Color.White;
            this.bremove.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.icons8_remove_48;
            this.bremove.Location = new System.Drawing.Point(912, 14);
            this.bremove.Name = "bremove";
            this.bremove.Size = new System.Drawing.Size(134, 36);
            this.bremove.TabIndex = 138;
            this.bremove.Text = "Remove Account";
            this.bremove.Click += new System.EventHandler(this.bremove_Click);
            // 
            // bapprove
            // 
            this.bapprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bapprove.BorderRadius = 3;
            this.bapprove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bapprove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bapprove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bapprove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bapprove.FillColor = System.Drawing.Color.SteelBlue;
            this.bapprove.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bapprove.ForeColor = System.Drawing.Color.White;
            this.bapprove.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.icons8_checked_user_male_48;
            this.bapprove.Location = new System.Drawing.Point(1052, 14);
            this.bapprove.Name = "bapprove";
            this.bapprove.Size = new System.Drawing.Size(134, 36);
            this.bapprove.TabIndex = 109;
            this.bapprove.Text = "Approve Account";
            this.bapprove.Click += new System.EventHandler(this.bapprove_Click);
            // 
            // brefresh
            // 
            this.brefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brefresh.BorderRadius = 2;
            this.brefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.brefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.brefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.brefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.brefresh.FillColor = System.Drawing.Color.White;
            this.brefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.brefresh.ForeColor = System.Drawing.Color.White;
            this.brefresh.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.icons8_available_updates_48;
            this.brefresh.Location = new System.Drawing.Point(1156, 14);
            this.brefresh.Name = "brefresh";
            this.brefresh.Size = new System.Drawing.Size(30, 30);
            this.brefresh.TabIndex = 108;
            this.brefresh.Click += new System.EventHandler(this.brefresh_Click);
            // 
            // frm_settings_signuaccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.lnorecord);
            this.Controls.Add(this.dgvusers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_settings_signuaccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signed up Accounts";
            this.Load += new System.EventHandler(this.frm_settings_signuaccounts_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button brefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button bremove;
        private Guna.UI2.WinForms.Guna2Button bapprove;
        public Guna.UI2.WinForms.Guna2TextBox tsearchfilter;
        private System.Windows.Forms.Label lnorecord;
        private Guna.UI2.WinForms.Guna2DataGridView dgvusers;
    }
}