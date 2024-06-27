using System.Collections.Concurrent;
using Semantica.Checks;

namespace Semantica.Domain.Data.Repositories;

/// <summary>
/// Default implementation of <see cref="IPropertyAnalyser"/>, that uses the injected <see cref="IPropertyIdentifier"/> to
/// determine immutable properties for any analysed model type. The <see cref="PropertyAnalysisResult"/> is stored statically
/// for each analysed type, so the analysis is only done once.
/// </summary>
public class PropertyAnalyser : IPropertyAnalyser
{
    private static readonly ConcurrentDictionary<string, PropertyAnalysisResult> _propertyNameSetsDictionary = new();
    private readonly IPropertyIdentifier _propertyIdentifier;

    public PropertyAnalyser(IPropertyIdentifier propertyIdentifier)
    {
        _propertyIdentifier = propertyIdentifier;
    }

    public PropertyAnalysisResult GetOrAnalyse<T>()
    {
        var type = typeof(T);
        Guard.For(Check.NotNull(type.FullName));
        return _propertyNameSetsDictionary.GetOrAdd(
            type.FullName!, 
            _ => AnalyseTypeProperties(type, _propertyIdentifier));
    }

    private static PropertyAnalysisResult AnalyseTypeProperties(Type type, IPropertyIdentifier propertyIdentifier)
    {
        return new PropertyAnalysisResult(immutableProperties:
            type.GetProperties()
                .Where(propertyIdentifier.IsImmutableProperty)
                .Select(propertyInfo => propertyInfo.Name));
    }
}