using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

using SysconCommon.Common;

namespace SysconCommon.GUI
{
    static public class DataGridViewExtensions
    {
        /// <summary>
        /// defines morphism from a datagridview to a datatable
        /// this and the ability to define the recordsource of a
        /// datagridview to a datatable define a complete
        /// isomorphism
        /// </summary>
        static public DataTable GetDataTable(this DataGridView self)
        {
            var dt = new DataTable();
            foreach(var i in FunctionalOperators.Range(self.Columns.Count))
            {

            }

            throw new NotImplementedException();
        }
    }
}
