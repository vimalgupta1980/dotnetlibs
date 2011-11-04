using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Algebras.MemoryDB
{
    /* 
     * can only be created from an existing collection, is then non-modifiable.  this is because it's planned
     * use is for quick temporary in-memory indexes
     */
    class BTree<T>
        where T: IComparable<T>
    {
        private BTree<T> _left = null;
        private BTree<T> _right = null;

        private readonly T[] _local_items = null;

        public T MaxValue
        {
            get
            {
                if (Count == 0)
                    throw new SysconCommon.Common.SysconException("Cannot find max value in empty b-tree");

                if (_right != null && _right.Count > 0)
                    return _right.MaxValue;
                else if (_local_items != null && _local_items.Length > 0)
                    return _local_items[_local_items.Length - 1];
                else
                    return _left.MaxValue;
            }
        }

        public T MinValue
        {
            get
            {
                if (Count == 0)
                    throw new SysconCommon.Common.SysconException("Cannot find min value in empty b-tree");

                if (_left != null && _left.Count > 0)
                    return _left.MinValue;
                else if (_local_items != null && _local_items.Length > 0)
                    return _local_items[0];
                else
                    return _right.MinValue;
            }
        }
        
        /* the Count property returns the count of all subitems as well */
        public int Count
        {
            get
            {
                return (_local_items == null ? 0 : _local_items.Length) + (_left != null ? _left.Count : 0) + (_right != null ? _right.Count : 0);
            }
        }

        public BTree(List<T> items, int max_local_items = 1024, bool input_is_sorted = false)
        {
            if (items.Count == 0)
                return;

            if (!input_is_sorted)
            {
                var unsorted = items;
                items = new List<T>();
                foreach (var i in unsorted)
                {
                    items.Add(i);
                }

                items.Sort((a, b) => a.CompareTo(b));
            }

            int local_start_index = 0;
            int local_end_index = 0;

            if (items.Count <= max_local_items)
            {
                local_start_index = 0;
                local_end_index = items.Count - 1;
            }
            else
            {
                // find "middle" and also build _left and _right
                var midstart = (items.Count - max_local_items) / 2;
                local_start_index = midstart;
                local_end_index = midstart + max_local_items;
                _left = new BTree<T>(items.GetRange(0, local_start_index), max_local_items, true);
                _right = new BTree<T>(items.GetRange(local_end_index + 1, items.Count - local_end_index - 1), max_local_items, true);
            }

            _local_items = new T[local_end_index - local_start_index + 1];
            items.CopyTo(local_start_index, _local_items, 0, _local_items.Length);
        }

        private BTree(T[] local_items, BTree<T> left, BTree<T> right)
        {
            _local_items = local_items;
            _left = left;
            _right = right;
        }

        public enum FindOps {
            EqualTo = 1,
            LessThan = 2,
            GreaterThan = 4,
            LessThanEqualTo = LessThan|EqualTo,
            GreaterThanEqualTo = GreaterThan|EqualTo,
        };

        private bool ValuesPossible(FindOps ops, T comparisonValue)
        {
            if (Count == 0)
                return false;

            if ((FindOps.LessThan & ops) == FindOps.LessThan && MinValue.CompareTo(comparisonValue) == -1)
                return true;

            if ((FindOps.GreaterThan & ops) == FindOps.GreaterThan && MaxValue.CompareTo(comparisonValue) == 1)
                return true;

            if ((FindOps.EqualTo & ops) == FindOps.EqualTo && MinValue.CompareTo(comparisonValue) <= 0 && MaxValue.CompareTo(comparisonValue) >= 0)
                return true;

            return false;
        }

        public BTree<T> Find(FindOps ops, T comparisonValue)
        {
            if(Count == 0)
                return this;

            if(!ValuesPossible(ops, comparisonValue))
                return new BTree<T>(null, null, null);

            if ((FindOps.GreaterThan & ops) == FindOps.GreaterThan && this.MinValue.CompareTo(comparisonValue) == 1)
                return this;

            if ((FindOps.LessThan & ops) == FindOps.LessThan && this.MaxValue.CompareTo(comparisonValue) == -1)
                return this;

            IEnumerable<T> found_local_items = null;

            if (_local_items != null)
            {
                found_local_items = _local_items.Where((i) =>
                {
                    var comparison = i.CompareTo(comparisonValue);

                    return (((ops & FindOps.EqualTo) == FindOps.EqualTo) && comparison == 0)
                        || (((ops & FindOps.GreaterThan) == FindOps.GreaterThan) && comparison == 1)
                        || (((ops & FindOps.LessThan) == FindOps.LessThan) && comparison == -1);

                });
            }

            return new BTree<T>(found_local_items == null ? null : found_local_items.ToArray(), 
                _left == null ? null : _left.Find(ops, comparisonValue), 
                _right == null ? null : _right.Find(ops, comparisonValue));
        }

        public IEnumerable<T> ToIEnumerable()
        {
            if (_left != null)
            {
                foreach (var i in _left.ToIEnumerable())
                {
                    yield return i;
                }
            }

            if (_local_items != null)
            {
                foreach (var i in _local_items)
                {
                    yield return i;
                }
            }

            if (_right != null)
            {
                foreach (var i in _right.ToIEnumerable())
                {
                    yield return i;
                }
            }
        }
    }
}
