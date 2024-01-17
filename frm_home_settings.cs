using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    public partial class frm_home_settings : Form
    {

        private Form currChildForm;
        private Guna2Button currentbtn;
        private Panel leftpanel;

        LoadingFunction load = new LoadingFunction();
        public frm_home_settings()
        {
            InitializeComponent();
            customUI();
            leftpanel = new Panel();
            leftpanel.Size = new Size(5, 45);
            pleft.Controls.Add(leftpanel);
        }

        #region "DISPLAY CUSTOM"
        private struct RGBColors
        {
            public static Color col = Color.FromArgb(13, 119, 192);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                btndisabled();
                currentbtn = (Guna2Button)senderBtn;
                currentbtn.BackColor = Color.White;
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = HorizontalAlignment.Left;
                currentbtn.ImageAlign = HorizontalAlignment.Left;

                leftpanel.BackColor = color;
                leftpanel.Location = new Point(0, currentbtn.Location.Y);
                leftpanel.Visible = true;
                leftpanel.BringToFront();
            }
        }
        private void btndisabled()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.White;
                currentbtn.ForeColor = Color.FromArgb(13, 119, 192);
                currentbtn.TextAlign = HorizontalAlignment.Left;
                currentbtn.ImageAlign = HorizontalAlignment.Left;
            }
        }
        #endregion

        #region "CHILD FORM"
        private void ChildForm(Form childForm)
        {
            if (currChildForm != null)
            {
                currChildForm.Close();
            }
            currChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pbody.Controls.Add(childForm);
            pbody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion

        #region "PANELS"
        private void customUI()
        {
            psubuser.Visible = false;

            psubsyslog.Visible = false;

        }
        private void hidepsub()
        {
            if (psubuser.Visible == true)
                psubuser.Visible = false;

            if (psubsyslog.Visible == true)
                psubsyslog.Visible = false;
        }
        private void showpsub(Panel psub)
        {
            if (psub.Visible == false)
            {
                hidepsub();
                psub.Visible = true;
            }
            else
            {
                psub.Visible = false;
            }
        }
        #endregion


        private void frm_home_settings_Load(object sender, EventArgs e)
        {

        }

        private void baccounts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.col);
            showpsub(psubuser);
        }

        private void bdbsettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.col);
            showpsub(psubsyslog);
        }


        #region "SETTINGS BUTTONS"
        private void baccountsignup_Click(object sender, EventArgs e)
        {
            load.Show(this);
            Thread.Sleep(1000);
            ChildForm(new frm_settings_signuaccounts());
            //MessageBox.Show("This feature will be available soon.", "Feature not yet available", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load.Close();
        }

        private void baccountreg_Click(object sender, EventArgs e)
        {
            load.Show(this);
            Thread.Sleep(1000);
            ChildForm(new frm_settings_registeresaccounts());
            //MessageBox.Show("This feature will be available soon.", "Feature not yet available", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load.Close();
        }

        private void buserhistory_Click(object sender, EventArgs e)
        {
            load.Show(this);
            Thread.Sleep(1000);
            ChildForm(new frm_settings_userhistory());
            load.Close();
            //MessageBox.Show("This feature will be available soon.", "Feature not yet available", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bfilehistory_Click(object sender, EventArgs e)
        {
            load.Show(this);
            Thread.Sleep(1000);
            load.Close();
            ChildForm(new frm_settings_filehistory());
            //MessageBox.Show("This feature will be available soon.", "Feature not yet available", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bdataconfig_Click(object sender, EventArgs e)
        {
            load.Show(this);
            Thread.Sleep(1000);
            ChildForm(new frm_settings_datainputconfig());
            load.Close();
            //MessageBox.Show("This feature will be available soon.", "Feature not yet available", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bermsaction_Click(object sender, EventArgs e)
        {
            load.Show(this);
            Thread.Sleep(1000);
            load.Close();
            MessageBox.Show("This feature will be available soon.", "Feature not yet available", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        #endregion
    }
}
