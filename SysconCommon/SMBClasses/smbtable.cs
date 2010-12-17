using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using SysconCommon.Common.Environment;
using SysconCommon.Common;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables
{
    public class smbtable
    {
        public override bool Equals(object obj)
        {
            if (this.GetType() != obj.GetType())
                return false;

            var type = this.GetType();
            
            foreach (var fi in type.GetFields())
            {
                if (!fi.GetValue(this).Equals(fi.GetValue(obj)))
                {
                    return false;
                }
            }

            // all fields match
            return true;
        }

        public override int GetHashCode()
        {
            return 1;
        }

        public static T[] GetAll<T>(string tblname)
            where T: smbtable, new()
        {
            if(tblname == null)
                tblname = typeof(T).Name;

            var dt = Connections.Connection.GetDataTable(tblname, "select * from " + tblname);
            return dt.ToList<T>().ToArray();
        }

        public static T[] GetAll<T>()
            where T : smbtable, new()
        {
            return GetAll<T>(null);
        }

        public static T[] Get<T>(string sql)
            where T: smbtable, new()
        {
            var dt = Connections.Connection.GetDataTable("tmptable", sql);
            return dt.ToList<T>().ToArray();
        }

        public virtual void Save(params string[] UpdateFields)
        {
            var mytype = this.GetType();
            var tblname = mytype.Name;

            var members = from m in mytype.GetFields()
                          where m.GetCustomAttributes(typeof(SMBFieldNameAttribute), false).Length > 0
                          select m;

            if (UpdateFields.Length == 0)
            {
                var names = (from m in members
                             select ((SMBFieldNameAttribute)m.GetCustomAttributes(typeof(SMBFieldNameAttribute), false).First()).name).ToArray();

                var values = (from m in members
                              select m.GetValue(this).ToString()).ToArray();

                string sql = string.Format("insert into {0} ({1}) values ('{2}')", tblname, string.Join(",", names), string.Join("','", values));

                using (var cmd = Connections.Connection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }

    public class SMBFieldDescriptionAttribute : Attribute
    {
        public readonly string description;
        public SMBFieldDescriptionAttribute(string desc)
        {
            description = desc;
        }
    }

    public class SMBFieldNameAttribute : Attribute
    {
        public readonly string name;
        public SMBFieldNameAttribute(string name)
        {
            this.name = name;
        }
    }
}
