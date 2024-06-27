namespace Semantica.Storage.DataStores;

public interface ISimpleDataStore<TStorage, in TKey> : IDataStore<TStorage, TKey>
    where TStorage : class
    where TKey : struct, IEquatable<TKey>
{
    
}
