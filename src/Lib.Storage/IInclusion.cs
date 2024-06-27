using System;
using System.Collections.Generic;
using System.Linq;

namespace Semantica.Storage;

public interface IInclusion<TStorable> : IDisposable
    where TStorable : class
{
    IQueryable<TStorable> AddIncludesTo(IQueryable<TStorable> queryable);
    
    void Dispose(bool disposing);
    
    void ExecuteNullAssignments();
    
    IInclusion<TStorable>? PreviousInclusion { get; }

    IEnumerable<TStorable>? QueryResults { get; }

    void RegisterQueryResult(TStorable? storageModel);

    void RegisterQueryResult(IEnumerable<TStorable?> storageModels);
    
    // public IQueryable<TDataSet> ThenInclude<TDataSet, TIncludedFrom>(IThenQueryable<TIncludedFrom> thenQueryable)
    //     where TDataSet : class
    //     where TIncludedFrom : class;
}



// public interface IThenQueryable<out TStorable>
// {
//     IQueryable<TStorable> Queryable { get; }
// }
