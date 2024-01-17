
namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    partial class frm_home_splashscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_home_splashscreen));
            this.pdec = new System.Windows.Forms.Panel();
            this.ploading = new System.Windows.Forms.Panel();
            this.tfade = new System.Windows.Forms.Timer(this.components);
            this.tslide = new System.Windows.Forms.Timer(this.components);
            this.lversion = new System.Windows.Forms.Label();
            this.pdec.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdec
            // 
            this.pdec.BackColor = System.Drawing.Color.Gainsboro;
            this.pdec.Controls.Add(this.ploading);
            this.pdec.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pdec.Location = new System.Drawing.Point(0, 390);
            this.pdec.Name = "pdec";
            this.pdec.Size = new System.Drawing.Size(500, 10);
            this.pdec.TabIndex = 7;
            // 
            // ploading
            // 
            this.ploading.BackColor = System.Drawing.Color.DodgerBlue;
            this.ploading.Location = new System.Drawing.Point(0, 0);
            this.ploading.Name = "ploading";
            this.ploading.Size = new System.Drawing.Size(70, 10);
            this.ploading.TabIndex = 3;
            // 
            // tfade
            // 
            this.tfade.Enabled = true;
            this.tfade.Interval = 5;
            this.tfade.Tick += new System.EventHandler(this.tfade_Tick);
            // 
            // tslide
            // 
            this.tslide.Enabled = true;
            this.tslide.Interval = 1;
            this.tslide.Tick += new System.EventHandler(this.tslide_Tick);
            // 
            // lversion
            // 
            this.lversion.AutoSize = true;
            this.lversion.BackColor = System.Drawing.Color.Transparent;
            this.lversion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lversion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(119)))), ((int)(((byte)(192)))));
            this.lversion.Location = new System.Drawing.Point(108, 344);
            this.lversion.Name = "lversion";
            this.lversion.Size = new System.Drawing.Size(62, 15);
            this.lversion.TabIndex = 8;
            this.lversion.Text = "Loading....";
            // 
            // frm_home_splashscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.SPLASCHSCREEN;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.lversion);
            this.Controls.Add(this.pdec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_home_splashscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_home_splashscreen_FormClosing);
            this.Load += new System.EventHandler(this.frm_home_splashscreen_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_home_splashscreen_MouseDown);
            this.pdec.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pdec;
        private System.Windows.Forms.Panel ploading;
        private System.Windows.Forms.Timer tfade;
        private System.Windows.Forms.Timer tslide;
        private System.Windows.Forms.Label lversion;
    }
}