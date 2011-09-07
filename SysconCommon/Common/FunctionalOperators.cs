/// This file contains a set of very general functions that can be used for many tasks
/// you could say it is related to Structures.cs

using System;
// using System.Numerics;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using System.Security.Cryptography;
using SysconCommon.GUI;

namespace SysconCommon.Common
{
    /// <summary>
    /// This defines some very common functional utility functions that can be used to make a
    /// very wide variety of more complex functions by simple composition, these functions are
    /// well known and studied.  The most popular known functions that are not included are
    /// fold and map; this is because .NET 3.5 provides the equivelant Aggregate and Select
    /// functions.
    /// </summary>
    public static class FunctionalOperators
    {
        public static Dictionary<T,U> Copy<T,U>(this Dictionary<T, U> self)
        {
            var copy = new Dictionary<T, U>();
            foreach (var k in self.Keys)
                copy[k] = self[k];

            return copy;
        }

        public static string RSAEncrypt(this string inputString, int dwKeySize, string xmlKeys)
        {
            RSACryptoServiceProvider provider = new RSACryptoServiceProvider(dwKeySize);
            provider.FromXmlString(xmlKeys);
            int keysize = dwKeySize / 8;
            byte[] bytes = Encoding.UTF32.GetBytes(inputString);
            int maxLength = keysize - 42;
            int dataLength = bytes.Length;
            int iterations = dataLength / maxLength;
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i <= iterations; i++)
            {
                byte[] tempBytes = new byte[
                    (dataLength - maxLength * i > maxLength) ? maxLength : dataLength - maxLength * i];
                Buffer.BlockCopy(bytes, maxLength * i, tempBytes, 0, tempBytes.Length);
                byte[] encrypted_bytes = provider.Encrypt(tempBytes, true);
                builder.Append(Convert.ToBase64String(encrypted_bytes));
            }

            return builder.ToString();
        }

