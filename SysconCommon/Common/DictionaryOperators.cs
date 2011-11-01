using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Common.Validity;

namespace SysconCommon.Common
{
    public class KeyExistsException : SysconException
    {
        public KeyExistsException(string keyname) : base(string.Format("Key exists already: {0}", keyname)) { }
    }

    static public class DictionaryOperators
    {
        public static IDictionary<T, U> TupsToDictionary<T,U>(this IEnumerable<Tuple<T,U>> self)
        {
            var dict = new Dictionary<T, U>();
            foreach (var tup in self)
            {
                dict[tup.First] = tup.Second;
            }

            return dict;
        }

        /// <summary>
        /// returns a dictionary that represents the object
        /// </summary>
        /// <typeparam name="InputType"></typeparam>
        /// <param name="self"></param>
        /// <returns></returns>
        public static IDictionary<string, object> ToDictionary<InputType>(this InputType self)
        {
            var dict = new Dictionary<string, object>();
            var type = typeof(InputType);

            foreach (var pi in type.GetProperties())
            {
                Validity.Validity.Assert(!dict.Keys.Contains(pi.Name), 
                    "Multiple members with same name ({0}) not allowed", pi.Name);
                dict.Add(pi.Name, pi.GetValue(self, null));
            }

            foreach (var fi in type.GetFields())
            {
                Validity.Validity.Assert(!dict.Keys.Contains(fi.Name), 
                    "Multiple members with same name ({0}) not allowed", fi.Name);
                dict.Add(fi.Name, fi.GetValue(self));
            }

            return dict;
        }

        /// <summary>
        /// build a list of an arbitrary types from key/value pairs
        /// </summary>
        /// <typeparam name="T">The element type of the returned list</typeparam>
        /// <typeparam name="KeyType">The dictionary key type</typeparam>
        /// <typeparam name="ValType">The dictionary value type</typeparam>
        /// <param name="self"></param>
        /// <param name="selector">Function to convert (key:KeyType,val:ValType) to a t:T</param>
        /// <returns></returns>
        public static IEnumerable<T> Select<T, KeyType, ValType>(
            this IDictionary<KeyType, ValType> self,
            Func<KeyType, ValType, T> selector)
        {
            foreach (var k in self.Keys)
                yield return selector(k, self[k]);
        }

        public static IDictionary<KeyType, ValType> Combine<KeyType, ValType>(this IDictionary<KeyType, ValType> self, IDictionary<KeyType, ValType> other)
        {
            var result = new Dictionary<KeyType, ValType>();

            foreach (var k in self.Keys)
            {
                if (result.Keys.Contains(k))
                    throw new KeyExistsException(k.ToString());

                result[k] = self[k];
            }

            foreach (var k in other.Keys)
            {
                if (result.Keys.Contains(k))
                    throw new KeyExistsException(k.ToString());

                result[k] = other[k];
            }

            return result;
        }
    }
}
