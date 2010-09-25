using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Common;
using SysconCommon.Common.Validity;

namespace SysconCommon.Common.ArgumentHandling
{
    public class ArgumentException : SysconException
    {
        public ArgumentException(string msgfrmt, params object[] args) : base(msgfrmt, args) { }
    }

    public class Arguments 
    {
        private readonly IEnumerable<string> args;

        public Arguments(IEnumerable<string> programArgs)
        {
            args = programArgs;
        }

        public IEnumerable<UnsafeString> UnnammedArguments
        {
            get
            {
                var arg_enum = args.GetEnumerator();

                while (arg_enum.MoveNext())
                {
                    if (arg_enum.Current[0] == '-')
                    {
                        var named = arg_enum.Current;
                        if (!arg_enum.MoveNext())
                            throw new ArgumentException("Unfinished named arg {0}", named);

                        continue;
                    }

                    yield return arg_enum.Current;
                }
            }
        }

        public Dictionary<string, UnsafeString> NamedArguments
        {
            get
            {
                var result = new Dictionary<string, UnsafeString>();
                var arg_enum = args.GetEnumerator();
                while (arg_enum.MoveNext())
                {
                    if (arg_enum.Current[0] != '-')
                        continue;

                    var name = arg_enum.Current.Substring(1);

                    if (!arg_enum.MoveNext())
                        throw new ArgumentException("Unfinished named arg {0}", name);

                    if (result.ContainsKey(name))
                        throw new ArgumentException("Named argument {0} is repeated", name);

                    result.Add(name, arg_enum.Current);
                }

                return result;
            }
        }
    }

    static public class ArgumentHandlingExtensions
    {
        static public Arguments ParseArguments(this string[] self)
        {
            return new Arguments(self);
        }
    }
}
