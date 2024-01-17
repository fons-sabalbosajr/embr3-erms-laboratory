using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    class CustomFolderDialog
    {
        public CustomFolderDialog(string Description, string RootPath)
        {
            this.Description = Description;
            this.RootPath = RootPath;
        }

        public string Description = "Choose Folder...";
        public string RootPath = "";
        public string SelectedPath = "";

        public DialogResult ShowDialog()
        {
            var shelltype = Type.GetTypeFromProgID("Shell.Application");
            var shell = Activator.CreateInstance(shelltype);
            var folder = shelltype.InvokeMember("BrowseForFolder", BindingFlags.InvokeMethod, null, shell, new object[] { 0, Description, 0, RootPath });
            if (folder == null)
                return DialogResult.Cancel;
            else
            {
                var folderself = folder.GetType().InvokeMember("Self", BindingFlags.GetProperty, null, folder, null);
                SelectedPath = folderself.GetType().InvokeMember("Path", BindingFlags.GetProperty, null, folderself, null) as string;
                return DialogResult.OK;
            }
        }
    }
}
