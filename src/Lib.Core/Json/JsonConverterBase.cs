using System.Text.Json;
using System.Text.Json.Serialization;

namespace Semantica.Core.Json;

/// <summary>
/// Provides base classes inheriting from <see cref="JsonConverter{T}"/> for value types that hold a single underlying value
/// type (<see langword="struct"/>) that is supported by System.Text.Json.
/// <list type="bullet">
/// <item>Boolean/bool</item>
/// <item>Byte/byte</item>
/// <item>Decimal/decimal</item>
/// <item>Double/double</item>
/// <item>Int16/short</item>
/// <item>Int32/int</item>
/// <item>Int64/long</item>
/// <item>SByte/sbyte</item>
/// <item>Single/float</item>
/// <item>UInt16/ushort</item>
/// <item>UInt32/uint</item>
/// <item>UInt64/ulong</item>
/// <item>DateOnly</item>
/// <item>DateTime</item>
/// <item>DateTimeOffset</item>
/// <item>Guid</item>
/// </list>
/// </summary>
/// <remarks>
/// For conversions from the underlying type, override <see cref="JsonConverterBase.Base{T,TStruct}.GetDefault()"/> if a value
/// different to default(T?) (<see langword="null"/>) should be returned when reading of the underlying type fails.
/// </remarks>
public static class JsonConverterBase
{
    /// <summary>
    /// Don't use this base class, but use one of the specific type base classes.
    /// </summary>
    public abstract class Base<T, TStruct> : JsonConverter<T>
        where TStruct : struct
    {
        /// <summary>
        /// Implementation of the conversion to <typeparamref name="T"/>.
        /// </summary>
        /// <param name="underlyingValue"> Value to convert. </param>
        /// <returns> An instance of <typeparamref name="T"/>. </returns>
        protected abstract T FromUnderlyingType(TStruct underlyingValue);
        
        /// <summary>
        /// Returns default(T?) (<see langword="null"/>). Override if a different value to should be returned when reading of
        /// the underlying type value fails.
        /// </summary>
        protected virtual T? GetDefault() => default(T?);

        /// <summary> Implementation of the conversion of <typeparamref name="T"/> to the underlying type. </summary>
        /// <param name="value"> Value of <typeparamref name="T"/> to convert. </param>
        /// <returns> A representation of the input as <see cref="Nullable{T}"/> of the underlying type. </returns>
        protected abstract TStruct? ToUnderlyingType(T? value);

        public sealed override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return !TryRead(ref reader, out var underlyingValue) ? GetDefault() : FromUnderlyingType(underlyingValue);
        }
        
        protected abstract bool TryRead(ref Utf8JsonReader reader, out TStruct underlyingValue);

