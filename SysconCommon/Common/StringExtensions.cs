using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Antlr.StringTemplate;

namespace SysconCommon.Common
{
    public static class StringExtensions
    {
        public static string NullToBlank(this string self)
        {
            return self == null ? "" : self;
        }

        public static string Base64Encode(this string self)
        {
            byte[] bytes = ASCIIEncoding.ASCII.GetBytes(self);
            return Convert.ToBase64String(bytes);
        }

        public static string Base64Decode(this string self)
        {
            byte[] bytes = Convert.FromBase64String(self);
            return ASCIIEncoding.ASCII.GetString(bytes);
        }

        public static string AddBS(this string self)
        {
            if (self[self.Length - 1] == '\\')
                return self;

            return self + "\\";
        }
    }

    public class SysconTemplate
    {
        private readonly string _template;
        private readonly StringTemplate _st;

        private SysconTemplate(string template_string)
        {
            _template = template_string;
            _st = new StringTemplate(_template);
        }

        public void SetAttribute<T>(string att, T val)
        {
            _st.SetAttribute(att, val);
        }

        public void SetAttributes<T>(IDictionary<string, T> atts)
        {
            foreach (var k in atts.Keys)
            {
                SetAttribute(k, atts[k]);
            }
        }

        public static SysconTemplate FromString(string template_string)
        {
            return new SysconTemplate(template_string);
        }

        public static SysconTemplate FromFile(string filename)
        {
            var _str = File.ReadAllText(filename);
            return FromString(_str);
        }

        public override string ToString()
        {
            return _st.ToString();
        }
    }
}
