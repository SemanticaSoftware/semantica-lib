
using Newtonsoft.Json;
using Semantica.Extensions;

namespace Semantica.Core.Json.Newtonsoft;

/// <summary>
/// Provides base JsonConverter classes for value types that hold a single underlying value (<see langword="struct"/>) type that is
/// supported by System.Text.Json.
/// <list type="bullet">
/// <item>Boolean/bool</item>
/// <item>Decimal/decimal</item>
/// <item>Double/double</item>
/// <item>Int32/int</item>
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
    /// Don't use this base class, but use one of the specific type 
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

        public sealed override T? ReadJson(JsonReader reader, Type objectType, T? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return !TryRead(reader, out var underlyingValue) ? GetDefault() : FromUnderlyingType(underlyingValue);
        }
        
        protected abstract bool TryRead(JsonReader reader, out TStruct underlyingValue);

        public sealed override void WriteJson(JsonWriter writer, T? value, JsonSerializer serializer)
        {
            var underlyingValue = value == null ? default : ToUnderlyingType(value);
            if (underlyingValue.HasValue)
            {
                Write(writer, underlyingValue.Value);
            }
            else
            {
                writer.WriteNull();
            }
        }

        protected abstract void Write(JsonWriter writer, TStruct underlyingValue);
    }
    
    /// <summary> Use for value types that can be represented as a <see cref="Boolean"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to boolean. </typeparam>
    public abstract class Boolean<T> : Base<T, bool>
    {
        protected sealed override bool TryRead(JsonReader reader, out bool underlyingValue)
        {
            return reader.ReadAsBoolean().TryValue(out underlyingValue);
        }

        protected sealed override void Write(JsonWriter writer, bool underlyingValue) => writer.WriteValue(underlyingValue);
    }
    
    /// <summary> Use for value types that can be represented as a <see cref="DateOnly"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to dateonly. </typeparam>
    /// <remarks>
    /// DateOnly is currently not supported by Newtonsoft.Json, so an extra conversion to and from DateTime is used.
    /// </remarks>
    public abstract class DateOnly<T> : Base<T, DateOnly>
    {
        protected sealed override bool TryRead(JsonReader reader, out DateOnly underlyingValue)
        {
            var result = reader.ReadAsDateTime().TryValue(out var dateTimeValue);
            underlyingValue = result ? DateOnly.FromDateTime(dateTimeValue) : default;
            return result;
        }

        protected sealed override void Write(JsonWriter writer, DateOnly underlyingValue) 
            => writer.WriteValue(underlyingValue.ToDateTime(TimeOnly.MinValue));
    }
    
    /// <summary> Use for value types that can be represented as a <see cref="DateTime"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to datetime. </typeparam>
    public abstract class DateTime<T> : Base<T, DateTime>
    {
        protected sealed override bool TryRead(JsonReader reader, out DateTime underlyingValue)
            => reader.ReadAsDateTime().TryValue(out underlyingValue);

        protected sealed override void Write(JsonWriter writer, DateTime underlyingValue) 
            => writer.WriteValue(underlyingValue);
    }
    
    /// <summary> Use for value types that can be represented as a <see cref="DateTimeOffset"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to datetime offset. </typeparam>
    public abstract class DateTimeOffset<T> : Base<T, DateTimeOffset>
    {
        protected sealed override bool TryRead(JsonReader reader, out DateTimeOffset underlyingValue) 
            => reader.ReadAsDateTimeOffset().TryValue(out underlyingValue);

        protected sealed override void Write(JsonWriter writer, DateTimeOffset underlyingValue) 
            => writer.WriteValue(underlyingValue);
    }

    /// <summary> Use for value types that can be represented as a <see cref="Decimal{T}"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to decimal. </typeparam>
    public abstract class Decimal<T> : Base<T, decimal>
    {
        protected sealed override bool TryRead(JsonReader reader, out decimal underlyingValue) 
            => reader.ReadAsDecimal().TryValue(out underlyingValue);

        protected sealed override void Write(JsonWriter writer, decimal underlyingValue) 
            => writer.WriteValue(underlyingValue);
    }

    /// <summary> Use for value types that can be represented as a <see cref="Double"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to double. </typeparam>
    public abstract class Double<T> : Base<T, double>
    {
        protected sealed override bool TryRead(JsonReader reader, out double underlyingValue) 
            => reader.ReadAsDouble().TryValue(out underlyingValue);

        protected sealed override void Write(JsonWriter writer, double underlyingValue) 
            => writer.WriteValue(underlyingValue);
    }
    
    /// <summary> Use for value types that can be represented as a <see cref="Guid"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to guid. </typeparam>
    /// <remarks>
    /// Guid is currently not supported by Newtonsoft.Json, so an extra conversion to and from Guid is used.
    /// </remarks>
    public abstract class Guid<T> : Base<T, Guid>
    {
        protected sealed override bool TryRead(JsonReader reader, out Guid underlyingValue)
        {
            var stringValue = reader.ReadAsString();
            var result = stringValue != null; 
            underlyingValue = result ? Guid.Parse(stringValue!) : Guid.Empty;
            return result;
        }

        protected sealed override void Write(JsonWriter writer, Guid underlyingValue) 
            => writer.WriteValue(underlyingValue);
    }

    /// <summary> Use for value types that can be represented as a <see cref="Int32"/>. </summary>
    /// <typeparam name="T"> The type to convert from or to int. </typeparam>
    public abstract class Int<T> : Base<T, int>
    {
        protected sealed override bool TryRead(JsonReader reader, out int underlyingValue) 
            => reader.ReadAsInt32().TryValue(out underlyingValue);

        protected sealed override void Write(JsonWriter writer, int underlyingValue) 
            => writer.WriteValue(underlyingValue);
    }
}
