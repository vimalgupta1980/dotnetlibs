using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;    

namespace SysconCommon.SMBReversed
{
    public class SecurityException : SysconCommon.Common.SysconException
    {
        public SecurityException(string msg) : base(msg) { }
    }

    public static class Security
    {
        public static string omDecryptEx(string strEncryptedString)
        {
            if (!string.IsNullOrEmpty(strEncryptedString))
            {
                try
                {
                    string strPassword = "H3faLump";
                    RijndaelManaged managed = new RijndaelManaged();
                    byte[] buffer = Convert.FromBase64String(strEncryptedString);
                    byte[] rgbSalt = Encoding.ASCII.GetBytes(strPassword.Length.ToString());
                    PasswordDeriveBytes bytes = new PasswordDeriveBytes(strPassword, rgbSalt);
                    ICryptoTransform transform = managed.CreateDecryptor(bytes.GetBytes(0x20), bytes.GetBytes(0x10));
                    MemoryStream stream = new MemoryStream(buffer);
                    CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
                    byte[] buffer3 = new byte[buffer.Length];
                    int count = stream2.Read(buffer3, 0, buffer3.Length);
                    stream.Close();
                    stream2.Close();
                    return Encoding.Unicode.GetString(buffer3, 0, count);
                }
                catch
                {
                    throw new SecurityException("Could not decrypt string"); 
                }
            }

            return string.Empty;
        }
    }
}
