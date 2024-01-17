using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    public partial class frm_home_login : Form
    {
        public frm_home_login()
        {
            InitializeComponent();
            Version ver = (ApplicationDeployment.IsNetworkDeployed) ?
               ApplicationDeployment.CurrentDeployment.CurrentVersion :
               Assembly.GetExecutingAssembly().GetName().Version;

            lversion.Text = ver.Major + "." + ver.Minor + "." + ver.Build;
            tusername.Focus();
            autocompleteuser();
        }


        public static string empno = "";
        public static string username = "";
        public static string cip = "";
        public static string role = "";
        public static string profname = "";

        public int ID = 0;
        private Form currChildForm;

        public static string getusername = "";
        public static string getpassword = "";

        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        SqlConnection d = new SqlConnection(ConfigurationManager.ConnectionStrings["cm"].ConnectionString);

        LoadingFunction load = new LoadingFunction();

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int con, int val);

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #region "GET IP ADDRESS"
        private void getIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    cip = ip.ToString();
                }
                lip.Text = cip;
            }
        }
        #endregion

        #region "FADE IN FORM"
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                tfade.Stop();
            else
                Opacity += 0.05;
        }
        #endregion

        #region "VISIT LINK"
        private void VisitLink()
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/?view=cm&fs=1&to=emb.idms@gmail.com");
        }
        #endregion

        #region "CREATING CHILDFORM"
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

            pright.Controls.Add(childForm);
            pright.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region "LOGIN EVENT"
        private void loginhistory()
        {
            if (string.IsNullOrEmpty(tusername.Text))
            {
                tusername.Text = "Previous Login Username Error";
            }
            else if (string.IsNullOrEmpty(tpassword.Text)) 
            {
                tpassword.Text = "Previous Login Password Error";
            }
            if ((tusername.Text != "") && (tpassword.Text != "")) 
            {
                try
                {
                    string login = "Logged In";
                    Login_History clh = new Login_History();
                    string query = @"Select User_ID FROM tb_erms_user_universe WHERE Username = '" + Convert.ToString(tusername.Text) + "' AND Password = '" + Convert.ToString(tpassword.Text) + "'";
                    empno = clh.convertstring(query).ToString();
                    if (empno != "")
                    {
                        string q = "SELECT Name FROM tb_erms_user_universe WHERE User_ID = '" + Convert.ToString(empno) + "'";
                        string r = "SELECT Role FROM tb_erms_user_universe WHERE User_ID = '" + Convert.ToString(empno) + "'";
                        username = clh.convertstring(q).ToString();
                        role = clh.convertstring(r).ToString();
                        clh.Execute(@"INSERT INTO tb_user_history (Name, User_No, Date, Function_Performed, IP_Address, Login_as) VALUES ('" + username + "','" + empno + "','" + 
                            DateTime.Now.ToString("MMM d yyyy h: mm tt") + "','" + login + "','" + cip + "','" + role + "')");
                        ID = 0;
                    }
                    else
                    {
                        MessageBox.Show(this, "Invalid Password");
                        tpassword.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Log Saving History Failed. Check your settings.\n" + ex.Message, "Log Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void login()
        {
            try
            {
                string AD = "Admin";
                string G = "Guest";
                string AA = "Admin Assistant";
                string user = tusername.Text;
                string pass = tpassword.Text;

                //kukunin ang value ng user
                c.Open();
                SqlCommand query = new SqlCommand("SELECT User_ID, Name, Division, Position, Username, Password, Role, ID_Number, " +
                    "Photo, Email_Address FROM tb_employees WHERE Username='" + user + "' AND Password ='" + pass + "'", c);
                SqlDataAdapter dap = new SqlDataAdapter(query);
                DataTable dtbl = new DataTable();
                dap.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    if (dtbl.Rows[0][5].ToString() == pass)
                    {
                        if (dtbl.Rows[0][6].ToString() == AD)
                        {
                            userdetails.uid = dtbl.Rows[0][0].ToString();
                            userdetails.uname = dtbl.Rows[0][1].ToString();
                            userdetails.udivision = dtbl.Rows[0][2].ToString();
                            userdetails.uposition = dtbl.Rows[0][3].ToString();
                            userdetails.uusername = dtbl.Rows[0][4].ToString();
                            userdetails.upassword = dtbl.Rows[0][5].ToString();
                            userdetails.urole = dtbl.Rows[0][6].ToString();
                            userdetails.uembid = dtbl.Rows[0][7].ToString();
                            userdetails.uemail = dtbl.Rows[0][8].ToString();
                           
                            frm_home fh = new frm_home();
                            fh.Show(this);
                            profname = dtbl.Rows[0][1].ToString();
                            loginhistory();
                            this.Hide();
                        }

                        //----------------------------------------------------------------------------------------
                        else if (dtbl.Rows[0][6].ToString() == AA)
                        {
                            userdetails.uid = dtbl.Rows[0][0].ToString();
                            userdetails.uname = dtbl.Rows[0][1].ToString();
                            userdetails.udivision = dtbl.Rows[0][2].ToString();
                            userdetails.uposition = dtbl.Rows[0][3].ToString();
                            userdetails.uusername = dtbl.Rows[0][4].ToString();
                            userdetails.upassword = dtbl.Rows[0][5].ToString();
                            userdetails.urole = dtbl.Rows[0][6].ToString();
                            userdetails.uembid = dtbl.Rows[0][7].ToString();
                            userdetails.uemail = dtbl.Rows[0][8].ToString();
                            
                            frm_home fh = new frm_home();
                            fh.Show(this);
                            profname = dtbl.Rows[0][1].ToString();
                            loginhistory();
                            this.Hide();
                        }

                        //---------------------------------------------------------------------------------------
                        else if (dtbl.Rows[0][6].ToString() == G)
                        {
                            userdetails.uname = dtbl.Rows[0][1].ToString();
                            userdetails.uid = dtbl.Rows[0][0].ToString();
                            userdetails.udivision = dtbl.Rows[0][2].ToString();
                            userdetails.uposition = dtbl.Rows[0][3].ToString();
                            userdetails.uusername = dtbl.Rows[0][4].ToString();
                            userdetails.upassword = dtbl.Rows[0][5].ToString();
                            userdetails.urole = dtbl.Rows[0][6].ToString();
                            userdetails.uembid = dtbl.Rows[0][7].ToString();
                            userdetails.uphoto = dtbl.Rows[0][8].ToString();
                            userdetails.uemail = dtbl.Rows[0][8].ToString();
                            
                            frm_home fh = new frm_home();
                            fh.Show(this);
                            profname = dtbl.Rows[0][1].ToString();
                            loginhistory();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    lwarning.Visible = true;
                    tusername.Focus();
                }
                query.ExecuteNonQuery();
                c.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Authentication Failed. \n \n Please check your IP Address \n" + ex.Message, "Change in IP Address Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tusername.Focus();
                c.Close();
            }
        }


        private void msalogin() 
        {
            try 
            {
                string MSA = "Master Admin";
                string user = tusername.Text;
                string pass = tpassword.Text;

                c.Open();
                SqlCommand cm = new SqlCommand("SELECT MSA_No, ID_Number, Name, Username, Password, Role FROM tb_masteradmin " +
                    "WHERE Username='" + user + "' AND Password ='" + pass + "'", c);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][4].ToString() == pass)
                    {
                        if (dt.Rows[0][5].ToString() == MSA)
                        {
                            msadetails.msano =      dt.Rows[0][0].ToString();
                            msadetails.msaid =      dt.Rows[0][1].ToString();
                            msadetails.msaname =    dt.Rows[0][2].ToString();
                            msadetails.msausername = dt.Rows[0][3].ToString();
                            msadetails.msapassword = dt.Rows[0][4].ToString();
                            msadetails.msarole =    dt.Rows[0][5].ToString();
                            frm_home fh = new frm_home();
                            fh.Show();
                            this.Hide();
                        }
                    }
                }
                c.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Authentication Failed. \n \n Please check your IP Address \n" + ex.Message, "Change in IP Address Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tusername.Focus();
                c.Close();
            }
        }
        #endregion

        private void autocompleteuser() 
        {
            {
                try
                {
                    SqlCommand cm = new SqlCommand("SELECT Username FROM tb_employees", c);
                    c.Open();
                    SqlDataReader dr = cm.ExecuteReader();
                    AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                    while (dr.Read())
                    {
                        col.Add(dr.GetString(0));
                    }
                    tusername.AutoCompleteCustomSource = col;
                    c.Close();
                }
                catch
                {
                }
            }
        }
        private void frm_home_login_Load(object sender, EventArgs e)
        {
            getIP();

            this.Opacity = 0;
            tfade.Interval = 10;
            tfade.Tick += new EventHandler(fadeIn);
            tfade.Start();

            int Out;
            if (InternetGetConnectedState(out Out, 0) == true)
            {
                pstatus.Visible = false;
            }
            else
            {
                pstatus.Visible = true;
            }
        }

        private void pbgmail_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked." + ex.Message);
            }
        }

        private void blogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tusername.Text))
            {
                MessageBox.Show("Please enter your username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tusername.Clear();
                tusername.Focus();
            }
            else if (string.IsNullOrEmpty(tpassword.Text))
            {
                MessageBox.Show("Please enter your password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tpassword.Clear();
                tpassword.Focus();
            }
            else
            {
                int Out;
                if (InternetGetConnectedState(out Out, 0) == true)
                {
                    load.Show(this);
                    Thread.Sleep(500);
                    load.Close();
                    login();
                    msalogin();
                    getusername = tusername.Text;
                    getpassword = tpassword.Text;
                }
                else
                {
                    MessageBox.Show("Login cannot prooced. Please check your internet connection", "Internet Connection not established", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void bclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quit Application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void tusername_TextChanged(object sender, EventArgs e)
        {
            lwarning.Visible = false;
        }

        private void tpassword_TextChanged(object sender, EventArgs e)
        {
            lwarning.Visible = false;
        }

        private void tusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                tpassword.Focus();
            }
        }

        private void tpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                blogin.PerformClick();
        }

        private void bsignup_Click(object sender, EventArgs e)
        {
            try
            {
                load.Show(this);
                Thread.Sleep(200);
                ChildForm(new frm_home_signup());
                load.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sign-up Window is not Available. Contact the Developer immediately.");
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pright_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }

    #region "PUBLIC CLASSES"
    public class userdetails
    {
        public static string uname { get; set; }
        public static string uid { get; set; }
        public static string uembid { get; set; }
        public static string uposition { get; set; }
        public static string udivision { get; set; }
        public static string uusername { get; set; }
        public static string upassword { get; set; }
        public static string uphoto { get; set; }
        public static string uemail { get; set; }
        public static string urole { get; set; }
        
    }

    public class msadetails 
    {
        public static string msano { get; set; }
        public static string msaid { get; set; }
        public static string msaname { get; set; }
        public static string msausername { get; set; }
        public static string msapassword { get; set; }
        public static string msarole { get; set; }
    }
    #endregion
}
