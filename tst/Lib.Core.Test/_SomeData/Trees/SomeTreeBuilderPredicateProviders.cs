using Semantica.Trees.Builders;

namespace Semantica.Lib.Tests.Core.Test._SomeData.Trees;

class SomeTreeBuilderPredicateEvenUneven : ITreeBuildPredicateProvider<int>
{
    public bool IsChildOf(int payload, int parent)
    {
        if (parent == 0 && payload <= 2)
        {
            return true;
        }

        return (payload - parent <= 2 && (parent + payload) % 2 == 0);
    }

    public bool UseOrdering()
    {
        return false;
    }

    public IComparable OrderChildrenBy(int payload)
    {
        throw new NotImplementedException();
    }

    public bool IsRoot(int payload)
    {
        return payload == 0;
    }
}