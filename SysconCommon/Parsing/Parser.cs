using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Common;

namespace SysconCommon.Parsing
{
    public class ParseException : SysconException
    {
        public ParseException(string msg)
            : base(msg)
        {
        }
    }

    public interface IParseStream
    {
        ParseResult<char> GetToken();
        bool EndOfStream { get; }
    }

    public class StringParseStream : IParseStream
    {
        private string stream;
        private int next_char_index;

        private StringParseStream(string str, int next_char)
        {
            stream = str;
            next_char_index = next_char;
        }

        public StringParseStream(string str)
            : this(str, 0)
        {
        }

        public ParseResult<char> GetToken()
        {
            if (EndOfStream)
                return ParseResult<char>.Failure();

            return new ParseResult<char>(true, stream[next_char_index], new StringParseStream(stream, next_char_index + 1));
        }

        public bool EndOfStream
        {
            get { return next_char_index >= stream.Length; }
        }
    }

    public class ParseResult<T>
    {
        public readonly bool IsSuccess;
        public readonly T result;
        public readonly IParseStream NewStream;

        public ParseResult(bool success, T result, IParseStream new_stream)
        {
            this.result = result;
            NewStream = new_stream;
            IsSuccess = success;
        }
        
        // for failures
        private ParseResult()
        {
            IsSuccess = false;
        }

        public static ParseResult<T> Failure()
        {
            return new ParseResult<T>();
        }
    }

    static public class Parse
    {
        public delegate ParseResult<T> Parser<T>(IParseStream stream);

        static public Parser<V> SelectMany<T, U, V>(this Parser<T> p, Func<T, Parser<U>> bindFunc, Func<T, U, V> combine)
        {
            return (stream) =>
            {
                var tmpResult = p(stream);
                if (!tmpResult.IsSuccess)
                    return ParseResult<V>.Failure();

                var newResult = bindFunc(tmpResult.result)(tmpResult.NewStream);
                return new ParseResult<V>(newResult.IsSuccess, combine(tmpResult.result, newResult.result), newResult.NewStream);
            };
        }

        static public Parser<char> Char()
        {
            return (stream) =>
            {
                if (stream.EndOfStream)
                    return ParseResult<char>.Failure();
                else
                    return stream.GetToken();
            };
        }

        static public Parser<char> Char(char c)
        {
            return (stream) =>
            {
                var cresult = Char()(stream);
                if (cresult.IsSuccess && cresult.result == c)
                    return cresult;
                else
                    return ParseResult<char>.Failure();
            };
        }

        static public Parser<char> AnyOf(char[] cs)
        {
            return (stream) =>
            {
                var cresult = Char()(stream);
                if (cresult.IsSuccess && cs.Contains(cresult.result))
                    return cresult;
                else
                    return ParseResult<char>.Failure();
            };
        }

        static public Parser<char> AnyOf(string cs)
        {
            return AnyOf(cs.ToArray());
        }

        static public Parser<char> NoneOf(char[] cs)
        {
            return (stream) =>
            {
                var cresult = Char()(stream);
                if (cresult.IsSuccess && !cs.Contains(cresult.result))
                    return cresult;
                else
                    return ParseResult<char>.Failure();
            };
        }

        static public Parser<char> NoneOf(string cs)
        {
            return NoneOf(cs.ToArray());
        }

        static public Parser<T[]> Many<T>(Parser<T> p)
        {
            List<T> rv = new List<T>();

            return (stream) =>
            {
                while (true)
                {
                    var rslt = p(stream);
                    if (rslt.IsSuccess)
                    {
                        rv.Add(rslt.result);
                        stream = rslt.NewStream;
                    }
                    else
                    {
                        return new ParseResult<T[]>(true, rv.ToArray(), stream); 
                    }
                }
            };
        }

        static public Parser<T[]> Many<T>(Parser<T> p, int min)
        {
            return (stream) =>
            {
                var zero_result = Many(p)(stream);
                if (zero_result.result.Length >= min)
                {
                    return zero_result;
                }
                else
                {
                    return ParseResult<T[]>.Failure();
                }
            };
        }

        static public Parser<T> Maybe<T>(Parser<T> p)
        {
            return (stream) =>
            {
                var rslt = p(stream);
                return rslt.IsSuccess
                    ? rslt
                    : new ParseResult<T>(true, default(T), stream);
            };
        }

        static public Parser<T> Or<T>(Parser<T> p, params Parser<T>[] rest)
        {
            return (stream) =>
            {
                var rslt = p(stream);
                if (rslt.IsSuccess)
                    return rslt;

                foreach (var r in rest)
                {
                    rslt = r(stream);
                    if (rslt.IsSuccess)
                        return rslt;
                }

                return ParseResult<T>.Failure();
            };
        }

        static public Parser<object> Nop()
        {
            return (stream) =>
            {
                return new ParseResult<object>(true, null, stream);
            };
        }

        static public Parser<string> WhiteSpace()
        {
            return (stream) =>
            {
                var rslt = Many(AnyOf(" \r\n\t"), 1)(stream);
                return rslt.IsSuccess
                    ? new ParseResult<string>(true, new string(rslt.result), rslt.NewStream)
                    : ParseResult<string>.Failure();
            };
        }

        static public Parser<string> NonWSToken()
        {
            return (stream) =>
            {
                var rslt = Many(NoneOf(" \r\n\t"), 1)(stream);
                return rslt.IsSuccess
                    ? new ParseResult<string>(true, new string(rslt.result), rslt.NewStream)
                    : ParseResult<string>.Failure();
            };
        }
    }
}
