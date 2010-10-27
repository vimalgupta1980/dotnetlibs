/// This file provides a set of useful datastructures that are very general and can
/// be used for many purposes, more structures will be added over time

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Common
{
    /// <summary>
    /// Tuples are generic intermidiate types when you need to glue pieces of data together
    /// Tuples don't require using state or writing your own looping code, see the function 
    /// FunctionalOperators.Zip for a good example of use.
    /// </summary>
    /// <typeparam name="T">type of tup.First</typeparam>
    /// <typeparam name="U">type of tup.Second</typeparam>
    public class Tuple<T, U>
    {
        public readonly T First;
        public readonly U Second;

        public Tuple(T first, U second)
        {
            First = first;
            Second = second;
        }
    }

    /// <summary>
    /// Tuples are generic intermidiate types when you need to glue pieces of data together
    /// Tuples don't require using state or writing your own looping code, see the function 
    /// FunctionalOperators.Zip for a good example of use.
    /// </summary>
    /// <typeparam name="T">type of tup.First</typeparam>
    /// <typeparam name="U">type of tup.Second</typeparam>
    /// <typeparam name="V">type of tup.Third</typeparam>
    public class Tuple3<T, U, V>
    {
        public readonly T First;
        public readonly U Second;
        public readonly V Third;

        public Tuple3(T first, U second, V third)
        {
            First = first;
            Second = second;
            Third = third;
        }
    }

    /// <summary>
    /// class to wrap up values as references, so that the value can be manipulated
    /// statefully in closures
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ReferenceWrap<T>
        where T : struct
    {
        public T Value { get; set; }

        public ReferenceWrap(T val)
        {
            Value = val;
        }

        public static implicit operator ReferenceWrap<T>(T val)
        {
            return new ReferenceWrap<T>(val);
        }
    }

    public static class Transformers
    {
        public static IEnumerable<T> MakeSingletonCollection<T>(this T self)
        {
            yield return self;
        }
    }
}
