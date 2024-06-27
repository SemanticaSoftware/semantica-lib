using System.Linq.Expressions;
using Semantica.Checks;

namespace Semantica.Storage.EntityFramework.DataStores;

public class InclusionPrototype<TStorable, TNavigationStorable>
    where TStorable : class, new()
    where TNavigationStorable : class, new()
{
    public Expression<Func<TStorable, TNavigationStorable?>> IncludeExpression { get; }

    public Action<TStorable> NullAssignmentAction { get; }

    //[EditorBrowsable(EditorBrowsableState.Never)]
    //public InclusionPrototype(Expression<Func<TStorageModel, TNavigationProperty>> includeExpression)
    //{
    //    IncludeExpression = includeExpression;
    //    NullAssignmentAction = MakeNullAssignmentAction(includeExpression);
    //}

    public InclusionPrototype(Expression<Func<TStorable, TNavigationStorable?>> includeExpression, Action<TStorable> nullAssignmentAction)
    {
        Guard.For(Check.Not(typeof(TNavigationStorable).GetInterfaces().Any(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IEnumerable<>))));
        IncludeExpression = includeExpression;
        NullAssignmentAction = nullAssignmentAction;
    }

    public IInclusion<TStorable> MakeInclusion()
    {
        return new Inclusion<TStorable,TNavigationStorable>(this);
    }

    public IInclusion<TStorable> MakeInclusion(IInclusion<TStorable>? nextInclusion)
    {
        return new Inclusion<TStorable,TNavigationStorable>(this, nextInclusion);
    }

    ///// <summary>
    ///// Method werkt nog niet
    ///// </summary>
    //[EditorBrowsable(EditorBrowsableState.Never)]
    //public static Action<TModel> MakeNullAssignmentAction<TModel, TProperty>(Expression<Func<TModel, TProperty>> expression)
    //    where TModel : class, new()
    //    where TProperty : class, new()
    //{
    //    ParameterExpression parameter = Expression.Parameter(typeof(TModel));
    //    BinaryExpression binary = Expression.Assign(expression, Expression.Constant(null));
    //    return Expression.Lambda<Action<TModel>>(binary, parameter).Compile();
    //}
}
