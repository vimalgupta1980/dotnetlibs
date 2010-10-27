using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using SysconCommon.Common;

namespace SysconCommon.Algebras.DataTables
{
    public class ColumnOrderAttribute : Attribute
    {
        public readonly int ColumnOrder;

        public ColumnOrderAttribute(int order)
        {
            ColumnOrder = order;
        }
    }

    public static partial class DataTableExtensions
    {
        public static int GetColumnOrder(this MemberInfo mi)
        {
            var attr = (from att in mi.GetCustomAttributes(false)
                        where att is ColumnOrderAttribute
                        select att).FirstOrDefault();

            return attr != null ? (attr as ColumnOrderAttribute).ColumnOrder : -1;
        }
    }
}
