using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    public partial class frm_settings_signuaccounts : Form
    {
        public frm_settings_signuaccounts()
        {
            InitializeComponent();
            lnorecord.Visible = false;
            Version ver = (ApplicationDeployment.IsNetworkDeployed) ?
                ApplicationDeployment.CurrentDeployment.CurrentVersion :
                Assembly.GetExecutingAssembly().GetName().Version;

            Text = "ERMS Legal Subsystem v." + ver.Major + "." + ver.Minor + "." + ver.Build;
        }
        frm_settings_createprofile cp = new frm_settings_createprofile();

        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        LoadingFunction load = new LoadingFunction();
        SqlDataAdapter da;
        DataSet ds;
        public int j;

        private void norecord()
        {
            if (dgvusers.Rows.Count == 0)
            {
                lnorecord.Visible = true;
            }
        }

        private void loaddata()
        {
            try
            {
                SqlCommand cm = new SqlCommand("SELECT EMB_ID, Name, Division, Position, Email_Address, ID_Number FROM tb_signup_employees", c);
                da = new SqlDataAdapter(cm);
                ds = new DataSet();

                da.Fill(ds, "tb_signup_employees");
                dgvusers.DataSource = ds.Tables["tb_signup_employees"];

                //dgvusers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvusers.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                norecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dgvusers.DataSource = null;
            }
        }

        private void searchdata()
        {
            if (string.IsNullOrEmpty(tsearchfilter.Text))
            {
                loaddata();
            }
            else
            {
                string q = "SELECT EMB_ID, Name, Division, Position, Email_Address, ID_Number FROM tb_signup_employees";
                q += " WHERE Name LIKE '%' + @search + '%'";
                q += " OR EMB_ID LIKE '%' + @search + '%'";
                q += " OR Division LIKE '%' + @search + '%'";
                q += " OR Position LIKE '%' + @search + '%'";
                q += " OR Email_Address LIKE '%' + @search + '%'";
                q += " OR ID_NUmber LIKE '%' + @search + '%'";

                q += " OR @search = ''";
                using (SqlCommand cmd = new SqlCommand(q, c))
                {
                    cmd.Parameters.AddWithValue("@search", tsearchfilter.Text.Trim());
                    using (SqlDataAdapter dap = new SqlDataAdapter(cmd))
                    {
                        ds = new DataSet();
                        dap.Fill(ds, "tb_signup_employees");
                        dgvusers.DataSource = ds.Tables["tb_signup_employees"];

                        //dgvusers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                        dgvusers.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    }
                }
            }
        }
        private void approveaccount()
        {
            try
            {
                string roledefault = "Admin";
                c.Open();
                SqlCommand cm = new SqlCommand("INSERT INTO tb_employees (User_ID, Name, Division, ID_Number, Position, Email_Address, Role)" +
                                                "VALUES(@User_ID, @Name, @Division, @ID_Number, @Position, @Email_Address, @Role)", c);

                cm.Parameters.AddWithValue("@User_ID",      dgvusers.SelectedRows[0].Cells[0].Value.ToString());
                cm.Parameters.AddWithValue("@Name",         dgvusers.SelectedRows[0].Cells[1].Value.ToString());
                cm.Parameters.AddWithValue("@Division",     dgvusers.SelectedRows[0].Cells[2].Value.ToString());
                cm.Parameters.AddWithValue("@Position",     dgvusers.SelectedRows[0].Cells[3].Value.ToString());
                cm.Parameters.AddWithValue("@Email_Address", dgvusers.SelectedRows[0].Cells[4].Value.ToString());
                cm.Parameters.AddWithValue("@ID_Number",    dgvusers.SelectedRows[0].Cells[5].Value.ToString());

                cm.Parameters.AddWithValue("@Role", roledefault);

                cm.ExecuteNonQuery();
                c.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Saving Account Error.\n" + ex.Message, "Saving Data Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.Close();
            }
        }
        private void recomoveaccount()
        {
            try
            {
                c.Open();
                SqlCommand cmd = new SqlCommand("DELETE from tb_signup_employees WHERE (EMB_ID ='" + dgvusers.SelectedRows[0].Cells[0].Value.ToString() + "')", c);
                j = cmd.ExecuteNonQuery();
                if (j > 0)
                {
                    MessageBox.Show("User Account Deleted Successfully.", "User Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                c.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Users cannot be displayed. Check the server settings. \n\n" + ex.Message);
                c.Close();
            }
        }

        private void frm_settings_signuaccounts_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dgvusers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvusers.ClearSelection();
        }

        private void brefresh_Click(object sender, EventArgs e)
        {
            load.Show(this);
            Thread.Sleep(500);
            loaddata();
            load.Close();
        }

        private void tsearchfilter_TextChanged(object sender, EventArgs e)
        {
            searchdata();
        }

        private void bapprove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Approve Account?", "Approve User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                load.Show(this);
                Thread.Sleep(2000);
                approveaccount();
                //approvetoserver();
                load.Close();
                cp.ShowDialog();
            }
        }

        private void bremove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete User?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                load.Show(this);
                Thread.Sleep(2000);
                load.Close();
                recomoveaccount();
                loaddata();
            }
        }
    }
}
