using System.Globalization;
using Semantica.Core;
using Semantica.Extensions;

namespace Semantica.Types.Converters;

/// <summary> TypeConverter for <see cref="PartitionDate"/> </summary>
public class PartitionDateTypeConverter : StringTypeConverterBase<PartitionDate>
    #if NET7_0_OR_GREATER 
    , IRuntimeTypeConverter<PartitionDate, PartitionDateTypeConverter>
    #else
    , IRuntimeTypeConverter<PartitionDate>
    #endif
{
    public const char Separator = '|';
    public const string SerializationFormat = "yyyy|MM|dd";

    protected override PartitionDate FromString(string str) => Deserialize(str);
    protected override string ToString(PartitionDate value) => Serialize(value);

    /// <summary>
    /// Deserializes a string to a <see cref="PartitionDate"/> value. Will accept any string that has exactly two '|' chars in
    /// it, and at least one of the parts can be parsed to a <see cref="Int16"/> (year) or <see cref="Byte"/> (day/month).
    /// </summary>
    /// <param name="str"> String to parse, "yyyy|MM|dd". </param>
    /// <returns> A <see cref="PartitionDate"/> value containing all valid parts of the parsed string. </returns>
    public static PartitionDate Deserialize(string str) 
        => TryParseDate(str, out var year, out var month, out var day) 
            ? PartitionDate.MakeSafe(year, month, day) 
            : default;

    /// <summary> Serializes a <see cref="PartitionDate"/> value </summary>
    /// <param name="value"> A <see cref="PartitionDate"/> value. </param>
    /// <returns> A <see cref="String"/> value representing the input value. </returns>
    public static string Serialize(PartitionDate value)
        => value.IsEmpty() ? string.Empty : $@"{value.Year:D4}{Separator}{value.Month:D2}{Separator}{value.Day:D2}";

    public static bool TryParseDate(string serialDate, out short year, out byte month, out byte day)
    {
        if (serialDate.Tokenize(Separator, out var spanYear)
                      .Next(out var spanMonth)
                      .Rest(out var spanDay)
                      .Try())
        {
            return short.TryParse(spanYear, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out year)
                   | byte.TryParse(spanMonth, NumberStyles.None, CultureInfo.InvariantCulture, out month)
                   | byte.TryParse(spanDay, NumberStyles.None, CultureInfo.InvariantCulture, out day);
        }
        year = month = day = 0;
        return false;
    }
}
