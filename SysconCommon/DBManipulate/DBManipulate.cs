using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Data.OleDb;

using SysconCommon;
using SysconCommon.Common;
using SysconCommon.Algebras.DataTables;
using SysconCommon.Common.Environment;
using SysconCommon.Common.Validity;
using SysconCommon.GUI;
using SysconCommon.Foxpro;

namespace SysconCommon.DBManipulate
{
    public static class DBManipulate
    {
        private static void Log(string msg, params object[] msgArgs)
        {
            Env.Log(msg, msgArgs);
        }

        private static void RunSql(this OleDbConnection con, string msg, params object[] args)
        {
            Log("SQL: " + msg, args);
            // con.ExecuteNonQuery(msg, args);
            var cmd = con.CreateCommand();
            cmd.CommandText = string.Format(msg, args);
            int rows_effected = cmd.ExecuteNonQuery();
            Log(" - Effected {0} rows", rows_effected);
        }

        public static string GetReferences(string tblnam, string fieldname, string remapping_dir, bool allow_edit = true)
        {
            using (var con = Connections.GetOLEDBConnection())
            {
                // make sure our mappings exist
                var dest = string.Format("{0}/{1}_{2}_refs", remapping_dir, tblnam, fieldname);
                if (!File.Exists(dest + ".dbf"))
                {
                    con.ExecuteNonQuery("select recno() as recno, 1 as updte, cast(tblnam as varchar(30)) as tblnam, cast(fldnme as varchar(30)) as fldnme from fldlib where relfld = '{0}.{1}' into table {2}", tblnam, fieldname, dest.FoxproQuote());
                }

                if (allow_edit)
                {
                    // get a table of mappings
                    con.FoxproUserEdit(dest, true,
                        DTColumns.SetIndexColumns("recno"),
                        DTColumns.DisallowNulls(),
                        DTColumns.HideColumns("recno"),
                        DTColumns.SetFillColumn("fldnme"),
                        DTColumns.CheckBoxColumns("updte"),
                        DTColumns.SetCaptions("tblnam", "Table", "fldnme", "Field", "updte", "Update")
                        );
                }

                // return our list
                return dest;
            }
        }

        public static string GetRemappings(string tblnam, string fieldname, string remapping_dir, object[,] mappings, bool allow_edit, bool start_new, params string[] display_fields)
        {
            using (var con = Connections.GetOLEDBConnection())
            {
                
                // do update
                var dest = string.Format("{0}/{1}_{2}_remap", remapping_dir, tblnam, fieldname);

                if (start_new && File.Exists(dest + ".dbf"))
                {
                    File.Delete(dest + ".dbf");
                }

                if (!File.Exists(dest + ".dbf") || start_new)
                {
                    var selectFields = new string[] { "recno() as recno", "1 as updte", "0 as remove", fieldname + " as oldid", fieldname + " as newid" }.Concat(display_fields);
                    var selectsql = string.Format("select {0} from {1} into table {2}",
                        string.Join(",", selectFields), tblnam, dest.FoxproQuote());

                    con.ExecuteNonQuery("{0}", selectsql);
                }

                if (allow_edit)
                {
                    con.FoxproUserEdit(dest, true,
                        DTColumns.SetIndexColumns("recno"),
                        DTColumns.DisallowNulls(),
                        DTColumns.HideColumns("recno"),
                        DTColumns.ReadOnly(),
                        DTColumns.AllowEdit("updte", "newid", "oldid"),
                        DTColumns.CheckBoxColumns("updte", "remove"),
                        DTColumns.SetFillColumn("cdenme"),
                        DTColumns.SetCaptions("oldid", "Original", "newid", "New", "cdenme", "Name", "updte", "Update")
                        );
                }

                return dest;
            }
        }

        public static void BuildRemapping(string tblnam, string fieldname, string remapping_dir, object[,] mappings, params string[] display_fields)
        {
            Log("Remapping {0}.{1}", tblnam, fieldname);

            if (remapping_dir == null)
            {
                remapping_dir = Env.GetTempPath() + "/SysconRemap";
            }

            Env.EnsureDirectoryExists(remapping_dir);
            var dest = string.Format("{0}/{1}_remap", remapping_dir, tblnam);

            using (var con = Connections.GetOLEDBConnection())
            {
                var refsdt = con.GetDataTable("Refs", "select * from {0}", GetReferences(tblnam, fieldname, remapping_dir).FoxproQuote());
                var edits = GetRemappings(tblnam, fieldname, remapping_dir, mappings, true, true, display_fields);

                RunSql(con, "update _target set _target.{0} = dest.newid"
                    + " from {1} _target"
                    + " join {2} dest on _target.{0} = dest.oldid and dest.updte = 1 and dest.oldid <> dest.newid"
                    , fieldname, tblnam, edits.FoxproQuote());

                foreach(var row in refsdt.Rows.ToIEnumerable()) 
                {
                    if (Convert.ToInt64(row["updte"]) != 1)
                        continue;

                    RunSql(con, "update _target set _target.{0} = dest.newid"
                        + " from {1} _target"
                        + " join {2} dest on _target.{0} = dest.oldid and dest.updte = 1 and dest.oldid <> dest.newid"
                        , row["fldnme"], row["tblnam"], edits.FoxproQuote());
                }
            }
        }
    }
}
