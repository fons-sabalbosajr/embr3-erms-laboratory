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
using System.Net.Mail;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    public partial class frm_home_signup : Form
    {
        public frm_home_signup()
        {
            InitializeComponent();
            Version ver = (ApplicationDeployment.IsNetworkDeployed) ?
            ApplicationDeployment.CurrentDeployment.CurrentVersion :
            Assembly.GetExecutingAssembly().GetName().Version;

            Text = "ERMS Legal Subsystem v." + ver.Major + "." + ver.Minor + "." + ver.Build;
            rterror.Visible = false;
        }

        #region "DLL FILES"
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int con, int val);
        #endregion

        LoadingFunction load = new LoadingFunction();
        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        string sql;


        private void VisitLink()
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/?view=cm&fs=1&to=emb.idms@gmail.com");
        }

        #region "INCREMENT EMP ID"
        private void incrementid()
        {
            try
            {
                sql = "SELECT MAX(User_ID) FROM tb_employees";
                SqlCommand cm = new SqlCommand(sql, c);
                c.Open();
                var maxid = cm.ExecuteScalar() as string;

                if (maxid == null)
                {
                    lid.Text = "ERMS_Laboratory-001";
                }
                else
                {
                    int val = int.Parse(maxid.Substring(16, 3));
                    val++;
                    lid.Text = String.Format("ERMS_Laboratory-{0:000}", val);
                }
                c.Close();
            }
            catch (Exception ex)
            {
                rterror.Visible = true;
                rterror.Text = ex.Message;
            }
        }
        #endregion

        #region "EMAIL SENDING"
        private void emailsend()
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(temail.Text);
            msg.To.Add("emb.idms@gmail.com");
            msg.Subject = "Employee SignUp Approval for " + tname.Text;
            string htmlstring = "User sign up to the system and waiting for Master Admin's Approval. <br /> <br />";
            htmlstring += "Name: " + tname.Text + "<br/>";
            htmlstring += "Position: " + tpos.Text + "<br/>";
            htmlstring += "Division: " + tdiv.Text + "<br/>";
            htmlstring += "Email Address: " + temail.Text + "<br/>";
            htmlstring += "Sub-System: " + Text + "<br/>";


            msg.IsBodyHtml = true;
            msg.Body = htmlstring;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("emb.idms@gmail.com", "pizdymchmeebxoai");
            smtp.EnableSsl = true;
            smtp.Send(msg);
        }
        private void signuprun()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO tb_signup_employees (EMB_ID, ID_Number, Name, Division, Position, Email_Address, Sub_System)" +
                                                "VALUES(@EMB_ID, @ID_Number, @Name, @Division, @Position, @Email_Address, @Sub_System)", c);
                cmd.Parameters.AddWithValue("@EMB_ID", lid.Text);
                cmd.Parameters.AddWithValue("@ID_Number", tembid.Text);
                cmd.Parameters.AddWithValue("@Name", tname.Text);
                cmd.Parameters.AddWithValue("@Division", tdiv.Text);
                cmd.Parameters.AddWithValue("@Position", tpos.Text);
                cmd.Parameters.AddWithValue("@Email_Address", temail.Text);
                cmd.Parameters.AddWithValue("@Sub_System", Text);

                c.Open();
                cmd.ExecuteNonQuery();
                c.Close();
                emailsend();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sign up Registration Failed. Please check your connection settings." + ex.Message, "Failed to register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.Close();
            }
        }
        #endregion

        private void bback_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel Sign-up?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    frm_home_signup fl = (frm_home_signup)Application.OpenForms["frm_home_signup"];
                    fl.Close();
                }
                catch (NullReferenceException ne)
                {
                    MessageBox.Show(ne.Message);
                }
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

        private void bsignup_Click(object sender, EventArgs e)
        {
            #region "Data Loading"
            if (string.IsNullOrEmpty(tembid.Text))
            {
                MessageBox.Show("Please enter your EMB-ID present", "Fields Required!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tname.Focus();
            }
            else if (string.IsNullOrEmpty(tname.Text))
            {
                MessageBox.Show("Please enter your Name", "Fields Required!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tname.Focus();
            }
            else if (string.IsNullOrEmpty(tdiv.Text))
            {
                MessageBox.Show("Please enter your Division", "Fields Required!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tdiv.Focus();
            }
            else if (string.IsNullOrEmpty(tpos.Text))
            {
                MessageBox.Show("Please enter your Position", "Fields Required!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tpos.Focus();
            }
            else if (string.IsNullOrEmpty(temail.Text))
            {
                MessageBox.Show("Please enter your Email", "Fields Required!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tpos.Focus();
            }
            #endregion

            else
            {
                try
                {
                    load.Show(this);
                    Thread.Sleep(5000);
                    signuprun();
                    load.Close();

                    MessageBox.Show("Account Added Successfully!. Plase wait for admin's approval", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pbody_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ptop_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region "TEXTBOX KEYPRESS"
        private void tembid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(tembid.Text))
                {
                    MessageBox.Show("Please enter your EMB ID", "Fields Required!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tembid.Focus();
                }
                else
                {
                    tname.Focus();
                }
            }
        }

        private void tname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(tname.Text))
                {
                    MessageBox.Show("Please enter your Name", "Fields Required!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tname.Focus();
                }
                else
                {
                    tdiv.Focus();
                }
            }
        }

        private void tdiv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(tdiv.Text))
                {
                    MessageBox.Show("Please enter your Division", "Fields Required!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tdiv.Focus();
                }
                else
                {
                    tpos.Focus();
                }
            }
        }

        private void tpos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(tpos.Text))
                {
                    MessageBox.Show("Please enter your Position", "Fields Required!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tpos.Focus();
                }
                else
                {
                    temail.Focus();
                }
            }
        }

        private void temail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(temail.Text))
                {
                    MessageBox.Show("Please enter your Email Address", "Fields Required!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    temail.Focus();
                }
                else
                {
                    bsignup.PerformClick();
                }
            }
        }
        #endregion

        private void frm_home_signup_Load(object sender, EventArgs e)
        {
            incrementid();
        }
    }
}
