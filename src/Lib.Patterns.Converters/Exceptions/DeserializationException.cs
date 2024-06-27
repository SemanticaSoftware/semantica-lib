namespace Semantica.Patterns.Exceptions;

public class DeserializationException : Exception
{
    public DeserializationException(Type type, string attemptedValue)
        : base(Format(type, attemptedValue))
    {
    }

    public DeserializationException(Type type, string attemptedValue, string expectedFormat)
        : base(Format(type, attemptedValue, expectedFormat))
    {
    }

    private static string Format(Type type, string attemptedValue)
    {
        return $"Deserialization of {type} failed. Unexpected formatting \"{attemptedValue}\".";
    }

    private static string Format(Type type, string attemptedValue, string expectedFormat)
    {
        return $"Deserialization of {type} failed. Unexpected formatting \"{attemptedValue}\" - expected: {expectedFormat}.";
    }
}
