using Microsoft.EntityFrameworkCore;
using Semantica.Checks;

namespace Semantica.Storage.EntityFramework.DataStores;

public class Inclusion<TStorable, TNavigationStorable> : IInclusion<TStorable>
    where TStorable : class, new()
    where TNavigationStorable : class, new()
{
    protected readonly InclusionPrototype<TStorable, TNavigationStorable> _InclusionPrototype;
    /// <summary>
    /// StorageModels worden alleen opgeslagen in de eerste/diepste inclusion. Een inclusion heeft dus nooit een List van
    /// storables én een <see cref="PreviousInclusion"/>.
    /// </summary>
    protected List<TStorable>? _Storables;

    /// <param name="inclusionPrototype"></param>
    /// <param name="previousInclusion"></param>
    public Inclusion(
            InclusionPrototype<TStorable, TNavigationStorable> inclusionPrototype,
            IInclusion<TStorable>? previousInclusion = null
        )
    {
        Guard.Contract(Check.NotNull(inclusionPrototype));
        PreviousInclusion = previousInclusion;
        _InclusionPrototype = inclusionPrototype;
    }
    
    // /// <summary>
    // /// Constructor voor inclusion als er opvolgende inclusions zijn.
    // /// </summary>
    // /// <param name="inclusionPrototype"></param>
    // /// <param name="thenInclusion"></param>
    // public Inclusion(
    //         InclusionPrototype<TStorable, TNavigationStorable> inclusionPrototype,
    //         IInclusion<TNavigationStorable>? thenInclusion
    //     )
    // {
    //     Check.NotNull(inclusionPrototype).Contract();
    //     Guard.Contract(thenInclusion == null || thenInclusion.NextInclusion == null);
    //     ThenInclusion = thenInclusion;
    //     _inclusionPrototype = inclusionPrototype;
    //     if (thenInclusion == null)
    //     {
    //         _storageModels = new List<TStorable>();
    //     }
    // }

    public IInclusion<TStorable>? PreviousInclusion { get; }
    
    // private IInclusion<TNavigationStorable>? ThenInclusion { get; }

    public IEnumerable<TStorable>? QueryResults => PreviousInclusion?.QueryResults ?? _Storables;

    public virtual IQueryable<TStorable> AddIncludesTo(IQueryable<TStorable> queryable)
    {
        if (PreviousInclusion != null)
        {
            queryable = PreviousInclusion.AddIncludesTo(queryable);
        }
        
        var includableQueryable = queryable.Include(_InclusionPrototype.IncludeExpression);
        // if (ThenInclusion != null)
        // {
        //     var q = new ThenQueryable<TStorable, TNavigationStorable>(includableQueryable);
        //     ThenInclusion.ThenInclude<TStorable, TStorable>(q);
        // }
        return includableQueryable;
    }
    
    // public IQueryable<TDataSet> ThenInclude<TDataSet, TIncludedFrom>(IThenQueryable<TDataSet?> thenQuerable)
    //     where TIncludedFrom : class where TDataSet : class
    // {
    //     var includableQueryable = (thenQuerable as ThenQueryable<TDataSet, TStorable>)?.IncludableQueryable
    //                               ?? throw new InvalidOperationException($"{nameof(thenQuerable)} implementation is not {nameof(ThenQueryable<TIncludedFrom, TStorable>)}");
    //     IIncludableQueryable<TIncludedFrom, TNavigationStorable?> thenIncludableQuery = includableQueryable.ThenInclude(_inclusionPrototype.IncludeExpression!);
    //     if (ThenInclusion != null)
    //     {
    //         var q = new ThenQueryable<TIncludedFrom, TNavigationStorable>(thenIncludableQuery);
    //         ThenInclusion.ThenInclude<TDataSet, TIncludedFrom>(q);
    //     }
    //     return thenIncludableQuery;
    // }

    public void RegisterQueryResult(TStorable? storageModel)
    {
        if (storageModel == null)
        {
            return;
        }
        
        if (PreviousInclusion == null)
        {
            _Storables ??= new List<TStorable>();
            _Storables.Add(storageModel);
        }
        else
        {
            PreviousInclusion.RegisterQueryResult(storageModel);
            // if (ThenInclusion != null)
            // {
            //     ThenInclusion?.RegisterQueryResult(_inclusionPrototype.IncludeExpression.Compile().Invoke(storageModel));
            // }
        }
    }

    public void RegisterQueryResult(IEnumerable<TStorable?> storageModels)
    {
        if (PreviousInclusion == null)
        {
            _Storables ??= new List<TStorable>();
            _Storables.AddRange(storageModels.WhereNotNull());
        }
        else
        {
            PreviousInclusion.RegisterQueryResult(storageModels);
            // else if (ThenInclusion != null)
            // {
            //     ThenInclusion?.RegisterQueryResult(storageModels.WhereNotNull().Select(_inclusionPrototype.IncludeExpression.Compile()));
            // }
        }
    }

    /// <summary>
    ///     Bij de dispose van de inclusion wordt in alle geregistreerde storage models de navigation property van de inclusion weer op null gezet.
    ///     Dat betekent niet dat de verwijzing naar dat entity wordt verwijdert, maar wel dat er geen onbedoelde inserts worden gedaan bij een update op de entity.
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    
    public virtual void Dispose(bool disposing)
    {
        if (disposing)
            ExecuteNullAssignments();
        PreviousInclusion?.Dispose(false);
        _Storables?.Clear();
        _Storables = null;
    }
    
    public void ExecuteNullAssignments()
    {
        QueryResults?.ForEach(_InclusionPrototype.NullAssignmentAction.Invoke);
        PreviousInclusion?.ExecuteNullAssignments();
    }
}

// internal class ThenQueryable<TDataSet, TNavigationStorable>(
//     IIncludableQueryable<TDataSet, TNavigationStorable?> includableQueryable
//     ) : IThenQueryable<TDataSet>
// {
//     public IIncludableQueryable<TDataSet, TNavigationStorable?> IncludableQueryable { get; } = includableQueryable;
//     public IQueryable<TDataSet> Queryable => IncludableQueryable;
// } 