        public static string RSADecrypt(this string inputString, int dwKeySize, string xmlKeys)
        {
            RSACryptoServiceProvider provider = new RSACryptoServiceProvider(dwKeySize);
            provider.FromXmlString(xmlKeys);
            int base64BlockSize = ((dwKeySize / 8) % 3 != 0) ?
                (((dwKeySize / 8) / 3) * 4) + 4 : ((dwKeySize / 8) / 3) * 4;
            int iterations = inputString.Length / base64BlockSize;

            var progress = new ProgressDialog(iterations);
            progress.Text = "Decrypting";
            progress.Show();

            try
            {
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < iterations; i++)
                {
                    progress.Tick();
                    byte[] encryptedBytes = Convert.FromBase64String(inputString.Substring(base64BlockSize * i, base64BlockSize));
                    arrayList.AddRange(provider.Decrypt(encryptedBytes, true));
                }

                return Encoding.UTF32.GetString(arrayList.ToArray(Type.GetType("System.Byte")) as byte[]);
            }
            finally
            {
                progress.Close();
            }
        }

        public static T FirstOrDefault<T>(this IEnumerable<T> self, T defaultValue)
        {
            if (self.IsEmpty())
                return defaultValue;
            else
                return self.First();
        }

        public static T MinOrDefault<T>(this IEnumerable<T> self)
        {
            if (self.IsEmpty())
                return default(T);

            else
                return self.Min();
        }

        public static T MaxOrDefault<T>(this IEnumerable<T> self)
        {
            if (self.IsEmpty())
                return default(T);
            else
                return self.Max();
        }

        public static int IndexOf<T>(this T[] self, T needle)
        {
            foreach (var i in Range(self.Length))
            {
                if (self[i].Equals(needle))
                    return i;
            }

            throw new SysconException("Could not find element in array");
        }

        // used to get different random numbers all the time, better than time based because
        // we may get 2 in the same ms
        private static int next_seed = Convert.ToInt32(DateTime.Now.Ticks % 1000000);
        
        /// <summary>
        /// infinite list of naturals (starting with 1)
        /// </summary>
        public static IEnumerable<int> Naturals
        {
            get
            {
                return CountFrom(1);
            }
        }

        public static IEnumerable<int> CountFrom(int beginning)
        {

            var i = beginning;

            while (true)
                yield return i++;
        }

        /// <summary>
        /// returns an infinite list of random integers
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static IEnumerable<int> CreateRandomInts(int minValue, int maxValue)
        {
            var r = new Random(next_seed++);
            while (true) { yield return r.Next(minValue, maxValue); }
        }

        public static IEnumerable<bool> CreateRandomBools()
        {
            var r = new Random(next_seed++);
            while (true) { yield return r.Next(1,2) == 1 ? true : false; }
        }

        public static IEnumerable<char> CreateRandomChars()
        {
            var r = new Random(next_seed++);
            foreach (var b in CreateRandomBools())
            {
                yield return (char) (b ? CreateRandomInts('a', 'z') : CreateRandomInts('A', 'Z')).First();
            }
        }

        public static string CreateRandomString(int minLength, int maxLength)
        {
            return new string(CreateRandomChars().Take(RandomNaturals.First() % maxLength + minLength).ToArray());
        }

        /// <summary>
        /// returns an infinite list of random integers
        /// </summary>
        public static IEnumerable<int> RandomInts
        {
            get
            {
                return CreateRandomInts(int.MinValue, int.MaxValue);
            }
        }

        /// <summary>
        /// returns an infinite list of random integers that are >= 1
        /// </summary>
        public static IEnumerable<int> RandomNaturals
        {
            get
            {
                return CreateRandomInts(1, int.MaxValue);
            }
        }

        /// <summary>
        /// flatten a list of lists
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="self"></param>
        /// <returns></returns>
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> self)
        {
            foreach (var i in self)
                foreach (var j in i)
                    yield return j;
        }

        /// <summary>
        /// uses a function to combine the elements in two lists to a list of Tuples, stopping
        /// as soon as one of the lists are empty, this is done lazily so infinite lists are fine
        /// ie... 
        /// new int[] { 1, 2, 3 }.Zip(new char[] { 'a', 'b', 'c', 'd' })
        ///    = new Tuple &lt;int,char&gt; [] {(1, 'a'), (2, 'b'), (3, 'c')}
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="ts"></param>
        /// <param name="us"></param>
        /// <returns></returns>
        public static IEnumerable<Tuple<T, U>> Zip<T, U>(this IEnumerable<T> ts, IEnumerable<U> us)
        {
            return ts.ZipWith(us, (t, u) => new Tuple<T, U>(t, u));
        }

        /// <summary>
        /// returns an infinite list with a single repeating item
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="self"></param>
        /// <returns></returns>
        public static IEnumerable<T> Repeat<T>(this T self)
        {
            while (true)
                yield return self;
        }

        /// <summary>
        /// returns a finite list with a single item repeated {count} times
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="self"></param>
        /// <param name="count">times to repeat</param>
        /// <returns></returns>
        public static IEnumerable<T> Repeat<T>(this T self, int count)
        {
            foreach (var i in Range(count))
            {
                yield return self;
            }
        }



        /// <summary>
        /// Naive implementation of quicksort.  This isn't very efficient so if you have a large
        /// collection, use .NET's sorting API.  This one is more convenient for small collections
        /// though because you don't have to implement any interfaces for it to work.
        /// 
        /// One place it is efficient is if you don't need a complete sort, if you only need the
        /// first few items say, then this will only sort it as much as required to find those
        /// because this is lazy... 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lst"></param>
        /// <param name="compareFunc"></param>
        /// <returns></returns>
        public static IEnumerable<T> Sort<T>(this IEnumerable<T> lst, Func<T, T, int> compareFunc)
        {
            // empty list
            if(lst.IsEmpty())
                return lst;

            // not empty 
            var head = lst.First();
            var tail = lst.Tail();

            // only one element
            if (tail.IsEmpty())
                return lst;

            // > 1 element
            return 
                // [sorted list of items < head]
                (tail.Where(i => compareFunc(i, head) < 0).Sort(compareFunc)) 
                    // [head]
                    .Concat(new T[] { head }) 
                    // [sorted list of items >= head]
                    .Concat(tail.Where(i => compareFunc(i, head) >= 0).Sort(compareFunc)); 

        }

        public static void InsertSorted<T>(this List<T> self, Func<T, T, int> compare_func, T value)
        {
            foreach (var i in Range(self.Count))
            {
                if (compare_func(self[i], value) >= 0)
                {
                    self.Insert(i, value);
                    return;
                }
            }

            // nothing is larger
            self.Add(value);
        }

        public static List<T> InsertSort<T>(this IEnumerable<T> lst, Func<T, T, int> compareFunc)
        {
            var slist = new List<T>();
            foreach (var i in lst)
            {
                slist.InsertSorted(compareFunc, i);
            }

            return slist;
        }

        /// <summary>
        /// retrieves all elements after the first one in a list, maintains order
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lst"></param>
        /// <returns></returns>
        public static IEnumerable<T> Tail<T>(this IEnumerable<T> lst)
        {
            bool pastHead = false;
            foreach (var l in lst)
            {
                if (!pastHead)
                {
                    pastHead = true;
                    continue;
                }

                yield return l;
            }
        }

        /// <summary>
        /// check if a list is empty without having to call the expensive
        /// function Count(), Count() also fails to terminate on inifinite 
        /// lists and this will not
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lst"></param>
        /// <returns></returns>
        public static bool IsEmpty<T>(this IEnumerable<T> lst)
        {
            foreach (var l in lst)
                return false;

            return true;
        }

        /// <summary>
        /// returns a function which will incrementally return each member of the list,
        /// ie... if you pass Naturals, it will return 1 the first call, 2 the second,
        /// and so on.
        /// </summary>
        /// <typeparam name="T">The type of value that is generated</typeparam>
        /// <param name="self">The list of values to generate</param>
        /// <returns></returns>
        public static Func<T> ToGenerator<T>(this IEnumerable<T> self)
        {
            var enumerator = self.GetEnumerator();
            return () =>
            {
                if (!enumerator.MoveNext())
                    throw new SysconException("Generator ran out of values");

                return enumerator.Current;
            };
        }

        /// <summary>
        /// removes duplicate elements from a list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lst"></param>
        /// <returns></returns>
        public static IEnumerable<T> Uniq<T>(this IEnumerable<T> lst)
        {
            var seen = new Dictionary<T, bool>();

            foreach (var i in lst)
            {
                if (seen.ContainsKey(i))
                    continue;

                yield return i;
                seen.Add(i, true);
            }
        }

        /// <summary>
        /// removes duplicate elements from a list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lst"></param>
        /// <param name="getKey">the value used to check for equality</param>
        /// <returns></returns>
        public static IEnumerable<T> Uniq<T>(this IEnumerable<T> lst, Func<T, string> getKey)
        {
            var seen = new Dictionary<string, bool>();

            foreach (var i in lst)
            {
                if (seen.ContainsKey(getKey(i)))
                    continue;

                yield return i;
                seen.Add(getKey(i), true);
            }
        }

        /// <summary>
        /// A generalization of Zip where you provide a function to combine the two elements into
        /// the type of your choosing
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <param name="ts"></param>
        /// <param name="us"></param>
        /// <param name="fn"></param>
        /// <returns></returns>
        public static IEnumerable<V> ZipWith<T, U, V>(this IEnumerable<T> ts, IEnumerable<U> us, Func<T, U, V> fn)
        {
            var tenum = ts.GetEnumerator();
            var uenum = us.GetEnumerator();

            while (tenum.MoveNext() && uenum.MoveNext())
                yield return fn((T)tenum.Current, (U)uenum.Current);
        }

        /// <summary>
        /// This is just a convenient way to get a range of integers so you can
        /// use the more palatable foreach instead of for, removing state from
        /// the equation
        /// </summary>
        /// <param name="bottom"></param>
        /// <param name="top"></param>
        /// <returns>[bottom ... top-1]</returns>
        public static IEnumerable<int> Range(this int bottom, int top)
        {
            for (int i = bottom; i < top; i++)
                yield return i;
        }

        /// <summary>
        /// This is just a convenient way to get a range of integers so you can
        /// use the more palatable foreach instead of for, removing state from
        /// the equation
        /// </summary>
        /// <param name="bottom"></param>
        /// <param name="top"></param>
        /// <returns>[bottom ... top-1]</returns>
        public static IEnumerable<long> Range(this long bottom, long top)
        {
            for (long i = bottom; i < top; i++)
                yield return i;
        }

        /// <summary>
        /// This is just a convenient way to get a range of integers so you can
        /// use the more palatable foreach instead of for, removing state from
        /// the equation, this is the same as Range(0, top)
        /// </summary>
        /// <param name="bottom"></param>
        /// <param name="top"></param>
        /// <returns>[0 ... top-1]</returns>
        public static IEnumerable<int> Range(this int top)
        {
            return Range(0, top);
        }

        /// <summary>
        /// compose two lists by appending one on the other
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="self"></param>
        /// <param name="other"></param>
        /// <returns>a list with all elements</returns>
        public static IEnumerable<T> Append<T>(this IEnumerable<T> self, IEnumerable<T> other)
        {
            foreach (var s in self)
                yield return s;

            foreach (var o in other)
                yield return o;
        }

        /// <summary>
        /// Add value to the beginning of a list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static IEnumerable<T> Cons<T>(this T val, IEnumerable<T> list)
        {
            yield return val;
            foreach (var l in list)
                yield return val;
        }

        public static IEnumerable<Match> ToIEnumerable(this MatchCollection matches)
        {
            foreach (var i in Range(matches.Count))
            {
                yield return matches[i];
            }
        }
    }
}