        public sealed override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            var underlyingValue = value == null ? default : ToUnderlyingType(value);
            if (underlyingValue.HasValue)
            {
                Write(writer, underlyingValue.Value);
            }
            else
            {
                writer.WriteNullValue();
            }
        }

        protected abstract void Write(Utf8JsonWriter writer, TStruct underlyingValue);
    }
    
    /// <summary> Use for value types that can be represented as a <see cref="Boolean"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to boolean. </typeparam>
    public abstract class Boolean<T> : Base<T, bool>
    {
        protected sealed override bool TryRead(ref Utf8JsonReader reader, out bool underlyingValue)
        {
            underlyingValue = reader.GetBoolean();
            return true;
        }

        protected sealed override void Write(Utf8JsonWriter writer, bool underlyingValue) => writer.WriteBooleanValue(underlyingValue);
    }
    
    /// <summary> Use for value types that can be represented as a <see cref="Byte"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to byte. </typeparam>
    public abstract class Byte<T> : Base<T, byte>
    {
        protected sealed override bool TryRead(ref Utf8JsonReader reader, out byte underlyingValue) 
            => reader.TryGetByte(out underlyingValue);

        protected sealed override void Write(Utf8JsonWriter writer, byte underlyingValue) 
            => writer.WriteNumberValue(underlyingValue);
    }

    /// <summary> Use for value types that can be represented as a <see cref="DateOnly"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to dateonly. </typeparam>
    /// <remarks>
    /// DateOnly is currently not supported by System.Text.Json, so an extra conversion to and from DateTime is used.
    /// </remarks>
    public abstract class DateOnly<T> : Base<T, DateOnly>
    {
        protected sealed override bool TryRead(ref Utf8JsonReader reader, out DateOnly underlyingValue)
        {
            var result = reader.TryGetDateTime(out var dateTimeValue);
            underlyingValue = result ? DateOnly.FromDateTime(dateTimeValue) : default;
            return result;
        }

        protected sealed override void Write(Utf8JsonWriter writer, DateOnly underlyingValue) 
            => writer.WriteStringValue(underlyingValue.ToDateTime(TimeOnly.MinValue));
    }
    
    /// <summary> Use for value types that can be represented as a <see cref="DateTime"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to datetime. </typeparam>
    public abstract class DateTime<T> : Base<T, DateTime>
    {
        protected sealed override bool TryRead(ref Utf8JsonReader reader, out DateTime underlyingValue)
            => reader.TryGetDateTime(out underlyingValue);

        protected sealed override void Write(Utf8JsonWriter writer, DateTime underlyingValue) 
            => writer.WriteStringValue(underlyingValue);
    }
    
    /// <summary> Use for value types that can be represented as a <see cref="DateTimeOffset"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to datetime offset. </typeparam>
    public abstract class DateTimeOffset<T> : Base<T, DateTimeOffset>
    {
        protected sealed override bool TryRead(ref Utf8JsonReader reader, out DateTimeOffset underlyingValue) 
            => reader.TryGetDateTimeOffset(out underlyingValue);

        protected sealed override void Write(Utf8JsonWriter writer, DateTimeOffset underlyingValue) 
            => writer.WriteStringValue(underlyingValue);
    }

    /// <summary> Use for value types that can be represented as a <see cref="Decimal{T}"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to decimal. </typeparam>
    public abstract class Decimal<T> : Base<T, decimal>
    {
        protected sealed override bool TryRead(ref Utf8JsonReader reader, out decimal underlyingValue) 
            => reader.TryGetDecimal(out underlyingValue);

        protected sealed override void Write(Utf8JsonWriter writer, decimal underlyingValue) 
            => writer.WriteNumberValue(underlyingValue);
    }

    /// <summary> Use for value types that can be represented as a <see cref="Double"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to double. </typeparam>
    public abstract class Double<T> : Base<T, double>
    {
        protected sealed override bool TryRead(ref Utf8JsonReader reader, out double underlyingValue) 
            => reader.TryGetDouble(out underlyingValue);

        protected sealed override void Write(Utf8JsonWriter writer, double underlyingValue) 
            => writer.WriteNumberValue(underlyingValue);
    }
    
    /// <summary> Use for value types that can be represented as a <see cref="Guid"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to guid. </typeparam>
    public abstract class Guid<T> : Base<T, Guid>
    {
        protected sealed override bool TryRead(ref Utf8JsonReader reader, out Guid underlyingValue) 
            => reader.TryGetGuid(out underlyingValue);

        protected sealed override void Write(Utf8JsonWriter writer, Guid underlyingValue) 
            => writer.WriteStringValue(underlyingValue);
    }

    /// <summary> Use for value types that can be represented as a <see cref="Int16"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to short. </typeparam>
    public abstract class Int16<T> : Base<T, short>
    {
        protected sealed override bool TryRead(ref Utf8JsonReader reader, out short underlyingValue) 
            => reader.TryGetInt16(out underlyingValue);

        protected sealed override void Write(Utf8JsonWriter writer, short underlyingValue) 
            => writer.WriteNumberValue(underlyingValue);
    }

    /// <summary> Use for value types that can be represented as a <see cref="Int32"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to int. </typeparam>
    public abstract class Int32<T> : Base<T, int>
    {
        protected sealed override bool TryRead(ref Utf8JsonReader reader, out int underlyingValue) 
            => reader.TryGetInt32(out underlyingValue);

        protected sealed override void Write(Utf8JsonWriter writer, int underlyingValue) 
            => writer.WriteNumberValue(underlyingValue);
    }
    
    /// <summary> Use for value types that can be represented as a <see cref="Int64"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to long. </typeparam>
    public abstract class Int64<T> : Base<T, int>
    {
        protected sealed override bool TryRead(ref Utf8JsonReader reader, out int underlyingValue) 
            => reader.TryGetInt32(out underlyingValue);

        protected sealed override void Write(Utf8JsonWriter writer, int underlyingValue) 
            => writer.WriteNumberValue(underlyingValue);
    }
    
    /// <summary> Use for value types that can be represented as a <see cref="SByte"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to sbyte. </typeparam>
    public abstract class SByte<T> : Base<T, sbyte>
    {
        protected sealed override bool TryRead(ref Utf8JsonReader reader, out sbyte underlyingValue) 
            => reader.TryGetSByte(out underlyingValue);

        protected sealed override void Write(Utf8JsonWriter writer, sbyte underlyingValue) 
            => writer.WriteNumberValue(underlyingValue);
    }

    /// <summary> Use for value types that can be represented as a <see cref="Single"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to float. </typeparam>
    public abstract class Single<T> : Base<T, float>
    {
        protected sealed override bool TryRead(ref Utf8JsonReader reader, out float underlyingValue) 
            => reader.TryGetSingle(out underlyingValue);

        protected sealed override void Write(Utf8JsonWriter writer, float underlyingValue)
            => writer.WriteNumberValue(underlyingValue);
    }

    /// <summary> Use for value types that can be represented as a <see cref="UInt16"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to ushort. </typeparam>
    public abstract class UInt16<T> : Base<T, ushort>
    {
        protected sealed override bool TryRead(ref Utf8JsonReader reader, out ushort underlyingValue)
            => reader.TryGetUInt16(out underlyingValue);

        protected sealed override void Write(Utf8JsonWriter writer, ushort underlyingValue)
            => writer.WriteNumberValue(underlyingValue);
    }

    /// <summary> Use for value types that can be represented as a <see cref="UInt32"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to uint. </typeparam>
    public abstract class UInt32<T> : Base<T, uint>
    {
        protected sealed override bool TryRead(ref Utf8JsonReader reader, out uint underlyingValue)
            => reader.TryGetUInt32(out underlyingValue);

        protected sealed override void Write(Utf8JsonWriter writer, uint underlyingValue)
            => writer.WriteNumberValue(underlyingValue);
    }

    /// <summary> Use for value types that can be represented as a <see cref="UInt64"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to ulong. </typeparam>
    public abstract class UInt64<T> : Base<T, ulong>
    {
        protected sealed override bool TryRead(ref Utf8JsonReader reader, out ulong underlyingValue)
            => reader.TryGetUInt64(out underlyingValue);

        protected sealed override void Write(Utf8JsonWriter writer, ulong underlyingValue)
            => writer.WriteNumberValue(underlyingValue);
    }

    //Byte byte
    //Decimal decimal
    //Double double
    //Int16 short
    //Int32 int
    //Int64 long
    //SByte sbyte
    //Single float
    //UInt16 ushort
    //UInt32 uint
    //UInt64 ulong

    //Guid
    //DateTime
    //DateTimeOffset    
}
