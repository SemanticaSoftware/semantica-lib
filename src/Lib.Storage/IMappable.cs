using System;
using System.Linq.Expressions;

namespace Semantica.Storage;

#if NET7_0_OR_GREATER

public interface IMappable<TIn, TOut>
{
    static abstract Expression<Func<TIn, TOut>> Mapping { get; }
}

#endif
