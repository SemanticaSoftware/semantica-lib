using System.Reflection;

namespace Semantica.Extensions;

public static class EnumAttributeProvider
{

    public static IReadOnlyDictionary<TEnum, TAttribute?> GetValueAttributes<TEnum, TAttribute>()
        where TAttribute : Attribute
        where TEnum : struct, Enum, IConvertible
    {
        var enumFieldInfos = typeof(TEnum).GetRuntimeFields().ToList();
        return GetValueAttributes<TEnum, TAttribute>(enumFieldInfos).ToDictionary(tuple => tuple.value, tuple => tuple.attribute);
    }

    private static IEnumerable<(TEnum value, TAttribute? attribute)> GetValueAttributes<TEnum, TAttribute>(IReadOnlyList<FieldInfo> enumFieldInfos)
        where TAttribute : Attribute
        where TEnum : struct, Enum, IConvertible
    {
        return Enum.GetValues<TEnum>()
                   .Select(value => (value, attribute: value.GetAttribute<TAttribute, TEnum>(enumFieldInfos)))
                   .Where(tuple => tuple.attribute != null);
    }

}
