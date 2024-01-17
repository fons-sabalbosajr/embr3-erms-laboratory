using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    public partial class frm_filelibrary_print : Form
    {
        public frm_filelibrary_print()
        {
            InitializeComponent();
            tfilename.ReadOnly = true;
        }
        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        LoadingFunction load = new LoadingFunction();

        private void frm_filelibrary_print_Load(object sender, EventArgs e)
        {
            printfilelibrary();
        }

        private void printfilelibrary() 
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
                    lfsn.Text =         dt.Rows[0][0].ToString();
                    tfilename.Text =    dt.Rows[0][1].ToString();
                    luploaded.Text =    dt.Rows[0][2].ToString();
                    ldateuploaded.Text = dt.Rows[0][3].ToString();
                    ldoctype.Text =     dt.Rows[0][4].ToString();
                    tfileloc.Text =     dt.Rows[0][5].ToString();
                }
                c.Open();
                query.ExecuteNonQuery();
                c.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("File Load Failed. \n" + ex.Message + "\n" + ex.StackTrace, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.Close();
            }
        }

        private void print()
        {
            try
            {
                if (string.IsNullOrEmpty(tfilename.Text))
                {
                    MessageBox.Show("File Not Found, Print Failed", "Failed to print", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    ProcessStartInfo info = new ProcessStartInfo();
                    info.Verb = "Print";
                    info.FileName = tfileloc.Text;
                    info.CreateNoWindow = true;
                    info.WindowStyle = ProcessWindowStyle.Hidden;

                    Process p = new Process();
                    p.StartInfo = info;
                    p.Start();

                    p.WaitForInputIdle();
                    Thread.Sleep(3000);
                    if (false == p.CloseMainWindow())
                        p.Kill();

                    MessageBox.Show("File has successfully printing. Click print button to print again.", "Print File Sucessfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("File Load Failed File Path \n from Drive is not available. Check your settings. \n" 
                    + ex.Message + "\n" + ex.StackTrace, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bprint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Print File?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                load.Show(this);
                Thread.Sleep(1000);
                load.Close();
                print();
            }
        }

        private void bcancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel print file?", "Cancel Process", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lfsn.Text = "--";
                tfilename.Clear();
                luploaded.Text = "--";
                ldateuploaded.Text = "--";
                tfileloc.Text = "--";
                this.Hide();
            }
        }

        private void frm_filelibrary_print_FormClosing(object sender, FormClosingEventArgs e)
        {
            lfsn.Text = "--";
            tfilename.Clear();
            luploaded.Text = "--";
            ldateuploaded.Text = "--";
            tfileloc.Text = "--";
            this.Hide();
            e.Cancel = true;
        }
    }
}
