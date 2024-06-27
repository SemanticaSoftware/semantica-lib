namespace Semantica.Types.CodeKeys;

public interface ICodeKeyCache<TCodeKey, TKey>
    where TCodeKey : struct
    where TKey : struct
{
    void Cache(TCodeKey codeKey, TKey key);

    void Invalidate(TCodeKey codekey);

    void Invalidate(TKey key);

    bool TryFindKey(TCodeKey codeKey, out TKey key);
    
    bool TryFindCodeKey(TKey key, out TCodeKey codeKey);

    TKey FindKey(TCodeKey codeKey);
    
    TCodeKey FindCodeKey(TKey key);
}
