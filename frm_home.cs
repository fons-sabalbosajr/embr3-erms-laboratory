using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    public partial class frm_home : Form
    {
        int pwidth;
        bool isShow;

        public string sql;
        public string q;
        public string fcode;

        private Guna.UI2.WinForms.Guna2Button currentbtn;
        private Form currChildForm;
        private Panel leftpanelbtn;

        public static string role = "";
        public static string msarole = "";
        public static string permission = "";
        public static string searchfile = "";

        public static string empno = "";
        public static string username = "";
        public static string cip = "";
        public int ID = 0;

        LoadingFunction load = new LoadingFunction();
        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        SqlConnection d = new SqlConnection(ConfigurationManager.ConnectionStrings["cm"].ConnectionString);


        public frm_home()
        {
            InitializeComponent();
            pwidth = pleft.Width;
            isShow = false;

            leftpanelbtn = new Panel();
            leftpanelbtn.Size = new Size(5, 45);
            pleft.Controls.Add(leftpanelbtn);

            ShowVersion();
        }

        private void ShowVersion()
        {
            Version ver = (ApplicationDeployment.IsNetworkDeployed) ?
                ApplicationDeployment.CurrentDeployment.CurrentVersion :
                Assembly.GetExecutingAssembly().GetName().Version;

            Text = Text + " v." + ver.Major + "." + ver.Minor + "."
                + ver.Build;
        }

        #region "DISPLAY CUSTOM"
        private void btndisabled()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(21, 61, 50);
                currentbtn.ForeColor = Color.White;
                currentbtn.TextAlign = HorizontalAlignment.Left;
                currentbtn.ImageAlign = HorizontalAlignment.Left;
            }
        }

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

        #region "USER DETAILS"
        private void userpro()
        {
            if (userdetails.uname != "")
            {
                luser.Text = userdetails.uname;
            }
        }

        private void userphoto()
        {
            q = "SELECT * FROM tb_employees WHERE Name = '" + luser.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(q, c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (!Convert.IsDBNull(dt.Rows[0][10]))
                {
                    byte[] img = (byte[])dt.Rows[0][10];
                    MemoryStream ms = new MemoryStream(img);
                    pbphoto.Image = Image.FromStream(ms);
                    da.Dispose();
                }
            }
        }
        #endregion

        private void logouthistory() 
        {
            try
            {
                d.Open();
                SqlCommand query = new SqlCommand("SELECT Name FROM tb_erms_user_universe WHERE Name='" + luser.Text + "'", d);
                SqlDataAdapter dap = new SqlDataAdapter(query);
                DataTable dtbl = new DataTable();
                DataSet ds = new DataSet();
                dap.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    string action = "Logged Out";
                    Login_History clh = new Login_History();
                    clh.Execute(@"INSERT INTO tb_user_history (Name, User_No, Date, Function_Performed, IP_Address, Login_as) VALUES ('" + frm_home_login.username + "','" + 
                        frm_home_login.empno + "','" + DateTime.Now.ToString("MMM d yyyy h: mm tt") + "','" + action + "','" + frm_home_login.cip + "','" + frm_home_login.role + "')");
                }
                query.ExecuteNonQuery();
                d.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Log Saving History Failed. Check your settings.\n" + ex.Message, "Log Saving Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                d.Close();
            }
        }

        private void frm_home_Load(object sender, EventArgs e)
        {
            try
            {
                userpro();
                userphoto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bsettings_Click(object sender, EventArgs e)
        {
            load.Show(this);
            Thread.Sleep(1000);
            ChildForm(new frm_home_settings());
            load.Close();
        }

        private void tslide_Tick(object sender, EventArgs e)
        {
            if (isShow)
            {
                pleft.Width = pleft.Width + 35;
                if (pleft.Width >= pwidth)
                {
                    tslide.Stop();
                    isShow = false;
                    bdashboard.Text = "Dashboard";
                    bupload.Text = "Upload";
                    blibrary.Text = "File Library";

                    this.Refresh();
                }
            }
            else
            {
                pleft.Width = pleft.Width - 35;
                if (pleft.Width <= 70)
                {
                    tslide.Stop();
                    isShow = true;
                    bdashboard.Text = "";
                    bupload.Text = "";
                    blibrary.Text = "";

                    this.Refresh();
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tslide.Start();
        }

        private void frm_home_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_home_login fl = new frm_home_login();

            load.Show(this);
            Thread.Sleep(500);
            logouthistory();
            load.Close();

            //fl.tusername.Clear();
            fl.tpassword.Clear();
            fl.Show();
            this.Hide();
        }

        private void bupload_Click(object sender, EventArgs e)
        {
            frm_home_upload fu = new frm_home_upload();

            load.Show(this);
            Thread.Sleep(500);
            fu.Show(this);
            load.Close();
        }

        private void blibrary_Click(object sender, EventArgs e)
        {
            load.Show(this);
            Thread.Sleep(1000);
            ChildForm(new frm_home_filelibrary());
            load.Close();
        }

        private void bdashboard_Click(object sender, EventArgs e)
        {
            load.Show(this);
            Thread.Sleep(1000);
            ChildForm(new frm_dashboard());
            load.Close();

        }
    }
}
