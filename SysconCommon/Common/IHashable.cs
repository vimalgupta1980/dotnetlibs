using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Security.Cryptography;

namespace SysconCommon.Common
{
    public interface IHashable
    {
        string UniqueHashSum { get; }
    }

    public class UniversalHashValueAttribute : Attribute
    {
        public readonly string HashValue;

        public UniversalHashValueAttribute(string hashValue)
        {
            HashValue = hashValue;
        }
    }

    public class NoHashValueExists : SysconException
    {
        public NoHashValueExists(object obj)
            : base("No hash value exists for {0}", obj)
        {
        }
    }

    public static class HashExtensionMethods
    {
        /// <summary>
        /// returns the hash sum of an object
        /// 
        /// there are 3 ways the hash sum can be calculated
        /// 1) The object implements IHashable
        /// 2) The object is an NHibernate object and has a primary key
        /// 3) The class of the object is marked with a UniversalHashValue attribute
        /// 
        /// in the case that none of these exist, a NoHashValueExists exception will be thrown
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="self"></param>
        /// <returns></returns>
        public static string GetHashSum<T>(this T self)
        {
            // the hash sum generator has been explicitly created by a developer
            if (self is IHashable)
                return ((IHashable)self).UniqueHashSum;

            // need to insert logic for nhibernate objects here, after talking
            // to rusty

            // check if the class has a universal hash value
            var hash_atts = from _att in typeof(T).GetCustomAttributes(typeof(UniversalHashValueAttribute), true)
                            from att in new UniversalHashValueAttribute[] { (UniversalHashValueAttribute) _att }
                            select att;

            if (!hash_atts.IsEmpty())
            {
                return hash_atts.First().HashValue;
            }

            // could not generate a hash value
            throw new NoHashValueExists(self);
        }

        // sample class that uses the utility function GetMD5Sum
        class SampleMd5SumIHashable : IHashable
        {
            int project_id = 42;
            int phase_id = 32;

            // this isn't important to the hashing, and will not effect the tmpCopy
            string non_unique_data = FunctionalOperators.CreateRandomString(20, 20);

            #region IHashable Members

            public string UniqueHashSum
            {
                get
                {
                    return this.GetMD5Sum(t => new
                    {
                        pid = this.project_id,
                        phid = this.phase_id
                    });
                }
            }

            #endregion
        }

        // this is a helper function to be used in implementing UniqueHashSum for IHashable objects
        public static string GetMD5Sum<T, U>(this T self, Func<T, U> getUniqueData)
        {
            var uniqStringVal = string.Join(",",
                typeof(U).GetMembers().Select(mi =>
                {
                    var key = mi.Name;

                    if (mi.MemberType == System.Reflection.MemberTypes.Property)
                        return string.Format("{0}:{1}", key, ((PropertyInfo)mi).GetValue(getUniqueData(self), null));
                    else if (mi.MemberType == MemberTypes.Field)
                        return string.Format("{0}:{1}", key, ((FieldInfo)mi).GetValue(getUniqueData(self)));
                    else
                        return string.Format("no_{0}", key);
                }).ToArray());

            var md5sp = new MD5CryptoServiceProvider();
            var data = md5sp.ComputeHash(System.Text.Encoding.ASCII.GetBytes(uniqStringVal));
            return typeof(T).Name + ":" + System.Text.Encoding.ASCII.GetString(data);
        }
    }
}
