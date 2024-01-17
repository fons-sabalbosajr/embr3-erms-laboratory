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
    public partial class frm_home_filelibrary : Form
    {
        public frm_home_filelibrary()
        {
            InitializeComponent();
            lnulldocs.Visible = false;
            terror.Visible = false;
            tfileclass.Visible = false;

            bview.Enabled = false;
            bprint.Enabled = false;
            bdownload.Enabled = false;
        }
        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        LoadingFunction load = new LoadingFunction();
        frm_filelibrary_print ffp = new frm_filelibrary_print();
        DataSet ds;
        DataTable dt;

        public static string ltrcode = "";
        public static string filecode = "";

        #region "LOAD COMBO BOX"
        private void loaddoctype() 
        {
            try
            {
                string q = "SELECT DISTINCT Document_Type from tb_labdata";
                SqlDataAdapter da = new SqlDataAdapter(q, c);
                DataTable dt = new DataTable();
                int i = da.Fill(dt);

                if (i > 0)
                {
                    DataRow drow = dt.NewRow();
                    drow["Document_Type"] = "--select document type--";
                    dt.Rows.InsertAt(drow, 0);

                    cbtype.DisplayMember = "Document_Type";
                    cbtype.ValueMember = "Document_Type";
                    cbtype.DataSource = dt;

                    cbtype.SelectedIndex = 0;
                    cbtype.Items[0] = "--select document type--";
                }
            }
            catch (Exception)
            {
                cbtype.SelectedIndex = 0;
            }
        }
        #endregion

        #region "LOAD DATA"
        private void loaddata() 
        {
            try
            {
                string sql = "SELECT Serial_No, File_Name, Document_Type, Date_Uploaded FROM tb_labdata ORDER BY Serial_No DESC";
                SqlCommand cm = new SqlCommand(sql, c);
                SqlDataAdapter da = new SqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvdata.DataSource = dt;

                //dgvdata.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvdata.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                DataGridViewColumn colfsn = dgvdata.Columns[0];
                colfsn.Width = 100;

                DataGridViewColumn coldid = dgvdata.Columns[1];
                coldid.Width = 300;

                DataGridViewColumn colpab = dgvdata.Columns[2];
                colpab.Width = 200;

                DataGridViewColumn colname = dgvdata.Columns[3];
                colname.Width = 200;

                totrows();
            }
            catch (Exception ex) 
            {
                terror.Visible = true;
                terror.Text = ex.Message;
                dgvdata.DataSource = null;
            }
        }
        #endregion

        #region "SEARCH DATA"
        private void searchdata()
        {
            if (string.IsNullOrEmpty(tsearch.Text))
            {
                dgvdata.DataSource = null;
                lnulldocs.Visible = true;
            }
            else
            {
                try
                {
                    lnulldocs.Visible = false;
                    string q = "SELECT Serial_No, File_Name, Document_Type, Date_Uploaded FROM tb_labdata";
                    q += " WHERE Serial_No LIKE '%' + @search + '%'";
                    q += " OR File_Name LIKE '%' + @search + '%'";
                    q += " OR Document_Type LIKE '%' + @search + '%'";
                    q += " OR Date_Uploaded LIKE '%' + @search + '%'";

                    q += " OR @search = '' ORDER BY Serial_No DESC";
                    using (SqlCommand cm = new SqlCommand(q, c))
                    {
                        cm.Parameters.AddWithValue("@search", tsearch.Text.Trim());
                        using (SqlDataAdapter da = new SqlDataAdapter(cm))
                        {
                            ds = new DataSet();
                            da.Fill(ds, "tb_labdata");
                            dt = ds.Tables["tb_labdata"];

                            dgvdata.DataSource = ds.Tables["tb_labdata"];
                            //dgvdata.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                            dgvdata.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                            DataGridViewColumn colfsn = dgvdata.Columns[0];
                            colfsn.Width = 100;

                            DataGridViewColumn coldid = dgvdata.Columns[1];
                            coldid.Width = 300;

                            DataGridViewColumn colpab = dgvdata.Columns[2];
                            colpab.Width = 200;

                            DataGridViewColumn colname = dgvdata.Columns[3];
                            colname.Width = 200;

                            totrows();
                        }
                    }
                }
                catch (Exception ex)
                {
                    terror.Visible = true;
                    terror.Text = ex.Message;
                    dgvdata.DataSource = null;
                   
                }
            }
        }

        private void searchdoctype() 
        {
            try
            {
                lnulldocs.Visible = false;
                string q = "SELECT Serial_No, File_Name, Document_Type, Date_Uploaded FROM tb_labdata WHERE Document_Type LIKE '%" + cbtype.SelectedValue + "%' ORDER BY Serial_No DESC";
                SqlDataAdapter da = new SqlDataAdapter(q, c);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_labdata");

                dgvdata.DataSource = ds.Tables["tb_labdata"];

                //dgvdata.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvdata.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                DataGridViewColumn colfsn = dgvdata.Columns[0];
                colfsn.Width = 100;

                DataGridViewColumn coldid = dgvdata.Columns[1];
                coldid.Width = 300;

                DataGridViewColumn colpab = dgvdata.Columns[2];
                colpab.Width = 200;

                DataGridViewColumn colname = dgvdata.Columns[3];
                colname.Width = 200;

                totrows();
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
            }
        }

        private void totrows()
        {
            try
            {
                SqlCommand cm = new SqlCommand("SELECT * FROM tb_labdata", c);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();

                da.Fill(dt);
                precords.Text = "Found " + dgvdata.Rows.Count.ToString() + " records of " + dt.Rows.Count.ToString() + " entries";
            }
            catch (Exception ex)
            {
                terror.Visible = true;
                terror.Text = ex.Message;
            }
        }
        #endregion

        #region "VIEW FILE DETAILS"
        private void viewfile() 
        {
            frm_filelibrarydetails lt = new frm_filelibrarydetails();
            if (dgvdata.SelectedRows[0].Cells[2].Value.ToString() == "LABORATORY TEST RESULT")
            {
                ltrcode = dgvdata.SelectedRows[0].Cells[0].Value.ToString();

                lt.ShowDialog(this);
            }
            else if (dgvdata.SelectedRows[0].Cells[2].Value.ToString() == "CHAIN OF CUSTODY FORM (COC)")
            {
                ltrcode = dgvdata.SelectedRows[0].Cells[0].Value.ToString();

                lt.ShowDialog(this);
            }
            else if (dgvdata.SelectedRows[0].Cells[2].Value.ToString() == "DRAFT RESULT OF ANALYSES")
            {
                ltrcode = dgvdata.SelectedRows[0].Cells[0].Value.ToString();

                lt.ShowDialog(this);
            }
            else if (dgvdata.SelectedRows[0].Cells[2].Value.ToString() == "LABORATORY CALIBRATION CERTIFICATE")
            {
                ltrcode = dgvdata.SelectedRows[0].Cells[0].Value.ToString();

                lt.ShowDialog(this);
            }
            else if (dgvdata.SelectedRows[0].Cells[2].Value.ToString() == "LABORATORY PR/RECEIPT")
            {
                ltrcode = dgvdata.SelectedRows[0].Cells[0].Value.ToString();

                lt.ShowDialog(this);
            }
            else if (dgvdata.SelectedRows[0].Cells[2].Value.ToString() == "LABORATORY MEMO")
            {
                ltrcode = dgvdata.SelectedRows[0].Cells[0].Value.ToString();

                lt.ShowDialog(this);
            }
        }
        #endregion

        private void printfile() 
        {
            frm_filelibrary_print lt = new frm_filelibrary_print();
            if (dgvdata.SelectedRows[0].Cells[2].Value.ToString() == "LABORATORY TEST RESULT")
            {
                filecode = dgvdata.SelectedRows[0].Cells[0].Value.ToString();

                lt.ShowDialog(this);
            }
            else if (dgvdata.SelectedRows[0].Cells[2].Value.ToString() == "CHAIN OF CUSTODY FORM (COC)")
            {
                filecode = dgvdata.SelectedRows[0].Cells[0].Value.ToString();

                lt.ShowDialog(this);
            }
            else if (dgvdata.SelectedRows[0].Cells[2].Value.ToString() == "DRAFT RESULT OF ANALYSES")
            {
                filecode = dgvdata.SelectedRows[0].Cells[0].Value.ToString();

                lt.ShowDialog(this);
            }
            else if (dgvdata.SelectedRows[0].Cells[2].Value.ToString() == "LABORATORY CALIBRATION CERTIFICATE")
            {
                filecode = dgvdata.SelectedRows[0].Cells[0].Value.ToString();

                lt.ShowDialog(this);
            }
            else if (dgvdata.SelectedRows[0].Cells[2].Value.ToString() == "LABORATORY PR/RECEIPT")
            {
                filecode = dgvdata.SelectedRows[0].Cells[0].Value.ToString();

                lt.ShowDialog(this);
            }
            else if (dgvdata.SelectedRows[0].Cells[2].Value.ToString() == "LABORATORY MEMO")
            {
                filecode = dgvdata.SelectedRows[0].Cells[0].Value.ToString();

                lt.ShowDialog(this);
            }
        }

        private void downloadfile()
        {
            frm_filelibrary_download lt = new frm_filelibrary_download();
            if (dgvdata.SelectedRows[0].Cells[2].Value.ToString() == "LABORATORY TEST RESULT")
            {
                filecode = dgvdata.SelectedRows[0].Cells[0].Value.ToString();

                lt.ShowDialog(this);
            }
            else if (dgvdata.SelectedRows[0].Cells[2].Value.ToString() == "CHAIN OF CUSTODY FORM (COC)")
            {
                filecode = dgvdata.SelectedRows[0].Cells[0].Value.ToString();

                lt.ShowDialog(this);
            }
            else if (dgvdata.SelectedRows[0].Cells[2].Value.ToString() == "DRAFT RESULT OF ANALYSES")
            {
                filecode = dgvdata.SelectedRows[0].Cells[0].Value.ToString();

                lt.ShowDialog(this);
            }
            else if (dgvdata.SelectedRows[0].Cells[2].Value.ToString() == "LABORATORY CALIBRATION CERTIFICATE")
            {
                filecode = dgvdata.SelectedRows[0].Cells[0].Value.ToString();

                lt.ShowDialog(this);
            }
            else if (dgvdata.SelectedRows[0].Cells[2].Value.ToString() == "LABORATORY PR/RECEIPT")
            {
                filecode = dgvdata.SelectedRows[0].Cells[0].Value.ToString();

                lt.ShowDialog(this);
            }
            else if (dgvdata.SelectedRows[0].Cells[2].Value.ToString() == "LABORATORY MEMO")
            {
                filecode = dgvdata.SelectedRows[0].Cells[0].Value.ToString();

                lt.ShowDialog(this);
            }
        }


        private void frm_home_filelibrary_Load(object sender, EventArgs e)
        {
            loaddoctype();
            loaddata();
        }

        private void brefresh_Click(object sender, EventArgs e)
        {
            load.Show(this);
            Thread.Sleep(1000);
            loaddata();
            totrows();
            load.Close();
        }

        private void tsearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tsearch.Text))
            {
                dgvdata.DataSource = null;
                lnulldocs.Visible = true;
            }
            else 
            {
                lnulldocs.Visible = false;
                searchdata();
            }
        }

        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtype.Text == "--select document type--")
            {
                loaddata();
            }
            else
                searchdoctype();
        }

        private void cbtype_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbtype.Text == "--select document type--")
            {
                dgvdata.DataSource = null;
            }
            else
                searchdoctype();
        }

        private void bview_Click(object sender, EventArgs e)
        {
            load.Show(this);
            Thread.Sleep(1000);
            load.Close();
            viewfile();
        }

        private void bprint_Click(object sender, EventArgs e)
        {
            load.Show(this);
            Thread.Sleep(1000);
            load.Close();
            printfile();
        }

        private void bdownload_Click(object sender, EventArgs e)
        {
            load.Show(this);
            Thread.Sleep(1000);
            load.Close();
            downloadfile();
        }

        private void dgvdata_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvdata.ClearSelection();

            bview.Enabled = false;
            bprint.Enabled = false;
            bdownload.Enabled = false;
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bview.PerformClick();
        }

        private void dgvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            bview.Enabled = true;
            bprint.Enabled = true;
            bdownload.Enabled = true;
        }
    }
}
