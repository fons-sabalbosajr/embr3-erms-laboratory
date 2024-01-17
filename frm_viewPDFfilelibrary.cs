using AxAcroPDFLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    public partial class frm_viewPDFfilelibrary : Form
    {
        public frm_viewPDFfilelibrary()
        {
            InitializeComponent();
        }

        public string pdffile;
        private void frm_viewPDFfilelibrary_Load(object sender, EventArgs e)
        {
            var input = new Thread(showall);
            input.SetApartmentState(ApartmentState.STA);
            input.Start();
        }
        private void showall()
        {
            try
            {
                SetLoading(true);
                openPDFAllrecords();
                SetLoading(false);
            }
            catch (Exception)
            {
                SetLoading(false);
            }
        }

        private void SetLoading(bool displayLoader)
        {
            if (displayLoader)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.Cursor = Cursors.WaitCursor;
                    openPDFAllrecords();

                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.Cursor = Cursors.Default;
                    openPDFAllrecords();

                });
            }
        }


        private void openPDFAllrecords()
        {
            AxAcroPDF pdf = new AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(pdf)).BeginInit();
            pdf.Dock = DockStyle.Fill;
            this.Controls.Add(pdf);
            ((System.ComponentModel.ISupportInitialize)(pdf)).EndInit();
            pdffile = frm_filelibrarydetails.filepath;
            viewpdffile.LoadFile(pdffile);
        }

    }
}
