using System.Data.Common;
using StoredProcedureEFCore;

namespace Semantica.Storage.StoredProcedures;

/// <remarks>
/// This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.
/// </remarks>
public static class StoredProcBuilderExtensions
{
    public static IStoredProcBuilder AddParams(this IStoredProcBuilder builder, IProcedureParameters parameters)
    {
        return parameters.AddParams(builder);
    }

    public static T? GetScalar<T>(this DbDataReader reader, int ordinal)
    {
        var typeofT = typeof(T);
        if (typeofT == typeof(bool)) return (T)(object)reader.GetBoolean(ordinal);
        if (typeofT == typeof(byte)) return (T)(object)reader.GetByte(ordinal);
        if (typeofT == typeof(char)) return (T)(object)reader.GetChar(ordinal);
        if (typeofT == typeof(decimal)) return (T)(object)reader.GetDecimal(ordinal);
        if (typeofT == typeof(double)) return (T)(object)reader.GetDouble(ordinal);
        if (typeofT == typeof(float)) return (T)(object)reader.GetFloat(ordinal);
        if (typeofT == typeof(Guid)) return (T)(object)reader.GetGuid(ordinal);
        if (typeofT == typeof(int)) return (T)(object)reader.GetInt32(ordinal);
        if (typeofT == typeof(long)) return (T)(object)reader.GetInt64(ordinal);
        if (typeofT == typeof(string)) return (T)(object)reader.GetString(ordinal);
        if (typeofT == typeof(DateTime)) return (T)(object)reader.GetDateTime(ordinal);
        if (typeofT == typeof(DateOnly)) return (T)(object)DateOnly.FromDateTime(reader.GetDateTime(ordinal));

        return default;
    }
}