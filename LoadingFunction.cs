using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    class LoadingFunction
    {
        frm_loadingform wait;
        Thread load;

        public void Show()
        {
            load = new Thread(new ThreadStart(LoadingProcess));
            load.Start();
        }
        public void Show(Form parent)
        {
            load = new Thread(new ParameterizedThreadStart(LoadingProcess));
            load.Start(parent);
        }

        public void Close()
        {
            if (wait != null)
            {
                wait.BeginInvoke(new System.Threading.ThreadStart(wait.CloseWaitForm));
                wait = null;
                load = null;
            }
        }
        private void LoadingProcess()
        {
            frm_loadingform wait = new frm_loadingform();
            wait.ShowDialog();
        }

        private void LoadingProcess(object parent)
        {
            Form parent1 = parent as Form;
            wait = new frm_loadingform(parent1);
            wait.ShowDialog();
        }
    }
}
