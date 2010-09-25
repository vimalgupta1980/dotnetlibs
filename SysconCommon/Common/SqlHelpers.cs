using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

using SysconCommon.Algebras.DataTables;

namespace SysconCommon.Common
{
    public static class SqlHelpers
    {
        static public T GetScalar<T>(this IDbConnection self, string sqlfmt, params object[] sqlargs)
        {
            try
            {
                var sql = string.Format(sqlfmt, sqlargs);

                using (var cmd = self.CreateCommand())
                {
                    cmd.CommandText = sql;
                    var result = cmd.ExecuteScalar();

                    if (result == DBNull.Value || result == null)
                        return default(T);

                    return (T) Convert.ChangeType(result, typeof(T));
                }
            }
            catch (Exception ex)
            {
                throw new SysconException(ex);
            }
        }

        static DataTable GetDataTable(this IDbConnection self, string sqlfmt, params object[] sqlargs)
        {
            try
            {
                using (var cmd = self.CreateCommand())
                {
                    cmd.CommandText = string.Format(sqlfmt, sqlargs);
                    var reader = cmd.ExecuteReader();
                    var dt = new DataTable();

                    foreach (var i in FunctionalOperators.Range(reader.FieldCount))
                    {
                        dt.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                    }

                    while (reader.Read())
                    {
                        var row = dt.NewRow();
                        foreach (var dc in dt.Columns.ToIEnumerable())
                        {
                            row[dc] = reader[dc.ColumnName];
                        }
                        dt.Rows.Add(row);
                    }

                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new SysconException(ex);
            }
        }
    }
}
