using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    public partial class frm_settings_userhistory : Form
    {
        public frm_settings_userhistory()
        {
            InitializeComponent();
        }
        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        LoadingFunction load = new LoadingFunction();


        SqlDataAdapter da;
        DataSet ds;
        DataTable dt = new DataTable();

        private void showdel()
        {
            try
            {
                string pos = "Developer";
                SqlCommand cm = new SqlCommand("SELECT Role FROM tb_employees", c);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][0].ToString() == pos)
                    {
                        bdelete.Visible = true;
                    }
                }
            }
            catch
            {
                bdelete.Visible = false;
            }
        }

        private void showall()
        {
            try
            {
                string sql = null;
                sql = "SELECT Log_ID, Date, Function_Performed, Name, Login_as FROM tb_employees_history ORDER BY Log_ID DESC";
                da = new SqlDataAdapter(sql, c);
                ds = new DataSet();
                da.Fill(ds, "tb_employees_history");
                dt = ds.Tables["tb_employees_history"];

                dgvlog.DataSource = ds.Tables["tb_employees_history"];

                lcount.Text = "Found " + dgvlog.Rows.Count.ToString() + "records out of " + ds.Tables["tb_employees_history"].Rows.Count.ToString() + " log entries";

                //dgvlog.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvlog.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

                DataGridViewColumn col = dgvlog.Columns[0];
                col.Width = 100;

                DataGridViewColumn cold = dgvlog.Columns[1];
                cold.Width = 200;

                DataGridViewColumn coln = dgvlog.Columns[3];
                coln.Width = 170;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loading Data Failed. Please check your settings.\n" + ex.Message, "Data Load Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.Close();
            }
        }

        private void showlogs()
        {
            try
            {
                SqlCommand cm = new SqlCommand("SELECT * FROM tb_employees_history WHERE Log_ID =  '" + dgvlog.SelectedRows[0].Cells[0].Value.ToString() + "'", c);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    luserid.Text = dt.Rows[0][0].ToString();
                    luser.Text = dt.Rows[0][1].ToString();
                    lembid.Text = dt.Rows[0][2].ToString();
                    ldate.Text = dt.Rows[0][3].ToString();
                    rtfunction.Text = dt.Rows[0][4].ToString();
                    lip.Text = dt.Rows[0][5].ToString();
                    lrole.Text = dt.Rows[0][6].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Users cannot be displayed. Check the server settings. \n\n" + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void deletevalue()
        {
            try
            {
                int j;
                c.Open();
                SqlCommand cmd = new SqlCommand("DELETE from tb_employees_history WHERE (Log_ID= '" + dgvlog.SelectedRows[0].Cells[0].Value.ToString() + "')", c);
                j = cmd.ExecuteNonQuery();
                if (j > 0)
                {
                    MessageBox.Show("User History succesfully deleted.", +j + "Log Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    c.Close();
                }
                showall();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
                c.Close();
            }
        }

        private void searchdata()
        {
            if (string.IsNullOrEmpty(tsearchfilter.Text))
            {
                showall();
            }
            else
            {
                try
                {
                    string q = "SELECT Log_ID, Date, Function_Performed, Name, Login_as FROM tb_employees_history";
                    q += " WHERE Log_ID LIKE '%' + @search + '%'";
                    q += " OR Date LIKE '%' + @search + '%'";
                    q += " OR Function_Performed LIKE '%' + @search + '%'";
                    q += " OR Name LIKE '%' + @search + '%'";
                    q += " OR Login_as LIKE '%' + @search + '%'";

                    q += " OR @search = '' ORDER BY Log_ID DESC";
                    using (SqlCommand cmd = new SqlCommand(q, c))
                    {
                        cmd.Parameters.AddWithValue("@search", tsearchfilter.Text.Trim());
                        using (SqlDataAdapter dap = new SqlDataAdapter(cmd))
                        {
                            ds = new DataSet();
                            dap.Fill(ds, "tb_employees_history");
                            dt = ds.Tables["tb_employees_history"];

                            dgvlog.DataSource = ds.Tables["tb_employees_history"];

                            lcount.Text = "Found " + dgvlog.Rows.Count.ToString() + " records out of " + ds.Tables["tb_employees_history"].Rows.Count.ToString() + " log entries";

                            //dgvlog.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                            dgvlog.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

                            DataGridViewColumn col = dgvlog.Columns[0];
                            col.Width = 100;

                            DataGridViewColumn cold = dgvlog.Columns[1];
                            cold.Width = 200;

                            DataGridViewColumn coln = dgvlog.Columns[3];
                            coln.Width = 170;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Document not found.\n Please check you searchings. \n\n" + ex.Message, "No record found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvlog.DataSource = null;
                }
            }
        }

        private void frm_settings_userhistory_Load(object sender, EventArgs e)
        {

        }

        private void dgvlog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showlogs();
        }

        private void bprint_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPrinter pr = new DGVPrinter();
                pr.Title = "Quick User History Verification Summary";
                pr.SubTitle = string.Format("As of : {0}", DateTime.Now.ToString());
                pr.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                pr.PageNumbers = true;
                pr.PageNumberInHeader = false;
                pr.PorportionalColumns = true;
                pr.HeaderCellAlignment = StringAlignment.Near;
                pr.Footer = "EMB - ERMS (Electronic Records Management Sub-System) Laboratory Unit";
                pr.FooterSpacing = 10;
                pr.PrintDataGridView(dgvlog);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot proceed to printing. Please check your settings. \n\n\n" + ex.Message, "Form print failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete user history data?", "Delete User Data History", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                deletevalue();
            }
        }

        private void tsearchfilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tsearchfilter.Text))
            {
                showall();
            }
            else
                searchdata();
        }
    }
}
