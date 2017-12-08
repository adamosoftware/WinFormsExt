using System.ComponentModel;
using System.Windows.Forms;

namespace AdamOneilSoftware
{
    public static class UserControlExtensions
    {
        public static bool IsDesignMode(this UserControl userControl)
        {
            return (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
        }
    }
}