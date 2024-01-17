
namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    partial class frm_loadingform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_loadingform));
            this.pbody = new Guna.UI2.WinForms.Guna2Panel();
            this.lloading = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tfade = new System.Windows.Forms.Timer(this.components);
            this.pbody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbody
            // 
            this.pbody.BackColor = System.Drawing.Color.White;
            this.pbody.BorderRadius = 2;
            this.pbody.Controls.Add(this.guna2PictureBox1);
            this.pbody.Controls.Add(this.lloading);
            this.pbody.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.pbody.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.pbody.Location = new System.Drawing.Point(1, 1);
            this.pbody.Name = "pbody";
            this.pbody.Size = new System.Drawing.Size(278, 83);
            this.pbody.TabIndex = 7;
            this.pbody.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbody_MouseDown);
            // 
            // lloading
            // 
            this.lloading.AutoSize = true;
            this.lloading.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lloading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.lloading.Location = new System.Drawing.Point(131, 30);
            this.lloading.Name = "lloading";
            this.lloading.Size = new System.Drawing.Size(93, 23);
            this.lloading.TabIndex = 4;
            this.lloading.Text = "Loading...";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::EMB_ERM_Sub_Sytem_Laboratory_Unit.Properties.Resources.loading__1_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(35, 6);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(70, 70);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // tfade
            // 
            this.tfade.Enabled = true;
            this.tfade.Interval = 5;
            // 
            // frm_loadingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 85);
            this.Controls.Add(this.pbody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_loadingform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Please Wait...";
            this.Load += new System.EventHandler(this.frm_loadingform_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_loadingform_MouseDown);
            this.pbody.ResumeLayout(false);
            this.pbody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pbody;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lloading;
        private System.Windows.Forms.Timer tfade;
    }
}