using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

using SysconCommon.Common;
using SysconCommon.Algebras.DataTables;

namespace SysconCommon.GUI
{
    static public class DataGridViewExtensions
    {
        static public IEnumerable<DataGridViewColumn> ToIEnumerable(this DataGridViewColumnCollection self)
        {
            foreach (DataGridViewColumn column in self)
                yield return column;
        }

        static public void SetSysconDataTable(this DataGridView self, DataTable dt)
        {
            self.DataSource = dt;

            var to_remove = new List<DataGridViewColumn>();

            foreach (var i in FunctionalOperators.Range(self.Columns.Count))
            {
                var c = self.Columns[i];
                var dc = dt.Columns[c.DataPropertyName];
                
                if (dc == null)
                    continue;

                var ctype = dc.GetExtendedProp<Type>("ViewColumnType", null);

                if (ctype != null)
                {
                    if (ctype == typeof(DataGridViewCheckBoxColumn))
                    {
                        var checkc = new DataGridViewCheckBoxColumn();
                        checkc.DataPropertyName = c.DataPropertyName;
                        checkc.Name = c.Name;

                        if (dc.DataType != typeof(bool))
                        {
                            checkc.FalseValue = 0;
                            checkc.TrueValue = 1;
                        }

                        checkc.DisplayIndex = c.DisplayIndex;
                        self.Columns.Add(checkc);

                        to_remove.Add(c);
                        c = checkc;
                    }
                }

                if (dc.Caption != null)
                    c.HeaderText = dc.Caption;

                c.Visible = dc.GetExtendedProp("Visible", true);

                if (dc.GetExtendedProp("ViewFill", false))
                {
                    c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }

                var colord = dc.GetExtendedProp<int>("DisplayIndex", -1);
                if (colord > -1)
                {
                    c.DisplayIndex = colord;
                }
            }

            foreach (var c in to_remove)
            {
                self.Columns.Remove(c);
            }
        }
    }
}
