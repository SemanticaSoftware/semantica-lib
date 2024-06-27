namespace Semantica.Storage.DataStores;

public interface IProcedure<TParams, TOut> 
    where TParams: class
    where TOut: class
{
    string Name { get; }
}

public interface IProcedure<TParams, TOut, TOut2> : IProcedure<TParams, TOut>
    where TParams: class
    where TOut: class
    where TOut2: class
{
}

public interface IProcedure<TParams, TOut, TOut2, TOut3> : IProcedure<TParams, TOut>
    where TParams: class
    where TOut: class
    where TOut2: class
    where TOut3: class
{
}

public interface IProcedureWithScalar<TParams, TOut, TScalar> : IProcedure<TParams, TOut>
    where TParams: class
    where TOut: class
{
}