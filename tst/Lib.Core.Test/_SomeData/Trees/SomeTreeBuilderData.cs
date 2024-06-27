using Semantica.Collections;

namespace Semantica.Lib.Tests.Core.Test._SomeData.Trees;

public static class SomeTreeBuilderData
{
    public static RetrievalCollection<int> CreateTreeBuilderCollection()
    {
        return new RetrievalCollection<int>(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
    }

    public static RetrievalCollection<int> CreateTreeBuilderCollectionWithValuesToFilter()
    {
        return new RetrievalCollection<int>(new List<int> { 0, 1, 2, 42, 3, 4, 5, 4242, 6, 7, 8, 9, 424242 });
    }
}