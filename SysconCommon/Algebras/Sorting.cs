using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Algebras.Sorting
{
    public enum BinarySearchOp
    {
        EqualTo = 1,
        LessThan = 2,
        GreaterThan = 4,
        LessThanEqualTo = EqualTo | LessThan,
        GreaterThanEqualTo = EqualTo | GreaterThan,
    }

    class HeapNode<T>
    {
        private readonly IList<T> heap;
        private readonly int one_based_index;

        public HeapNode(IList<T> _heap, int _one_based_index)
        {
            heap = _heap;
            one_based_index = _one_based_index;
        }

        public T Value
        {
            get
            {
                return heap[one_based_index - 1];
            }
            set
            {
                heap[one_based_index - 1] = value;
            }
        }

        public HeapNode<T> LeftChild
        {
            get
            {
                var left_index = one_based_index * 2;
                return left_index > heap.Count ? null : new HeapNode<T>(heap, left_index);
            }
        }

        public HeapNode<T> RightChild
        {
            get
            {
                var right_index = (one_based_index * 2) + 1;
                return right_index > heap.Count ? null : new HeapNode<T>(heap, right_index);
            }
        }

        public HeapNode<T> Parent
        {
            get
            {
                return one_based_index == 1
                    ? null
                    : new HeapNode<T>(heap, one_based_index / 2);
            }
        }

        /// <summary>
        /// enumerate through all values of this node and it's children, unordered!!!
        /// </summary>
        public IEnumerable<T> SelfAndChildren
        {
            get
            {
                if (Parent == null)
                {
                    foreach (var i in heap)
                        yield return i;
                }
                else
                {

                    yield return Value;

                    var l = LeftChild;
                    if (l != null)
                    {
                        foreach (var i in l.SelfAndChildren)
                            yield return i;
                    }

                    var r = RightChild;
                    if (r != null)
                    {
                        foreach (var i in r.SelfAndChildren)
                            yield return i;
                    }
                }
            }
        }
    }

    public class SearchResult<T>
        where T: IComparable<T>
    {
        private readonly List<T> initial_list;
        private readonly int starting_index, ending_index;

        public SearchResult(List<T> _initial_list, int _starting_index, int _ending_index)
        {
            initial_list = _initial_list;
            starting_index = _starting_index;
            ending_index = _ending_index;
        }

        public int BinarySearch(T needle)
        {
            return initial_list.BinarySearch(starting_index, (ending_index - starting_index) + 1, needle, Comparer<T>.Default);
        }
    }

    public static class Sorting
    {
        
    }
}
