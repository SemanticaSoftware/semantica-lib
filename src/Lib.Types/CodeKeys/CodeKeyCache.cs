using System.Collections.Concurrent;

namespace Semantica.Types.CodeKeys
{
    internal class CodeKeyCache<TCodeKey, TKey> : ICodeKeyCache<TCodeKey, TKey>
        where TKey : struct, IEquatable<TKey>
        where TCodeKey : struct
    {
        private readonly ConcurrentDictionary<TCodeKey, TKey> _dictionary = new();
        private readonly ConcurrentDictionary<TKey, TCodeKey> _reverseDictionary = new();

        public void Cache(TCodeKey codeKey, TKey key)
        {
            _dictionary.TryAdd(codeKey, key);
            _reverseDictionary.TryAdd(key, codeKey);
        }

        public void Invalidate(TCodeKey codeKey)
        {
            if (_dictionary.TryRemove(codeKey, out TKey key))
            {
                _reverseDictionary.TryRemove(key, out codeKey);
            }
        }

        public void Invalidate(TKey key)
        {
            if (_reverseDictionary.TryRemove(key, out TCodeKey codeKey))
            {
                _dictionary.TryRemove(codeKey, out key);
            }
        }

        public TCodeKey FindCodeKey(TKey key)
        {
            return _reverseDictionary.TryGetValue(key, out TCodeKey codekey) ? codekey : default(TCodeKey);
        }

        public TKey FindKey(TCodeKey codeKey)
        {
            return _dictionary.TryGetValue(codeKey, out TKey key) ? key : default(TKey);
        }

        public bool TryFindCodeKey(TKey key, out TCodeKey codeKey)
        {
            return _reverseDictionary.TryGetValue(key, out codeKey);
        }

        public bool TryFindKey(TCodeKey codeKey, out TKey key)
        {
            return _dictionary.TryGetValue(codeKey, out key);
        }
    }
}
