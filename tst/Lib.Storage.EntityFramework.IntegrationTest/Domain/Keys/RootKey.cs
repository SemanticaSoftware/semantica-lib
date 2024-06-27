using System.Collections.Generic;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;
using Semantica.Linq;
using Semantica.Patterns.Domain;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;

public readonly record struct RootKey(int Id) : ISimpleKey<RootKey, int>
{
    public bool IsEmpty() => Id <= 0;

    public int? AsNullableId() => IsEmpty() ? default(int?) : Id;

    public static RootKey FromNullableId(int? id) => id.HasValue ? new(id.Value) : default;

    //test keys
    public static IReadOnlyList<RootKey> ExistingKeys = Root.Config.Ids.SelectArray(id => new RootKey(id));
}