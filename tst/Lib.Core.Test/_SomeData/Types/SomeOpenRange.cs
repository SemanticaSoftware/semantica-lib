using Semantica.Intervals;
using Semantica.TestTools.Core.ValueTypes;

namespace Semantica.Lib.Tests.Core.Test._SomeData.Types;

public static class SomeOpenRange
{
    public const int UpperBound = 16;
        
    public static EmptyUnbindsInterval<ComparableCanBeEmpty> CreateClosed(int upperBound = UpperBound)
    {
        return new EmptyUnbindsInterval<ComparableCanBeEmpty>(Make(0), Make(upperBound));
    }
        
    public static EmptyUnbindsInterval<ComparableCanBeEmpty> CreateUpperOpen()
    {
        return new EmptyUnbindsInterval<ComparableCanBeEmpty>(Make(0), default);
    }
        
    public static EmptyUnbindsInterval<ComparableCanBeEmpty> CreateLowerOpen()
    {
        return new EmptyUnbindsInterval<ComparableCanBeEmpty>(default, Make(UpperBound));
    }

    private static ComparableCanBeEmpty Make(int value) => new ComparableCanBeEmpty(value);
}