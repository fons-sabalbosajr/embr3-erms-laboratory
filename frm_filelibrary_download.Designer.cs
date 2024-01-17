
namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    partial class frm_filelibrary_download
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_filelibrary_download));
            this.ltotalasof = new System.Windows.Forms.Label();
            this.tfileloc = new System.Windows.Forms.Label();
            this.bcancel = new Guna.UI2.WinForms.Guna2Button();
            this.bdownload = new Guna.UI2.WinForms.Guna2Button();
            this.lpercent = new System.Windows.Forms.Label();
            this.pbloading = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.ldateuploaded = new System.Windows.Forms.Label();
            this.luploaded = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tfilename = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lfsn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ldoctype = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bwcopy = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // ltotalasof
            // 
            this.ltotalasof.AutoSize = true;
            this.ltotalasof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.ltotalasof.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotalasof.ForeColor = System.Drawing.Color.White;
            this.ltotalasof.Location = new System.Drawing.Point(12, 9);
            this.ltotalasof.Name = "ltotalasof";
            this.ltotalasof.Size = new System.Drawing.Size(145, 21);
            this.ltotalasof.TabIndex = 71;
            this.ltotalasof.Text = "Export File to PDF";
            // 
            // tfileloc
            // 
            this.tfileloc.AutoSize = true;
            this.tfileloc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfileloc.ForeColor = System.Drawing.Color.White;
            this.tfileloc.Location = new System.Drawing.Point(16, 237);
            this.tfileloc.Name = "tfileloc";
            this.tfileloc.Size = new System.Drawing.Size(15, 13);
            this.tfileloc.TabIndex = 161;
            this.tfileloc.Text = "--";
            // 
            // bcancel
            // 
            this.bcancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bcancel.BorderRadius = 3;
            this.bcancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bcancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bcancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bcancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bcancel.FillColor = System.Drawing.Color.Maroon;
            this.bcancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bcancel.ForeColor = System.Drawing.Color.White;
            this.bcancel.ImageSize = new System.Drawing.Size(24, 24);
            this.bcancel.Location = new System.Drawing.Point(428, 249);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(95, 35);
            this.bcancel.TabIndex = 160;
            this.bcancel.Text = "&Cancel";
            this.bcancel.Click += new System.EventHandler(this.bcancel_Click);
            // 
            // bdownload
            // 
            this.bdownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bdownload.BorderRadius = 3;
            this.bdownload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bdownload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bdownload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bdownload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bdownload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.bdownload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bdownload.ForeColor = System.Drawing.Color.White;
            this.bdownload.ImageSize = new System.Drawing.Size(24, 24);
            this.bdownload.Location = new System.Drawing.Point(316, 249);
            this.bdownload.Name = "bdownload";
            this.bdownload.Size = new System.Drawing.Size(104, 35);
            this.bdownload.TabIndex = 159;
            this.bdownload.Text = "Download File";
            this.bdownload.Click += new System.EventHandler(this.bdownload_Click);
            // 
            // lpercent
            // 
            this.lpercent.AutoSize = true;
            this.lpercent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpercent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lpercent.Location = new System.Drawing.Point(16, 268);
            this.lpercent.Name = "lpercent";
            this.lpercent.Size = new System.Drawing.Size(23, 15);
            this.lpercent.TabIndex = 157;
            this.lpercent.Text = "0%";
            // 
            // pbloading
            // 
            this.pbloading.AutoRoundedCorners = true;
            this.pbloading.BorderRadius = 3;
            this.pbloading.Location = new System.Drawing.Point(7, 292);
            this.pbloading.Name = "pbloading";
            this.pbloading.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.pbloading.ProgressColor2 = System.Drawing.Color.DeepSkyBlue;
            this.pbloading.Size = new System.Drawing.Size(516, 8);
            this.pbloading.TabIndex = 158;
            this.pbloading.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // ldateuploaded
            // 
            this.ldateuploaded.AutoSize = true;
            this.ldateuploaded.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldateuploaded.Location = new System.Drawing.Point(119, 208);
            this.ldateuploaded.Name = "ldateuploaded";
            this.ldateuploaded.Size = new System.Drawing.Size(17, 15);
            this.ldateuploaded.TabIndex = 156;
            this.ldateuploaded.Text = "--";
            // 
            // luploaded
            // 
            this.luploaded.AutoSize = true;
            this.luploaded.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luploaded.Location = new System.Drawing.Point(119, 183);
            this.luploaded.Name = "luploaded";
            this.luploaded.Size = new System.Drawing.Size(17, 15);
            this.luploaded.TabIndex = 155;
            this.luploaded.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 154;
            this.label3.Text = "Date Uploaded:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 153;
            this.label2.Text = "Uploaded by:";
            // 
            // tfilename
            // 
            this.tfilename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tfilename.DefaultText = "";
            this.tfilename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tfilename.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tfilename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tfilename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tfilename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tfilename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tfilename.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tfilename.Location = new System.Drawing.Point(119, 72);
            this.tfilename.Multiline = true;
            this.tfilename.Name = "tfilename";
            this.tfilename.PasswordChar = '\0';
            this.tfilename.PlaceholderText = "";
            this.tfilename.SelectedText = "";
            this.tfilename.Size = new System.Drawing.Size(401, 75);
            this.tfilename.TabIndex = 152;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 151;
            this.label1.Text = "File Name:";
            // 
            // lfsn
            // 
            this.lfsn.AutoSize = true;
            this.lfsn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfsn.Location = new System.Drawing.Point(119, 48);
            this.lfsn.Name = "lfsn";
            this.lfsn.Size = new System.Drawing.Size(17, 15);
            this.lfsn.TabIndex = 150;
            this.lfsn.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 162;
            this.label4.Text = "FSN No:";
            // 
            // ldoctype
            // 
            this.ldoctype.AutoSize = true;
            this.ldoctype.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldoctype.Location = new System.Drawing.Point(119, 158);
            this.ldoctype.Name = "ldoctype";
            this.ldoctype.Size = new System.Drawing.Size(17, 15);
            this.ldoctype.TabIndex = 164;
            this.ldoctype.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 163;
            this.label6.Text = "Document Type:";
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PictureBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PictureBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(534, 40);
            this.guna2PictureBox4.TabIndex = 70;
            this.guna2PictureBox4.TabStop = false;
            // 
            // bwcopy
            // 
            this.bwcopy.WorkerReportsProgress = true;
            this.bwcopy.WorkerSupportsCancellation = true;
            this.bwcopy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwcopy_DoWork);
            this.bwcopy.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwcopy_ProgressChanged);
            // 
            // frm_filelibrary_download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.ldoctype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tfileloc);
            this.Controls.Add(this.bcancel);
            this.Controls.Add(this.bdownload);
            this.Controls.Add(this.lpercent);
            this.Controls.Add(this.pbloading);
            this.Controls.Add(this.ldateuploaded);
            this.Controls.Add(this.luploaded);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tfilename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lfsn);
            this.Controls.Add(this.ltotalasof);
            this.Controls.Add(this.guna2PictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_filelibrary_download";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export PDF File";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_filelibrary_download_FormClosing);
            this.Load += new System.EventHandler(this.frm_filelibrary_download_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.Label ltotalasof;
        private System.Windows.Forms.Label tfileloc;
        private Guna.UI2.WinForms.Guna2Button bcancel;
        private Guna.UI2.WinForms.Guna2Button bdownload;
        private System.Windows.Forms.Label lpercent;
        private Guna.UI2.WinForms.Guna2ProgressBar pbloading;
        private System.Windows.Forms.Label ldateuploaded;
        private System.Windows.Forms.Label luploaded;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tfilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lfsn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ldoctype;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker bwcopy;
    }
}