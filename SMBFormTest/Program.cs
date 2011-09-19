using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

// using Sage.SMB.MasterBuilder.Forms.GL;
using System.Reflection;

namespace SMBFormTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // var frm = new Frm1_6();
            var fs = new FileStream(@"c:\mb7\programs\sagemasterbuilder.exe", FileMode.Open, FileAccess.Read);
            var br = new BinaryReader(fs);
            var binData = br.ReadBytes(Convert.ToInt32(fs.Length));

            var assm = Assembly.Load(binData);
            var o = assm.CreateInstance("Sage.SMB.MasterBuilder.Forms.GL.Frm1_6");
        }
    }
}
