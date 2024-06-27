namespace Semantica.Patterns.Exceptions;

public class JsonDeserializationException : Exception
{
    public JsonDeserializationException(Type type, string attemptedValue)
        : base(Format(type, attemptedValue))
    {
    }

    private static string Format(Type type, string attemptedValue)
    {
        return $"Type does not implement ICanSerialize<{type}>. Value \"{attemptedValue}\" cannot be converted.";
    }
}
