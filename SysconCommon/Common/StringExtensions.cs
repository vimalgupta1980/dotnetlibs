using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
