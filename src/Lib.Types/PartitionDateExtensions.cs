namespace Semantica.Types;

/// <summary> Provides additional functionality for to <see cref="PartitionDate"/> values. </summary>
public static class PartitionDateExtensions
{
    /// <summary> Conversts a <see cref="PartitionDate"/> value to <see cref="DateOnly"/>. </summary>
    /// <param name="value"> Date value to convert. </param>
    /// <returns> A <see cref="DateOnly"/> instance. </returns>
    /// <exception cref="ArgumentOutOfRangeException"/>
    /// <exception cref="ArgumentException"/>
    public static DateOnly AsDateOnly(this PartitionDate value) => new(value.Year, value.Month, value.Day);

    /// <summary> Conversts a <see cref="PartitionDate"/> value to <see cref="DateTime"/>. </summary>
    /// <param name="value"> Date value to convert. </param>
    /// <param name="dateTimeKind"> Optional. <see cref="DateTimeKind"/> used in the created DateTime. </param>
    /// <returns> A <see cref="DateTime"/> instance, with the time part set at midnight. </returns>
    /// <exception cref="ArgumentOutOfRangeException"/>
    /// <exception cref="ArgumentException"/>
    public static DateTime AsDateTime(this PartitionDate value, DateTimeKind dateTimeKind = DateTimeKind.Unspecified)
    {
        return new(value.Year, value.Month, value.Day, 0, 0, 0, dateTimeKind);
    }

    /// <summary>
    /// Conversts a <see cref="PartitionDate"/> value to <see cref="DateOnly"/>.<br/>
    /// If input is invalid then null is returned (see <see cref="IsValidDate"/>.
    /// </summary>
    /// <param name="value"> Date value to convert. </param>
    /// <returns> A <see cref="DateOnly"/> instance; no value when invalid. </returns>
    public static DateOnly? AsNullableDateOnly(this PartitionDate value)
    {
        return value.TryAsDateOnly(out var dateOnly) 
            ? dateOnly
            : default(DateOnly?);
    }

    /// <summary>
    /// Converts a <see cref="PartitionDate"/> value to <see cref="DateTime"/>.<br/>
    /// If input is invalid then null is returned (see <see cref="IsValidDate"/>.
    /// </summary>
    /// <param name="value"> Date value to convert. </param>
    /// <param name="dateTimeKind"> Optional. <see cref="DateTimeKind"/> used in the created value. </param>
    /// <returns> A <see cref="DateTime"/> instance; no value when invalid. </returns>
    public static DateTime? AsNullableDateTime(this PartitionDate value, 
        DateTimeKind dateTimeKind = DateTimeKind.Unspecified)
    {
        return value.TryAsDateTime(out var dateTime, dateTimeKind) 
            ? dateTime
            : default(DateTime?);
    }

    /// <summary> Converts a <see cref="DateOnly"/> value to <see cref="PartitionDate"/>. </summary>
    /// <param name="value"> <see cref="DateOnly"/> value to convert. </param>
    /// <returns> A <see cref="PartitionDate"/> instance. </returns>
    public static PartitionDate AsPartitionDate(this DateOnly value)
    {
        return new(value.Year, value.Month, value.Day);
    }

    /// <summary> Converts a <see cref="DateTime"/> value to <see cref="PartitionDate"/>. The time part is ignored. </summary>
    /// <param name="value"> <see cref="DateTime"/> value to convert. </param>
    /// <returns> A <see cref="PartitionDate"/> instance. </returns>
    public static PartitionDate AsPartitionDate(this DateTime value)
    {
        return new(value.Year, value.Month, value.Day);
    }

    /// <summary>
    /// Determines if the <see cref="PartitionDate.Day"/> part of the input has a valid value. The combination of all parts can
    /// still be invalid. 
    /// </summary>
    /// <param name="value"> <see cref="PartitionDate"/> to evaluate the day part of. </param>
    /// <returns>
    /// <see langword="true"/> if the day part is valid (in the range of 1-31); <see langword="false"/> otherwise.
    /// </returns>
    public static bool HasValidDay(this PartitionDate value) => value.Day is >= 1 and <= 31;
    
    /// <summary>
    /// Determines if the <see cref="PartitionDate.Month"/> part of the input has a valid value. The combination of all parts
    /// can still be invalid. 
    /// </summary>
    /// <param name="value"> <see cref="PartitionDate"/> to evaluate the month part of. </param>
    /// <returns>
    /// <see langword="true"/> if the month part is valid (in the range of 1-12); <see langword="false"/> otherwise.
    /// </returns>
    public static bool HasValidMonth(this PartitionDate value) => value.Month is >= 1 and <= 12;
    
    /// <summary>
    /// Determines if the <see cref="PartitionDate.Year"/> part of the input has a valid value. The combination of all parts can
    /// still be invalid. 
    /// </summary>
    /// <param name="value"> <see cref="PartitionDate"/> to evaluate the year part of. </param>
    /// <returns>
    /// <see langword="true"/> if the year part is valid (in the range of 1-9999); <see langword="false"/> otherwise.
    /// </returns>
    public static bool HasValidYear(this PartitionDate value) => value.Year >= 1;

    /// <summary> Determines whether <paramref name="value"/> contains a valid date. </summary>
    /// <param name="value"> <see cref="PartitionDate"/> to convert </param>
    /// <returns> <see langword="true"/> if date is convertable to <see cref="DateTime"/>. </returns>
    public static bool IsValidDate(this PartitionDate value)
    {
        return value.TryAsDateTime(out _);
    }

    /// <summary>
    /// Converts a <see cref="PartitionDate"/> value to <see cref="DateOnly"/> and returns whether conversion succeeded.<br/>
    /// Fails when the value is an invalid date (see <see cref="IsValidDate"/>).
    /// </summary>
    /// <param name="value"> <see cref="PartitionDate"/> to convert. </param>
    /// <param name="dateOnly"> Out parameter that will contain the <see cref="DateOnly"/> value if succeeded. </param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="dateOnly"/> has been set; <see langword="false"/> otherwise.
    /// </returns>
    public static bool TryAsDateOnly(this PartitionDate value, out DateOnly dateOnly)
    {
        var result = value.TryAsDateTime(out var dateTime);
        dateOnly = DateOnly.FromDateTime(dateTime);
        return result;
    }

    /// <summary>
    /// Converts a <see cref="PartitionDate"/> value to <see cref="DateTime"/> and returns whether conversion succeeded.<br/>
    /// Fails when the value is an invalid date (see <see cref="IsValidDate"/>).
    /// </summary>
    /// <param name="value"> <see cref="PartitionDate"/> to convert. </param>
    /// <param name="dateTime"> Out parameter that will contain the <see cref="DateTime"/> value if succeeded. </param>
    /// <param name="dateTimeKind"> Optional. <see cref="DateTimeKind"/> used in the created value. </param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="dateTime"/> has been set; <see langword="false"/> otherwise.
    /// </returns>
    public static bool TryAsDateTime(this PartitionDate value, 
        out DateTime dateTime, DateTimeKind dateTimeKind = DateTimeKind.Unspecified)
    {
        if (!value.IsEmpty())
        {
            try
            {
                dateTime = value.AsDateTime(dateTimeKind);
                return true;
            }
            catch { /* No need to know reason for failure */ }
        }

        dateTime = default;
        return false;
    }
}
