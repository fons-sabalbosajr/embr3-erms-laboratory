using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    public partial class frm_settings_filehistory : Form
    {
        public frm_settings_filehistory()
        {
            InitializeComponent();
        }

        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;

        string sql;

        private void nulldb()
        {
            if (dgvdata.Rows.Count == 0)
            {
                lnulldocs.Visible = true;
                dgvdata.DataSource = null;
            }
        }

        private string FileSize(double bCount)
        {
            string size = "0 B";
            if (bCount >= 1073741824.0)
                size = String.Format("{0:##.##}", bCount / 1073741824.0) + " GB";
            else if (bCount >= 1048576.0)
                size = String.Format("{0:##.##}", bCount / 1048576.0) + " MB";
            else if (bCount >= 1024.0)
                size = String.Format("{0:##.##}", bCount / 1024.0) + " KB";
            else if (bCount > 0 && bCount < 1024.0)
                size = bCount.ToString() + " bytes";
            return size;
        }

        private void loaddata()
        {
            try
            {
                sql = "SELECT Log_ID, Date_Uploaded, File_Name, Document_Type, File_Size, Accessed, Accessed_by FROM tb_file_history " +
                    "WHERE Log_ID = '" + dgvdata.SelectedRows[0].Cells[0].Value.ToString() + "' ORDER BY Log_ID DESC";

                da = new SqlDataAdapter(sql, c);
                ds = new DataSet();
                da.Fill(ds, "tb_file_history");
                dt = ds.Tables["tb_file_history"];

                if (ds.Tables["tb_file_history"].Rows.Count > 0)
                {
                    lfsn.Text = dt.Rows[0][0].ToString();
                    lname.Text = dt.Rows[0][1].ToString();
                    lfclass.Text = dt.Rows[0][2].ToString();
                    ldateuploaded.Text = dt.Rows[0][3].ToString();
                    lfileloc.Text = dt.Rows[0][4].ToString();

                    string path = dt.Rows[0][4].ToString();
                    FileInfo fi = new FileInfo(path);
                    string fsize = FileSize((int)fi.Length);
                    lsize.Text = fsize;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Failed. Restart the Application. \n\n" + ex.Message);
            }
        }

        private void deleteFILE()
        {
            try
            {
                int j;
                c.Open();
                SqlCommand cmd = new SqlCommand("DELETE from tb_file_history WHERE (Serial_No ='" + dgvdata.SelectedRows[0].Cells[0].Value.ToString() + "')", c);
                j = cmd.ExecuteNonQuery();
                if (j > 0)
                {
                    string filename = lfileloc.Text;
                    FileInfo file = new FileInfo(filename);
                    file.Delete();
                    MessageBox.Show("Data deleted successfully.", "Data deleted.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                c.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("File cannot be deleted. Check your settings. \n\n" + ex.Message);
            }
        }

        private void searchdata()
        {
            try
            {
                string q = "SELECT Log_ID, File_Name, Date_Uploaded, Accessed_by FROM tb_file_history";
                q += " WHERE Log_ID LIKE '%' + @search + '%'";
                q += " OR File_Name LIKE '%' + @search + '%'";
                q += " OR Document_Type LIKE '%' + @search + '%'";
                q += " OR Accessed_by LIKE '%' + @search + '%'";

                q += " OR @search = '' ORDER BY Date_Uploaded DESC";
                using (SqlCommand cm = new SqlCommand(q, c))
                {
                    cm.Parameters.AddWithValue("@search", tsearch.Text.Trim());
                    using (SqlDataAdapter da = new SqlDataAdapter(cm))
                    {
                        ds = new DataSet();
                        da.Fill(ds, "tb_labdata");
                        dt = ds.Tables["tb_labdata"];

                        dgvdata.DataSource = ds.Tables["tb_labdata"];

                        //dgvfiles.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                        dgvdata.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

                        dgvdata.Columns["Log_ID"].DisplayIndex = 0;
                        dgvdata.Columns["File_Name"].DisplayIndex = 1;
                        dgvdata.Columns["Date_Uploaded"].DisplayIndex = 2;
                        dgvdata.Columns["Accessed_by"].DisplayIndex = 3;

                        DataGridViewColumn colfsn = dgvdata.Columns[0];
                        colfsn.Width = 100;

                        DataGridViewColumn colname = dgvdata.Columns[1];
                        colname.Width = 125;

                        DataGridViewColumn colfiles = dgvdata.Columns[2];
                        colfiles.Width = 100;

                        DataGridViewColumn coluser = dgvdata.Columns[3];
                        coluser.Width = 175;

                        int row = dgvdata.Rows.Count;
                        lcount.Text = dgvdata.Rows.Count.ToString() + " records of " + ds.Tables["tb_labdata"].Rows.Count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Failed. Restart the Application. \n" + ex.Message);
            }
        }


        private void frm_settings_filehistory_Load(object sender, EventArgs e)
        {

        }

        private void tsearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tsearch.Text))
            {
                dgvdata.DataSource = null;
                lnulldocs.Visible = true;

                lfsn.Text = "--------------";
                lname.Clear();
                lsize.Text = "--------------";
                lfclass.Text = "--------------";
                ldateuploaded.Text = "--------------";
                lfileloc.Clear();

                lcount.Text = "0 record out of 0 entries";
            }
            else
            {
                lnulldocs.Visible = false;
                searchdata();
            }
        }

        private void bdel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete user history data?", "Delete User Data History", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                deleteFILE();
            }
        }

        private void dgvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loaddata();
        }
    }
}
