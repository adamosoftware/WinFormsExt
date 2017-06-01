using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamOneilSoftware
{
    public static class Shell
    {
        public static void ViewFileLocation(string fileName)
        {
            ProcessStartInfo psi = new ProcessStartInfo("explorer.exe");
            psi.Arguments = $"/select,{fileName}";
            Process.Start(psi);
        }
        
        public static void ViewFolder(string folder)
        {
            ProcessStartInfo psi = new ProcessStartInfo("explorer.exe");
            psi.Arguments = folder;
            Process.Start(psi);
        }

        public static void ViewDocument(string fileName)
        {
            ProcessStartInfo psi = new ProcessStartInfo(fileName);
            psi.UseShellExecute = true;
            Process.Start(psi);
        }
    }
}
