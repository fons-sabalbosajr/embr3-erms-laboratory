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
    public partial class frm_dashboard_libraries : Form
    {
        public frm_dashboard_libraries()
        {
            InitializeComponent();
            
        }
        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        LoadingFunction load = new LoadingFunction();

        private void frm_dashboard_libraries_Load(object sender, EventArgs e)
        {
            lfoldername.Text = frm_dashboard.doctype;

        }
    }
}
