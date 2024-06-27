namespace Semantica.Patterns.Domain;

public interface IIdentityKey : IIdKey<int>
{
}

public interface IIdentityKey<out TSelf> : IIdentityKey, ISimpleKey<TSelf, int>
    where TSelf : struct
{
}
