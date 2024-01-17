
namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    partial class frm_viewPDFfilelibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_viewPDFfilelibrary));
            this.viewpdffile = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.viewpdffile)).BeginInit();
            this.SuspendLayout();
            // 
            // viewpdffile
            // 
            this.viewpdffile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewpdffile.Enabled = true;
            this.viewpdffile.Location = new System.Drawing.Point(0, 0);
            this.viewpdffile.Name = "viewpdffile";
            this.viewpdffile.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("viewpdffile.OcxState")));
            this.viewpdffile.Size = new System.Drawing.Size(684, 861);
            this.viewpdffile.TabIndex = 0;
            // 
            // frm_viewPDFfilelibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 861);
            this.Controls.Add(this.viewpdffile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_viewPDFfilelibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview Document";
            this.Load += new System.EventHandler(this.frm_viewPDFfilelibrary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewpdffile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF viewpdffile;
    }
}