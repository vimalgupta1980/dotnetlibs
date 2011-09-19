using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.GUI;
using SysconCommon;

namespace SysconCommonTest
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var methods = new COMMethods();
            var username = methods.RequireSMBLogin();

            // SysconCommon.SMBReversed.SysconFldlib.EnsureSysconFldlibExists();

            Console.WriteLine("User [{0}] logged in", username);

            /*
            SysconCommon.SMBReversed.SysconFldlib.AddSFieldDefinition(
                "dedmap", "uninum", "Union Number", "payuni.recnum", "N", true, true, 0, 999999999);
            */

            methods.EditTableWithGrid("dedmap");

            // Console.ReadKey();
        }
    }
}
 