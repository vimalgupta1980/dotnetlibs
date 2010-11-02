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
    }
}
