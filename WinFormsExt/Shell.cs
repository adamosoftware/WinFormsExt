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
    }
}
