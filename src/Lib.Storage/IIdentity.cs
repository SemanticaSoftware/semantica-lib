namespace Semantica.Storage;

public interface IIdentity : IIdentity<int>
{
}

/// <summary>
/// 
/// </summary>
/// <typeparam name="TId">  </typeparam>
public interface IIdentity<TId>
{
    /// <summary> Primary key of the entity </summary>
    TId Id { get; set; }
}