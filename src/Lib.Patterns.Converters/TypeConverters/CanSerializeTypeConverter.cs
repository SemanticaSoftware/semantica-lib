using System.ComponentModel;
using System.Globalization;

namespace Semantica.Patterns.TypeConverters;

public class CanSerializeTypeConverter<TSerializable> : CanSerializeOneWayTypeConverter<TSerializable>
    where TSerializable : ICanSerialize<TSerializable>, IEquatable<TSerializable>, new()
{
    public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
    {
        return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
    }

    public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
    {
        if (value is not string stringValue)
        {
            return base.ConvertFrom(context, culture, value);
        }
#if NET7_0_OR_GREATER    
        return TSerializable.Deserialize(stringValue);
#else    
        var deserializer = new TSerializable();
        return deserializer.Deserialize(stringValue);
#endif        
    }
}
