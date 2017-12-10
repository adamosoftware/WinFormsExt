using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AdamOneilSoftware
{
    public static class DataGridViewExtensions
    {
        public static void FillFromEnum<TEnum>(this DataGridViewComboBoxColumn column)
        {
            column.DataSource = (from TEnum enumVal in Enum.GetValues(typeof(TEnum))
                                 select new KeyValuePair<int, string>(Convert.ToInt32(enumVal), enumVal.ToString())).ToList();
            column.ValueMember = "Key";
            column.DisplayMember = "Value";
        }
    }
}