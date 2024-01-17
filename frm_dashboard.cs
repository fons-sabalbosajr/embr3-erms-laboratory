using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    public partial class frm_dashboard : Form
    {
        public frm_dashboard()
        {
            InitializeComponent();
            terror.Text = "";
            terror.Visible = false;
            hideloadings();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        LoadingFunction load = new LoadingFunction();
        DataSet ds;

        frm_dashboard_libraries flb = new frm_dashboard_libraries();

        public static string doctype = "";

        private void hideloadings() 
        {
            pbloadfile.Visible = false;
            pbloadfolder.Visible = false;
            pbmemoryloading.Visible = false;
            tfilecountcoc.Visible = false;
            tfilecountlabcert.Visible = false;
            tfilecountdra.Visible = false;
            tfilecountlabpr.Visible = false;
            tfilecountlabres.Visible = false;
            tfilecountlabmemo.Visible = false;
        }

        #region "LOADING SECTION"
        private void SetLoading(bool displayLoader)
        {
            if (displayLoader)
            {
                this.Invoke((MethodInvoker)delegate
                {

                    pbloadfile.Visible = true;
                    pbloadfolder.Visible = true;

                    this.Cursor = Cursors.WaitCursor;
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {

                    pbloadfile.Visible = false;
                    pbloadfolder.Visible = false;

                    this.Cursor = Cursors.Default;
                });
            }
        }

        #endregion

        private void showalldata()
        {

            SetLoading(true);
            this.Cursor = Cursors.WaitCursor;

            loadusers();
            recentuploads();
            totalRecords();
            todayrecords();
           
          
            //loadmessages();
            //messages();

            SetLoading(false);
            this.Cursor = Cursors.Default;
        }

        #region "LOAD USERS"
        private void loadusers() 
        {
            try
            {
                dgvuserlog.RowHeadersVisible = false;
                dgvuserlog.DataSource = null;
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 5 Name FROM tb_employees_history ORDER BY Log_ID DESC", c);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_employees_history");

                DataTable dt = ds.Tables["tb_employees_history"];
                dt = removeredundantrows(dt, "Name");

                dgvuserlog.DataSource = ds.Tables["tb_employees_history"].DefaultView;
                //dgvusers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvuserlog.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                DataGridViewColumn col = dgvuserlog.Columns[0];
                col.Width = 80;
                col.DefaultCellStyle.Padding = new Padding(7, 10, 7, 10);

                lactiveusers.Text = dgvuserlog.Rows.Count.ToString();
            }
            catch (Exception ex) 
            {
                terror.Visible = true;
                terror.Text = ex.Message;
            }
        }

        public DataTable removeredundantrows(DataTable dt, string colName)
        {
            Hashtable ht = new Hashtable();
            ArrayList dlist = new ArrayList();

            foreach (DataRow drow in dt.Rows)
            {
                if (ht.Contains(drow["Name"]))
                    dlist.Add(drow);
                else
                    ht.Add(drow["Name"], string.Empty);
            }

            foreach (DataRow row in dlist)
                dt.Rows.Remove(row);
            return dt;
        }
        #endregion

        #region "LOAD TOTAL FILES"
        private void totalRecords() 
        {
            try
            {
                string pub = "Att-";

                SqlCommand cm = new SqlCommand("SELECT * FROM tb_labdata WHERE Serial_No NOT LIKE '%" + pub + "%'", c);
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cm;
                da.Fill(ds, "tb_labdata");
                da.Dispose();
                cm.Dispose();
                c.Close();

                lfiles.Text = String.Format("{0:n0}", ds.Tables[0].Rows.Count);

            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
            }
        }

        private void todayrecords()
        {
            try
            {
                DateTime dt = DateTime.Now;
                ldatenow.Text = dt.ToString("MMM d yyyy");

                string sql = "SELECT Serial_No, Date_Uploaded FROM tb_labdata WHERE Date_Uploaded LIKE '%' + @search + '%'";
                using (SqlCommand cm = new SqlCommand(sql, c))
                {
                    cm.Parameters.AddWithValue("@search", ldatenow.Text.Trim());
                    using (SqlDataAdapter da = new SqlDataAdapter(cm))
                    {
                        ds = new DataSet();
                        da.Fill(ds, "tb_labdata");

                        luploadtoday.Text = ds.Tables[0].Rows.Count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
            }
        }
        #endregion

        #region "LOAD RECENT UPLOADS"
        private void recentuploads()
        {
            try
            {
                SqlCommand cm = new SqlCommand("SELECT TOP 7 Serial_No, File_Name, Document_Type, Date_Uploaded FROM tb_labdata ORDER BY Serial_No DESC", c);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_labdata");

                dgvdatarecent.DataSource = ds.Tables["tb_labdata"];

                DataGridViewColumn colfsn = dgvdatarecent.Columns[0];
                colfsn.Width = 200;

                DataGridViewColumn colname = dgvdatarecent.Columns[1];
                colname.Width = 700;


                DataGridViewColumn coltype = dgvdatarecent.Columns[2];
                coltype.Width = 300;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Total Files Not Found.\n" + ex.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.Close();
            }
        }
        #endregion

        private void frm_dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                Thread input = new Thread(showalldata);
                input.Start();
            }
            catch (Exception)
            {

            }
        }

        private void brefresh_Click(object sender, EventArgs e)
        {
            load.Show(this);
            Thread.Sleep(1000);
            this.Cursor = Cursors.WaitCursor;

            loadusers();
            recentuploads();
            totalRecords();
            todayrecords();

            load.Close();
            this.Cursor = Cursors.Default;
        }

        private void dgvuserlog_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvuserlog.ClearSelection();
        }

        private void dgvuserlog_MouseLeave(object sender, EventArgs e)
        {
            dgvuserlog.ClearSelection();
        }

        private void openlabres_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System Development Ongoing. Please wait for the next update.", "Feature Under Development", MessageBoxButtons.OK, MessageBoxIcon.Information);
            doctype = "Laboratory Test Results";
            load.Show(this);
            Thread.Sleep(500);
            load.Close();
            //flb.Show(this);
        }

        private void opencoc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System Development Ongoing. Please wait for the next update.", "Feature Under Development", MessageBoxButtons.OK, MessageBoxIcon.Information);
            doctype = "Laboratory Sample Submission / Chain of Custody Form (COC)";
            load.Show(this);
            Thread.Sleep(500);
            load.Close();
            //flb.Show(this);
        }

        private void opendra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System Development Ongoing. Please wait for the next update.", "Feature Under Development", MessageBoxButtons.OK, MessageBoxIcon.Information);
            doctype = "Draft Results of Analyses";
            load.Show(this);
            Thread.Sleep(500);
            load.Close();
            //flb.Show(this);
        }

        private void openlabpr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System Development Ongoing. Please wait for the next update.", "Feature Under Development", MessageBoxButtons.OK, MessageBoxIcon.Information);
            doctype = "Laboratory PR/Receipt";
            load.Show(this);
            Thread.Sleep(500);
            load.Close();
            //flb.Show(this);
        }

        private void openlabmemo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System Development Ongoing. Please wait for the next update.", "Feature Under Development", MessageBoxButtons.OK, MessageBoxIcon.Information);
            doctype = "Laboratory Memo";
            load.Show(this);
            Thread.Sleep(500);
            load.Close();
            //flb.Show(this);
        }

        private void openlabcert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System Development Ongoing. Please wait for the next update.", "Feature Under Development", MessageBoxButtons.OK, MessageBoxIcon.Information);
            doctype = "Laboratory Calibration Certificate";
            load.Show(this);
            Thread.Sleep(500);
            load.Close();
            //flb.Show(this);
        }

        private void dgvdatarecent_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvdatarecent.ClearSelection();
        }

        private void brefreshnas_Click(object sender, EventArgs e)
        {
            try
            {
                Thread input = new Thread(loadmemory);
                input.Start();
            }
            catch
            {
                Thread input = new Thread(loadmemory);
                input.Abort();
            }
        }

        private void loadmemory()
        {
            SetMemoryLoading(true);
            getstorage();

            SetMemoryLoading(false);
        }

        private void getstorage()
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(@"Z:\LABORATORY\Database\Laboratory Database");
                string dfile = d.ToString();

                if (Directory.Exists(dfile))
                {
                    FileInfo[] f = d.GetFiles("*", SearchOption.AllDirectories);
                    int dcount = d.GetDirectories().Length;

                    DriveInfo di = new DriveInfo("Z:/");
                    if (di.IsReady)
                    {
                        if (di.VolumeLabel.Length > 0)
                        {
                            string fsize = String.Format("{0:##.###}", di.AvailableFreeSpace / 1099511627776.0) + " TB";
                            string tsize = String.Format("{0:##.###}", di.TotalSize / 1099511627776.0) + " TB";

                            double dused = di.TotalSize - di.AvailableFreeSpace;
                            double uspace = dused / 1099511627776.0;

                            string usize = String.Format("{0:##.##}", uspace * 1024) + " GB";

                            lspace.Text = usize;
                            lvol.Text = usize + " used from " + tsize;

                            pbvol.Minimum = 0;
                            pbvol.Maximum = Convert.ToInt32((di.TotalSize / 1099511627776.0) * 1000);
                            pbvol.Value = Convert.ToInt32(uspace * 1000);
                        }
                        else
                        {
                            lspace.Text = "0 GB";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
            }
        }
        private void SetMemoryLoading(bool displayLoader)
        {
            if (displayLoader)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    pbmemoryloading.Visible = true;

                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    pbmemoryloading.Visible = false;

                });
            }
        }
    }
}
