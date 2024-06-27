namespace Semantica.Domain.Electives;

public static class ElectiveExtensions
{
    
    public static TOut? SelectIfLoadedAndNotNull<TIn, TOut>(this IElective<TIn> elective, Func<TIn, TOut> selector)
        where TIn : class?
        where TOut : class?
    {
        return elective.IsLoaded() && ! elective.IsEmpty() ? selector(elective.Payload!) : null;
    }
    
    public static TOut? SelectIfLoadedAndNotNull<TIn, TOut>(this IElective<TIn?> elective, Func<TIn, TOut> selector)
        where TIn : struct
        where TOut : class?
    {
        return elective.IsLoaded() && elective.Payload.HasValue ? selector(elective.Payload.Value) : default;
    }
    
    public static TOut? SelectIfLoadedAndNotNull<TIn, TOut>(this IElective<TIn?> elective, Func<TIn, TOut?> selector)
        where TIn : struct
        where TOut : struct
    {
        return elective.IsLoaded() && elective.Payload.HasValue ? selector(elective.Payload.Value) : default(TOut?);
    }
    
    public static IEnumerable<TOut> SelectIfLoadedAndNotNull<TIn, TOut>(this IElectiveCollection<IEnumerable<TIn>, TIn> elective, Func<TIn, TOut> selector)
        where TIn : class?
        where TOut : class?
    {
        if (! elective.IsLoaded() || elective.Payload == null)
        {
            yield break;
        }

        foreach (var element in elective.Payload)
        {
            if (element != null)
            {
                var output = selector.Invoke(element);
                if (output != null)
                {
                    yield return output;
                }
            }
        }
    }
    
    public static IEnumerable<TOut> SelectIfLoadedAndNotNull<TIn, TOut>(this IElectiveCollection<IEnumerable<TIn>, TIn> elective, Func<TIn, TOut?> selector)
        where TIn : class?
        where TOut : struct
    {
        if (! elective.IsLoaded() || elective.Payload == null)
        {
            yield break;
        }

        foreach (var element in elective.Payload)
        {
            if (element != null)
            {
                var output = selector.Invoke(element);
                if (output.HasValue)
                {
                    yield return output.Value;
                }
            }
        }
    }
    
    public static TOut[] ToArrayIfLoaded<TIn, TOut>(this IElectiveCollection<IReadOnlyList<TIn>, TIn> elective, Func<TIn, TOut> selector)
        where TIn : class
        where TOut : class?
    {
        return elective.IsLoaded() && elective.Payload != null 
            ? elective.Payload.SelectArray(selector) 
            : Array.Empty<TOut>();
    }
}

/// <summary>
/// Provides additional functionality for classes/structs in electives, that cannot be part of <see cref="ElectiveExtensions"/>
/// because of signature overlap.
/// </summary>
/// <remarks>
/// The compiler doesn't acknoweledge the difference between a non-nullable struct and class in Func output types, unless they
/// are on a separate class, so this weird thing has to exist. 
/// </remarks>
public static class ElectiveExtensionsX
{
    public static TOut? SelectIfLoadedAndNotNull<TIn, TOut>(this IElective<TIn?> elective, Func<TIn, TOut> selector)
        where TIn : struct
        where TOut : struct
    {
        return elective.IsLoaded() && elective.Payload.HasValue ? selector(elective.Payload.Value) : default(TOut?);
    }
    
    public static IEnumerable<TOut> SelectIfLoadedAndNotNull<TIn, TOut>(this IElectiveCollection<IEnumerable<TIn>, TIn> elective, Func<TIn, TOut> selector)
        where TIn : class?
        where TOut : struct
    {
        if (! elective.IsLoaded() || elective.Payload == null)
        {
            yield break;
        }

        foreach (var element in elective.Payload)
        {
            if (element != null)
            {
                yield return selector.Invoke(element);
            }
        }
    }
}
