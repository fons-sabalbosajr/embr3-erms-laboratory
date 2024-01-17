using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    public partial class frm_settings_datainputconfig : Form
    {
        public frm_settings_datainputconfig()
        {
            InitializeComponent();

            terror.Visible = false;
            terror.Text = "";

            disabled();
        }

        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        LoadingFunction load = new LoadingFunction();

        public string sql;

        private void frm_settings_datainputconfig_Load(object sender, EventArgs e)
        {

        }

        /// ========================================================================= PARAMETER TAB =====================================================================

        #region "PARAMETERS INPUT"
        private void disabled()
        {
            tidnumber.Enabled = false;
            tname.Enabled = false;
            bsave.Enabled = false;
            bdelete.Enabled = false;
        }

        private void nulldgv()
        {
            if (dgvdataparameters.Rows.Count == 0)
            {
                lnullrecord.Visible = true;
            }
            else
                lnullrecord.Visible = false;
        }

        private void incrementid()
        {
            try
            {

                sql = "SELECT MAX(ID_No) FROM tb_input_parameters";
                SqlCommand cm = new SqlCommand(sql, c);
                c.Open();
                var maxno = cm.ExecuteScalar() as string;
                if (maxno == null)
                {
                    tidnumber.Text = "ERMS-PM-001";
                }
                else
                {
                    int val = int.Parse(maxno.Substring(8, 3));
                    val++;
                    tidnumber.Text = String.Format("ERMS-PM-{0:000}", val);
                }
                c.Close();
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }

        private void loaddatalegalofficer()
        {
            try
            {
                sql = "SELECT ID_No, Parameter_Name, Date_Added, Added_by FROM tb_input_parameters ORDER BY ID_No DESC";
                SqlDataAdapter da = new SqlDataAdapter(sql, c);
                DataSet ds = new DataSet();

                da.Fill(ds, "tb_input_parameters");
                dgvdataparameters.DataSource = ds.Tables["tb_input_parameters"];

                llegalofficercount.Text = "Found " + dgvdataparameters.Rows.Count.ToString() + " records out of " + ds.Tables["tb_input_parameters"].Rows.Count.ToString() + " entries";
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
            }
        }

        private void savedata()
        {
            try
            {
                DateTime dt = DateTime.Now;
                sql = "INSERT INTO tb_input_parameters (ID_No, Parameter_Name, Date_Added, Added_by) VALUES (@ID_No, @Parameter_Name, @Date_Added, @Added_by)";
                SqlCommand cm = new SqlCommand(sql, c);

                cm.Parameters.AddWithValue("@ID_No", tidnumber.Text);
                cm.Parameters.AddWithValue("@Parameter_Name", tname.Text);
                cm.Parameters.AddWithValue("@Date_Added", dt.ToString("MMM d yyyy h:mmtt"));
                cm.Parameters.AddWithValue("@Added_by", userdetails.uname);

                c.Open();
                cm.ExecuteNonQuery();
                c.Close();
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
            }
        }

        private void updatedataparameters()
        {
            try
            {
                DateTime dt = DateTime.Now;
                sql = "UPDATE tb_input_parameters SET ID_No = @ID_No, Parameter_Name = @Parameter_Name, Date_Added = @Date_Added, Added_by = @Added_by WHERE ID_No = @ID_No";
                SqlCommand cm = new SqlCommand(sql, c);

                cm.CommandType = CommandType.Text;

                cm.Parameters.AddWithValue("@ID_No", tidnumber.Text);
                cm.Parameters.AddWithValue("@Parameter_Name", tname.Text);
                cm.Parameters.AddWithValue("@Date_Added", dt.ToString("MMM d yyyy h:mmtt"));
                cm.Parameters.AddWithValue("@Added_by", userdetails.uname);

                c.Open();
                cm.ExecuteNonQuery();
                c.Close();
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
            }
        }

        #endregion

        private void baddfile_Click(object sender, EventArgs e)
        {
            incrementid();
            tname.Enabled = true;
            tname.Focus();
            bsave.Enabled = true;
            bdelete.Enabled = true;
        }

        private void bedit_Click(object sender, EventArgs e)
        {
            tname.Enabled = true;
            tname.Focus();
            leditlegalofficer.Visible = true;
        }

        private void bsave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Add Parameter?", "Add Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                load.Show(this);
                Thread.Sleep(500);
                savedata();
                load.Close();

                MessageBox.Show("Parameter saved successfully", "Data saved successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddatalegalofficer();
                disabled();
                nulldgv();
                bsave.Enabled = false;
                bdelete.Enabled = false;
            }
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be available soon.", "Feature not yet available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tname_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(tname.Text))
                {
                    if (MessageBox.Show("Discard Changes", "Cancel Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        loaddatalegalofficer();
                        leditlegalofficer.Visible = false;
                        disabled();
                    }
                }
                else
                {
                    if (MessageBox.Show("Save Changes", "Update Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        load.Show(this);
                        Thread.Sleep(500);
                        updatedataparameters();
                        load.Close();

                        MessageBox.Show("Data has been updated successfully", "Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaddatalegalofficer();
                        leditlegalofficer.Visible = false;
                        disabled();
                    }
                }
            }
        }

        private void dgvdataparameters_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvdataparameters.ClearSelection();
        }

        private void dgvdataparameters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tidnumber.Text = dgvdataparameters.SelectedRows[0].Cells[0].Value.ToString();
            tname.Text = dgvdataparameters.SelectedRows[0].Cells[1].Value.ToString(); 
        }
    }
}
