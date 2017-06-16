using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamOneilSoftware
{
    public static class ExceptionExtensions
    {
        public static void ShowMessage(this Exception exc)
        {
            StringBuilder sb = new StringBuilder(exc.Message + $" ({exc.GetType().Name})");
            if (exc.InnerException != null)
            {
                sb.AppendLine();
                GetFullMessageR(sb, exc.InnerException, 0);
            }
            MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void GetFullMessageR(StringBuilder sb, Exception exc, int depth)
        {
            depth++;
            sb.AppendLine(new string('-', depth) + exc.Message + $" ({exc.GetType().Name})");
            if (exc.InnerException != null) GetFullMessageR(sb, exc.InnerException, depth);
        }
    }
}
