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
    public partial class frm_home_upload : Form
    {
        public frm_home_upload()
        {
            InitializeComponent();

            terror.Visible = false;
            terror.Clear();
            loadparamlabres();
            loadparamcoc();
            loadparamdra();

            autocompleteltrcompname();
            autocompleteltradd();

            #region "DISABLE FIELDS"

            disablelabtestresult();
            disablecoc();
            disabledra();
            disablepr();
            disablememo();
            disablecabcert();
            #endregion

            #region "POPULATE DGV FOR FILE UPLOADS"

            popdgvfileslabtestresults();
            popdgvfilescoc();
            popdgvfilesdra();
            popdgvfilespr();
            popdgvfilesmemo();
            popdgvfilescabcert();
            #endregion

            #region "PERCENTS AND LOADING PANELS"

            pbloadinglabtresults.Visible = false;
            lpercentlabtresults.Visible = false;

            pbloadingcoc.Visible = false;
            lpercentcoc.Visible = false;

            pbloadingdraft.Visible = false;
            lpercentdraft.Visible = false;

            pbloadingpr.Visible = false;
            lpercentpr.Visible = false;

            pbloadingmemo.Visible = false;
            lpercentmemo.Visible = false;

            pbloadingcabcert.Visible = false;
            lpercentcabcert.Visible = false;
            #endregion
        }

        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        LoadingFunction load = new LoadingFunction();
        OpenFileDialog opd = new OpenFileDialog();

        DataTable dtlabtesresults = new DataTable();
        DataTable dtcoc = new DataTable();
        DataTable dtdra = new DataTable();
        DataTable dtpr = new DataTable();
        DataTable dtmemo = new DataTable();
        DataTable dtcabcert = new DataTable();

        DataRow drlabresult;
        DataRow drcoc;
        DataRow drdra;
        DataRow drpr;
        DataRow drmemo;
        DataRow drcabcert;
        
        public string sql;

        public string fpathlabresult;
        public string fpathcoc;
        public string fpathdra;
        public string fpathpr;
        public string fpathmemo;
        public string fpathcabcert;

        public string labresult = "LABORATORY TEST RESULT";
        public string coc = "CHAIN OF CUSTODY FORM (COC)";
        public string draft = "DRAFT RESULT OF ANALYSES";
        public string pr = "LABORATORY PR/RECEIPT";
        public string memo = "LABORATORY MEMO";
        public string cabcert = "LABORATORY CALIBRATION CERTIFICATE";

        private void frm_home_upload_Load(object sender, EventArgs e)
        {
            incrementFSNLABTESTRESULT();
            incrementFSNCOC();
            incrementFSNDRA();
            incrementFSNPR();
            incrementFSNMEMO();
            incrementFSNCABCERT();
        }

        private void bhelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "To upload a file: \n" +
        "1. Fill up all the necessary information for data profiling. \n\n" +
        "2. Check if there are violation to generate PAB Case Number automatically. \n\n" +
        "3. Please select Destination Folder First in order to process to file upload. \n\n" +
        "   Just click the folder icon. Also just right-click on the dialog if you want to create a folder. \n\n" +
        "4. Click the upload file button to upload a file. Please be reminded that you must insert one (1) file at a time to avoid errors in uploading. \n\n" +
        "5. Click the upload button to proceed. Wait for the Message to proceed to next upload.", "How to Upload a file?", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void brefresh_Click(object sender, EventArgs e)
        {
            load.Show(this);
            this.Cursor = Cursors.WaitCursor;
            Thread.Sleep(1000);

            incrementFSNLABTESTRESULT();
            incrementFSNCOC();
            incrementFSNDRA();
            incrementFSNPR();
            incrementFSNMEMO();
            incrementFSNCABCERT();

            #region "PERCENTS AND LOADING PANELS"

            pbloadinglabtresults.Visible = false;
            lpercentlabtresults.Visible = false;

            pbloadingcoc.Visible = false;
            lpercentcoc.Visible = false;

            pbloadingdraft.Visible = false;
            lpercentdraft.Visible = false;

            pbloadingpr.Visible = false;
            lpercentpr.Visible = false;

            pbloadingmemo.Visible = false;
            lpercentmemo.Visible = false;

            pbloadingcabcert.Visible = false;
            lpercentcabcert.Visible = false;
            #endregion

            load.Close();
            terror.Clear();
            terror.Visible = false;
            this.Cursor = Cursors.Default;
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            load.Show(this);
            this.Cursor = Cursors.WaitCursor;
            Thread.Sleep(1000);

            disablelabtestresult();
            disablecoc();
            disabledra();
            disablepr();
            disablememo();
            disablecabcert();

            #region "PERCENTS AND LOADING PANELS"

            pbloadinglabtresults.Visible = false;
            lpercentlabtresults.Visible = false;

            pbloadingcoc.Visible = false;
            lpercentcoc.Visible = false;

            pbloadingdraft.Visible = false;
            lpercentdraft.Visible = false;

            pbloadingpr.Visible = false;
            lpercentpr.Visible = false;

            pbloadingmemo.Visible = false;
            lpercentmemo.Visible = false;

            pbloadingcabcert.Visible = false;
            lpercentcabcert.Visible = false;
            #endregion

            load.Close();
            terror.Clear();
            terror.Visible = false;
            this.Cursor = Cursors.Default;
        }

        private void frm_home_upload_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Cancel File Uploading Process?", "Cancel Upload", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                disablelabtestresult();
                disablecoc();
                disabledra();
                disablepr();
                disablememo();
                disablecabcert();

                terror.Clear();
                terror.Visible = false;
            }
        }

        private void loadparamlabres() 
        {
            try
            {
                string q = "SELECT DISTINCT Parameter_Name FROM tb_input_parameters";
                SqlDataAdapter da = new SqlDataAdapter(q, c);
                DataTable dt = new DataTable();
                int i = da.Fill(dt);

                if (i > 0) 
                {
                    DataRow drow = dt.NewRow();
                    drow["Parameter_Name"] = "--select parameter--";
                    dt.Rows.InsertAt(drow, 0);

                    cbparamlabtresults.DisplayMember = "Parameter_Name";
                    cbparamlabtresults.ValueMember = "Parameter_Name";
                    cbparamlabtresults.DataSource = dt;

                    cbparamlabtresults.SelectedIndex = 0;
                    cbparamlabtresults.Items[0] = "--select parameter--";
                }
            }
            catch
            {
                //remove error message
            }
        }

        private void loadparamcoc()
        {
            try
            {
                string q = "SELECT DISTINCT Parameter_Name FROM tb_input_parameters";
                SqlDataAdapter da = new SqlDataAdapter(q, c);
                DataTable dt = new DataTable();
                int i = da.Fill(dt);

                if (i > 0)
                {
                    DataRow drow = dt.NewRow();
                    drow["Parameter_Name"] = "--select parameter--";
                    dt.Rows.InsertAt(drow, 0);

                    cbparamcoc.DisplayMember = "Parameter_Name";
                    cbparamcoc.ValueMember = "Parameter_Name";
                    cbparamcoc.DataSource = dt;

                    cbparamcoc.SelectedIndex = 0;
                    cbparamcoc.Items[0] = "--select parameter--";
                }
            }
            catch
            {
              //remove error message
            }
        }

        private void loadparamdra()
        {
            try
            {
                string q = "SELECT DISTINCT Parameter_Name FROM tb_input_parameters";
                SqlDataAdapter da = new SqlDataAdapter(q, c);
                DataTable dt = new DataTable();
                int i = da.Fill(dt);

                if (i > 0)
                {
                    DataRow drow = dt.NewRow();
                    drow["Parameter_Name"] = "--select parameter--";
                    dt.Rows.InsertAt(drow, 0);

                    cbparamdraft.DisplayMember = "Parameter_Name";
                    cbparamdraft.ValueMember = "Parameter_Name";
                    cbparamdraft.DataSource = dt;

                    cbparamdraft.SelectedIndex = 0;
                    cbparamdraft.Items[0] = "--select parameter--";
                }
            }
            catch
            {
                //remove error message
            }
        }

        private void autocompleteltrcompname() 
        {
            try
            {
                SqlCommand cm = new SqlCommand("SELECT Name_of_Firm FROM tb_lab_testresults", c);
                c.Open();
                SqlDataReader dr = cm.ExecuteReader();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    col.Add(dr.GetString(0));
                }
                tcompnamelabtresults.AutoCompleteCustomSource = col;
                c.Close();
            }
            catch (Exception ex)
            {
                terror.Visible = false;
                terror.Text = ex.Message;
            }
        }

        private void autocompleteltradd() 
        {
            try
            {
                SqlCommand cm = new SqlCommand("SELECT Address FROM tb_lab_testresults", c);
                c.Open();
                SqlDataReader dr = cm.ExecuteReader();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    col.Add(dr.GetString(0));
                }
                taddresslabtresults.AutoCompleteCustomSource = col;
                c.Close();
            }
            catch (Exception ex)
            {
                terror.Visible = false;
                terror.Text = ex.Message;
            }
        }

        #region "LAB TEST RESULT"
        ///============================================================================== Laboratory Test Results ===================================================================

        #region "DISABLE"
        private void disablelabtestresult() 
        {
            grplabtresults.Enabled = false;
            buploadlabtresults.Enabled = false;
            bcancellabtresults.Enabled = false;
            lpathlabtresults.Text = "Choose Folder";
            dgvfileslabtresults.DataSource = null;
            lnullrecordlabtresults.Visible = true;

            dtdatesamplinglabtresults.Value = DateTime.Now;
            dtdatereportlabtresults.Value = DateTime.Now;
            tcompnamelabtresults.Text = "";
            taddresslabtresults.Text = "";
        }
        #endregion

        #region "POPULATE DGV FILES"
        private void popdgvfileslabtestresults()
        {
            try
            {
                dtlabtesresults.Columns.Add("File Name");
                dtlabtesresults.Columns.Add("Size");
                dtlabtesresults.Columns.Add("Path");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Table for Lab Test Results load Failed.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "INCREMENT NOV-FSN"
        private void incrementFSNLABTESTRESULT() 
        {
            try
            {
                sql = "SELECT MAX(Serial_No) FROM tb_lab_testresults";
                SqlCommand cm = new SqlCommand(sql, c);
                c.Open();
                var maxno = cm.ExecuteScalar() as string;
                if (maxno == null)
                {
                    lfsnlabtresults.Text = "FSN-LTR-000001";
                }
                else
                {
                    int val = int.Parse(maxno.Substring(8, 6));
                    val++;
                    lfsnlabtresults.Text = String.Format("FSN-LTR-{0:000000}", val);
                }
                c.Close();
            }
            catch
            {
                c.Close();
            }
        }
        #endregion

        #region "SELECT FOLDER"
        private void selectfolder()
        {
            try
            {
                load.Show(this);
                Thread.Sleep(200);
                CustomFolderDialog cfd = new CustomFolderDialog("Please select a folder.", "Z:\\LABORATORY\\Database\\Laboratory Database");
                load.Close();

                if (cfd.ShowDialog() == DialogResult.OK)
                {
                    load.Show(this);
                    Thread.Sleep(200);

                    lpathlabtresults.Text = cfd.SelectedPath;
                    baddfilelabtresults.Enabled = true;
                    buploadlabtresults.Enabled = true;
                    load.Close();
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }
        #endregion

        #region "SELECT FILES TO UPLOAD"
        private void selectfile()
        {
            try
            {
                if (string.IsNullOrEmpty(lpathlabtresults.Text))
                {
                    MessageBox.Show("Please choose folder/directory first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    load.Show(this);
                    Thread.Sleep(200);
                    AddLabresultFiles();
                    lnullrecordlabtresults.Visible = false;
                    tusuccessltr.Visible = false;
                    load.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecting File Error. Check your settings", "Browse File Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
        #endregion

        #region "ADD FILE"
        private void AddLabresultFiles()
        {
            drlabresult = dtlabtesresults.NewRow();
            dgvfileslabtresults.DataSource = dtlabtesresults;

            opd.CheckFileExists = true;
            opd.CheckPathExists = true;
            opd.Multiselect = true;
            opd.Filter = "PDF Files (*.pdf)|*.pdf|All files (*.*)|*.*";
            opd.Title = "Select File";
            opd.FilterIndex = 1;

            if (opd.ShowDialog() == DialogResult.OK)
            {
                string[] selfiles = opd.SafeFileNames;
                FileInfo fi = new FileInfo(opd.FileName);
                string fullpath = fi.Name;

                string fsize = FileSize((int)fi.Length);
                foreach (string fnames in selfiles)
                {
                    drlabresult["File Name"] = fnames;
                    drlabresult["Size"] = fsize;
                    drlabresult["Path"] = fullpath;
                    dtlabtesresults.Rows.Add(drlabresult);

                    //dgvfileslabtresults.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dgvfileslabtresults.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                fpathlabresult = opd.FileName;
                buploadlabtresults.Enabled = true;
                opd.RestoreDirectory = true;
            }

            //dgvfileslabtresults.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvfileslabtresults.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            DataGridViewColumn col = dgvfileslabtresults.Columns[0];
            col.Width = 250;

            DataGridViewColumn col1 = dgvfileslabtresults.Columns[1];
            col1.Width = 80;

            DataGridViewColumn col2 = dgvfileslabtresults.Columns[2];
            col2.Width = 250;

            if (dgvfileslabtresults.Rows.Count > 1)
            {
                bhelplabtresults.Visible = true;
                buploadlabtresults.Enabled = false;
            }
            bcancellabtresults.Enabled = true;
        }
        #endregion

        #region "REMOVE SELECTED FILES TO DGV"
        private void removedgv()
        {
            try
            {
                foreach (DataGridViewCell oneCell in dgvfileslabtresults.SelectedCells)
                {
                    if (oneCell.Selected)
                    {
                        dgvfileslabtresults.Rows.RemoveAt(oneCell.RowIndex);
                    }
                    else
                    {
                        dgvfileslabtresults.Refresh();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No data to be deleted!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "UPLOAD ALL DATA VALUES"
        private void uploadlabtestresults() 
        {
            try 
            {
                this.Cursor = Cursors.WaitCursor;
                dgvfileslabtresults.RowHeadersVisible = false;
                Control.CheckForIllegalCrossThreadCalls = false;
                if (string.IsNullOrEmpty(tcompnamelabtresults.Text))
                {
                    MessageBox.Show("Please complete the necessary details.\n " +
                        "Company/Client Name is required.", "Complete required fields.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else 
                {
                    foreach (DataGridViewRow dgvrow in dgvfileslabtresults.Rows) 
                    {
                        DateTime dt = DateTime.Now;
                        string q = "INSERT INTO tb_lab_testresults (Serial_No, Name_of_Firm, Address, Date_of_Sampling, Parameters, Date_Reported, Attach_File, File_Date_Uploaded, Uploaded_by, File_Path, Document_Type)" +
                            "VALUES (@Serial_No, @Name_of_Firm, @Address, @Date_of_Sampling, @Parameters, @Date_Reported, @Attach_File, @File_Date_Uploaded, @Uploaded_by, @File_Path, @Document_Type)";

                        SqlCommand cm = new SqlCommand(q, c);

                        if (dgvrow.IsNewRow) continue;
                        {
                            cm.Parameters.AddWithValue("@Serial_No", lfsnlabtresults.Text);
                            cm.Parameters.AddWithValue("@Name_of_Firm", tcompnamelabtresults.Text);
                            cm.Parameters.AddWithValue("@Address", taddresslabtresults.Text);
                            cm.Parameters.AddWithValue("@Date_of_Sampling", dtdatesamplinglabtresults.Text);
                            cm.Parameters.AddWithValue("@Parameters",cbparamlabtresults.Text);
                            cm.Parameters.AddWithValue("@Date_Reported", dtdatereportlabtresults.Text);

                            cm.Parameters.AddWithValue("@File_Date_Uploaded", dt.ToString("MMM d yyyy h:mmtt"));
                            cm.Parameters.AddWithValue("@Uploaded_by", userdetails.uname);
                            cm.Parameters.AddWithValue("@Document_Type", labresult);

                            if (fpathlabresult == "")
                            {
                                cm.Parameters.AddWithValue("@Attach_File", "");
                                cm.Parameters.AddWithValue("@File_Path", "");
                            }
                            else 
                            {
                                cm.CommandType = CommandType.Text;
                                cm.Parameters.AddWithValue("@Attach_File", dgvrow.Cells["File Name"].Value ?? DBNull.Value);
                                cm.Parameters.AddWithValue("@File_Path", lpathlabtresults.Text + @"\" + dgvrow.Cells["Path"].Value);
                                File.Copy(fpathlabresult, Path.Combine(lpathlabtresults.Text, Path.GetFileName(dgvrow.Cells["Path"].Value.ToString())), true);
                            }
                            c.Open();
                            cm.ExecuteNonQuery();
                            if (bwltrloading == null)
                            {
                                bwltrloading.RunWorkerAsync();
                            }
                            else if (!bwltrloading.IsBusy) 
                            {
                                bwltrloading.RunWorkerAsync();
                            }
                            c.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }

        private void insertlabresultdata()
        {
            try
            {
                foreach (DataGridViewRow dgvrow in dgvfileslabtresults.Rows)
                {
                    DateTime dt = DateTime.Now;
                    string sql = "INSERT INTO tb_labdata (Serial_No, File_Name, Document_Type, Date_Uploaded, Uploaded_by, File_Path)" +
                    "VALUES (@Serial_No, @File_Name, @Document_Type, @Date_Uploaded, @Uploaded_by, @File_Path)";

                    SqlCommand cm = new SqlCommand(sql, c);

                    if (dgvrow.IsNewRow) continue;
                    {
                        cm.Parameters.AddWithValue("@Serial_No", lfsnlabtresults.Text);
                        cm.Parameters.AddWithValue("@Document_Type", labresult);
                        cm.Parameters.AddWithValue("@Date_Uploaded", dt.ToString("MMM d yyyy h:mmtt"));
                        cm.Parameters.AddWithValue("@Uploaded_by", userdetails.uname);

                        if (fpathlabresult == "")
                        {
                            cm.Parameters.AddWithValue("@File_Name", "");
                            cm.Parameters.AddWithValue("@File_Path", "");
                        }
                        else
                        {
                            cm.CommandType = CommandType.Text;
                            cm.Parameters.AddWithValue("@File_Name", dgvrow.Cells["File Name"].Value ?? DBNull.Value);
                            cm.Parameters.AddWithValue("@File_Path", lpathlabtresults.Text + @"\" + dgvrow.Cells["Path"].Value);
                        }
                        c.Open();
                        cm.ExecuteNonQuery();
                        c.Close();
                    }
                }      
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }

        private void filehistorylabresult()
        {
            try
            {
                FileInfo fi = new FileInfo(opd.FileName);
                string fsize = FileSize((int)fi.Length);
                string doc = "Laboratory Test Result";

                foreach (DataGridViewRow dgvrow in dgvfileslabtresults.Rows)
                {
                    SqlCommand cm = new SqlCommand("INSERT INTO tb_file_history(Date_Uploaded, User_Name, File_Name, Document_Type, File_Size, Accessed, Accessed_by)" +
                                                "VALUES (@Date_Uploaded, @User_Name, @File_Name, @Document_Type, @File_Size, @Accessed, @Accessed_by)", c);

                    cm.Parameters.AddWithValue("@Date_Uploaded", DateTime.Now.ToString("MMM d yyyy h:mmtt"));
                    cm.Parameters.AddWithValue("@User_Name", userdetails.uname);
                    cm.Parameters.AddWithValue("@Document_Type", doc);
                    cm.Parameters.AddWithValue("@Accessed", DateTime.Now.ToString("MMM d yyyy h:mmtt"));
                    cm.Parameters.AddWithValue("@Accessed_by", userdetails.uname);

                    if (fpathlabresult == "")
                    {
                        cm.Parameters.AddWithValue("@File_Name, @File_Size", "");
                    }
                    else
                    {
                        cm.CommandType = CommandType.Text;
                        cm.Parameters.AddWithValue("@File_Name", Path.GetFileName(opd.FileName));
                        cm.Parameters.AddWithValue("@File_Size", fsize);
                    }
                    c.Open();
                    cm.ExecuteNonQuery();
                    c.Close();
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }
        #endregion

        private void buploadlabtresults_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Upload Files?", "Upload Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                load.Show(this);
                Thread.Sleep(1000);
                pbloadinglabtresults.Visible = true;
                lpercentlabtresults.Visible = true;
                uploadlabtestresults();
                insertlabresultdata();
                filehistorylabresult();
                load.Close();
            }
        }

        private void bbrowselabtresults_Click(object sender, EventArgs e)
        {
            selectfolder();
        }

        private void baddfilelabtresults_Click(object sender, EventArgs e)
        {
            selectfile();
        }

        private void bremovelabtresults_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remove File?", "Remove upload", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                removedgv();
            }
        }

        private void bcancellabtresults_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel File Uploading Process?", "Cancel Upload", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bwltrloading.CancelAsync();
                pbloadinglabtresults.Visible = false;
                lpercentlabtresults.Visible = false;
                disablelabtestresult();
                removedgv();
                
                //this.Hide();
            }
        }

        private void bwltrloading_DoWork(object sender, DoWorkEventArgs e)
        {
            for (var i = 1; i <= 100; i++)
            {
                Thread.Sleep(10);
                bwltrloading.WorkerReportsProgress = true;
                bwltrloading.ReportProgress(i);
            }
        }

        private void bwltrloading_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbloadinglabtresults.Value = e.ProgressPercentage;
            lpercentlabtresults.Text = e.ProgressPercentage.ToString() + " %";
            if (lpercentlabtresults.Text == "100 %")
            {
                MessageBox.Show("File uploaded successfully! ", "Uploading Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
                c.Close();
                pbloadinglabtresults.Visible = false;
                lpercentlabtresults.Visible = false;

                load.Show(this);
                Thread.Sleep(1000);
                removedgv();
                dgvfileslabtresults.DataSource = null;
                lnullrecordlabtresults.Visible = true;
                incrementFSNLABTESTRESULT();
                tusuccessltr.Visible = true;
                load.Close();
            }
        }

        private void tcompnamelabtresults_TextChanged(object sender, EventArgs e)
        {
            grplabtresults.Enabled = true;
        }

        private void bhelplabtresults_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "To upload multiple files: \n" +
            "Please make sure that all files selected and highlighted. \n\n", "Select multiple files", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buploadlabtresults.Enabled = true;
        }


        ///============================================================================== Laboratory Test Results ===================================================================
        #endregion

        #region "COC"
        ///============================================================================== Chain of Custody (COC) ===================================================================

        #region "DISABLE COC"
        private void disablecoc() 
        {
            grpcoc.Enabled = false;
            buploadcoc.Enabled = false;
            bcancelcoc.Enabled = false;
            lfpathcoc.Text = "Choose Folder...";
            dgvfilescoc.DataSource = null;
            lnullrecordcoc.Visible = true;

            dtdatereccoc.Value = DateTime.Now;
            dtdatesamplingcoc.Value = DateTime.Now;
            tcompnamecoc.Text = "";
            taddresscoc.Text = "";
            trecbycoc.Text = "";
            tcocno.Text = "";
        }
        #endregion

        #region "POPULATE DGV FILES"
        private void popdgvfilescoc()
        {
            try
            {
                dtcoc.Columns.Add("File Name");
                dtcoc.Columns.Add("Size");
                dtcoc.Columns.Add("Path");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Table for COC load Failed.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "INCREMENT COC-FSN"
        private void incrementFSNCOC()
        {
            try
            {
                sql = "SELECT MAX(Serial_No) FROM tb_lab_coc";
                SqlCommand cm = new SqlCommand(sql, c);
                c.Open();
                var maxno = cm.ExecuteScalar() as string;
                if (maxno == null)
                {
                    lfsncoc.Text = "FSN-COC-000001";
                }
                else
                {
                    int val = int.Parse(maxno.Substring(8, 6));
                    val++;
                    lfsncoc.Text = String.Format("FSN-COC-{0:000000}", val);
                }
                c.Close();
            }
            catch
            {
                c.Close();
            }
        }
        #endregion

        #region "SELECT FOLDER"
        private void selectfoldercoc()
        {
            try
            {
                load.Show(this);
                Thread.Sleep(200);
                CustomFolderDialog cfd = new CustomFolderDialog("Please select a folder.", "Z:\\LABORATORY\\Database\\Laboratory Database");
                load.Close();

                if (cfd.ShowDialog() == DialogResult.OK)
                {
                    load.Show(this);
                    Thread.Sleep(200);

                    lfpathcoc.Text = cfd.SelectedPath;
                    baddfilecoc.Enabled = true;
                    buploadcoc.Enabled = true;
                    load.Close();
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }
        #endregion

        #region "SELECT FILES TO UPLOAD"
        private void selectfilecoc()
        {
            try
            {
                if (string.IsNullOrEmpty(lfpathcoc.Text))
                {
                    MessageBox.Show("Please choose folder/directory first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    load.Show(this);
                    Thread.Sleep(200);
                    AddCOCFiles();
                    lnullrecordcoc.Visible = false;
                    tusuccesscoc.Visible = true;
                    load.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecting File Error. Check your settings", "Browse File Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        #endregion

        #region "ADD FILE"
        private void AddCOCFiles()
        {
            drcoc = dtcoc.NewRow();
            dgvfilescoc.DataSource = dtcoc;

            opd.CheckFileExists = true;
            opd.CheckPathExists = true;
            opd.Multiselect = true;
            opd.Filter = "PDF Files (*.pdf)|*.pdf|All files (*.*)|*.*";
            opd.Title = "Select File";
            opd.FilterIndex = 1;

            if (opd.ShowDialog() == DialogResult.OK)
            {
                string[] selfiles = opd.SafeFileNames;
                FileInfo fi = new FileInfo(opd.FileName);
                string fullpath = fi.Name;

                string fsize = FileSize((int)fi.Length);
                foreach (string fnames in selfiles)
                {
                    drcoc["File Name"] = fnames;
                    drcoc["Size"] = fsize;
                    drcoc["Path"] = fullpath;
                    dtcoc.Rows.Add(drcoc);

                    //dgvfilescoc.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dgvfilescoc.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                fpathcoc = opd.FileName;
                buploadcoc.Enabled = true;
                opd.RestoreDirectory = true;
            }

            //dgvfilescoc.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvfilescoc.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            DataGridViewColumn col = dgvfilescoc.Columns[0];
            col.Width = 250;

            DataGridViewColumn col1 = dgvfilescoc.Columns[1];
            col1.Width = 80;

            DataGridViewColumn col2 = dgvfilescoc.Columns[2];
            col2.Width = 250;

            if (dgvfilescoc.Rows.Count > 1)
            {
                bhelpcoc.Visible = true;
                buploadcoc.Enabled = false;
            }
            bcancelcoc.Enabled = true;
        }
        #endregion

        #region "REMOVE SELECTED FILES TO DGV"
        private void removedgvcoc()
        {
            try
            {
                foreach (DataGridViewCell oneCell in dgvfilescoc.SelectedCells)
                {
                    if (oneCell.Selected)
                    {
                        dgvfilescoc.Rows.RemoveAt(oneCell.RowIndex);
                    }
                    else
                    {
                        dgvfilescoc.Refresh();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No data to be deleted!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "UPLOAD ALL DATA VALUES"
        private void uploadcoc()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
               
                dgvfilescoc.RowHeadersVisible = false;
                Control.CheckForIllegalCrossThreadCalls = false;
                if (string.IsNullOrEmpty(tcompnamecoc.Text))
                {
                    MessageBox.Show("Please complete the necessary details.\n " +
                        "Company/Client Name is required.", "Complete required fields.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    foreach (DataGridViewRow dgvrow in dgvfilescoc.Rows)
                    {
                        DateTime dt = DateTime.Now;
                        string q = "INSERT INTO tb_lab_coc (Serial_No, COC_No, Name_of_Firm, Address, Date_of_Sampling, Parameters, Received_by, Date_Received, Attach_File, File_Date_Uploaded, Uploaded_by, File_Path, Document_Type)" +
                            "VALUES (@Serial_No, @COC_No, @Name_of_Firm, @Address, @Date_of_Sampling, @Parameters, @Received_by, @Date_Received, @Attach_File, @File_Date_Uploaded, @Uploaded_by, @File_Path, @Document_Type)";

                        SqlCommand cm = new SqlCommand(q, c);

                        if (dgvrow.IsNewRow) continue;
                        {
                            cm.Parameters.AddWithValue("@Serial_No", lfsncoc.Text);
                            cm.Parameters.AddWithValue("@COC_No", tcocno.Text);
                            cm.Parameters.AddWithValue("@Name_of_Firm", tcompnamecoc.Text);
                            cm.Parameters.AddWithValue("@Address", taddresscoc.Text);
                            cm.Parameters.AddWithValue("@Date_of_Sampling", dtdatesamplingcoc.Text);
                            cm.Parameters.AddWithValue("@Parameters", cbparamcoc.Text);
                            cm.Parameters.AddWithValue("@Received_by", trecbycoc.Text);
                            cm.Parameters.AddWithValue("@Date_Received", dtdatereccoc.Text);
                            
                            cm.Parameters.AddWithValue("@File_Date_Uploaded", dt.ToString("MMM d yyyy h:mmtt"));
                            cm.Parameters.AddWithValue("@Uploaded_by", userdetails.uname);
                            cm.Parameters.AddWithValue("@Document_Type", coc);


                            if (fpathcoc == "")
                            {
                                cm.Parameters.AddWithValue("@Attach_File", "");
                                cm.Parameters.AddWithValue("@File_Path", "");
                            }
                            else
                            {
                                cm.CommandType = CommandType.Text;
                                cm.Parameters.AddWithValue("@Attach_File", dgvrow.Cells["File Name"].Value ?? DBNull.Value);
                                cm.Parameters.AddWithValue("@File_Path", lfpathcoc.Text + @"\" + dgvrow.Cells["Path"].Value);
                                File.Copy(fpathcoc, Path.Combine(lfpathcoc.Text, Path.GetFileName(dgvrow.Cells["Path"].Value.ToString())), true);
                            }
                            c.Open();
                            cm.ExecuteNonQuery();
                            if (bwcocloading == null)
                            {
                                bwcocloading.RunWorkerAsync();
                            }
                            else if (!bwcocloading.IsBusy)
                            {
                                bwcocloading.RunWorkerAsync();
                            }
                            c.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }

        private void insertcocdata()
        {
            try
            {
                foreach (DataGridViewRow dgvrow in dgvfilescoc.Rows)
                {
                    DateTime dt = DateTime.Now;
                    string sql = "INSERT INTO tb_labdata (Serial_No, File_Name, Document_Type, Date_Uploaded, Uploaded_by, File_Path)" +
                    "VALUES (@Serial_No, @File_Name, @Document_Type, @Date_Uploaded, @Uploaded_by, @File_Path)";

                    SqlCommand cm = new SqlCommand(sql, c);

                    if (dgvrow.IsNewRow) continue;
                    {
                        cm.Parameters.AddWithValue("@Serial_No", lfsncoc.Text);
                        cm.Parameters.AddWithValue("@Document_Type", coc);
                        cm.Parameters.AddWithValue("@Date_Uploaded", dt.ToString("MMM d yyyy h:mmtt"));
                        cm.Parameters.AddWithValue("@Uploaded_by", userdetails.uname);

                        if (fpathlabresult == "")
                        {
                            cm.Parameters.AddWithValue("@File_Name", "");
                            cm.Parameters.AddWithValue("@File_Path", "");
                        }
                        else
                        {
                            cm.CommandType = CommandType.Text;
                            cm.Parameters.AddWithValue("@File_Name", dgvrow.Cells["File Name"].Value ?? DBNull.Value);
                            cm.Parameters.AddWithValue("@File_Path", lfpathcoc.Text + @"\" + dgvrow.Cells["Path"].Value);
                        }
                        c.Open();
                        cm.ExecuteNonQuery();
                        c.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }

        private void filehistorycoc()
        {
            try
            {
                FileInfo fi = new FileInfo(opd.FileName);
                string fsize = FileSize((int)fi.Length);
                string doc = "COC";

                foreach (DataGridViewRow dgvrow in dgvfilescoc.Rows)
                {
                    SqlCommand cm = new SqlCommand("INSERT INTO tb_file_history(Date_Uploaded, User_Name, File_Name, Document_Type, File_Size, Accessed, Accessed_by)" +
                                                "VALUES (@Date_Uploaded, @User_Name, @File_Name, @Document_Type, @File_Size, @Accessed, @Accessed_by)", c);

                    cm.Parameters.AddWithValue("@Date_Uploaded", DateTime.Now.ToString("MMM d yyyy h:mmtt"));
                    cm.Parameters.AddWithValue("@User_Name", userdetails.uname);
                    cm.Parameters.AddWithValue("@Document_Type", doc);
                    cm.Parameters.AddWithValue("@Accessed", DateTime.Now.ToString("MMM d yyyy h:mmtt"));
                    cm.Parameters.AddWithValue("@Accessed_by", userdetails.uname);

                    if (fpathcoc == "")
                    {
                        cm.Parameters.AddWithValue("@File_Name, @File_Size", "");
                    }
                    else
                    {
                        cm.CommandType = CommandType.Text;
                        cm.Parameters.AddWithValue("@File_Name", Path.GetFileName(opd.FileName));
                        cm.Parameters.AddWithValue("@File_Size", fsize);
                    }
                    c.Open();
                    cm.ExecuteNonQuery();
                    c.Close();
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }

        #endregion

        private void buploadcoc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Upload Files?", "Upload Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                load.Show(this);
                Thread.Sleep(1000);
                pbloadingcoc.Visible = true;
                lpercentcoc.Visible = true;
                uploadcoc();
                insertcocdata();
                filehistorycoc();
                load.Close();
            }
        }

        private void bbrowsecoc_Click(object sender, EventArgs e)
        {
            selectfoldercoc();
        }

        private void baddfilecoc_Click(object sender, EventArgs e)
        {
            selectfilecoc();
        }

        private void bremovecoc_Click(object sender, EventArgs e)
        {
            removedgvcoc();
        }

        private void bhelpcoc_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "To upload multiple files: \n" +
            "Please make sure that all files selected and highlighted. \n\n", "Select multiple files", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buploadlabtresults.Enabled = true;
        }

        private void bcancelcoc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel File Uploading Process?", "Cancel Upload", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bwcocloading.CancelAsync();
                pbloadingcoc.Visible = false;
                lpercentcoc.Visible = false;

                disablecoc();
                removedgvcoc();
                //this.Hide();
            }
        }

        private void bwcocloading_DoWork(object sender, DoWorkEventArgs e)
        {
            for (var i = 1; i <= 100; i++)
            {
                Thread.Sleep(10);
                bwcocloading.WorkerReportsProgress = true;
                bwcocloading.ReportProgress(i);
            }
        }

        private void bwcocloading_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbloadingcoc.Value = e.ProgressPercentage;
            lpercentcoc.Text = e.ProgressPercentage.ToString() + " %";
            if (lpercentcoc.Text == "100 %")
            {
                MessageBox.Show("File uploaded successfully! ", "Uploading Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
                c.Close();
                pbloadingcoc.Visible = false;
                lpercentcoc.Visible = false;

                load.Show(this);
                Thread.Sleep(1000);
                removedgvcoc();
                dgvfilescoc.DataSource = null;
                lnullrecordcoc.Visible = true;
                disablecoc();
                incrementFSNCOC();
                tusuccesscoc.Visible = true;
                load.Close();
            }
        }

        private void tcompnamecoc_TextChanged(object sender, EventArgs e)
        {
            grpcoc.Enabled = true;
        }
        ///============================================================================== Chain of Custody (COC) ===================================================================
        #endregion

        #region "DRAFT RESULT OF ANALYSIS"
        ///============================================================================== DRAFT RESULT OF ANALYSES ===================================================================

        #region "DISABLE DRAFT RESULT OF ANALYSES"
        private void disabledra()
        {
            grpdraft.Enabled = false;
            buploaddraft.Enabled = false;
            bcanceldraft.Enabled = false;
            lfpathdraft.Text = "Choose Folder...";
            dgvfilesdraft.DataSource = null;
            lnullrecorddraft.Visible = true;

            tcompnamedraft.Text = "";
            taddressdraft.Text = "";
            tcocnodraft.Text = "";
        }
        #endregion

        #region "POPULATE DGV FILES"
        private void popdgvfilesdra()
        {
            try
            {
                dtdra.Columns.Add("File Name");
                dtdra.Columns.Add("Size");
                dtdra.Columns.Add("Path");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Table for Draft Result of Analyses load Failed.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "INCREMENT DRA-FSN"
        private void incrementFSNDRA()
        {
            try
            {
                sql = "SELECT MAX(Serial_No) FROM tb_lab_draftanalysis";
                SqlCommand cm = new SqlCommand(sql, c);
                c.Open();
                var maxno = cm.ExecuteScalar() as string;
                if (maxno == null)
                {
                    lfsndraft.Text = "FSN-DRA-000001";
                }
                else
                {
                    int val = int.Parse(maxno.Substring(8, 6));
                    val++;
                    lfsndraft.Text = String.Format("FSN-DRA-{0:000000}", val);
                }
                c.Close();
            }
            catch
            {
                c.Close();
            }
        }
        #endregion

        #region "SELECT FOLDER"
        private void selectfolderdra()
        {
            try
            {
                load.Show(this);
                Thread.Sleep(200);
                CustomFolderDialog cfd = new CustomFolderDialog("Please select a folder.", "Z:\\LABORATORY\\Database\\Laboratory Database");
                load.Close();

                if (cfd.ShowDialog() == DialogResult.OK)
                {
                    load.Show(this);
                    Thread.Sleep(200);

                    lfpathdraft.Text = cfd.SelectedPath;
                    baddfiledraft.Enabled = true;
                    buploaddraft.Enabled = true;
                    load.Close();
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }
        #endregion

        #region "SELECT FILES TO UPLOAD"
        private void selectfiledra()
        {
            try
            {
                if (string.IsNullOrEmpty(lfpathcoc.Text))
                {
                    MessageBox.Show("Please choose folder/directory first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    load.Show(this);
                    Thread.Sleep(200);
                    AddDRAFiles();
                    lnullrecorddraft.Visible = false;
                    tusuccessdra.Visible = false;
                    load.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecting File Error. Check your settings", "Browse File Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        #endregion

        #region "ADD FILE"
        private void AddDRAFiles()
        {
            drdra = dtdra.NewRow();
            dgvfilesdraft.DataSource = dtdra;

            opd.CheckFileExists = true;
            opd.CheckPathExists = true;
            opd.Multiselect = true;
            opd.Filter = "PDF Files (*.pdf)|*.pdf|All files (*.*)|*.*";
            opd.Title = "Select File";
            opd.FilterIndex = 1;

            if (opd.ShowDialog() == DialogResult.OK)
            {
                string[] selfiles = opd.SafeFileNames;
                FileInfo fi = new FileInfo(opd.FileName);
                string fullpath = fi.Name;

                string fsize = FileSize((int)fi.Length);
                foreach (string fnames in selfiles)
                {
                    drdra["File Name"] = fnames;
                    drdra["Size"] = fsize;
                    drdra["Path"] = fullpath;
                    dtdra.Rows.Add(drdra);

                    //dgvfilesdraft.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dgvfilesdraft.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                fpathdra = opd.FileName;
                buploaddraft.Enabled = true;
                opd.RestoreDirectory = true;
            }

            //dgvfilesdraft.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvfilesdraft.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            DataGridViewColumn col = dgvfilesdraft.Columns[0];
            col.Width = 250;

            DataGridViewColumn col1 = dgvfilesdraft.Columns[1];
            col1.Width = 80;

            DataGridViewColumn col2 = dgvfilesdraft.Columns[2];
            col2.Width = 250;

            if (dgvfilesdraft.Rows.Count > 1)
            {
                bhelpdraft.Visible = true;
                buploaddraft.Enabled = false;
            }
            bcanceldraft.Enabled = true;
        }
        #endregion

        #region "REMOVE SELECTED FILES TO DGV"
        private void removedgvdra()
        {
            try
            {
                foreach (DataGridViewCell oneCell in dgvfilesdraft.SelectedCells)
                {
                    if (oneCell.Selected)
                    {
                        dgvfilesdraft.Rows.RemoveAt(oneCell.RowIndex);
                    }
                    else
                    {
                        dgvfilesdraft.Refresh();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No data to be deleted!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "UPLOAD ALL DATA VALUES"
        private void uploaddra()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
               
                dgvfilesdraft.RowHeadersVisible = false;
                Control.CheckForIllegalCrossThreadCalls = false;
                if (string.IsNullOrEmpty(tcompnamedraft.Text))
                {
                    MessageBox.Show("Please complete the necessary details.\n " +
                        "Company/Client Name is required.", "Complete required fields.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    foreach (DataGridViewRow dgvrow in dgvfilesdraft.Rows)
                    {
                        DateTime dt = DateTime.Now;
                        string q = "INSERT INTO tb_lab_draftanalysis (Serial_No, COC_No, Name_of_Firm, Address, Parameters, Attach_File, File_Date_Uploaded, Uploaded_by, File_Path, Document_Type)" +
                            "VALUES (@Serial_No, @COC_No, @Name_of_Firm, @Address, @Parameters, @Attach_File, @File_Date_Uploaded, @Uploaded_by, @File_Path, @Document_Type)";

                        SqlCommand cm = new SqlCommand(q, c);

                        if (dgvrow.IsNewRow) continue;
                        {
                            cm.Parameters.AddWithValue("@Serial_No", lfsndraft.Text);
                            cm.Parameters.AddWithValue("@COC_No", tcocnodraft.Text);
                            cm.Parameters.AddWithValue("@Name_of_Firm", tcompnamedraft.Text);
                            cm.Parameters.AddWithValue("@Address", taddressdraft.Text);
                            cm.Parameters.AddWithValue("@Parameters", cbparamdraft.Text);
                           
                            cm.Parameters.AddWithValue("@File_Date_Uploaded", dt.ToString("MMM d yyyy h:mmtt"));
                            cm.Parameters.AddWithValue("@Uploaded_by", userdetails.uname);
                            cm.Parameters.AddWithValue("@Document_Type", draft);

                            if (fpathdra == "")
                            {
                                cm.Parameters.AddWithValue("@Attach_File", "");
                                cm.Parameters.AddWithValue("@File_Path", "");
                            }
                            else
                            {
                                cm.CommandType = CommandType.Text;
                                cm.Parameters.AddWithValue("@Attach_File", dgvrow.Cells["File Name"].Value ?? DBNull.Value);
                                cm.Parameters.AddWithValue("@File_Path", lfpathdraft.Text + @"\" + dgvrow.Cells["Path"].Value);
                                File.Copy(fpathdra, Path.Combine(lfpathdraft.Text, Path.GetFileName(dgvrow.Cells["Path"].Value.ToString())), true);
                            }
                            c.Open();
                            cm.ExecuteNonQuery();
                            if (bwdraloading == null)
                            {
                                bwdraloading.RunWorkerAsync();
                            }
                            else if (!bwdraloading.IsBusy)
                            {
                                bwdraloading.RunWorkerAsync();
                            }
                            c.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }

        private void insertdradata()
        {
            try
            {
                foreach (DataGridViewRow dgvrow in dgvfilesdraft.Rows)
                {
                    DateTime dt = DateTime.Now;
                    string sql = "INSERT INTO tb_labdata (Serial_No, File_Name, Document_Type, Date_Uploaded, Uploaded_by, File_Path)" +
                    "VALUES (@Serial_No, @File_Name, @Document_Type, @Date_Uploaded, @Uploaded_by, @File_Path)";

                    SqlCommand cm = new SqlCommand(sql, c);

                    if (dgvrow.IsNewRow) continue;
                    {
                        cm.Parameters.AddWithValue("@Serial_No", lfsndraft.Text);
                        cm.Parameters.AddWithValue("@Document_Type", draft);
                        cm.Parameters.AddWithValue("@Date_Uploaded", dt.ToString("MMM d yyyy h:mmtt"));
                        cm.Parameters.AddWithValue("@Uploaded_by", userdetails.uname);

                        if (fpathlabresult == "")
                        {
                            cm.Parameters.AddWithValue("@File_Name", "");
                            cm.Parameters.AddWithValue("@File_Path", "");
                        }
                        else
                        {
                            cm.CommandType = CommandType.Text;
                            cm.Parameters.AddWithValue("@File_Name", dgvrow.Cells["File Name"].Value ?? DBNull.Value);
                            cm.Parameters.AddWithValue("@File_Path", lfpathdraft.Text + @"\" + dgvrow.Cells["Path"].Value);
                        }
                        c.Open();
                        cm.ExecuteNonQuery();
                        c.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }

        private void filehistorydra()
        {
            try
            {
                FileInfo fi = new FileInfo(opd.FileName);
                string fsize = FileSize((int)fi.Length);
                string doc = "Draft Result Analysis";

                foreach (DataGridViewRow dgvrow in dgvfilesdraft.Rows)
                {
                    SqlCommand cm = new SqlCommand("INSERT INTO tb_file_history(Date_Uploaded, User_Name, File_Name, Document_Type, File_Size, Accessed, Accessed_by)" +
                                                "VALUES (@Date_Uploaded, @User_Name, @File_Name, @Document_Type, @File_Size, @Accessed, @Accessed_by)", c);

                    cm.Parameters.AddWithValue("@Date_Uploaded", DateTime.Now.ToString("MMM d yyyy h:mmtt"));
                    cm.Parameters.AddWithValue("@User_Name", userdetails.uname);
                    cm.Parameters.AddWithValue("@Document_Type", doc);
                    cm.Parameters.AddWithValue("@Accessed", DateTime.Now.ToString("MMM d yyyy h:mmtt"));
                    cm.Parameters.AddWithValue("@Accessed_by", userdetails.uname);

                    if (fpathdra == "")
                    {
                        cm.Parameters.AddWithValue("@File_Name, @File_Size", "");
                    }
                    else
                    {
                        cm.CommandType = CommandType.Text;
                        cm.Parameters.AddWithValue("@File_Name", Path.GetFileName(opd.FileName));
                        cm.Parameters.AddWithValue("@File_Size", fsize);
                    }
                    c.Open();
                    cm.ExecuteNonQuery();
                    c.Close();
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }

        #endregion

        private void buploaddraft_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Upload Files?", "Upload Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                load.Show(this);
                Thread.Sleep(1000);
                pbloadingdraft.Visible = true;
                lpercentdraft.Visible = true;
                uploaddra();
                insertdradata();
                filehistorydra();
                load.Close();
            }
        }

        private void bbrowsedraft_Click(object sender, EventArgs e)
        {
            selectfolderdra();
        }

        private void baddfiledraft_Click(object sender, EventArgs e)
        {
            selectfiledra();
        }

        private void bremovedraft_Click(object sender, EventArgs e)
        {
            removedgvdra();
        }

        private void bhelpdraft_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
          "To upload multiple files: \n" +
          "Please make sure that all files selected and highlighted. \n\n", "Select multiple files", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buploaddraft.Enabled = true;
        }

        private void bcanceldraft_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel File Uploading Process?", "Cancel Upload", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bwdraloading.CancelAsync();
                pbloadingdraft.Visible = false;
                lpercentdraft.Visible = false;

                disabledra();
                removedgvdra();
                //this.Hide();
            }
        }

        private void bwdraloading_DoWork(object sender, DoWorkEventArgs e)
        {
            for (var i = 1; i <= 100; i++)
            {
                Thread.Sleep(10);
                bwdraloading.WorkerReportsProgress = true;
                bwdraloading.ReportProgress(i);
            }
        }

        private void bwdraloading_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbloadingdraft.Value = e.ProgressPercentage;
            lpercentdraft.Text = e.ProgressPercentage.ToString() + " %";
            if (lpercentdraft.Text == "100 %")
            {
                MessageBox.Show("File uploaded successfully! ", "Uploading Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
                c.Close();
                pbloadingdraft.Visible = false;
                lpercentdraft.Visible = false;

                load.Show(this);
                Thread.Sleep(1000);
                removedgvdra();
                dgvfilesdraft.DataSource = null;
                lnullrecorddraft.Visible = true;
                disabledra();
                incrementFSNDRA();
                tusuccessdra.Visible = true;
                load.Close();
            }
        }

        private void tcompnamedraft_TextChanged(object sender, EventArgs e)
        {
            grpdraft.Enabled = true;
        }

        ///============================================================================== DRAFT RESULT OF ANALYSES ===================================================================
        #endregion

        #region "LAB PR/RECEIPTS"
        ///============================================================================== LAB PR/RECEIPTS ===================================================================

        #region "DISABLE DRAFT RESULT OF ANALYSES"
        private void disablepr()
        {
            grppr.Enabled = false;
            buploadpr.Enabled = false;
            bcancelpr.Enabled = false;
            lfpathpr.Text = "Choose Folder...";
            dgvfilespr.DataSource = null;
            lnullrecordpr.Visible = true;

            tprno.Text = "";
            tprsubject.Text = "";
        }
        #endregion

        #region "POPULATE DGV FILES"
        private void popdgvfilespr()
        {
            try
            {
                dtpr.Columns.Add("File Name");
                dtpr.Columns.Add("Size");
                dtpr.Columns.Add("Path");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Table for Laboratory Receipts load Failed.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "INCREMENT LPR-FSN"
        private void incrementFSNPR()
        {
            try
            {
                sql = "SELECT MAX(Serial_No) FROM tb_lab_receipt";
                SqlCommand cm = new SqlCommand(sql, c);
                c.Open();
                var maxno = cm.ExecuteScalar() as string;
                if (maxno == null)
                {
                    lfsnpr.Text = "FSN-LPR-000001";
                }
                else
                {
                    int val = int.Parse(maxno.Substring(8, 6));
                    val++;
                    lfsnpr.Text = String.Format("FSN-LPR-{0:000000}", val);
                }
                c.Close();
            }
            catch
            {
                c.Close();
            }
        }
        #endregion

        #region "SELECT FOLDER"
        private void selectfolderpr()
        {
            try
            {
                load.Show(this);
                Thread.Sleep(200);
                CustomFolderDialog cfd = new CustomFolderDialog("Please select a folder.", "Z:\\LABORATORY\\Database\\Laboratory Database");
                load.Close();

                if (cfd.ShowDialog() == DialogResult.OK)
                {
                    load.Show(this);
                    Thread.Sleep(200);

                    lfpathpr.Text = cfd.SelectedPath;
                    baddfilepr.Enabled = true;
                    buploadpr.Enabled = true;
                    load.Close();
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }
        #endregion

        #region "SELECT FILES TO UPLOAD"
        private void selectfilepr()
        {
            try
            {
                if (string.IsNullOrEmpty(lfpathpr.Text))
                {
                    MessageBox.Show("Please choose folder/directory first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    load.Show(this);
                    Thread.Sleep(200);
                    AddPRFiles();
                    lnullrecordpr.Visible = false;
                    tusuccesspr.Visible = false;
                    load.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecting File Error. Check your settings", "Browse File Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        #endregion

        #region "ADD FILE"
        private void AddPRFiles()
        {
            drpr = dtpr.NewRow();
            dgvfilespr.DataSource = dtpr;

            opd.CheckFileExists = true;
            opd.CheckPathExists = true;
            opd.Multiselect = true;
            opd.Filter = "PDF Files (*.pdf)|*.pdf|All files (*.*)|*.*";
            opd.Title = "Select File";
            opd.FilterIndex = 1;

            if (opd.ShowDialog() == DialogResult.OK)
            {
                string[] selfiles = opd.SafeFileNames;
                FileInfo fi = new FileInfo(opd.FileName);
                string fullpath = fi.Name;

                string fsize = FileSize((int)fi.Length);
                foreach (string fnames in selfiles)
                {
                    drpr["File Name"] = fnames;
                    drpr["Size"] = fsize;
                    drpr["Path"] = fullpath;
                    dtpr.Rows.Add(drpr);

                    //dgvfilespr.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dgvfilespr.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                fpathpr = opd.FileName;
                buploadpr.Enabled = true;
                opd.RestoreDirectory = true;
            }

            //dgvfilespr.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvfilespr.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            DataGridViewColumn col = dgvfilespr.Columns[0];
            col.Width = 250;

            DataGridViewColumn col1 = dgvfilespr.Columns[1];
            col1.Width = 80;

            DataGridViewColumn col2 = dgvfilespr.Columns[2];
            col2.Width = 250;

            if (dgvfilespr.Rows.Count > 1)
            {
                bhelppr.Visible = true;
                buploadpr.Enabled = false;
            }
            bcancelpr.Enabled = true;
        }
        #endregion

        #region "REMOVE SELECTED FILES TO DGV"
        private void removedgvpr()
        {
            try
            {
                foreach (DataGridViewCell oneCell in dgvfilespr.SelectedCells)
                {
                    if (oneCell.Selected)
                    {
                        dgvfilespr.Rows.RemoveAt(oneCell.RowIndex);
                    }
                    else
                    {
                        dgvfilespr.Refresh();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No data to be deleted!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "UPLOAD ALL DATA VALUES"
        private void uploadpr()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                dgvfilespr.RowHeadersVisible = false;
                Control.CheckForIllegalCrossThreadCalls = false;
                if (string.IsNullOrEmpty(tprsubject.Text))
                {
                    MessageBox.Show("Please complete the necessary details.\n " +
                        "Receipt Subject is required.", "Complete required fields.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    foreach (DataGridViewRow dgvrow in dgvfilespr.Rows)
                    {
                        DateTime dt = DateTime.Now;
                        string q = "INSERT INTO tb_lab_receipt (Serial_No, OR_PR_Number, Subject, OR_Date, Attach_File, File_Date_Uploaded, Uploaded_by, File_Path, Document_Type)" +
                            "VALUES (@Serial_No, @OR_PR_Number, @Subject, @OR_Date, @Attach_File, @File_Date_Uploaded, @Uploaded_by, @File_Path, @Document_Type)";

                        SqlCommand cm = new SqlCommand(q, c);

                        if (dgvrow.IsNewRow) continue;
                        {
                            cm.Parameters.AddWithValue("@Serial_No", lfsnpr.Text);
                            cm.Parameters.AddWithValue("@OR_PR_Number", tprno.Text);
                            cm.Parameters.AddWithValue("@Subject", tprsubject.Text);
                            cm.Parameters.AddWithValue("@OR_Date", dtdatepr.Text);

                            cm.Parameters.AddWithValue("@File_Date_Uploaded", dt.ToString("MMM d yyyy h:mmtt"));
                            cm.Parameters.AddWithValue("@Uploaded_by", userdetails.uname);
                            cm.Parameters.AddWithValue("@Document_Type", pr);

                            if (fpathpr == "")
                            {
                                cm.Parameters.AddWithValue("@Attach_File", "");
                                cm.Parameters.AddWithValue("@File_Path", "");
                            }
                            else
                            {
                                cm.CommandType = CommandType.Text;
                                cm.Parameters.AddWithValue("@Attach_File", dgvrow.Cells["File Name"].Value ?? DBNull.Value);
                                cm.Parameters.AddWithValue("@File_Path", lfpathpr.Text + @"\" + dgvrow.Cells["Path"].Value);
                                File.Copy(fpathpr, Path.Combine(lfpathpr.Text, Path.GetFileName(dgvrow.Cells["Path"].Value.ToString())), true);
                            }
                            c.Open();
                            cm.ExecuteNonQuery();
                            if (bwprloading == null)
                            {
                                bwprloading.RunWorkerAsync();
                            }
                            else if (!bwprloading.IsBusy)
                            {
                                bwprloading.RunWorkerAsync();
                            }
                            c.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }

        private void insertprdata()
        {
            try
            {
                foreach (DataGridViewRow dgvrow in dgvfilespr.Rows)
                {
                    DateTime dt = DateTime.Now;
                    string sql = "INSERT INTO tb_labdata (Serial_No, File_Name, Document_Type, Date_Uploaded, Uploaded_by, File_Path)" +
                    "VALUES (@Serial_No, @File_Name, @Document_Type, @Date_Uploaded, @Uploaded_by, @File_Path)";

                    SqlCommand cm = new SqlCommand(sql, c);

                    if (dgvrow.IsNewRow) continue;
                    {
                        cm.Parameters.AddWithValue("@Serial_No", lfsnpr.Text);
                        cm.Parameters.AddWithValue("@Document_Type", pr);
                        cm.Parameters.AddWithValue("@Date_Uploaded", dt.ToString("MMM d yyyy h:mmtt"));
                        cm.Parameters.AddWithValue("@Uploaded_by", userdetails.uname);

                        if (fpathlabresult == "")
                        {
                            cm.Parameters.AddWithValue("@File_Name", "");
                            cm.Parameters.AddWithValue("@File_Path", "");
                        }
                        else
                        {
                            cm.CommandType = CommandType.Text;
                            cm.Parameters.AddWithValue("@File_Name", dgvrow.Cells["File Name"].Value ?? DBNull.Value);
                            cm.Parameters.AddWithValue("@File_Path", lfpathpr.Text + @"\" + dgvrow.Cells["Path"].Value);
                        }
                        c.Open();
                        cm.ExecuteNonQuery();
                        c.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }

        private void filehistoryprdata()
        {
            try
            {
                FileInfo fi = new FileInfo(opd.FileName);
                string fsize = FileSize((int)fi.Length);
                string doc = "Laboratory PR/Receipt";

                foreach (DataGridViewRow dgvrow in dgvfilespr.Rows)
                {
                    SqlCommand cm = new SqlCommand("INSERT INTO tb_file_history(Date_Uploaded, User_Name, File_Name, Document_Type, File_Size, Accessed, Accessed_by)" +
                                                "VALUES (@Date_Uploaded, @User_Name, @File_Name, @Document_Type, @File_Size, @Accessed, @Accessed_by)", c);

                    cm.Parameters.AddWithValue("@Date_Uploaded", DateTime.Now);
                    cm.Parameters.AddWithValue("@User_Name", userdetails.uname);
                    cm.Parameters.AddWithValue("@Document_Type", doc);
                    cm.Parameters.AddWithValue("@Accessed", DateTime.Now.ToString("MMM d yyyy h:mmtt"));
                    cm.Parameters.AddWithValue("@Accessed_by", userdetails.uname);

                    if (fpathpr == "")
                    {
                        cm.Parameters.AddWithValue("@File_Name, @File_Size", "");
                    }
                    else
                    {
                        cm.CommandType = CommandType.Text;
                        cm.Parameters.AddWithValue("@File_Name", Path.GetFileName(opd.FileName));
                        cm.Parameters.AddWithValue("@File_Size", fsize);
                    }
                    c.Open();
                    cm.ExecuteNonQuery();
                    c.Close();
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }

        #endregion

        private void tprsubject_TextChanged(object sender, EventArgs e)
        {
            grppr.Enabled = true;
        }

        private void buploadpr_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Upload Files?", "Upload Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                load.Show(this);
                Thread.Sleep(1000);
                pbloadingpr.Visible = true;
                lpercentpr.Visible = true;
                uploadpr();
                insertprdata();
                filehistoryprdata();
                load.Close();
            }
        }

        private void bbrowsepr_Click(object sender, EventArgs e)
        {
            selectfolderpr();
        }

        private void baddfilepr_Click(object sender, EventArgs e)
        {
            selectfilepr();
        }

        private void bremovepr_Click(object sender, EventArgs e)
        {
            removedgvpr();
        }

        private void bhelppr_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
         "To upload multiple files: \n" +
         "Please make sure that all files selected and highlighted. \n\n", "Select multiple files", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buploadpr.Enabled = true;
        }

        private void bcancelpr_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel File Uploading Process?", "Cancel Upload", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bwprloading.CancelAsync();
                pbloadingpr.Visible = false;
                lpercentpr.Visible = false;

                disablepr();
                removedgvpr();
                //this.Hide();
            }
        }

        private void bwprloading_DoWork(object sender, DoWorkEventArgs e)
        {
            for (var i = 1; i <= 100; i++)
            {
                Thread.Sleep(10);
                bwprloading.WorkerReportsProgress = true;
                bwprloading.ReportProgress(i);
            }
        }

        private void bwprloading_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbloadingpr.Value = e.ProgressPercentage;
            lpercentpr.Text = e.ProgressPercentage.ToString() + " %";
            if (lpercentpr.Text == "100 %")
            {
                MessageBox.Show("File uploaded successfully! ", "Uploading Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
                c.Close();
                pbloadingpr.Visible = false;
                lpercentpr.Visible = false;

                load.Show(this);
                Thread.Sleep(1000);
                removedgvpr();
                dgvfilespr.DataSource = null;
                lnullrecordpr.Visible = true;
                disablepr();
                incrementFSNPR();
                tusuccesspr.Visible = true;
                load.Close();
            }
        }

        ///============================================================================== LAB PR/RECEIPTS ===================================================================
        #endregion

        #region "LABORATORY MEMO"
        ///============================================================================== LAB MEMO ===================================================================

        #region "DISABLE DRAFT RESULT OF ANALYSES"
        private void disablememo()
        {
            grpmemo.Enabled = false;
            buploadmemo.Enabled = false;
            bcancelmemo.Enabled = false;
            lfpathmemo.Text = "Choose Folder...";
            dgvfilesmemo.DataSource = null;
            lnullrecordmemo.Visible = true;

            tsubjectmemo.Text = "";
        }
        #endregion

        #region "POPULATE DGV FILES"
        private void popdgvfilesmemo()
        {
            try
            {
                dtmemo.Columns.Add("File Name");
                dtmemo.Columns.Add("Size");
                dtmemo.Columns.Add("Path");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Table for Laboratory Memo load Failed.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "INCREMENT MEMO-FSN"
        private void incrementFSNMEMO()
        {
            try
            {
                sql = "SELECT MAX(Serial_No) FROM tb_lab_memo";
                SqlCommand cm = new SqlCommand(sql, c);
                c.Open();
                var maxno = cm.ExecuteScalar() as string;
                if (maxno == null)
                {
                    lfsnmemo.Text = "FSN-MEMO-000001";
                }
                else
                {
                    int val = int.Parse(maxno.Substring(9, 6));
                    val++;
                    lfsnmemo.Text = String.Format("FSN-MEMO-{0:000000}", val);
                }
                c.Close();
            }
            catch
            {
                c.Close();
            }
        }
        #endregion

        #region "SELECT FOLDER"
        private void selectfoldermemo()
        {
            try
            {
                load.Show(this);
                Thread.Sleep(200);
                CustomFolderDialog cfd = new CustomFolderDialog("Please select a folder.", "Z:\\LABORATORY\\Database\\Laboratory Database");
                load.Close();

                if (cfd.ShowDialog() == DialogResult.OK)
                {
                    load.Show(this);
                    Thread.Sleep(200);

                    lfpathmemo.Text = cfd.SelectedPath;
                    baddfilememo.Enabled = true;
                    buploadmemo.Enabled = true;
                    load.Close();
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }
        #endregion

        #region "SELECT FILES TO UPLOAD"
        private void selectfilememo()
        {
            try
            {
                if (string.IsNullOrEmpty(lfpathmemo.Text))
                {
                    MessageBox.Show("Please choose folder/directory first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    load.Show(this);
                    Thread.Sleep(200);
                    AddMEMOFiles();
                    lnullrecordmemo.Visible = false;
                    tusuccessmemo.Visible = false;
                    load.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecting File Error. Check your settings", "Browse File Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        #endregion

        #region "ADD FILE"
        private void AddMEMOFiles()
        {
            drmemo = dtmemo.NewRow();
            dgvfilesmemo.DataSource = dtmemo;

            opd.CheckFileExists = true;
            opd.CheckPathExists = true;
            opd.Multiselect = true;
            opd.Filter = "PDF Files (*.pdf)|*.pdf|All files (*.*)|*.*";
            opd.Title = "Select File";
            opd.FilterIndex = 1;

            if (opd.ShowDialog() == DialogResult.OK)
            {
                string[] selfiles = opd.SafeFileNames;
                FileInfo fi = new FileInfo(opd.FileName);
                string fullpath = fi.Name;

                string fsize = FileSize((int)fi.Length);
                foreach (string fnames in selfiles)
                {
                    drmemo["File Name"] = fnames;
                    drmemo["Size"] = fsize;
                    drmemo["Path"] = fullpath;
                    dtmemo.Rows.Add(drmemo);

                    //dgvfilesmemo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dgvfilesmemo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                fpathmemo = opd.FileName;
                buploadmemo.Enabled = true;
                opd.RestoreDirectory = true;
            }

            //dgvfilesmemo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvfilesmemo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            DataGridViewColumn col = dgvfilesmemo.Columns[0];
            col.Width = 250;

            DataGridViewColumn col1 = dgvfilesmemo.Columns[1];
            col1.Width = 80;

            DataGridViewColumn col2 = dgvfilesmemo.Columns[2];
            col2.Width = 250;

            if (dgvfilesmemo.Rows.Count > 1)
            {
                bhelpmemo.Visible = true;
                buploadmemo.Enabled = false;
            }
            bcancelmemo.Enabled = true;
        }
        #endregion

        #region "REMOVE SELECTED FILES TO DGV"
        private void removedgvmemo()
        {
            try
            {
                foreach (DataGridViewCell oneCell in dgvfilesmemo.SelectedCells)
                {
                    if (oneCell.Selected)
                    {
                        dgvfilesmemo.Rows.RemoveAt(oneCell.RowIndex);
                    }
                    else
                    {
                        dgvfilesmemo.Refresh();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No data to be deleted!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "UPLOAD ALL DATA VALUES"
        private void uploadmemo()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                
                dgvfilesmemo.RowHeadersVisible = false;
                Control.CheckForIllegalCrossThreadCalls = false;
                if (string.IsNullOrEmpty(tsubjectmemo.Text))
                {
                    MessageBox.Show("Please complete the necessary details.\n " +
                        "Memo Subject is required.", "Complete required fields.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    foreach (DataGridViewRow dgvrow in dgvfilesmemo.Rows)
                    {
                        DateTime dt = DateTime.Now;
                        string q = "INSERT INTO tb_lab_memo (Serial_No, Memo_Subject, Date, Attach_File, File_Date_Uploaded, Uploaded_by, File_Path, Document_Type)" +
                            "VALUES (@Serial_No, @Memo_Subject, @Date, @Attach_File, @File_Date_Uploaded, @Uploaded_by, @File_Path, @Document_Type)";

                        SqlCommand cm = new SqlCommand(q, c);

                        if (dgvrow.IsNewRow) continue;
                        {
                            cm.Parameters.AddWithValue("@Serial_No", lfsnmemo.Text);
                            cm.Parameters.AddWithValue("@Memo_Subject", tsubjectmemo.Text);
                            cm.Parameters.AddWithValue("@Date", dtdatememo.Text);

                            cm.Parameters.AddWithValue("@File_Date_Uploaded", dt.ToString("MMM d yyyy h:mmtt"));
                            cm.Parameters.AddWithValue("@Uploaded_by", userdetails.uname);
                            cm.Parameters.AddWithValue("@Document_Type", memo);

                            if (fpathmemo == "")
                            {
                                cm.Parameters.AddWithValue("@Attach_File", "");
                                cm.Parameters.AddWithValue("@File_Path", "");
                            }
                            else
                            {
                                cm.CommandType = CommandType.Text;
                                cm.Parameters.AddWithValue("@Attach_File", dgvrow.Cells["File Name"].Value ?? DBNull.Value);
                                cm.Parameters.AddWithValue("@File_Path", lfpathmemo.Text + @"\" + dgvrow.Cells["Path"].Value);
                                File.Copy(fpathmemo, Path.Combine(lfpathmemo.Text, Path.GetFileName(dgvrow.Cells["Path"].Value.ToString())), true);
                            }
                            c.Open();
                            cm.ExecuteNonQuery();
                            if (bwmemoloading == null)
                            {
                                bwmemoloading.RunWorkerAsync();
                            }
                            else if (!bwmemoloading.IsBusy)
                            {
                                bwmemoloading.RunWorkerAsync();
                            }
                            c.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }

        private void insertmemodata()
        {
            try
            {
                foreach (DataGridViewRow dgvrow in dgvfilesmemo.Rows)
                {
                    DateTime dt = DateTime.Now;
                    string sql = "INSERT INTO tb_labdata (Serial_No, File_Name, Document_Type, Date_Uploaded, Uploaded_by, File_Path)" +
                    "VALUES (@Serial_No, @File_Name, @Document_Type, @Date_Uploaded, @Uploaded_by, @File_Path)";

                    SqlCommand cm = new SqlCommand(sql, c);

                    if (dgvrow.IsNewRow) continue;
                    {
                        cm.Parameters.AddWithValue("@Serial_No", lfsnmemo.Text);
                        cm.Parameters.AddWithValue("@Document_Type", memo);
                        cm.Parameters.AddWithValue("@Date_Uploaded", dt.ToString("MMM d yyyy h:mmtt"));
                        cm.Parameters.AddWithValue("@Uploaded_by", userdetails.uname);

                        if (fpathmemo == "")
                        {
                            cm.Parameters.AddWithValue("@File_Name", "");
                            cm.Parameters.AddWithValue("@File_Path", "");
                        }
                        else
                        {
                            cm.CommandType = CommandType.Text;
                            cm.Parameters.AddWithValue("@File_Name", dgvrow.Cells["File Name"].Value ?? DBNull.Value);
                            cm.Parameters.AddWithValue("@File_Path", lfpathmemo.Text + @"\" + dgvrow.Cells["Path"].Value);
                        }
                        c.Open();
                        cm.ExecuteNonQuery();
                        c.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }

        private void filehistorymemodata()
        {
            try
            {
                FileInfo fi = new FileInfo(opd.FileName);
                string fsize = FileSize((int)fi.Length);
                string doc = "Laboratory Memo";

                foreach (DataGridViewRow dgvrow in dgvfilesmemo.Rows)
                {
                    SqlCommand cm = new SqlCommand("INSERT INTO tb_file_history(Date_Uploaded, User_Name, File_Name, Document_Type, File_Size, Accessed, Accessed_by)" +
                                                "VALUES (@Date_Uploaded, @User_Name, @File_Name, @Document_Type, @File_Size, @Accessed, @Accessed_by)", c);

                    cm.Parameters.AddWithValue("@Date_Uploaded", DateTime.Now);
                    cm.Parameters.AddWithValue("@User_Name", userdetails.uname);
                    cm.Parameters.AddWithValue("@Document_Type", doc);
                    cm.Parameters.AddWithValue("@Accessed", DateTime.Now.ToString("MMM d yyyy h:mmtt"));
                    cm.Parameters.AddWithValue("@Accessed_by", userdetails.uname);

                    if (fpathmemo == "")
                    {
                        cm.Parameters.AddWithValue("@File_Name, @File_Size", "");
                    }
                    else
                    {
                        cm.CommandType = CommandType.Text;
                        cm.Parameters.AddWithValue("@File_Name", Path.GetFileName(opd.FileName));
                        cm.Parameters.AddWithValue("@File_Size", fsize);
                    }
                    c.Open();
                    cm.ExecuteNonQuery();
                    c.Close();
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }

        #endregion

        private void tsubjectmemo_TextChanged(object sender, EventArgs e)
        {
            grpmemo.Enabled = true;
        }

        private void buploadmemo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Upload Files?", "Upload Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                load.Show(this);
                Thread.Sleep(1000);
                pbloadingmemo.Visible = true;
                lpercentmemo.Visible = true;
                uploadmemo();
                insertmemodata();
                filehistorymemodata();
                load.Close();
            }
        }

        private void bbrowsememo_Click(object sender, EventArgs e)
        {
            selectfoldermemo();
        }

        private void baddfilememo_Click(object sender, EventArgs e)
        {
            selectfilememo();
        }

        private void bremovememo_Click(object sender, EventArgs e)
        {
            removedgvmemo();
        }

        private void bhelpmemo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "To upload multiple files: \n" +
        "Please make sure that all files selected and highlighted. \n\n", "Select multiple files", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buploadmemo.Enabled = true;
        }

        private void bcancelmemo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel File Uploading Process?", "Cancel Upload", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bwmemoloading.CancelAsync();
                pbloadingmemo.Visible = false;
                lpercentmemo.Visible = false;

                disablememo();
                removedgvmemo();
                //this.Hide();
            }
        }

        private void bwmemoloading_DoWork(object sender, DoWorkEventArgs e)
        {
            for (var i = 1; i <= 100; i++)
            {
                Thread.Sleep(10);
                bwmemoloading.WorkerReportsProgress = true;
                bwmemoloading.ReportProgress(i);
            }
        }

        private void bwmemoloading_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbloadingmemo.Value = e.ProgressPercentage;
            lpercentmemo.Text = e.ProgressPercentage.ToString() + " %";
            if (lpercentmemo.Text == "100 %")
            {
                MessageBox.Show("File uploaded successfully! ", "Uploading Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
                c.Close();
                pbloadingmemo.Visible = false;
                lpercentmemo.Visible = false;

                load.Show(this);
                Thread.Sleep(1000);
                removedgvmemo();
                dgvfilesmemo.DataSource = null;
                lnullrecordmemo.Visible = true;
                disablememo();
                incrementFSNMEMO();
                tusuccessmemo.Visible = true;
                load.Close();
            }
        }

        ///============================================================================== LAB MEMO ===================================================================
        #endregion

        #region "LAB CALIBRATION CERTIFICATES"
        ///============================================================================== LAB CALIBRATION CERTIFICATES ===================================================================

        #region "DISABLE DRAFT RESULT OF ANALYSES"
        private void disablecabcert()
        {
            grpcabcert.Enabled = false;
            buploadcabcert.Enabled = false;
            bcancelcabcert.Enabled = false;
            lfpathcabcert.Text = "Choose Folder...";
            dgvfilescabcert.DataSource = null;
            lnullrecordcabcert.Visible = true;

            tcompnamecabcert.Text = "";
            tcabcertunit.Text = "";
            taddresscabcert.Text = "";
        }
        #endregion

        #region "POPULATE DGV FILES"
        private void popdgvfilescabcert()
        {
            try
            {
                dtcabcert.Columns.Add("File Name");
                dtcabcert.Columns.Add("Size");
                dtcabcert.Columns.Add("Path");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Table for Lab Calibration Certificates load Failed.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "INCREMENT MEMO-FSN"
        private void incrementFSNCABCERT()
        {
            try
            {
                sql = "SELECT MAX(Serial_No) FROM tb_lab_calibrationcerts";
                SqlCommand cm = new SqlCommand(sql, c);
                c.Open();
                var maxno = cm.ExecuteScalar() as string;
                if (maxno == null)
                {
                    lfsncabcert.Text = "FSN-LCC-000001";
                }
                else
                {
                    int val = int.Parse(maxno.Substring(8, 6));
                    val++;
                    lfsncabcert.Text = String.Format("FSN-LCC-{0:000000}", val);
                }
                c.Close();
            }
            catch
            {
                c.Close();
            }
        }
        #endregion

        #region "SELECT FOLDER"
        private void selectfoldercabcert()
        {
            try
            {
                load.Show(this);
                Thread.Sleep(200);
                CustomFolderDialog cfd = new CustomFolderDialog("Please select a folder.", "Z:\\LABORATORY\\Database\\Laboratory Database");
                load.Close();

                if (cfd.ShowDialog() == DialogResult.OK)
                {
                    load.Show(this);
                    Thread.Sleep(200);

                    lfpathcabcert.Text = cfd.SelectedPath;
                    baddfilecabcert.Enabled = true;
                    buploadcabcert.Enabled = true;
                    load.Close();
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }
        #endregion

        #region "SELECT FILES TO UPLOAD"
        private void selectfilecabcert()
        {
            try
            {
                if (string.IsNullOrEmpty(lfpathcabcert.Text))
                {
                    MessageBox.Show("Please choose folder/directory first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    load.Show(this);
                    Thread.Sleep(200);
                    AddCABCERTFiles();
                    lnullrecordcabcert.Visible = false;
                    tusuccesslabcert.Visible = false;
                    load.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecting File Error. Check your settings", "Browse File Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        #endregion

        #region "ADD FILE"
        private void AddCABCERTFiles()
        {
            drcabcert = dtcabcert.NewRow();
            dgvfilescabcert.DataSource = dtcabcert;

            opd.CheckFileExists = true;
            opd.CheckPathExists = true;
            opd.Multiselect = true;
            opd.Filter = "PDF Files (*.pdf)|*.pdf|All files (*.*)|*.*";
            opd.Title = "Select File";
            opd.FilterIndex = 1;

            if (opd.ShowDialog() == DialogResult.OK)
            {
                string[] selfiles = opd.SafeFileNames;
                FileInfo fi = new FileInfo(opd.FileName);
                string fullpath = fi.Name;

                string fsize = FileSize((int)fi.Length);
                foreach (string fnames in selfiles)
                {
                    drcabcert["File Name"] = fnames;
                    drcabcert["Size"] = fsize;
                    drcabcert["Path"] = fullpath;
                    dtcabcert.Rows.Add(drcabcert);

                    //dgvfilescabcert.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dgvfilescabcert.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                fpathcabcert = opd.FileName;
                buploadcabcert.Enabled = true;
                opd.RestoreDirectory = true;
            }

            //dgvfilescabcert.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvfilescabcert.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            DataGridViewColumn col = dgvfilescabcert.Columns[0];
            col.Width = 250;

            DataGridViewColumn col1 = dgvfilescabcert.Columns[1];
            col1.Width = 80;

            DataGridViewColumn col2 = dgvfilescabcert.Columns[2];
            col2.Width = 250;

            if (dgvfilescabcert.Rows.Count > 1)
            {
                bhelpcabcert.Visible = true;
                buploadcabcert.Enabled = false;
            }
            bcancelcabcert.Enabled = true;
        }
        #endregion

        #region "REMOVE SELECTED FILES TO DGV"
        private void removedgvcabcert()
        {
            try
            {
                foreach (DataGridViewCell oneCell in dgvfilescabcert.SelectedCells)
                {
                    if (oneCell.Selected)
                    {
                        dgvfilescabcert.Rows.RemoveAt(oneCell.RowIndex);
                    }
                    else
                    {
                        dgvfilescabcert.Refresh();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No data to be deleted!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "UPLOAD ALL DATA VALUES"
        private void uploadcabcert()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                dgvfilescabcert.RowHeadersVisible = false;
                Control.CheckForIllegalCrossThreadCalls = false;
                if (string.IsNullOrEmpty(tcompnamecabcert.Text))
                {
                    MessageBox.Show("Please complete the necessary details.\n " +
                        "Name of the Firm is required.", "Complete required fields.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    foreach (DataGridViewRow dgvrow in dgvfilescabcert.Rows)
                    {
                        DateTime dt = DateTime.Now;
                        string q = "INSERT INTO tb_lab_calibrationcerts (Serial_No, Reference_No, Name_of_Firm, Address, Unit_Under_Test, Date_Issued, Date_Calibrated, Date_Due, Attach_File, File_Date_Uploaded, Uploaded_by, File_Path, Document_Type)" +
                            "VALUES (@Serial_No, @Reference_No, @Name_of_Firm, @Address, @Unit_Under_Test, @Date_Issued, @Date_Calibrated, @Date_Due, @Attach_File, @File_Date_Uploaded, @Uploaded_by, @File_Path, @Document_Type)";

                        SqlCommand cm = new SqlCommand(q, c);

                        if (dgvrow.IsNewRow) continue;
                        {
                            cm.Parameters.AddWithValue("@Serial_No", lfsncabcert.Text);
                            cm.Parameters.AddWithValue("@Reference_No", trefnocabcert.Text);
                            cm.Parameters.AddWithValue("@Name_of_Firm", tcompnamecabcert.Text);
                            cm.Parameters.AddWithValue("@Address", taddresscabcert.Text);
                            cm.Parameters.AddWithValue("@Unit_Under_Test", tcabcertunit.Text);
                            cm.Parameters.AddWithValue("@Date_Issued", dtdateissuedcabcert.Text);
                            cm.Parameters.AddWithValue("@Date_Calibrated", dtdatecabcert.Text);
                            cm.Parameters.AddWithValue("@Date_Due", dtdateduecabcert.Text);

                            cm.Parameters.AddWithValue("@File_Date_Uploaded", dt.ToString("MMM d yyyy h:mmtt"));
                            cm.Parameters.AddWithValue("@Uploaded_by", userdetails.uname);
                            cm.Parameters.AddWithValue("@Document_Type", cabcert);


                            if (fpathcabcert == "")
                            {
                                cm.Parameters.AddWithValue("@Attach_File", "");
                                cm.Parameters.AddWithValue("@File_Path", "");
                            }
                            else
                            {
                                cm.CommandType = CommandType.Text;
                                cm.Parameters.AddWithValue("@Attach_File", dgvrow.Cells["File Name"].Value ?? DBNull.Value);
                                cm.Parameters.AddWithValue("@File_Path", lfpathcabcert.Text + @"\" + dgvrow.Cells["Path"].Value);
                                File.Copy(fpathcabcert, Path.Combine(lfpathcabcert.Text, Path.GetFileName(dgvrow.Cells["Path"].Value.ToString())), true);
                            }
                            c.Open();
                            cm.ExecuteNonQuery();
                            if (bwcabcertloading == null)
                            {
                                bwcabcertloading.RunWorkerAsync();
                            }
                            else if (!bwcabcertloading.IsBusy)
                            {
                                bwcabcertloading.RunWorkerAsync();
                            }
                            c.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }

        private void insertcabcertdata()
        {
            try
            {
                foreach (DataGridViewRow dgvrow in dgvfilescabcert.Rows)
                {
                    DateTime dt = DateTime.Now;
                    string sql = "INSERT INTO tb_labdata (Serial_No, File_Name, Document_Type, Date_Uploaded, Uploaded_by, File_Path)" +
                    "VALUES (@Serial_No, @File_Name, @Document_Type, @Date_Uploaded, @Uploaded_by, @File_Path)";

                    SqlCommand cm = new SqlCommand(sql, c);

                    if (dgvrow.IsNewRow) continue;
                    {
                        cm.Parameters.AddWithValue("@Serial_No", lfsncabcert.Text);
                        cm.Parameters.AddWithValue("@Document_Type", cabcert);
                        cm.Parameters.AddWithValue("@Date_Uploaded", dt.ToString("MMM d yyyy h:mmtt"));
                        cm.Parameters.AddWithValue("@Uploaded_by", userdetails.uname);

                        if (fpathcabcert == "")
                        {
                            cm.Parameters.AddWithValue("@File_Name", "");
                            cm.Parameters.AddWithValue("@File_Path", "");
                        }
                        else
                        {
                            cm.CommandType = CommandType.Text;
                            cm.Parameters.AddWithValue("@File_Name", dgvrow.Cells["File Name"].Value ?? DBNull.Value);
                            cm.Parameters.AddWithValue("@File_Path", lfpathcabcert.Text + @"\" + dgvrow.Cells["Path"].Value);
                        }
                        c.Open();
                        cm.ExecuteNonQuery();
                        c.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }

        private void filehistorycabcert()
        {
            try
            {
                FileInfo fi = new FileInfo(opd.FileName);
                string fsize = FileSize((int)fi.Length);
                string doc = "Laboratory Test Result";

                foreach (DataGridViewRow dgvrow in dgvfilescabcert.Rows)
                {
                    SqlCommand cm = new SqlCommand("INSERT INTO tb_file_history(Date_Uploaded, User_Name, File_Name, Document_Type, File_Size, Accessed, Accessed_by)" +
                                                "VALUES (@Date_Uploaded, @User_Name, @File_Name, @Document_Type, @File_Size, @Accessed, @Accessed_by)", c);

                    cm.Parameters.AddWithValue("@Date_Uploaded", DateTime.Now);
                    cm.Parameters.AddWithValue("@User_Name", userdetails.uname);
                    cm.Parameters.AddWithValue("@Document_Type", doc);
                    cm.Parameters.AddWithValue("@Accessed", DateTime.Now.ToString("MMM d yyyy h:mmtt"));
                    cm.Parameters.AddWithValue("@Accessed_by", userdetails.uname);

                    if (fpathcabcert == "")
                    {
                        cm.Parameters.AddWithValue("@File_Name, @File_Size", "");
                    }
                    else
                    {
                        cm.CommandType = CommandType.Text;
                        cm.Parameters.AddWithValue("@File_Name", Path.GetFileName(opd.FileName));
                        cm.Parameters.AddWithValue("@File_Size", fsize);
                    }
                    c.Open();
                    cm.ExecuteNonQuery();
                    c.Close();
                }
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                c.Close();
            }
        }
        #endregion

        private void tcompnamecabcert_TextChanged(object sender, EventArgs e)
        {
            grpcabcert.Enabled = true;
        }

        private void buploadcabcert_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Upload Files?", "Upload Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                load.Show(this);
                Thread.Sleep(1000);
                pbloadingcabcert.Visible = true;
                lpercentcabcert.Visible = true;
                uploadcabcert();
                insertcabcertdata();
                filehistorycabcert();
                load.Close();
            }
        }

        private void bbrowsecabcert_Click(object sender, EventArgs e)
        {
            selectfoldercabcert();
        }

        private void baddfilecabcert_Click(object sender, EventArgs e)
        {
            selectfilecabcert();
        }

        private void bremovecabcert_Click(object sender, EventArgs e)
        {
            removedgvcabcert();
        }

        private void bhelpcabcert_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "To upload multiple files: \n" +
            "Please make sure that all files selected and highlighted. \n\n", "Select multiple files", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buploadcabcert.Enabled = true;
        }

        private void bcancelcabcert_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel File Uploading Process?", "Cancel Upload", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bwcabcertloading.CancelAsync();
                pbloadingcabcert.Visible = false;
                lpercentcabcert.Visible = false;

                disablecabcert();
                removedgvcabcert();
                //this.Hide();
            }
        }

        private void bwcabcertloading_DoWork(object sender, DoWorkEventArgs e)
        {
            for (var i = 1; i <= 100; i++)
            {
                Thread.Sleep(10);
                bwcabcertloading.WorkerReportsProgress = true;
                bwcabcertloading.ReportProgress(i);
            }
        }

        private void bwcabcertloading_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbloadingcabcert.Value = e.ProgressPercentage;
            lpercentcabcert.Text = e.ProgressPercentage.ToString() + " %";
            if (lpercentcabcert.Text == "100 %")
            {
                MessageBox.Show("File uploaded successfully! ", "Uploading Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
                c.Close();
                pbloadingcabcert.Visible = false;
                lpercentcabcert.Visible = false;

                load.Show(this);
                Thread.Sleep(1000);
                removedgvcabcert();
                dgvfilescabcert.DataSource = null;
                lnullrecordcabcert.Visible = true;
                disablecabcert();
                incrementFSNCABCERT();
                tusuccesslabcert.Visible = true;
                load.Close();
            }
        }

        #endregion

    }
}
