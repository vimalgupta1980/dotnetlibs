using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Common.Validity;
using SysconCommon.Common;
using SysconCommon.Common.Environment;

namespace SysconCommon.Algebras.Graphs
{
    /// <summary>
    /// Basic directional graph
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DirectionalGraph<T>
    {
        public readonly IEnumerable<T> Nodes;
        public readonly Func<T, IEnumerable<T>> NeighborFinder;

        public DirectionalGraph(IEnumerable<T> nodes, Func<T, IEnumerable<T>> neighborFinder)
        {
            Nodes = nodes;
            Env.DebugPrint("Graph contains the following nodes: {0}", string.Join(",", nodes.Select(n => n.ToString()).ToArray()));
            NeighborFinder = neighborFinder;
        }

        /// <summary>
        /// checks if a graph is a DAG, this will not terminate with infinite graphs
        /// </summary>
        public bool IsAcylic
        {
            get
            {
                // a DAG will always have at least one leaf node, so just remove
                // all leaf nodes inductively until there are none, if the graph
                // is acylic, it will be empty at the end of this operation

                if (this.Nodes.Count() == 0)
                    return true;

                var withoutLeafs = this.RemoveLeafs();

                if (withoutLeafs.Nodes.Count() == this.Nodes.Count())
                {
                    Env.DebugPrint("Cylic graph with at most {0} nodes", Nodes.Count());
                    Env.DebugPrint("Cylic graph nodes are (some may not be part of the loop): {0}", string.Join(",", Nodes.Select(n => n.ToString()).ToArray()));
                    foreach (var n in Nodes)
                    {
                        Env.DebugPrint("{0} neighbors {1}", n, string.Join(",", NeighborFinder(n).Select(_n => _n.ToString()).ToArray()));
                    }
                    return false; // there is a cycle somewhere
                }

                return withoutLeafs.IsAcylic;
            }
        }

        public DirectionalGraph<T> RemoveLeafs()
        {
            // find the non-leafs
            var nonleafs = this.Nodes.Where(n => !NeighborFinder(n).IsEmpty());

            // make a new neighbor finder that will not find the leaf nodes
            Func<T, IEnumerable<T>> newNeighborFinder = (node) => NeighborFinder(node).Where(n => nonleafs.Contains(n));

            // build a new graph
            return new DirectionalGraph<T>(nonleafs, newNeighborFinder);
        }
    }
}
