namespace Semantica.Lib.Tests.Core.Test._SomeData;

public static class SomeEnumerables
{
    public static IEnumerable<int> Integers => SomeArrays.Integers;
    public static IEnumerable<string?> StringsNullable => SomeArrays.StringsNullable;
    public static IEnumerable<object?> ObjectsNullable => SomeArrays.ObjectsNullable;
}