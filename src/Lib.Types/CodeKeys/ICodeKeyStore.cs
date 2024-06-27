using System.Threading.Tasks;
using Semantica.Checks;
using Semantica.Patterns;

namespace Semantica.Types.CodeKeys;

public interface ICodeKeyStore<TCodeKey, TKey>
    where TCodeKey : struct, ICanBeEmpty
    where TKey : struct, IEquatable<TKey>, ICanBeEmpty
{
    ValueTask<Chk<TKey>> ExistsCodeKeyAsync(TCodeKey codeKey);
        
    TKey GetKey(TCodeKey codeKey);
    
    ValueTask<TKey> GetKeyAsync(TCodeKey codeKey);

    TCodeKey GetCodeKey(TKey key);
    
    ValueTask<TCodeKey> GetCodeKeyAsync(TKey key);
        
    bool TryGetCachedKey(TKey key, out TCodeKey codeKey);
    
    bool TryGetCachedKey(TCodeKey codeKey, out TKey key);
}
