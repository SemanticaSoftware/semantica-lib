namespace Semantica.Domain.Data.Repositories;

/// <summary>
/// Interface for functionality to analyse properties of a storage model type, in order to identify immutable properties. Used
/// by repositories for replace methods.
/// </summary>
public interface IPropertyAnalyser
{
    /// <summary>
    /// Analyse type <typeparamref name="T"/> for immutable properties.
    /// </summary>
    /// <typeparam name="T"> Model type to analyse. </typeparam>
    /// <returns> A newly generated or cached <see cref="PropertyAnalysisResult"/> for the provided type. </returns>
    PropertyAnalysisResult GetOrAnalyse<T>();
}