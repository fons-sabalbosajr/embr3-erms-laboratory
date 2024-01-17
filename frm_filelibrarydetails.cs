using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    public partial class frm_filelibrarydetails : Form
    {
        public frm_filelibrarydetails()
        {
            InitializeComponent();
            unicode();
            disable();
            popdgvfiles();
            bsave.Visible = false;
            grpfile.Enabled = false;
        }
        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        OpenFileDialog opd = new OpenFileDialog();
        LoadingFunction load = new LoadingFunction();
        DataTable dt = new DataTable();
        DataRow dr;

        public static string filepath = "";
        public string fpath;

        public static string emplog = "";
        public static string username = "";
        public static string cip = "";
        public static string role = "";
        public int ID = 0;

        #region "LABEL VISIBLITY"
        private void unicode() 
        {
            luniversecode.Visible = false;
            lunicode.Visible = false;

            lunicode1.Visible = false;
            lunicode2.Visible = false;
            lunicode3.Visible = false;
            lunicode4.Visible = false;
            lunicode5.Visible = false;
            lunicode6.Visible = false;

            lcode1.Visible = false;
            lcode2.Visible = false;
            lcode3.Visible = false;
            lcode4.Visible = false;
            lcode5.Visible = false;
            lcode6.Visible = false;
        }
        #endregion

        #region "ENABLE/DISABLE"
        private void disable() 
        {
            tfirmname.ReadOnly = true;
            tfirmname.ForeColor = Color.DimGray;

            tadd.ReadOnly = true;
            tadd.ForeColor = Color.DimGray;

            lcode1.ReadOnly = true;
            lcode1.ForeColor = Color.DimGray;

            lcode2.ReadOnly = true;
            lcode2.ForeColor = Color.DimGray;

            lcode3.ReadOnly = true;
            lcode3.ForeColor = Color.DimGray;

            lcode4.ReadOnly = true;
            lcode4.ForeColor = Color.DimGray;

            lcode5.ReadOnly = true;
            lcode5.ForeColor = Color.DimGray;

            lcode6.ReadOnly = true;
            lcode6.ForeColor = Color.DimGray;
        }

        private void enable() 
        {
            tfirmname.ReadOnly = false;
            tfirmname.ForeColor = Color.FromArgb(0, 40, 78);

            tadd.ReadOnly = false;
            tadd.ForeColor = Color.FromArgb(0, 40, 78);

            lcode1.ReadOnly = false;
            lcode1.ForeColor = Color.FromArgb(0, 40, 78);

            lcode2.ReadOnly = false;
            lcode2.ForeColor = Color.FromArgb(0, 40, 78);

            lcode3.ReadOnly = false;
            lcode3.ForeColor = Color.FromArgb(0, 40, 78);

            lcode4.ReadOnly = false;
            lcode4.ForeColor = Color.FromArgb(0, 40, 78);

            lcode5.ReadOnly = false;
            lcode5.ForeColor = Color.FromArgb(0, 40, 78);

            lcode6.ReadOnly = false;
            lcode6.ForeColor = Color.FromArgb(0, 40, 78);
        }
        #endregion

        #region "LOAD DATA"
        private void loaddata() 
        {
            try
            {
                lfilecode.Text = frm_home_filelibrary.ltrcode;
                string q = "SELECT Document_Type FROM tb_labdata WHERE Serial_No ='" + lfilecode.Text + "'";
                SqlCommand cm = new SqlCommand(q, c);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0) 
                {
                    #region "CHAIN CUSTODY FORM (COC)"
                    if (dt.Rows[0][0].ToString() == "CHAIN OF CUSTODY FORM (COC)")
                    {
                        string sql = "SELECT COC_No, Name_of_Firm, Address, Date_of_Sampling, Received_by, Date_Received, Parameters, Attach_File," +
                            " File_Date_Uploaded, Uploaded_by, File_Path, Document_Type, Serial_No FROM tb_lab_coc WHERE Serial_No = '" + lfilecode.Text + "'";

                        SqlCommand cmd = new SqlCommand(sql, c);
                        SqlDataAdapter dap = new SqlDataAdapter(cmd);
                        DataTable dtb = new DataTable();
                        dap.Fill(dtb);

                        if (dtb.Rows.Count > 0)
                        {
                            //show labels
                            luniversecode.Visible = true;
                            luniversecode.Text = "COC Number:";
                            lunicode.Visible = true;

                            lunicode1.Visible = true;
                            lunicode2.Visible = true;
                            lunicode4.Visible = true;
                            lunicode5.Visible = true;

                            lcode1.Visible = true;
                            lcode2.Visible = true;
                            lcode4.Visible = true;
                            lcode5.Visible = true;

                            lunicode1.Text = "Date of Sampling:";
                            lunicode2.Text = "Received by:";
                            lunicode4.Text = "Date Received:";
                            lunicode5.Text = "Parameters:";

                            lunicode.Text = dtb.Rows[0][0].ToString();
                            tfirmname.Text = dtb.Rows[0][1].ToString();
                            tadd.Text = dtb.Rows[0][2].ToString();

                            lcode1.Text = dtb.Rows[0][3].ToString();
                            lcode2.Text = dtb.Rows[0][4].ToString();
                            lcode4.Text = dtb.Rows[0][5].ToString();
                            lcode5.Text = dtb.Rows[0][6].ToString();

                            lfilename.Text = dtb.Rows[0][7].ToString();
                            ldateuploaded.Text = dtb.Rows[0][8].ToString();
                            luploadedby.Text = dtb.Rows[0][9].ToString();
                            lpath.Text = dtb.Rows[0][10].ToString();
                            ldoctype.Text = dtb.Rows[0][11].ToString();

                            ///for file history
                            lhistoryfname.Text = dtb.Rows[0][7].ToString();
                            lhistorypermitno.Text = dtb.Rows[0][0].ToString();


                            ///for reupload files
                            lfsn.Text = dtb.Rows[0][12].ToString();
                            ltypeno.Text = dtb.Rows[0][0].ToString();
                            lfname.Text = dtb.Rows[0][7].ToString();
                            tfileloc.Text = dtb.Rows[0][10].ToString();

                            ///for view pdf
                            filepath = dtb.Rows[0][10].ToString();
                        }
                    }
                    #endregion

                    #region "LAB TEST RESULT"
                    else if (dt.Rows[0][0].ToString() == "LABORATORY TEST RESULT")
                    {
                        string sql = "SELECT Name_of_Firm, Address, Date_of_Sampling, Parameters, Date_Reported, Attach_File," +
                            " File_Date_Uploaded, Uploaded_by, File_Path, Document_Type, Serial_No FROM tb_lab_testresults WHERE Serial_No = '" + lfilecode.Text + "'";

                        SqlCommand cmd = new SqlCommand(sql, c);
                        SqlDataAdapter dap = new SqlDataAdapter(cmd);
                        DataTable dtb = new DataTable();
                        dap.Fill(dtb);

                        if (dtb.Rows.Count > 0)
                        {
                            //show labels
                            lunicode1.Visible = true;
                            lunicode2.Visible = true;
                            lunicode3.Visible = true;

                            lcode1.Visible = true;
                            lcode2.Visible = true;
                            lcode3.Visible = true;

                            lunicode1.Text = "Date of Sampling:";
                            lunicode2.Text = "Parameters:";
                            lunicode3.Text = "Date Reported:";

                            tfirmname.Text = dtb.Rows[0][0].ToString();
                            tadd.Text = dtb.Rows[0][1].ToString();

                            lcode1.Text = dtb.Rows[0][2].ToString();
                            lcode2.Text = dtb.Rows[0][3].ToString();
                            lcode3.Text = dtb.Rows[0][4].ToString();

                            lfilename.Text = dtb.Rows[0][5].ToString();
                            ldateuploaded.Text = dtb.Rows[0][6].ToString();
                            luploadedby.Text = dtb.Rows[0][7].ToString();
                            lpath.Text = dtb.Rows[0][8].ToString();
                            ldoctype.Text = dtb.Rows[0][9].ToString();

                            ///for file history
                            lhistoryfname.Text = dtb.Rows[0][5].ToString();
                            lhistorypermitno.Text = "Date of Sampling: " + dtb.Rows[0][1].ToString();

                            ///for reupload files
                            lfsn.Text = dtb.Rows[0][10].ToString();
                            ltypeno.Text = dtb.Rows[0][0].ToString();
                            lfname.Text = dtb.Rows[0][5].ToString();
                            tfileloc.Text = dtb.Rows[0][8].ToString();

                            ///for view pdf
                            filepath = dtb.Rows[0][8].ToString();
                        }
                    }
                    #endregion

                    #region "DRAFT RESULT OF ANALYSIS"
                    else if (dt.Rows[0][0].ToString() == "DRAFT RESULT OF ANALYSES")
                    {
                        string sql = "SELECT COC_No, Name_of_Firm, Address, Parameters, Attach_File, File_Date_Uploaded, Uploaded_by, File_Path, Document_Type, Serial_No " +
                            "FROM tb_lab_draftanalysis WHERE Serial_No = '" + lfilecode.Text + "'";

                        SqlCommand cmd = new SqlCommand(sql, c);
                        SqlDataAdapter dap = new SqlDataAdapter(cmd);
                        DataTable dtb = new DataTable();
                        dap.Fill(dtb);

                        if (dtb.Rows.Count > 0)
                        {
                            //show labels
                            luniversecode.Visible = true;
                            luniversecode.Text = "COC Number:";
                            lunicode.Visible = true;

                            lunicode1.Visible = true;
                            lcode1.Visible = true;

                            lunicode1.Text = "Parameters:";

                            lunicode.Text = dtb.Rows[0][0].ToString();
                            tfirmname.Text = dtb.Rows[0][1].ToString();
                            tadd.Text = dtb.Rows[0][2].ToString();

                            lcode1.Text = dtb.Rows[0][3].ToString();

                            lfilename.Text = dtb.Rows[0][4].ToString();
                            ldateuploaded.Text = dtb.Rows[0][5].ToString();
                            luploadedby.Text = dtb.Rows[0][6].ToString();
                            lpath.Text = dtb.Rows[0][7].ToString();
                            ldoctype.Text = dtb.Rows[0][8].ToString();

                            ///for file history
                            lhistoryfname.Text = dtb.Rows[0][4].ToString();
                            lhistorypermitno.Text = dtb.Rows[0][0].ToString();

                            ///for reupload files
                            lfsn.Text = dtb.Rows[0][9].ToString();
                            ltypeno.Text = "n/a";
                            lfname.Text = dtb.Rows[0][4].ToString();
                            tfileloc.Text = dtb.Rows[0][7].ToString();

                            ///for view pdf
                            filepath = dtb.Rows[0][7].ToString();
                        }
                    }
                    #endregion

                    #region "LAB CALIBRATION CERT"

                    else if (dt.Rows[0][0].ToString() == "LABORATORY CALIBRATION CERTIFICATE")
                    {
                        string sql = "SELECT Reference_No, Name_of_Firm, Address, Unit_Under_Test, Date_Issued, Date_Calibrated, Date_Due, " +
                            "Attach_File, File_Date_Uploaded, Uploaded_by, File_Path, Document_Type, Serial_No FROM tb_lab_calibrationcerts WHERE Serial_No = '" + lfilecode.Text + "'";

                        SqlCommand cmd = new SqlCommand(sql, c);
                        SqlDataAdapter dap = new SqlDataAdapter(cmd);
                        DataTable dtb = new DataTable();
                        dap.Fill(dtb);

                        if (dtb.Rows.Count > 0)
                        {
                            //show labels
                            luniversecode.Visible = true;
                            luniversecode.Text = "Reference No:";
                            lunicode.Visible = true;

                            lunicode1.Visible = true;
                            lunicode2.Visible = true;
                            lunicode4.Visible = true;
                            lunicode5.Visible = true;

                            lcode1.Visible = true;
                            lcode2.Visible = true;
                            lcode4.Visible = true;
                            lcode5.Visible = true;

                            lunicode1.Text = "Unit Under Test:";
                            lunicode2.Text = "Date Issued:";
                            lunicode4.Text = "Date Calibrated:";
                            lunicode5.Text = "Date Due:";

                            lunicode.Text = dtb.Rows[0][0].ToString();
                            tfirmname.Text = dtb.Rows[0][1].ToString();
                            tadd.Text = dtb.Rows[0][2].ToString();

                            lcode1.Text = dtb.Rows[0][3].ToString();
                            lcode2.Text = dtb.Rows[0][4].ToString();
                            lcode4.Text = dtb.Rows[0][5].ToString();
                            lcode5.Text = dtb.Rows[0][6].ToString();

                            lfilename.Text = dtb.Rows[0][7].ToString();
                            ldateuploaded.Text = dtb.Rows[0][8].ToString();
                            luploadedby.Text = dtb.Rows[0][9].ToString();
                            lpath.Text = dtb.Rows[0][10].ToString();
                            ldoctype.Text = dtb.Rows[0][11].ToString();

                            ///for file history
                            lhistoryfname.Text = dtb.Rows[0][7].ToString();
                            lhistorypermitno.Text = dtb.Rows[0][0].ToString();

                            ///for reupload files
                            lfsn.Text = dtb.Rows[0][12].ToString();
                            ltypeno.Text = dtb.Rows[0][0].ToString();
                            lfname.Text = dtb.Rows[0][7].ToString();
                            tfileloc.Text = dtb.Rows[0][10].ToString();

                            ///for view pdf
                            filepath = tfileloc.Text = dtb.Rows[0][10].ToString();
                        }
                    }
                    #endregion

                    #region "LAB MEMO"

                    else if (dt.Rows[0][0].ToString() == "LABORATORY MEMO")
                    {
                        string sql = "SELECT Memo_Subject, Date, Attach_File, File_Date_Uploaded, Uploaded_by, File_Path, Document_Type, Serial_No FROM tb_lab_memo" +
                            " WHERE Serial_No = '" + lfilecode.Text + "'";

                        SqlCommand cmd = new SqlCommand(sql, c);
                        SqlDataAdapter dap = new SqlDataAdapter(cmd);
                        DataTable dtb = new DataTable();
                        dap.Fill(dtb);

                        if (dtb.Rows.Count > 0)
                        {
                            //show labels
                            lunicodefirm.Text = "Memo Subject:";
                            lunicodeadd.Text = "Date:";
                            tadd.Size = new Size(228, 34);

                            tfirmname.Text = dtb.Rows[0][0].ToString();
                            tadd.Text = dtb.Rows[0][1].ToString();

                            lfilename.Text = dtb.Rows[0][2].ToString();
                            ldateuploaded.Text = dtb.Rows[0][3].ToString();
                            luploadedby.Text = dtb.Rows[0][4].ToString();
                            lpath.Text = dtb.Rows[0][5].ToString();
                            ldoctype.Text = dtb.Rows[0][6].ToString();

                            ///for file history
                            lhistoryfname.Text = dtb.Rows[0][2].ToString();
                            lhistorypermitno.Text = "Dated " + dtb.Rows[0][1].ToString();

                            ///for reupload files
                            lfsn.Text = dtb.Rows[0][12].ToString();
                            ltypeno.Text = "n/a";
                            lfname.Text = dtb.Rows[0][7].ToString();
                            tfileloc.Text = dtb.Rows[0][10].ToString();

                            ///for view pdf
                            filepath = dtb.Rows[0][10].ToString();
                        }
                    }
                    #endregion

                    #region "LAB PR/RECEIPT"

                    else if (dt.Rows[0][0].ToString() == "LABORATORY PR/RECEIPT")
                    {
                        string sql = "SELECT OR_PR_Number, Subject, OR_Date, Attach_File, File_Date_Uploaded, Uploaded_by, File_Path, Document_Type, Serial_No FROM tb_lab_receipt" +
                            " WHERE Serial_No = '" + lfilecode.Text + "'";

                        SqlCommand cmd = new SqlCommand(sql, c);
                        SqlDataAdapter dap = new SqlDataAdapter(cmd);
                        DataTable dtb = new DataTable();
                        dap.Fill(dtb);

                        if (dtb.Rows.Count > 0)
                        {
                            //show labels
                            luniversecode.Visible = true;
                            luniversecode.Text = "OR_PR_Number:";
                            lunicode.Visible = true;

                            lunicodefirm.Text = "Subject:";
                            lunicodeadd.Text = "OR Date:";
                            tadd.Size = new Size(228, 34);

                            lunicode.Text = dtb.Rows[0][0].ToString();
                            tfirmname.Text = dtb.Rows[0][1].ToString();
                            tadd.Text = dtb.Rows[0][2].ToString();

                            lfilename.Text = dtb.Rows[0][3].ToString();
                            ldateuploaded.Text = dtb.Rows[0][4].ToString();
                            luploadedby.Text = dtb.Rows[0][5].ToString();
                            lpath.Text = dtb.Rows[0][6].ToString();
                            ldoctype.Text = dtb.Rows[0][7].ToString();

                            ///for file history
                            lhistoryfname.Text = dtb.Rows[0][3].ToString();
                            lhistorypermitno.Text = "Receipt No. " + dtb.Rows[0][0].ToString();

                            ///for reupload files
                            lfsn.Text = dtb.Rows[0][12].ToString();
                            ltypeno.Text = dtb.Rows[0][0].ToString();
                            lfname.Text = dtb.Rows[0][3].ToString();
                            tfileloc.Text = dtb.Rows[0][6].ToString();

                            ///for view pdf
                            filepath = dtb.Rows[0][6].ToString();
                        }
                    }
                    #endregion
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("File Details load failed.\n\n" + ex.Message + ex.StackTrace, "Failed to Load Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #region "UPDATE FILE DATA VALUES"
        private void updatedata() 
        {
            try
            {
                string q = "SELECT Document_Type FROM tb_labdata WHERE Serial_No ='" + lfilecode.Text + "'";
                SqlCommand cm = new SqlCommand(q, c);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][0].ToString() == "CHAIN OF CUSTODY FORM (COC)")
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE tb_lab_coc SET Serial_No = @Serial_No, COC_No = @COC_No, Name_of_Firm = @Name_of_Firm, Address = @Address, Date_of_Sampling = @Date_of_Sampling," +
                            " Parameters = @Parameters, Date_Received = @Date_Received, Received_by = @Recieved_by, Date_Received = @Date_Received WHERE Serial_No = @Serial_No", c);

                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@Serial_No", lfilecode.Text);
                        cmd.Parameters.AddWithValue("@COC_No", lunicode.Text);
                        cmd.Parameters.AddWithValue("@Name_of_Firm", tfirmname.Text);
                        cmd.Parameters.AddWithValue("@Address", tadd.Text);
                        cmd.Parameters.AddWithValue("@Date_of_Sampling", lcode1.Text);
                        cmd.Parameters.AddWithValue("@Parameters", lcode2.Text);
                        cmd.Parameters.AddWithValue("@Date_Received", lcode4.Text);
                        cmd.Parameters.AddWithValue("@Received_by", lcode5.Text);

                        c.Open();
                        cmd.ExecuteNonQuery();
                        c.Close();
                    }
                    else if (dt.Rows[0][0].ToString() == "LABORATORY TEST RESULT")
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE tb_lab_testresults SET Serial_No = @Serial_No, Name_of_Firm = @Name_of_Firm, Address = @Address, Date_of_Sampling = @Date_of_Sampling," +
                            " Parameters = @Parameters, Date_Reported = @Date_Reported WHERE Serial_No = @Serial_No", c);

                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@Serial_No",       lfilecode.Text);
                        cmd.Parameters.AddWithValue("@Name_of_Firm",    tfirmname.Text);
                        cmd.Parameters.AddWithValue("@Address",         tadd.Text);
                        cmd.Parameters.AddWithValue("@Date_of_Sampling", lcode1.Text);
                        cmd.Parameters.AddWithValue("@Parameters",      lcode2.Text);
                        cmd.Parameters.AddWithValue("@Date_Reported",   lcode3.Text);
                        
                        c.Open();
                        cmd.ExecuteNonQuery();
                        c.Close();
                    }
                    else if (dt.Rows[0][0].ToString() == "DRAFT RESULT OF ANALYSES")
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE tb_lab_draftanalysis SET Serial_No = @Serial_No, COC_No = @COC_No, Name_of_Firm = @Name_of_Firm, Address = @Address "+
                            "Parameters = @Parameters WHERE Serial_No = @Serial_No", c);

                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@Serial_No", lfilecode.Text);
                        cmd.Parameters.AddWithValue("@Name_of_Firm", tfirmname.Text);
                        cmd.Parameters.AddWithValue("@Address", tadd.Text);
                        cmd.Parameters.AddWithValue("@Parameters", lcode1.Text);

                        c.Open();
                        cmd.ExecuteNonQuery();
                        c.Close();
                    }
                    else if (dt.Rows[0][0].ToString() == "LABORATORY CALIBRATION CERTIFICATE")
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE tb_lab_calibrationcerts SET Serial_No = @Serial_No, Reference_No = @Reference_No, Name_of_Firm = @Name_of_Firm, Address = @Address " +
                            "Unit_Under_Test = @Unit_Under_Test, Date_Issued = @Date_Issued, Date_Calibrated = @Date_Calibrated, Date_Due = @Date_Due WHERE Serial_No = @Serial_No", c);

                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@Serial_No", lfilecode.Text);
                        cmd.Parameters.AddWithValue("@Reference_No", lunicode.Text);
                        cmd.Parameters.AddWithValue("@Name_of_Firm", tfirmname.Text);
                        cmd.Parameters.AddWithValue("@Address", tadd.Text);
                        cmd.Parameters.AddWithValue("@Unit_Under_Test", lcode1.Text);
                        cmd.Parameters.AddWithValue("@Date_Issued", lcode2.Text);
                        cmd.Parameters.AddWithValue("@Date_Calibrated", lcode4.Text);
                        cmd.Parameters.AddWithValue("@Date_Due", lcode5.Text);

                        c.Open();
                        cmd.ExecuteNonQuery();
                        c.Close();
                    }
                    else if (dt.Rows[0][0].ToString() == "LABORATORY MEMO")
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE tb_lab_memo SET Serial_No = @Serial_No, Memo_Subject = @Memo_Subject, Date = @Date WHERE Serial_No = @Serial_No", c);

                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@Serial_No", lfilecode.Text);
                        cmd.Parameters.AddWithValue("@Memo_Subject", tfirmname.Text);
                        cmd.Parameters.AddWithValue("@Date", tadd.Text);
                        
                        c.Open();
                        cmd.ExecuteNonQuery();
                        c.Close();
                    }
                    else if (dt.Rows[0][0].ToString() == "LABORATORY PR/RECEIPT")
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE tb_lab_receipt SET Serial_No = @Serial_No, OR_PR_Number = @OR_PR_Number, Subject = @Subject, " +
                            "OR_Date = @OR_Date WHERE Serial_No = @Serial_No", c);

                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@Serial_No", lfilecode.Text);
                        cmd.Parameters.AddWithValue("@OR_PR_Number", lunicode.Text);
                        cmd.Parameters.AddWithValue("@Subject", tfirmname.Text);
                        cmd.Parameters.AddWithValue("@OR_Date", tadd.Text);

                        c.Open();
                        cmd.ExecuteNonQuery();
                        c.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Updating Data process failed.\n\n" + ex.Message, "Data Update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "LOAD FILE LOGS"
        private void loadfilehistory() 
        {
            try 
            {
                try
                {
                    SqlCommand cm = new SqlCommand("SELECT * FROM tb_filelogs WHERE File_Modified LIKE '" + lhistoryfname.Text + "'ORDER BY Log_ID DESC", c);
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tb_filelogs");
                    dgvdata.DataSource = ds.Tables["tb_filelogs"];

                    //dgvdata.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dgvdata.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    ltotlogs.Text = dgvdata.Rows.Count.ToString() + " Total Logs Found";

                    DataGridViewColumn collog = dgvdata.Columns[0];
                    collog.Width = 50;
                }
                catch
                {
                    MessageBox.Show("Saving Event Log Failed. Please check your settings.", "Save Log Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Loading File History Failed.\n" + ex.Message, "Loading Data Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        /// reupload files
        
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

                    tfolderloc.Text = cfd.SelectedPath;
                    baddfile.Enabled = false;
                    bupload.Enabled = false;
                    load.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Browsing forlder failed. \n" + ex.Message, "Browsing folder failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.Close();
            }
        }
        #endregion

        #region "COMPUTE FILE SIZE"
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

        #region "REMOVE FILE FROM DGV"
        private void removedgv()
        {
            try
            {
                foreach (DataGridViewCell oneCell in dgvfiles.SelectedCells)
                {
                    if (oneCell.Selected)
                    {
                        dgvfiles.Rows.RemoveAt(oneCell.RowIndex);
                    }
                    else
                    {
                        dgvfiles.Refresh();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No data to be deleted!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "UPLOAD PROCESSING"
        private void Upload() 
        {
            dr = dt.NewRow();
            dgvfiles.DataSource = dt;

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
                    dr["File Name"] = fnames;
                    dr["Size"] = fsize;
                    dr["Path"] = fullpath;
                    dt.Rows.Add(dr);
                }
                fpath = opd.FileName;
                bupload.Enabled = true;
                opd.RestoreDirectory = true;
            }

            //dgvfiles.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvfiles.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            DataGridViewColumn col = dgvfiles.Columns[0];
            col.Width = 250;

            DataGridViewColumn col1 = dgvfiles.Columns[1];
            col1.Width = 120;

            DataGridViewColumn col2 = dgvfiles.Columns[2];
            col2.Width = 250;
        }
        #endregion

        #region "SELECT FILE"
        private void selectfile()
        {
            try
            {
                if (string.IsNullOrEmpty(tfolderloc.Text))
                {
                    MessageBox.Show("Please choose folder/directory first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    load.Show(this);
                    Thread.Sleep(200);
                    Upload();
                    bupload.Enabled = true;
                    bremove.Enabled = true;
                    baddfile.Enabled = false;
                    lnullrecord.Visible = false;
                    load.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecting File Error. Check your settings. \n" + ex.Message, "Browse File Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        #endregion

        #region "removefile"
        private void removefile()
        {
            try
            {
                foreach (DataGridViewCell oneCell in dgvfiles.SelectedCells)
                {
                    if (oneCell.Selected)
                    {
                        dgvfiles.Rows.RemoveAt(oneCell.RowIndex);
                    }
                    else
                    {
                        dgvfiles.Refresh();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No data to be deleted!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "REUPLOAD FILE PROCESS"
        private void replacefile()
        {
            try
            {
                lfilecode.Text = frm_home_filelibrary.ltrcode;
                string q = "SELECT Document_Type FROM tb_labdata WHERE Serial_No ='" + lfilecode.Text + "'";
                SqlCommand cm = new SqlCommand(q, c);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][0].ToString() == "CHAIN OF CUSTODY FORM (COC)") 
                    {
                        #region "COC"
                        dgvfiles.RowHeadersVisible = false;
                        Control.CheckForIllegalCrossThreadCalls = false;

                        foreach (DataGridViewRow row in dgvfiles.Rows)
                        {
                            c.Open();
                            string sql = "UPDATE tb_lab_coc SET Serial_No = @Serial_No, Attach_File = @Attach_File, File_Path = @File_Path WHERE Serial_No = @Serial_No";
                            SqlCommand cmd = new SqlCommand(sql, c);

                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Serial_No", lfsn.Text);

                            if (row.IsNewRow) continue;
                            {
                                if (fpath == "")
                                {
                                    cmd.Parameters.AddWithValue("@Attach_File", "");
                                    cmd.Parameters.AddWithValue("@File_Path", "");
                                }
                                else
                                {
                                    cmd.CommandType = CommandType.Text;
                                    cmd.Parameters.AddWithValue("@Attach_File", row.Cells["File Name"].Value ?? DBNull.Value);
                                    cmd.Parameters.AddWithValue("@File_Path", tfolderloc.Text.Replace("'", "") + @"\" + row.Cells["Path"].Value);
                                    File.Copy(fpath, Path.Combine(tfolderloc.Text.Replace("'", ""), Path.GetFileName(row.Cells["Path"].Value.ToString())), true);
                                }
                                cmd.ExecuteNonQuery();
                                c.Close();
                                savefilelog();
                            }
                        }
                        #endregion

                        replacelabdata();
                    }
                    else if (dt.Rows[0][0].ToString() == "LABORATORY TEST RESULT")
                    {
                        #region "LTR"
                        dgvfiles.RowHeadersVisible = false;
                        Control.CheckForIllegalCrossThreadCalls = false;

                        foreach (DataGridViewRow row in dgvfiles.Rows)
                        {
                            c.Open();
                            string sql = "UPDATE tb_lab_testresults SET Serial_No = @Serial_No, Attach_File = @Attach_File, File_Path = @File_Path WHERE Serial_No = @Serial_No";
                            SqlCommand cmd = new SqlCommand(sql, c);

                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Serial_No", lfsn.Text);

                            if (row.IsNewRow) continue;
                            {
                                if (fpath == "")
                                {
                                    cmd.Parameters.AddWithValue("@Attach_File", "");
                                    cmd.Parameters.AddWithValue("@File_Path", "");
                                }
                                else
                                {
                                    cmd.CommandType = CommandType.Text;
                                    cmd.Parameters.AddWithValue("@Attach_File", row.Cells["File Name"].Value ?? DBNull.Value);
                                    cmd.Parameters.AddWithValue("@File_Path", tfolderloc.Text.Replace("'", "") + @"\" + row.Cells["Path"].Value);
                                    File.Copy(fpath, Path.Combine(tfolderloc.Text.Replace("'", ""), Path.GetFileName(row.Cells["Path"].Value.ToString())), true);
                                }
                                cmd.ExecuteNonQuery();
                                c.Close();
                                savefilelog();
                            }
                        }
                        #endregion

                        replacelabdata();
                    }
                    else if (dt.Rows[0][0].ToString() == "DRAFT RESULT OF ANALYSES")
                    {
                        #region "DRA"
                        dgvfiles.RowHeadersVisible = false;
                        Control.CheckForIllegalCrossThreadCalls = false;

                        foreach (DataGridViewRow row in dgvfiles.Rows)
                        {
                            c.Open();
                            string sql = "UPDATE tb_lab_draftanalysis SET Serial_No = @Serial_No, Attach_File = @Attach_File, File_Path = @File_Path WHERE Serial_No = @Serial_No";
                            SqlCommand cmd = new SqlCommand(sql, c);

                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Serial_No", lfsn.Text);

                            if (row.IsNewRow) continue;
                            {
                                if (fpath == "")
                                {
                                    cmd.Parameters.AddWithValue("@Attach_File", "");
                                    cmd.Parameters.AddWithValue("@File_Path", "");
                                }
                                else
                                {
                                    cmd.CommandType = CommandType.Text;
                                    cmd.Parameters.AddWithValue("@Attach_File", row.Cells["File Name"].Value ?? DBNull.Value);
                                    cmd.Parameters.AddWithValue("@File_Path", tfolderloc.Text.Replace("'", "") + @"\" + row.Cells["Path"].Value);
                                    File.Copy(fpath, Path.Combine(tfolderloc.Text.Replace("'", ""), Path.GetFileName(row.Cells["Path"].Value.ToString())), true);
                                }
                                cmd.ExecuteNonQuery();
                                c.Close();
                                savefilelog();
                            }
                        }
                        #endregion

                        replacelabdata();
                    }
                    else if (dt.Rows[0][0].ToString() == "LABORATORY CALIBRATION CERTIFICATE")
                    {
                        #region "LAB CERTS"
                        dgvfiles.RowHeadersVisible = false;
                        Control.CheckForIllegalCrossThreadCalls = false;

                        foreach (DataGridViewRow row in dgvfiles.Rows)
                        {
                            c.Open();
                            string sql = "UPDATE tb_lab_calibrationcerts SET Serial_No = @Serial_No, Attach_File = @Attach_File, File_Path = @File_Path WHERE Serial_No = @Serial_No";
                            SqlCommand cmd = new SqlCommand(sql, c);

                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Serial_No", lfsn.Text);

                            if (row.IsNewRow) continue;
                            {
                                if (fpath == "")
                                {
                                    cmd.Parameters.AddWithValue("@Attach_File", "");
                                    cmd.Parameters.AddWithValue("@File_Path", "");
                                }
                                else
                                {
                                    cmd.CommandType = CommandType.Text;
                                    cmd.Parameters.AddWithValue("@Attach_File", row.Cells["File Name"].Value ?? DBNull.Value);
                                    cmd.Parameters.AddWithValue("@File_Path", tfolderloc.Text.Replace("'", "") + @"\" + row.Cells["Path"].Value);
                                    File.Copy(fpath, Path.Combine(tfolderloc.Text.Replace("'", ""), Path.GetFileName(row.Cells["Path"].Value.ToString())), true);
                                }
                                cmd.ExecuteNonQuery();
                                c.Close();
                                savefilelog();
                            }
                        }
                        #endregion

                        replacelabdata();
                    }
                    else if (dt.Rows[0][0].ToString() == "LABORATORY MEMO")
                    {
                        #region "LAB MEMO"
                        dgvfiles.RowHeadersVisible = false;
                        Control.CheckForIllegalCrossThreadCalls = false;

                        foreach (DataGridViewRow row in dgvfiles.Rows)
                        {
                            c.Open();
                            string sql = "UPDATE tb_lab_memo SET Serial_No = @Serial_No, Attach_File = @Attach_File, File_Path = @File_Path WHERE Serial_No = @Serial_No";
                            SqlCommand cmd = new SqlCommand(sql, c);

                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Serial_No", lfsn.Text);

                            if (row.IsNewRow) continue;
                            {
                                if (fpath == "")
                                {
                                    cmd.Parameters.AddWithValue("@Attach_File", "");
                                    cmd.Parameters.AddWithValue("@File_Path", "");
                                }
                                else
                                {
                                    cmd.CommandType = CommandType.Text;
                                    cmd.Parameters.AddWithValue("@Attach_File", row.Cells["File Name"].Value ?? DBNull.Value);
                                    cmd.Parameters.AddWithValue("@File_Path", tfolderloc.Text.Replace("'", "") + @"\" + row.Cells["Path"].Value);
                                    File.Copy(fpath, Path.Combine(tfolderloc.Text.Replace("'", ""), Path.GetFileName(row.Cells["Path"].Value.ToString())), true);
                                }
                                cmd.ExecuteNonQuery();
                                c.Close();
                                savefilelog();
                            }
                        }
                        #endregion

                        replacelabdata();
                    }
                    else if (dt.Rows[0][0].ToString() == "LABORATORY PR/RECEIPT")
                    {
                        #region "LABORATORY PR/RECEIPT"
                        dgvfiles.RowHeadersVisible = false;
                        Control.CheckForIllegalCrossThreadCalls = false;

                        foreach (DataGridViewRow row in dgvfiles.Rows)
                        {
                            c.Open();
                            string sql = "UPDATE tb_lab_receipt SET Serial_No = @Serial_No, Attach_File = @Attach_File, File_Path = @File_Path WHERE Serial_No = @Serial_No";
                            SqlCommand cmd = new SqlCommand(sql, c);

                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Serial_No", lfsn.Text);

                            if (row.IsNewRow) continue;
                            {
                                if (fpath == "")
                                {
                                    cmd.Parameters.AddWithValue("@Attach_File", "");
                                    cmd.Parameters.AddWithValue("@File_Path", "");
                                }
                                else
                                {
                                    cmd.CommandType = CommandType.Text;
                                    cmd.Parameters.AddWithValue("@Attach_File", row.Cells["File Name"].Value ?? DBNull.Value);
                                    cmd.Parameters.AddWithValue("@File_Path", tfolderloc.Text.Replace("'", "") + @"\" + row.Cells["Path"].Value);
                                    File.Copy(fpath, Path.Combine(tfolderloc.Text.Replace("'", ""), Path.GetFileName(row.Cells["Path"].Value.ToString())), true);
                                }
                                cmd.ExecuteNonQuery();
                                c.Close();
                                savefilelog();
                            }
                        }
                        #endregion

                        replacelabdata();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Replacing File Failed. Please check your settings." + ex.Message, "Process Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "REUPLOAD GENERAL DATA"
        private void replacelabdata() 
        {
            try
            {
                #region "LABORATORY PR/RECEIPT"
                dgvfiles.RowHeadersVisible = false;
                Control.CheckForIllegalCrossThreadCalls = false;

                foreach (DataGridViewRow row in dgvfiles.Rows)
                {
                    c.Open();
                    string sql = "UPDATE tb_labdata SET Serial_No = @Serial_No, File_Name = @File_Name, File_Path = @File_Path WHERE Serial_No = @Serial_No";
                    SqlCommand cmd = new SqlCommand(sql, c);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Serial_No", lfsn.Text);

                    if (row.IsNewRow) continue;
                    {
                        if (fpath == "")
                        {
                            cmd.Parameters.AddWithValue("@File_Name", "");
                            cmd.Parameters.AddWithValue("@File_Path", "");
                        }
                        else
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@File_Name", row.Cells["File Name"].Value ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@File_Path", tfolderloc.Text.Replace("'", "") + @"\" + row.Cells["Path"].Value);
                            File.Copy(fpath, Path.Combine(tfolderloc.Text.Replace("'", ""), Path.GetFileName(row.Cells["Path"].Value.ToString())), true);
                        }
                        cmd.ExecuteNonQuery();
                        c.Close();
                        //savefilelog();
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Replacing File Failed. Please check your settings." + ex.Message, "Process Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "SAVE FILE LOG DATA"
        private void savefilelog()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Username, Password FROM tb_employees", c);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string sevent = "Replace the File to \n" + dgvfiles.Rows[0].Cells[0].Value.ToString();

                    FileLog flog = new FileLog();
                    string sql = @"SELECT User_ID FROM tb_employees WHERE Username = '" + frm_home_login.getusername +
                                "' AND Password = '" + frm_home_login.getpassword + "'";

                    emplog = flog.constring(sql).ToString();
                    if (emplog != "")
                    {
                        string a = "SELECT Name FROM tb_employees WHERE User_ID = '" + Convert.ToString(emplog) + "'";
                        string b = "SELECT Role FROM tb_employees WHERE User_ID = '" + Convert.ToString(emplog) + "'";
                        username = flog.constring(a).ToString();
                        role = flog.constring(b).ToString();
                        flog.Log(@"INSERT INTO tb_filelogs (Function_Performed, File_Modified, Permit_Number, Date, User_No,Name,Login_as, IP_Address) 
                        VALUES ('" + sevent + "','" + lfname.Text.Replace("'", "") + "','" + ltypeno.Text + "','" + DateTime.Now + "','" + emplog + "','" + username + "','" + role + "','" + cip + "')");
                        ID = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Saving Event Log Failed. Please check your settings." + ex.Message, "Save Log Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "VIEW FILE LOG"
        private void viewfilelog()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Username, Password FROM tb_employees", c);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string sevent = "View the File Data Information";

                    FileLog flog = new FileLog();
                    string sql = @"SELECT User_ID FROM tb_employees WHERE Username = '" + frm_home_login.getusername +
                                "' AND Password = '" + frm_home_login.getpassword + "'";

                    emplog = flog.constring(sql).ToString();
                    if (emplog != "")
                    {
                        string a = "SELECT Name FROM tb_employees WHERE User_ID = '" + Convert.ToString(emplog) + "'";
                        string b = "SELECT Role FROM tb_employees WHERE User_ID = '" + Convert.ToString(emplog) + "'";
                        username = flog.constring(a).ToString();
                        role = flog.constring(b).ToString();
                        flog.Log(@"INSERT INTO tb_filelogs (Function_Performed, File_Modified, Permit_Number, Date, User_No,Name,Login_as, IP_Address) 
                        VALUES ('" + sevent + "','" + lfname.Text.Replace("'", "") + "','" + ltypeno.Text + "','" + DateTime.Now + "','" + emplog + "','" + username + "','" + role + "','" + cip + "')");
                        ID = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viewing Event Log Failed. Please check your settings." + ex.Message, "Save Log Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "POPULATE DGV AND GET IP"
        private void getIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    cip = ip.ToString();
                }
            }
        }

        private void popdgvfiles()
        {
            try
            {
                dt.Columns.Add("File Name");
                dt.Columns.Add("Size");
                dt.Columns.Add("Path");
            }
            catch (Exception)
            {
                MessageBox.Show("Browse File Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void frm_filelibrarydetails_Load(object sender, EventArgs e)
        {
            loaddata();
            loadfilehistory();
            getIP();
        }

        private void bedit_Click(object sender, EventArgs e)
        {
            enable();
            bsave.Visible = true;
            tfirmname.Focus();
        }

        private void bsave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save modified changes?", "Update File Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                load.Show(this);
                Thread.Sleep(1500);
                updatedata();
                load.Close();

                MessageBox.Show("File Data Successfully Updated", "Information Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                load.Show(this);
                Thread.Sleep(1500);
                loaddata();
                load.Close();

                disable();
                bsave.Visible = false;
            }
        }


        private void bview_Click(object sender, EventArgs e)
        {
            load.Show(this);
            Thread.Sleep(500);
            viewfilelog();
            load.Close();
            frm_viewPDFfilelibrary lpdf = new frm_viewPDFfilelibrary();
            lpdf.Show(this);
        }

        private void beditfile_Click(object sender, EventArgs e)
        {
            grpfile.Enabled = true;
        }

        private void bbrowse_Click(object sender, EventArgs e)
        {
            selectfolder();
        }

        private void baddfile_Click(object sender, EventArgs e)
        {
            selectfile();
        }

        private void bremove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Remove File?", "Remove upload", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                removedgv();
                baddfile.Enabled = true;

                if (dgvfiles.Rows.Count == 0)
                    bremove.Enabled = false;
            }
        }

        private void bupload_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The file will be replaced. \n Do you want to replace the file?", "Replace File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                load.Show(this);
                Thread.Sleep(1000);
                replacefile();
                load.Close();

                MessageBox.Show("File has been replaced successfully.", "Replaced Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpfile.Enabled = false;
                removefile();
                tfileloc.Clear();
                tfolderloc.Text = "Choose Folder...";
                //filehistory();
                loaddata();
                lnullrecord.Visible = true;
            }
        }

        private void bcancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel file reupload?", "Abort Process", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                load.Show(this);
                Thread.Sleep(1000);
                removedgv();
                tfileloc.Text = "";
                tfolderloc.Text = "Choose Folder";
                lfname.Text = "";
                lfsn.Text = "";
                ltypeno.Text = "";
                grpfile.Enabled = false;
                load.Close();
                this.Hide();
            }
        }

        private void dgvfiles_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvfiles.ClearSelection();
        }

        private void brefreshhistory_Click(object sender, EventArgs e)
        {
            load.Show(this);
            Thread.Sleep(500);
            loadfilehistory();
            load.Close();
        }
    }
}
