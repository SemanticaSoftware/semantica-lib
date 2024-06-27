using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Semantica.Checks;
using Semantica.Storage.DataStores;
using StoredProcedureEFCore;

namespace Semantica.Storage.StoredProcedures;

/// <remarks>
/// This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.
/// </remarks>
public static class DbContextExtention
{
    public static IReadOnlyList<TOut> ExecuteProcedure<TIn, TOut>(
        this DbContext dbContext,
        IProcedure<TIn, TOut> definition,
        TIn parameters)
        where TIn : class
        where TOut : class, new()
    {
        IReadOnlyList<TOut> results = null!;
        dbContext.BuildProcedureQuery(definition, parameters).Exec(reader => results = reader.ToList<TOut>());
        return results;
    }

    public static async Task<IReadOnlyList<TOut>> ExecuteProcedureAsync<TIn, TOut>(
        this DbContext dbContext,
        IProcedure<TIn, TOut> definition,
        TIn parameters,
        CancellationToken cancellationToken = default)
        where TIn : class
        where TOut : class, new()
    {
        IReadOnlyList<TOut> results = null!;
        await dbContext.BuildProcedureQuery(definition, parameters)
                       .ExecAsync(
                           async reader => results = await reader.ToListAsync<TOut>(cancellationToken),
                           cancellationToken);
        return results;
    }

    public static async Task<(IReadOnlyList<TOut> result, IReadOnlyList<TOut2> result2)>
        ExecuteProcedureAsync<TIn, TOut, TOut2>(
            this DbContext dbContext,
            IProcedure<TIn, TOut, TOut2> definition,
            TIn parameters,
            CancellationToken cancellationToken = default)
        where TIn : class
        where TOut : class, new()
        where TOut2 : class, new()
    {
        IReadOnlyList<TOut> result = null!;
        IReadOnlyList<TOut2> result2 = null!;
        await dbContext.BuildProcedureQuery(definition, parameters).ExecAsync(
            async reader =>
            {
                result = await reader.ToListAsync<TOut>(cancellationToken);
                if (!await reader.NextResultAsync(cancellationToken))
                    throw new StoredProcedureException($"Procedure {definition.Name} did not return a second result set.");

                result2 = await reader.ToListAsync<TOut2>(cancellationToken);
            },
            cancellationToken);
        return (result, result2);
    }

    public static async Task<(IReadOnlyList<TOut> result, IReadOnlyList<TOut2> result2, IReadOnlyList<TOut3> result3)>
        ExecuteProcedureAsync<TIn, TOut, TOut2, TOut3>(
            this DbContext dbContext,
            IProcedure<TIn, TOut, TOut2, TOut3> definition,
            TIn parameters,
            CancellationToken cancellationToken = default)
        where TIn : class
        where TOut : class, new()
        where TOut2 : class, new()
        where TOut3 : class, new()
    {
        IReadOnlyList<TOut> result = null!;
        IReadOnlyList<TOut2> result2 = null!;
        IReadOnlyList<TOut3> result3 = null!;
        await dbContext.BuildProcedureQuery(definition, parameters).ExecAsync(
            async reader =>
            {
                result = await reader.ToListAsync<TOut>(cancellationToken);
                if (!await reader.NextResultAsync(cancellationToken))
                    throw new StoredProcedureException($"Procedure {definition.Name} did not return a second result set.");

                result2 = await reader.ToListAsync<TOut2>(cancellationToken);
                if (!await reader.NextResultAsync(cancellationToken))
                    throw new StoredProcedureException($"Procedure {definition.Name} did not return a third result set.");

                result3 = await reader.ToListAsync<TOut3>(cancellationToken);
            },
            cancellationToken);
        return (result, result2, result3);
    }

    public static async Task<(IReadOnlyList<TOut> result, TScalar? scalar)> ExecuteProcedureAsync<TIn, TOut, TScalar>(
        this DbContext dbContext,
        IProcedureWithScalar<TIn, TOut, TScalar> definition,
        TIn parameters,
        CancellationToken cancellationToken = default)
        where TIn : class
        where TOut : class, new()
        where TScalar : class, new()
    {
        IReadOnlyList<TOut> result = null!;
        TScalar? scalar = default;
        await dbContext.BuildProcedureQuery(definition, parameters).ExecAsync(
            async reader =>
            {
                result = await reader.ToListAsync<TOut>(cancellationToken);
                if (!await reader.NextResultAsync(cancellationToken))
                    throw new StoredProcedureException($"Procedure {definition.Name} did not return a second result.");

                scalar = reader.GetScalar<TScalar>(0);
            },
            cancellationToken);
        return (result, scalar);
    }

    public static async Task<(IReadOnlyList<TOut> result, int count)>
        ExecuteProcedureWithCountAsync<TIn, TOut>(
            this DbContext dbContext,
            IProcedure<TIn, TOut> definition,
            TIn parameters,
            CancellationToken cancellationToken = default)
        where TIn : class
        where TOut : class, new()
    {
        IReadOnlyList<TOut> results = null!;
        var count = 0;
        await dbContext.BuildProcedureQuery(definition, parameters).ExecAsync(
            async reader =>
            {
                results = await reader.ToListAsync<TOut>(cancellationToken);
                if (!await reader.NextResultAsync(cancellationToken))
                    throw new StoredProcedureException($"Procedure {definition.Name} did not return a second result.");
                count = reader.GetInt32(0);
            },
            cancellationToken);
        return (results, count);
    }

    public static async Task<(IReadOnlyList<TOut> result, IReadOnlyList<int> counts)>
        ExecuteProcedureWithCountsAsync<TIn, TOut>(
            this DbContext dbContext,
            IProcedure<TIn, TOut> definition,
            TIn parameters,
            CancellationToken cancellationToken = default)
        where TIn : class
        where TOut : class, new()
    {
        IReadOnlyList<TOut> results = null!;
        var counts = new List<int>();
        await dbContext.BuildProcedureQuery(definition, parameters).ExecAsync(
            async reader =>
            {
                results = await reader.ToListAsync<TOut>(cancellationToken);
                while (await reader.NextResultAsync(cancellationToken))
                {
                    counts.Add(reader.GetInt32(0));
                }
            },
            cancellationToken);
        return (results, counts);
    }

    private static IStoredProcBuilder BuildProcedureQuery<TIn, TOut>(
        this DbContext dbContext,
        IProcedure<TIn, TOut> definition,
        TIn parameters)
        where TIn : class
        where TOut : class
    {
        Check.That(definition is ProcedureDefinition<TIn, TOut>).Contract();
        Check.That(parameters is IProcedureParameters).Contract();
        var builder = dbContext.LoadStoredProc(definition.Name)
                               .AddParams((IProcedureParameters)parameters);
        return builder;
    }
}