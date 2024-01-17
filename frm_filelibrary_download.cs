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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    public partial class frm_filelibrary_download : Form
    {
        public frm_filelibrary_download()
        {
            InitializeComponent();
            tfilename.ReadOnly = true;
            pbloading.Visible = false;
            lpercent.Visible = false;
        }

        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        LoadingFunction load = new LoadingFunction();


        private void LoadFileDetails()
        {
            try
            {
                string fsn = frm_home_filelibrary.filecode;
                SqlCommand query = new SqlCommand("SELECT Serial_No, File_Name, Uploaded_by, Date_Uploaded, Document_Type, File_Path" +
                                                    " FROM tb_labdata WHERE Serial_No='" + fsn + "'", c);
                SqlDataAdapter dap = new SqlDataAdapter(query);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    lfsn.Text = dt.Rows[0][0].ToString();
                    tfilename.Text = dt.Rows[0][1].ToString();
                    luploaded.Text = dt.Rows[0][2].ToString();
                    ldateuploaded.Text = dt.Rows[0][3].ToString();
                    ldoctype.Text = dt.Rows[0][4].ToString();
                    tfileloc.Text = dt.Rows[0][5].ToString();
                }
                c.Open();
                query.ExecuteNonQuery();
                c.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("File Load Failed. \n" + ex.Message + "\n", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.Close();
            }
        }

        private void DownloadFile()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string serverpath = tfileloc.Text;
                string targetpath = @"C:\ERMS_Downloaded_Documents\";
                string fname = Path.GetFileName(serverpath);

                File.Copy(serverpath, targetpath + fname);
                bwcopy.RunWorkerAsync();
            }
            catch
            {
                MessageBox.Show("Download failed. Please check if there is a folder \n C:/ERMS_Downloaded_Documents/ in your computer.", "Folder path not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_filelibrary_download_Load(object sender, EventArgs e)
        {
            LoadFileDetails();
        }

        private void bwcopy_DoWork(object sender, DoWorkEventArgs e)
        {
            for (var i = 1; i <= 100; i++)
            {
                Thread.Sleep(10);
                bwcopy.WorkerReportsProgress = true;
                bwcopy.ReportProgress(i);
            }
        }

        private void bwcopy_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbloading.Value = e.ProgressPercentage;
            lpercent.Text = e.ProgressPercentage.ToString() + " %";
            if (lpercent.Text == "100 %")
            {
                MessageBox.Show("File successfuly downloaded! ", "Downloading Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pbloading.Visible = false;
                lpercent.Visible = false;
                this.Cursor = Cursors.Default;
                bdownload.Enabled = false;
                System.Diagnostics.Process.Start("C:\\ERMS_Downloaded_Documents");
            }
        }

        private void bdownload_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Download File?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pbloading.Visible = true;
                lpercent.Visible = true;
                DownloadFile();
            }
        }

        private void bcancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel Download File?", "Cancel Process", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lfsn.Text = "--";
                tfilename.Clear();
                luploaded.Text = "--";
                ldateuploaded.Text = "--";
                tfileloc.Text = "--";
                this.Hide();
            }
        }

        private void frm_filelibrary_download_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Cancel Download File?", "Cancel Process", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lfsn.Text = "fsnno";
                tfilename.Clear();
                luploaded.Text = "--";
                ldateuploaded.Text = "--";
                tfileloc.Text = "--";
                this.Hide();
            }
        }
    }
}
