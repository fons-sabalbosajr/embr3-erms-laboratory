using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    public partial class frm_z_shutdown : Form
    {
        public frm_z_shutdown()
        {
            InitializeComponent();
        }

        private void breadmore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please be advised that all ERMS Online Systems will be inaccessible from August 25, 2023 to August 31, 2023.\n" +
                "The purpose of this maintenance is to move the Database Connection from the local PC to our office's server in order to \n" +
                "maintain the security of our data and other files on our system. \n\nStarting Aug 25, 2023, all online systems will undergo a " +
                "shutdown update and will be inaccessible until the system maintenance is completed.More information will be available soon.",
                "System Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frm_z_shutdown_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void frm_z_shutdown_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
