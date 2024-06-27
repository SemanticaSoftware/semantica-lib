using Semantica.Trees.Implementations;

namespace Semantica.Lib.Tests.Core.Test._SomeData.Trees;

public static class SomeTree
{
    /// <summary>
    ///     Creates an "empty" tree with just a Root Node.
    /// </summary>
    /// <param name="root">Value of the RootNode</param>
    public static GrowingTree<int> CreateEmpty(int root = 0)
    {
        return new GrowingTree<int>(root);
    }

    /// <summary>
    ///     Creates a tree along with some ChildNodes in the following structure:
    ///     
    ///<para>                    Root                   </para>
    ///<para>            Node1   Node4      Node5       </para>
    ///<para>         Node2      Node6   Node7   Node8  </para>  
    ///<para>      Node3         Node9                  </para>
    ///
    /// </summary>
    /// <param name="root">Value of the RootNode</param>
    public static GrowingTree<int> CreateWithChildNodes(int root = 0)
    {
        var tree = new GrowingTree<int>(root);
        var node1 = tree.AddChildNode(tree.RootNode, 1);
        var node2 = tree.AddChildNode(node1, 2);
        tree.AddChildNode(node2, 3);
        var node4 = tree.AddChildNode(tree.RootNode, 4);
        var node5 = tree.AddChildNode(tree.RootNode, 5);
        var node6 = tree.AddChildNode(node4, 6);
        tree.AddChildNode(node5, 7);
        tree.AddChildNode(node5, 8);
        tree.AddChildNode(node6, 9);
        return tree;
    }
}