using Semantica.Checks.Exceptions;

namespace Semantica.Domain.Electives;

public class ElectiveNotLoadedException<T> : StateException
{
    public ElectiveNotLoadedException() :base(GetMessage())
    {
    }

    private static string GetMessage()
    {
        return $"Trying to retrieve {nameof(IElective<T>.Payload)} of unloaded elective of type {typeof(T).FullName}.";
    }
}
