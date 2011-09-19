using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using SysconCommon.Common.Environment;
using SysconCommon;
using SysconCommon.Common;

namespace SysconCommon.SMBReversed
{
    public static class SysconFldlib
    {
        static public void EnsureSysconFldlibExists()
        {
            var mbdir = Env.GetMBDir();

            if (!File.Exists(mbdir + @"\syscon_fldlib.dbf"))
            {
                using (var con = Connections.GetOLEDBConnection())
                {
                    con.ExecuteNonQuery("select * from fldlib where tblnam == 'invalid table' into table syscon_fldlib");
                    // con.ExecuteNonQuery("delete from syscon_fldlib");
                }
            }
        }

#if false
        public static void AddSFieldDefinition(string table_name, string field_name, string field_description, string lookup_field, string field_type
            , bool include_in_guis, bool required_field, long min_value = 0, long max_value = 0)
        {
            if(lookup_field == null)
                lookup_field = "";

            using (var con = Connections.GetOLEDBConnection())
            {
                var exists = con.GetScalar<int>("select count(*) from syscon_fldlib where tblnam == '{0}' and fldnme == '{1}'", table_name, field_name);
                if (exists > 0)
                    return; // it already exists

                object last_fldnum_object = con.GetScalar<object>("select max(fldnum) from syscon_fldlib where tblnam == '{0}' and fldnme == '{1}'", table_name, field_name);
                var fldnum = last_fldnum_object == null ? 0 : Convert.ToInt32(last_fldnum_object) + 1;

                con.ExecuteNonQuery("insert into syscon_fldlib (tblnam, fldnum, fldnme, flddsc, fldtyp, relfld, scnrel, fldreq, lowval, hghval, wndbtn)" +
                    " values ('{0}', {1}, '{2}', '{3}', '{4}', '{5}', {6}, {7}, {8}, {9}, {10})"
                    , table_name, fldnum, field_name, field_description, field_type, lookup_field, lookup_field != "" ? 1 : 0, required_field ? 1 : 0
                    , min_value, max_value, lookup_field != "" ? 1 : 0);
            }
        }
#endif
    }

    
}
