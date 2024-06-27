namespace Semantica.Domain.Data.Repositories;

/// <summary>
/// Holdings the result of property analysis of a single type. Used in <see cref="PropertyAnalyser"/>.
/// </summary>
public class PropertyAnalysisResult
{
    private readonly string[] _immutableProperties;

    public PropertyAnalysisResult(IEnumerable<string> immutableProperties)
    {
        _immutableProperties = immutableProperties.ToArray();
    }

    /// <summary> A list of all immutable properties of the analysed type. </summary>
    public IReadOnlyList<string> ImmutableProperties => _immutableProperties;
}
