using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    public partial class frm_settings_createprofile : Form
    {
        public frm_settings_createprofile()
        {
            InitializeComponent();
            Version ver = (ApplicationDeployment.IsNetworkDeployed) ?
            ApplicationDeployment.CurrentDeployment.CurrentVersion :
            Assembly.GetExecutingAssembly().GetName().Version;

            Text = "ERMS Legal Subsystem v." + ver.Major + "." + ver.Minor + "." + ver.Build;
        }

        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        LoadingFunction load = new LoadingFunction();
        OpenFileDialog opd = new OpenFileDialog();

        private void loaddata()
        {
            try
            {
                SqlCommand cm = new SqlCommand("SELECT User_ID, Name FROM tb_employees WHERE User_ID=(SELECT MAX(User_ID) FROM tb_employees)", c);
                c.Open();
                SqlDataReader sdr = cm.ExecuteReader();
                sdr.Read();

                string name = sdr["Name"].ToString();
                string id = sdr["User_ID"].ToString();
                lname.Text = "Hi " + name + " !. Please enter your credentials below.";
                lid.Text = id;
                c.Close();
            }
            catch
            {
                lname.Text = "Data has not been saved. Please check the sign up accounts settings.";
                tusername.Enabled = false;
                tpass.Enabled = false;
                bapprove.Enabled = false;
                c.Close();
            }
        }

        private void savephoto()
        {
            try
            {
                string q = "UPDATE tb_employees SET Photo = @Photo WHERE User_ID ='" + lid.Text + "'";
                SqlCommand cm = new SqlCommand(q, c);

                c.Open();
                MemoryStream ms = new MemoryStream();
                pbphoto.Image.Save(ms, ImageFormat.Png);
                byte[] b = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(b, 0, b.Length);

                cm.Parameters.Add(new SqlParameter("@Photo", b));
                cm.ExecuteNonQuery();
                c.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region "CREATE ACCOUNT"
        private void createaccount()
        {
            try
            {
                if (string.IsNullOrEmpty(tusername.Text))
                {
                    MessageBox.Show("Please enter your username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tusername.Focus();
                }
                else if (string.IsNullOrEmpty(tpass.Text))
                {
                    MessageBox.Show("Please enter your password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tpass.Focus();

                }
                else
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE tb_employees SET Username = @Username, Password = @Password, Sub_System = @Sub_System WHERE User_ID = (SELECT MAX(User_ID)FROM tb_employees)", c);
                        c.Open();

                        cmd.Parameters.AddWithValue("@Username", tusername.Text);
                        cmd.Parameters.AddWithValue("@Password", tpass.Text);
                        cmd.Parameters.AddWithValue("@Sub_System", Text);

                        cmd.ExecuteNonQuery();
                        c.Close();
                        savephoto();
                        approvesend();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Account Saving Failed. Check your settings", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Create Account Failed. Please check your settings.\n" + ex.Message, "Account Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void approvesend()
        {
            try
            {
                SqlCommand cm = new SqlCommand("SELECT User_ID, Name, Username, Password, Email_Address FROM tb_employees WHERE User_ID=(SELECT MAX(User_ID) FROM tb_employees)", c);
                c.Open();
                SqlDataReader sdr = cm.ExecuteReader();
                sdr.Read();

                string id = sdr["User_ID"].ToString();
                string name = sdr["Name"].ToString();
                string username = sdr["Username"].ToString();
                string pass = sdr["Password"].ToString();
                string email = sdr["Email_Address"].ToString();
                c.Close();

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("emb.idms@gmail.com");
                msg.To.Add(email);
                msg.Subject = "Your Sign up has been Approved! " + name;
                string htmlstring = "Congratulations!. Your credentials to EMB-ERMS Legal Sub-System has been approved. Please keep your username and password to secure your account. <br />";
                htmlstring += "USER ID: " + id + "<br/>";
                htmlstring += "Name: " + name + "<br/>";
                htmlstring += "Your UserName: " + username + "<br/>";
                htmlstring += "Password: " + pass + "<br/>";
                htmlstring += "You may now proceed to application for log in. Thank You!.";

                msg.IsBodyHtml = true;
                msg.Body = htmlstring;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("emb.idms@gmail.com", "pizdymchmeebxoai");
                smtp.EnableSsl = true;
                smtp.Send(msg);
            }
            catch
            {
                MessageBox.Show("Sending Information to client Failed. Please contact your administrator", "Failed to send Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void beye_Click(object sender, EventArgs e)
        {
            tpass.UseSystemPasswordChar = false;
        }

        private void beye_KeyDown(object sender, KeyEventArgs e)
        {
            tpass.PasswordChar = (char)0;
        }

        private void beye_MouseUp(object sender, MouseEventArgs e)
        {
            tpass.PasswordChar = '•';
        }

        private void frm_settings_createprofile_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void bbrowse_Click(object sender, EventArgs e)
        {
            opd.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                pbphoto.Image = Image.FromFile(opd.FileName);
            }
        }

        private void bapprove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save account?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                load.Show(this);
                Thread.Sleep(3000);
                createaccount();
                //createserveraccount();
                load.Close();
                MessageBox.Show("User Account Added Successfully! A confirmation message has been sent to your email.", "User Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
