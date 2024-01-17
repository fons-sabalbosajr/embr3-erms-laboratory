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
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    public partial class frm_settings_registeresaccounts : Form
    {
        public frm_settings_registeresaccounts()
        {
            InitializeComponent();
            disable();
            uneditable();
            lnorecord.Visible = false;
            paskpassword.Visible = false;
            tsubsysversion.Enabled = false;
        }

        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        LoadingFunction load = new LoadingFunction();
        OpenFileDialog opd = new OpenFileDialog();
        SqlDataAdapter da;

        #region "EDITABLE"
        private void disable()
        {
            bedit.Visible = false;
            bsave.Visible = false;
            bbrowse.Visible = false;
        }

        private void enable()
        {
            editable();
            bedit.Visible = true;
            bsave.Visible = true;
            bbrowse.Visible = true;
        }

        public void uneditable()
        {
            tname.ReadOnly = true;
            tusername.ReadOnly = true;
            tdiv.ReadOnly = true;
            tpos.ReadOnly = true;
            tidno.ReadOnly = true;
            trole.ReadOnly = true;
            temail.ReadOnly = true;
            tpassword.ReadOnly = true;
            bgetsysver.Enabled = false;
            beye.Visible = false;

        }

        private void editable()
        {
            tname.ReadOnly = false;
            tusername.ReadOnly = false;
            tdiv.ReadOnly = false;
            tpos.ReadOnly = false;
            tidno.ReadOnly = false;
            trole.ReadOnly = false;
            temail.ReadOnly = false;
            tpassword.ReadOnly = false;

            bgetsysver.Enabled = true;
            beye.Enabled = true;
        }
        #endregion

        private void loaddata()
        {
            try
            {
                SqlCommand cm = new SqlCommand("SELECT User_ID, Name, Division, ID_Number FROM tb_employees", c);
                da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvusers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Users cannot be loaded due to connection error.\nPlease check your settings.\n\n" + ex.Message, "Load Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void userphoto()
        {
            string q = "SELECT * FROM tb_employees WHERE User_ID = '" + dgvusers.SelectedRows[0].Cells[0].Value.ToString() + "'";
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

        private void loadvalues()
        {
            try
            {
                SqlCommand cm = new SqlCommand("Select Name, User_ID, Division, Position, ID_Number, Username, Password, Role, Email_Address, Sub_System FROM tb_employees " +
               "WHERE User_ID = '" + dgvusers.SelectedRows[0].Cells[0].Value.ToString() + "'", c);

                da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                tname.Text =    dt.Rows[0][0].ToString();
                lembid.Text =   dt.Rows[0][1].ToString();
                tdiv.Text =     dt.Rows[0][2].ToString();
                tpos.Text =     dt.Rows[0][3].ToString();
                tidno.Text =    dt.Rows[0][4].ToString();
                tusername.Text = dt.Rows[0][5].ToString();
                tpassword.Text = dt.Rows[0][6].ToString();
                trole.Text =    dt.Rows[0][7].ToString();
                temail.Text =   dt.Rows[0][8].ToString();
                tsubsysversion.Text = dt.Rows[0][9].ToString();
                userphoto();

                uneditable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No data to be selected. Error in Selecting Data Values. \n Please check your settings. \n" + ex.Message, "Thrown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region "ASK PASSWORD TO EDIT"
        private void askpassword()
        {
            try
            {
                string MA = "Master Admin";
                string AD = "Admin";

                string pass = tpass.Text;

                c.Open();
                SqlCommand query = new SqlCommand("SELECT User_ID, Name, Division, " +
                    "Position, Username, Password, Role, ID_Number, Photo, Email_Address FROM tb_employees WHERE Password ='" + pass + "'", c);
                SqlDataAdapter dap = new SqlDataAdapter(query);
                DataTable dtbl = new DataTable();
                dap.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    if (dtbl.Rows[0][5].ToString() == pass)
                    {
                        if (dtbl.Rows[0][6].ToString() == MA)
                        {
                            load.Show(this);
                            Thread.Sleep(1000);
                            paskpassword.Visible = false;
                            load.Close();
                            tname.Focus();
                        }
                        else if (dtbl.Rows[0][6].ToString() == AD)
                        {
                            load.Show(this);
                            Thread.Sleep(1000);
                            //MessageBox.Show("Please ask for System Administrator's assistance. Thank you.", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            load.Close();
                            paskpassword.Visible = false;
                            tname.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input! \n Check your password", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    tpass.Focus();
                }
                query.ExecuteNonQuery();
                c.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Access Authentication Failed. \n \n" + ex.Message, "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tusername.Focus();
                c.Close();
            }
        }
        #endregion

        #region "UPDATE DATA"
        private void savedata()
        {
            try
            {
                c.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_employees SET Name =  @Name, Division = @Division, ID_Number = @ID_Number, " +
                    "Position = @Position, Email_Address = @Email_Address, Role = @Role, Sub_System = @Sub_System WHERE User_ID = '" + lembid.Text + "'", c);
                if (string.IsNullOrEmpty(this.tname.Text))
                {
                    cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Name", this.tname.Text);
                }

                if (string.IsNullOrEmpty(this.tdiv.Text))
                {
                    cmd.Parameters.AddWithValue("@Division", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Division", this.tdiv.Text);
                }

                if (string.IsNullOrEmpty(this.tidno.Text))
                {
                    cmd.Parameters.AddWithValue("@ID_Number", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_Number", this.tidno.Text);
                }

                if (string.IsNullOrEmpty(this.tpos.Text))
                {
                    cmd.Parameters.AddWithValue("@Position", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Position", this.tpos.Text);
                }

                if (string.IsNullOrEmpty(this.temail.Text))
                {
                    cmd.Parameters.AddWithValue("@Email_Address", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Email_Address", this.temail.Text);
                }

                if (string.IsNullOrEmpty(this.tpassword.Text))
                {
                    cmd.Parameters.AddWithValue("@Password", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Password", this.tpassword.Text);
                }

                if (string.IsNullOrEmpty(this.trole.Text))
                {
                    cmd.Parameters.AddWithValue("@Role", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Role", this.trole.Text);
                }

                if (string.IsNullOrEmpty(this.tsubsysversion.Text))
                {
                    cmd.Parameters.AddWithValue("@Sub_System", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Sub_System", this.tsubsysversion.Text);
                }

                cmd.ExecuteNonQuery();
                c.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Upload Files cannot be updated.\nPlease check your settings.\n\n" + ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void updatephoto()
        {
            try
            {
                string q = "UPDATE tb_employees SET Photo = @Photo WHERE User_ID ='" + lembid.Text + "'";
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
        #endregion

        private void frm_settings_registeresaccounts_Load(object sender, EventArgs e)
        {
            load.Show(this);
            Thread.Sleep(500);
            loaddata();
            load.Close();
        }

        private void dgvusers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bedit.Visible = true;
            loadvalues();
        }

        private void brefresh_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dgvusers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvusers.ClearSelection();
        }

        private void bedit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Edit User Information?", "Edit Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                paskpassword.Visible = true;
                tpass.Focus();
            }
        }

        private void bproceed_Click(object sender, EventArgs e)
        {
            askpassword();
            enable();
        }

        private void bcancel_Click(object sender, EventArgs e)
        {
            paskpassword.Visible = false;
        }

        private void tpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                bproceed.PerformClick();
            }
        }

        private void bsave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save User Changes?", "Save Edits", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                load.Show(this);
                Thread.Sleep(500);
                updatephoto();
                savedata();
                load.Close();

                MessageBox.Show("User Information Updated Successfully!", "User Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bsave.Visible = false;
                loaddata();
                dgvusers.Refresh();
                uneditable();
                disable();
            }
        }

        private void beye_MouseDown(object sender, MouseEventArgs e)
        {
            tpassword.PasswordChar = (char)0;
        }

        private void beye_MouseUp(object sender, MouseEventArgs e)
        {
            tpassword.PasswordChar = '•';
        }

        private void bbrowse_Click(object sender, EventArgs e)
        {
            opd.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                pbphoto.Image = Image.FromFile(opd.FileName);
            }
        }

        private void bgetsysver_Click(object sender, EventArgs e)
        {
            Version ver = (ApplicationDeployment.IsNetworkDeployed) ?
            ApplicationDeployment.CurrentDeployment.CurrentVersion :
            Assembly.GetExecutingAssembly().GetName().Version;

            tsubsysversion.Text = "ERMS Legal Subsystem v." + ver.Major + "." + ver.Minor + "." + ver.Build;
        }
    }
}
