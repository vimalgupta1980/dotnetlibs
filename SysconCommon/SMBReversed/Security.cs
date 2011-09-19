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

        public static string omEncryptEx(string strUnencryptedString)
        {
            if (!string.IsNullOrEmpty(strUnencryptedString))
            {
                try
                {
                    string strPassword = "H3faLump";
                    RijndaelManaged managed = new RijndaelManaged();
                    byte[] buffer = Encoding.Unicode.GetBytes(strUnencryptedString);
                    byte[] rgbSalt = Encoding.ASCII.GetBytes(strPassword.Length.ToString());
                    PasswordDeriveBytes bytes = new PasswordDeriveBytes(strPassword, rgbSalt);
                    ICryptoTransform transform = managed.CreateEncryptor(bytes.GetBytes(0x20), bytes.GetBytes(0x10));
                    MemoryStream stream = new MemoryStream();
                    CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
                    stream2.Write(buffer, 0, buffer.Length);
                    stream2.FlushFinalBlock();
                    byte[] inArray = stream.ToArray();
                    stream.Close();
                    stream2.Close();
                    return Convert.ToBase64String(inArray);
                }
                catch (Exception exception)
                {
                    throw new SecurityException("Could not encrypt string: " + strUnencryptedString);
                }
            }
            return string.Empty;
        }

        public static string omEncrypt(string strUnencryptedString)
        {
            string str = string.Empty;
            int num = 0;
            StringBuilder builder = new StringBuilder();
            builder.Append(string.Empty);
            str = "";
            if (strUnencryptedString.Length > 0)
            {
                for (int i = 1; i <= strUnencryptedString.Length; i++)
                {
                    char ch = strUnencryptedString[i - 1];
                    if (ch.ToString()[0] >= '(')
                    {
                        char ch2 = strUnencryptedString[i - 1];
                        if (ch2.ToString()[0] <= '~')
                        {
                            goto Label_0069;
                        }
                    }
                    return str;
                Label_0069: ;
                }
                builder = new StringBuilder("");
                for (int j = 1; j <= strUnencryptedString.Length; j++)
                {
                    char ch3 = strUnencryptedString[j - 1];
                    num = ch3.ToString()[0] + '\x0014';
                    if (num > 0x7e)
                    {
                        num = (num - 0x7e) + 0x27;
                    }
                    builder.Append((char)num);
                }
                for (int k = 1; k <= builder.ToString().Length; k++)
                {
                    if ((k % 2) == 1)
                    {
                        str = str + builder.ToString()[k - 1].ToString();
                    }
                    else
                    {
                        str = builder.ToString()[k - 1].ToString() + str;
                    }
                }
            }
            return str;
        }

        public static string omDecrypt(string strEncryptedString)
        {
            string str = string.Empty;
            int num = 0;
            StringBuilder builder = new StringBuilder();
            builder.Append(string.Empty);
            string str2 = string.Empty;
            str = "";
            if (strEncryptedString.Length > 0)
            {
                for (int i = 1; i <= strEncryptedString.Length; i++)
                {
                    char ch = strEncryptedString[i - 1];
                    if (ch.ToString()[0] >= '\'')
                    {
                        char ch2 = strEncryptedString[i - 1];
                        if (ch2.ToString()[0] <= '~')
                        {
                            goto Label_0072;
                        }
                    }
                    return str;
                Label_0072: ;
                }
                builder = new StringBuilder("");
                str2 = strEncryptedString;
                do
                {
                    if ((str2.Length % 2) == 1)
                    {
                        builder.Append(str2.Substring(str2.Length - Math.Min(str2.Length, 1)));
                        str2 = str2.Substring(0, str2.Length - 1);
                    }
                    else
                    {
                        builder.Append(str2[0].ToString());
                        str2 = str2.Substring(str2.Length - (str2.Length - 1));
                    }
                }
                while (str2.Length != 0);
                for (int j = 1; j <= builder.ToString().Length; j++)
                {
                    char ch4 = builder.ToString()[j - 1];
                    num = ch4.ToString()[0] - '\x0014';
                    if (num == 0x13)
                    {
                        num = 0x4c;
                    }
                    if (num < 40)
                    {
                        num = (num + 0x7e) - 0x27;
                    }
                    str = ((char)num) + str;
                }
            }
            return str;
        }
    }
}
