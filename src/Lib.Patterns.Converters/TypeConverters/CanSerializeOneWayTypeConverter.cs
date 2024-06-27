using System.ComponentModel;
using System.Globalization;

namespace Semantica.Patterns.TypeConverters;

public class CanSerializeOneWayTypeConverter<TSerializable> : TypeConverter
    where TSerializable : ICanSerialize
{
    public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
    {
        return false;
    }

    public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
    {
        return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
    }

    public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
    {
        if (value is not TSerializable serializable)
        {
            return base.ConvertTo(context, culture, value, destinationType);
        }
        return serializable.Serialize();
    }
}
