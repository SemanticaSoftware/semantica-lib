using System.Collections.Generic;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;
using Semantica.Linq;
using Semantica.Patterns.Domain;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;

public readonly record struct SimpleDependentKey(int Id) : ISimpleKey<SimpleDependentKey, int>
{
    public bool IsEmpty() => Id <= 0;

    public int? AsNullableId() => IsEmpty() ? default(int?) : Id;

    public static SimpleDependentKey FromNullableId(int? id) => id.HasValue ? new(id.Value) : default;
    
    /// <summary>
    /// 
    /// </summary>
    public static IReadOnlyList<SimpleDependentKey> ExistingKeys = SimpleDependent.Config.Ids.SelectArray(id => new SimpleDependentKey(id));
}