
namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    partial class frm_dashboard_libraries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dashboard_libraries));
            this.ptop = new System.Windows.Forms.Panel();
            this.terror = new Guna.UI2.WinForms.Guna2TextBox();
            this.brefresh = new Guna.UI2.WinForms.Guna2Button();
            this.lfoldername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvfolder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ptop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfolder)).BeginInit();
            this.SuspendLayout();
            // 
            // ptop
            // 
            this.ptop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.ptop.Controls.Add(this.terror);
            this.ptop.Controls.Add(this.brefresh);
            this.ptop.Controls.Add(this.lfoldername);
            this.ptop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptop.Location = new System.Drawing.Point(0, 0);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(1284, 50);
            this.ptop.TabIndex = 27;
            // 
            // terror
            // 
            this.terror.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.terror.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.terror.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.terror.DefaultText = "Error";
            this.terror.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.terror.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.terror.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.terror.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.terror.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.terror.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.terror.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.terror.ForeColor = System.Drawing.Color.White;
            this.terror.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.terror.IconRight = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.icons8_high_priority_48;
            this.terror.Location = new System.Drawing.Point(499, 7);
            this.terror.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.terror.Multiline = true;
            this.terror.Name = "terror";
            this.terror.PasswordChar = '\0';
            this.terror.PlaceholderText = "";
            this.terror.SelectedText = "";
            this.terror.Size = new System.Drawing.Size(731, 36);
            this.terror.TabIndex = 123;
            this.terror.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // brefresh
            // 
            this.brefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brefresh.BorderRadius = 3;
            this.brefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.brefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.brefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.brefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.brefresh.FillColor = System.Drawing.Color.White;
            this.brefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.brefresh.ForeColor = System.Drawing.Color.White;
            this.brefresh.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.icons8_available_updates_48;
            this.brefresh.ImageSize = new System.Drawing.Size(24, 24);
            this.brefresh.Location = new System.Drawing.Point(1239, 8);
            this.brefresh.Name = "brefresh";
            this.brefresh.Size = new System.Drawing.Size(35, 35);
            this.brefresh.TabIndex = 4;
            this.brefresh.Text = " ";
            // 
            // lfoldername
            // 
            this.lfoldername.AutoSize = true;
            this.lfoldername.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfoldername.ForeColor = System.Drawing.Color.White;
            this.lfoldername.Location = new System.Drawing.Point(11, 12);
            this.lfoldername.Name = "lfoldername";
            this.lfoldername.Size = new System.Drawing.Size(105, 25);
            this.lfoldername.TabIndex = 1;
            this.lfoldername.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dgvfolder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 711);
            this.panel1.TabIndex = 28;
            // 
            // dgvfolder
            // 
            this.dgvfolder.AllowUserToAddRows = false;
            this.dgvfolder.AllowUserToDeleteRows = false;
            this.dgvfolder.AllowUserToResizeColumns = false;
            this.dgvfolder.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvfolder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvfolder.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvfolder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvfolder.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvfolder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvfolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvfolder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvfolder.Location = new System.Drawing.Point(0, 0);
            this.dgvfolder.Name = "dgvfolder";
            this.dgvfolder.ReadOnly = true;
            this.dgvfolder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvfolder.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvfolder.RowHeadersVisible = false;
            this.dgvfolder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvfolder.RowTemplate.Height = 30;
            this.dgvfolder.Size = new System.Drawing.Size(600, 711);
            this.dgvfolder.TabIndex = 142;
            this.dgvfolder.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White;
            this.dgvfolder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvfolder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvfolder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvfolder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvfolder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvfolder.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvfolder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvfolder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvfolder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvfolder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvfolder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvfolder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvfolder.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvfolder.ThemeStyle.ReadOnly = true;
            this.dgvfolder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvfolder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvfolder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvfolder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvfolder.ThemeStyle.RowsStyle.Height = 30;
            this.dgvfolder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvfolder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // frm_dashboard_libraries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_dashboard_libraries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Properties";
            this.Load += new System.EventHandler(this.frm_dashboard_libraries_Load);
            this.ptop.ResumeLayout(false);
            this.ptop.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfolder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ptop;
        private Guna.UI2.WinForms.Guna2TextBox terror;
        private Guna.UI2.WinForms.Guna2Button brefresh;
        private System.Windows.Forms.Label lfoldername;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvfolder;
    }
}