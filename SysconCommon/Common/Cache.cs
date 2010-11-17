using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Diagnostics;

using System.Linq.Expressions;

namespace SysconCommon.Common
{
    public static class Cache
    {
        private static string GetCallingMethod()
        {
            var st = new StackTrace();
            var m = st.GetFrame(2).GetMethod();
            return string.Format("{0}:{1}", m.DeclaringType, m.Name);
        }

        private static Dictionary<string, object> cache = new Dictionary<string, object>();

        public static void InvalidateAll()
        {
            cache.Clear();
        }

        public static T CacheResult<T>(Func<T> fn, params object[] args)
        {
            // don't actually cache anything, this cache scheme is getting too slow
            return fn();

            var caller = GetCallingMethod();
            var strings = args.Select(s => s.ToString());
            var key = string.Format("{0}:{1}", caller, string.Join(";", strings.ToArray())).GetMD5Sum();

            if (!cache.ContainsKey(key))
            {
                var result = fn();
                // Environment.Env.DebugPrint("Adding result {0} for {1} to cache", result, caller);
                cache.Add(key, result);
                return result;
            }
            else
            {
                var result = (T) cache[key];
                // Environment.Env.DebugPrint("Pulling result {0} out of cache for {1}", result, caller);
                return result;
            }
        }
    }
}
