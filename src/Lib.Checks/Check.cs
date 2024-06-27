using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Semantica.Patterns;

namespace Semantica.Checks;

/// <summary>
/// Provides a number of standard checks that can be used for guards. The <see cref="CheckKind"/> <see cref="Chk{T}.Payload"/>
/// indicates the type of check that has failed, so a proper exception(-message) can be constructed. The
/// <see cref="Chk.Reason"/> will contain the expression passed on failure.
/// </summary>
public static class Check
{
    /// <summary>
    /// Creates a failed check reason that can be <c>||</c>'d onto an actual check in order to make the evaluation of the
    /// reason only evaluated if the check fails using short-circuit mechanisms.  
    /// </summary>
    /// <param name="description"> Description of the failed check. </param>
    /// <returns> A <see cref="Chk{T}"/> of <see cref="CheckKind"/> with the provided <paramref name="description"/>. </returns>
    public static Chk<CheckKind> Fails(string description) => Chk.Rsn.ForFail<CheckKind>(description);
    
    /// <summary>
    /// A passing <see cref="Chk{T}"/> of <see cref="CheckKind"/>.
    /// </summary>
    public static readonly Chk<CheckKind> None = Chk<CheckKind>.Pass;

    #region Bool

    /// <summary>
    /// Makes a check that passes if the <paramref name="left"/> and the <paramref name="right"/> are equal; and fails otherwise.
    /// </summary>
    /// <param name="left"> The <see langword="bool"/> result of a condition. </param>
    /// <param name="right"> The <see langword="bool"/> result of a condition. </param>
    /// <param name="leftExpression"> The left expression to be added as reason on fail. </param>
    /// <param name="rightExpression"> The right expression to be added as reason on fail. </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> AreEqual<T>(
        T left,
        T right,
        [CallerArgumentExpression("left")] string? leftExpression = null,
        [CallerArgumentExpression("right")] string? rightExpression = null)
        where T: IEquatable<T>
    {
        return Chk.If(left.Equals(right)).WithPld(CheckKind.Bool) || Fails($"({leftExpression}) == ({rightExpression})");
    }

    /// <summary>
    /// Makes a check that passes if <paramref name="condition"/> is <see langword="false"/>; and fails otherwise.
    /// </summary>
    /// <param name="condition"> The <see langword="bool"/> result of a condition. </param>
    /// <param name="expression"> The expression to be added as reason on fail. </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> Not(bool condition,
        [CallerArgumentExpression("condition")] string? expression = null)
    {
        return Chk.If(!condition).WithPld(CheckKind.Bool) || Fails($"!({expression})");
    }

    /// <summary>
    /// Makes a check that passes if <paramref name="condition"/> is <see langword="true"/>; and fails otherwise. 
    /// </summary>
    /// <param name="condition"> The <see langword="bool"/> result of a condition. </param>
    /// <param name="expression"> The expression to be added as reason on fail. </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> That(
        bool condition,
        [CallerArgumentExpression("condition")] string? expression = null)
    {
        return Chk.If(condition).WithPld(CheckKind.Bool).Fails(expression);
    }

    #endregion
    #region Defined

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.Defined"/> that passes if <paramref name="value"/> is a valid value for enum
    /// <typeparamref name="T"/>; and fails otherwise. 
    /// </summary>
    /// <typeparam name="T"> Type of the enum value to check. </typeparam>
    /// <param name="value"> The value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> IsDefined<T>(T value,
        [CallerArgumentExpression("value")] string? name = null)
        where T : struct, Enum
    {
        return Chk.If(Enum.IsDefined(typeof(T), value)).WithPld(CheckKind.Defined).Fails(name);
    }
    
    /// <summary>
    /// Makes a check of kind <see cref="F:Semantica.Checks.CheckKind.Defined" /> that passes if <paramref name="value" /> is a valid value for enum
    /// <typeparamref name="T" />; and fails otherwise.
    /// </summary>
    /// <typeparam name="T"> Type of the enum value to check. </typeparam>
    /// <param name="value"> The value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="P:Semantica.Checks.Chk.Reason" /> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="T:Semantica.Checks.Chk`1" /> of <see cref="T:Semantica.Checks.CheckKind" /> that is <see cref="P:Semantica.Checks.Chk.Passed" /> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> IsDefined<T>(T? value, [CallerArgumentExpression("value")] string? name = null)
            where T : struct, Enum
        => Chk.If(value.HasValue && Enum.IsDefined(typeof(T), value.Value)).WithPld<CheckKind>(CheckKind.Defined).Fails(name);

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.Defined"/> that passes if <paramref name="value"/> is a valid value for
    /// double; and fails if the value is <see langword="double.NaN"/> or <see langword="double.Infinity"/>. 
    /// </summary>
    /// <param name="value"> The value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> IsDefined(double value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(!(double.IsNaN(value) || double.IsInfinity(value))).WithPld(CheckKind.Defined).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="F:Semantica.Checks.CheckKind.Defined" /> that passes if <paramref name="value" /> is a valid value for
    /// double; and fails if the value is <see langword="double.NaN" /> or <see langword="double.Infinity" />.
    /// </summary>
    /// <param name="value"> The value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="P:Semantica.Checks.Chk.Reason" /> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="T:Semantica.Checks.Chk`1" /> of <see cref="T:Semantica.Checks.CheckKind" /> that is <see cref="P:Semantica.Checks.Chk.Passed" /> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> IsDefined(double? value, [CallerArgumentExpression("value")] string? name = null)
        => Chk.If(value.HasValue && ! double.IsNaN(value.Value) && ! double.IsInfinity(value.Value)).WithPld<CheckKind>(CheckKind.Defined).Fails(name);

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.Defined"/> that passes if <paramref name="value"/> is determined;
    /// and fails otherwise.
    /// </summary>
    /// <typeparam name="T"> The <see cref="IDeterminable"/> type of instance to check. </typeparam>
    /// <param name="value"> The instance to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> IsDetermined<T>(T value,
        [CallerArgumentExpression("value")] string? name = null)
        where T : IDeterminable
    {
        return Chk.If(value.IsDetermined).WithPld(CheckKind.Defined).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.Defined"/> that passes if <paramref name="value"/> is determined;
    /// and fails otherwise.
    /// </summary>
    /// <typeparam name="T"> The <see cref="IDeterminable"/> type of instance to check. </typeparam>
    /// <param name="value"> The instance to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> IsDetermined<T>(T? value,
        [CallerArgumentExpression("value")] string? name = null)
        where T : struct, IDeterminable
    {
        return Chk.If(value is { IsDetermined: true }).WithPld(CheckKind.Defined).Fails(name);
    }

    #endregion
    #region MaxValue
#if NET7_0_OR_GREATER
    
    public static Chk<CheckKind> MaxValue<T>(T value, T maxValue,
        [CallerArgumentExpression("value")] string? name = null)
    where T: IComparisonOperators<T,T,bool>
    {
        return Chk.If(value <= maxValue).WithPld(CheckKind.NonNegative).Fails(name);
    }
    
    public static Chk<CheckKind> MaxValueAbs<T>(T value, T maxValue,
        [CallerArgumentExpression("value")] string? name = null)
        where T: IComparisonOperators<T,T,bool>, ISignedNumber<T>
    {
        return Chk.If(T.Abs(value) <= maxValue).WithPld(CheckKind.NonNegative).Fails(name);
    }
    
#else

    public static Chk<CheckKind> MaxValue(int value, int maxValue,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value <= maxValue).WithPld(CheckKind.NonNegative).Fails(name);
    }

    public static Chk<CheckKind> MaxValueAbs(int value, int maxValue,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(Math.Abs(value) <= maxValue).WithPld(CheckKind.NonNegative).Fails(name);
    }
    
#endif    
    
    #endregion
    #region NotNegative

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NonNegative"/> that passes if <paramref name="value"/> is not negative;
    /// and fails otherwise.
    /// </summary>
    /// <param name="value"> The <see langword="int"/> value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NotNegative(int value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value >= 0).WithPld(CheckKind.NonNegative).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NonNegative"/> that passes if <paramref name="value"/> is not negative;
    /// and fails otherwise.
    /// </summary>
    /// <param name="value"> The <see langword="short"/> value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NotNegative(short value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value >= 0).WithPld(CheckKind.NonNegative).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NonNegative"/> that passes if <paramref name="value"/> is not negative;
    /// and fails otherwise.
    /// </summary>
    /// <param name="value"> The <see langword="long"/> value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NotNegative(long value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value >= 0).WithPld(CheckKind.NonNegative).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NonNegative"/> that passes if <paramref name="value"/> is not negative;
    /// and fails otherwise.
    /// </summary>
    /// <param name="value"> The <see langword="float"/> value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NotNegative(float value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value >= 0).WithPld(CheckKind.NonNegative).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NonNegative"/> that passes if <paramref name="value"/> is not negative;
    /// and fails otherwise.
    /// </summary>
    /// <param name="value"> The <see langword="double"/> value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NotNegative(double value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value >= 0).WithPld(CheckKind.NonNegative).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NonNegative"/> that passes if <paramref name="value"/> is not negative;
    /// and fails otherwise.
    /// </summary>
    /// <param name="value"> The <see langword="decimal"/> value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NotNegative(decimal value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value >= 0).WithPld(CheckKind.NonNegative).Fails(name);
    }
    
    #endregion
    #region NotNull
    
    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NotNull"/> that passes if <paramref name="value"/> is not equal to
    /// <see langword="default"/>; and fails otherwise.
    /// </summary>
    /// <param name="value"> The instance to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <typeparam name="T"> The <see cref="IEquatable{T}"/> type of instance to check. </typeparam>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NotDefault<T>(T value,
        [CallerArgumentExpression("value")] string? name = null)
        where T : struct, IEquatable<T>
    {
        return Chk.If(!value.Equals(default(T))).WithPld(CheckKind.NotEmpty).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NotNull"/> that passes if <paramref name="value"/> is not
    /// <see langword="null"/>; and fails otherwise.
    /// </summary>
    /// <param name="value"> The instance to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <typeparam name="T"> The reference type of instance to check. </typeparam>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    [ContractAnnotation("value: null => false")]
    public static Chk<CheckKind> NotNull<T>([NotNullWhen(returnValue: true)][NoEnumeration] T? value,
        [CallerArgumentExpression("value")] string? name = null)
        where T : class
    {
        return Chk.If(value != null).WithPld(CheckKind.NotNull).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NotNull"/> that passes if <paramref name="value"/> is not
    /// <see langword="null"/>; and fails otherwise.
    /// </summary>
    /// <param name="value"> The instance to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <typeparam name="T"> The <see cref="Nullable{T}"/> value type of instance to check. </typeparam>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NotNull<T>([NotNullWhen(returnValue: true)] T? value,
        [CallerArgumentExpression("value")] string? name = null)
        where T : struct
    {
        return Chk.If(value.HasValue).WithPld(CheckKind.NotNull).Fails(name);
    }
    
    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NotNull"/> that passes if <paramref name="value"/> is not
    /// <see langword="default"/>, using de default <see cref="EqualityComparer{T}"/>; and fails otherwise.
    /// </summary>
    /// <param name="value"> The instance to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <typeparam name="T"> The reference type of instance to check. </typeparam>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NotNullOrDefault<T>([NotNullWhen(returnValue: true)][NoEnumeration] T value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(!EqualityComparer<T>.Default.Equals(value, default(T))).WithPld(CheckKind.NotNull).Fails(name);
    }

    #endregion
    #region NotEmpty
    
    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NotEmpty"/> that passes if <paramref name="collection"/> is not
    /// <see langword="null"/> and has at least one element; and fails otherwise.
    /// </summary>
    /// <param name="collection"> The collection instance to check. </param>
    /// <param name="name">
    /// Name/expression of the collection field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <typeparam name="T"> The <see cref="IReadOnlyCollection{T}"/> type of instance to check. </typeparam>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NotEmpty<T>(IReadOnlyCollection<T>? collection,
        [CallerArgumentExpression("collection")] string? name = null)
    {
        return Chk.If(collection != null && collection.Count > 0).WithPld(CheckKind.NotEmpty).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NotEmpty"/> that passes if <paramref name="collection"/> is not
    /// <see langword="null"/> and has at least one element; and fails otherwise.
    /// </summary>
    /// <param name="collection"> The collection instance to check. </param>
    /// <param name="name">
    /// Name/expression of the collection field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <typeparam name="T"> The <see cref="IReadOnlyList{T}"/> type of instance to check. </typeparam>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NotEmpty<T>([NotNullWhen(returnValue: true)] IReadOnlyList<T>? collection,
        [CallerArgumentExpression("collection")] string? name = null)
    {
        return NotEmpty((IReadOnlyCollection<T>?)collection, name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NotEmpty"/> that passes if <paramref name="value"/> is not
    /// <see langword="Guid.Empty"/>; and fails otherwise.
    /// </summary>
    /// <param name="value"> The <see cref="Guid"/> instance to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NotEmpty(Guid value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(! Guid.Empty.Equals(value)).WithPld(CheckKind.NotEmpty).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NotEmpty"/> that passes if <paramref name="value"/> is not
    /// <see langword="Guid.Empty"/>; and fails otherwise.
    /// </summary>
    /// <param name="value"> The <see cref="Guid"/> instance to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NotEmpty(Guid? value, [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value.HasValue && !Guid.Empty.Equals(value.Value)).WithPld(CheckKind.NotEmpty).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NotEmpty"/> that passes if <paramref name="value"/> is not empty; and fails
    /// otherwise.
    /// </summary>
    /// <param name="value"> The instance to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <typeparam name="T"> The <see cref="ICanBeEmpty"/> type of instance to check. </typeparam>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NotEmpty<T>(T value,
        [CallerArgumentExpression("value")] string? name = null)
        where T : ICanBeEmpty
    {
        return Chk.If(! value.IsEmpty()).WithPld(CheckKind.NotEmpty).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NotEmpty"/> that passes if <paramref name="value"/> is not empty; and fails
    /// otherwise.
    /// </summary>
    /// <param name="value"> The instance to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <typeparam name="T"> The <see cref="ICanBeEmpty"/> type of instance to check. </typeparam>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NotEmpty<T>(T? value, [CallerArgumentExpression("value")] string? name = null)
        where T : struct, ICanBeEmpty
    {
        return Chk.If(value.HasValue && !value.Value.IsEmpty()).WithPld(CheckKind.NotEmpty).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NotEmpty"/> that passes if <paramref name="value"/> is not
    /// <see langword="null"/> or an empty string; and fails otherwise.
    /// </summary>
    /// <param name="value"> The <see cref="string"/> instance to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NotEmpty([NotNullWhen(returnValue: true)] string? value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(!string.IsNullOrEmpty(value)).WithPld(CheckKind.NotEmpty).Fails(name);
    }

    #endregion
    #region NonZero

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NonZero"/> that passes if <paramref name="value"/> is not zero; and fails
    /// otherwise.
    /// </summary>
    /// <param name="value"> The <see langword="int"/> value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NonZero(int value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value != 0).WithPld(CheckKind.NonZero).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NonZero"/> that passes if <paramref name="value"/> is not zero; and fails
    /// otherwise.
    /// </summary>
    /// <param name="value"> The <see langword="short"/> value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NonZero(short value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value != 0).WithPld(CheckKind.NonZero).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NonZero"/> that passes if <paramref name="value"/> is not zero; and fails
    /// otherwise.
    /// </summary>
    /// <param name="value"> The <see langword="long"/> value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NonZero(long value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value != 0).WithPld(CheckKind.NonZero).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NonZero"/> that passes if <paramref name="value"/> is not zero; and fails
    /// otherwise.
    /// </summary>
    /// <param name="value"> The <see langword="float"/> value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NonZero(float value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value > float.Epsilon || value < -float.Epsilon).WithPld(CheckKind.NonZero).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NonZero"/> that passes if <paramref name="value"/> is not zero; and fails
    /// otherwise.
    /// </summary>
    /// <param name="value"> The <see langword="double"/> value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NonZero(double value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value > double.Epsilon || value < -double.Epsilon).WithPld(CheckKind.NonZero).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.NonZero"/> that passes if <paramref name="value"/> is not zero; and fails
    /// otherwise.
    /// </summary>
    /// <param name="value"> The <see langword="decimal"/> value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> NonZero(decimal value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value != 0).WithPld(CheckKind.NonZero).Fails(name);
    }

    #endregion
    #region StrictPositive

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.StrictPositive"/> that passes if <paramref name="value"/> is greater than
    /// zero; and fails otherwise.
    /// </summary>
    /// <param name="value"> The <see langword="int"/> value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> StrictPositive(int value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value > 0).WithPld(CheckKind.StrictPositive).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.StrictPositive"/> that passes if <paramref name="value"/> is greater than
    /// zero; and fails otherwise.
    /// </summary>
    /// <param name="value"> The <see langword="short"/> value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> StrictPositive(short value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value > 0).WithPld(CheckKind.StrictPositive).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.StrictPositive"/> that passes if <paramref name="value"/> is greater than
    /// zero; and fails otherwise.
    /// </summary>
    /// <param name="value"> The <see langword="long"/> value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> StrictPositive(long value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value > 0).WithPld(CheckKind.StrictPositive).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.StrictPositive"/> that passes if <paramref name="value"/> is greater than
    /// zero; and fails otherwise.
    /// </summary>
    /// <param name="value"> The <see langword="float"/> value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> StrictPositive(float value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value > 0).WithPld(CheckKind.StrictPositive).Fails(name);
    }

    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.StrictPositive"/> that passes if <paramref name="value"/> is greater than
    /// zero; and fails otherwise.
    /// </summary>
    /// <param name="value"> The <see langword="double"/> value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> StrictPositive(double value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value > 0).WithPld(CheckKind.StrictPositive).Fails(name);
    }
    /// <summary>
    /// Makes a check of kind <see cref="CheckKind.StrictPositive"/> that passes if <paramref name="value"/> is greater than
    /// zero; and fails otherwise.
    /// </summary>
    /// <param name="value"> The <see langword="decimal"/> value to check. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> StrictPositive(decimal value,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value > 0).WithPld(CheckKind.StrictPositive).Fails(name);
    }

    #endregion
    #region string

    /// <summary>
    /// Makes a check that passes if <paramref name="value"/> is not <see langword="null"/> and at least
    /// <paramref name="minLength"/> characters in length; and fails otherwise.
    /// </summary>
    /// <param name="value"> The <see cref="string"/> instance to check. </param>
    /// <param name="minLength"> The minimal valid length for the input. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> MinLength([NotNullWhen(returnValue: true)] string? value, int minLength,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value != null && value.Length >= minLength).WithPld(CheckKind.Bool) 
               || Fails($"{name} >= {minLength}");
    }

    /// <summary>
    /// Makes a check that passes if <paramref name="value"/> is at most <paramref name="maxLength"/> characters in length; and
    /// fails otherwise.
    /// </summary>
    /// <param name="value"> The <see cref="string"/> instance to check. </param>
    /// <param name="maxLength"> The maximal valid length for the input. </param>
    /// <param name="name">
    /// Name/expression of the value field, argument or property to check. Added as <see cref="Chk.Reason"/> on failure.
    /// </param>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> MaxLength(string? value, int maxLength,
        [CallerArgumentExpression("value")] string? name = null)
    {
        return Chk.If(value == null || value.Length <= maxLength).WithPld(CheckKind.Bool)
               || Fails($"{name} <= {maxLength}");
    }

    #endregion
    #region Conditional chaining
    
    /// <summary>
    /// Checks if <paramref name="value"/> is not empty and only then returns <paramref name="check"/>;
    /// returns a passed test otherwise.
    /// </summary>
    /// <param name="value"> The <see cref="ICanBeEmpty"/> instance to check. </param>
    /// <param name="check"> The check to return if <paramref name="value"/> is not empty. </param>
    /// <typeparam name="T"> The <see cref="ICanBeEmpty"/> type of instance to check. </typeparam>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> WhenNotEmpty<T>(T value, Chk<CheckKind> check)
        where T : ICanBeEmpty => value.IsEmpty() ? Check.None : check;

    /// <summary>
    /// Checks if <paramref name="value"/> is not <see langword="null"/> or empty and only then returns <paramref name="check"/>;
    /// returns a passed test otherwise.
    /// </summary>
    /// <param name="value"> The nullable <see cref="ICanBeEmpty"/> instance to check. </param>
    /// <param name="check"> The check to return if <paramref name="value"/> is not empty. </param>
    /// <typeparam name="T"> The <see cref="ICanBeEmpty"/> type of instance to check. </typeparam>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> WhenNotEmpty<T>(T? value, Chk<CheckKind> check)
        where T : struct, ICanBeEmpty => !value.HasValue || value.Value.IsEmpty() ? Check.None : check;
    
    /// <summary>
    /// Checks if <paramref name="value"/> is not <see langword="null"/> and only then returns <paramref name="check"/>;
    /// returns a passed test otherwise.
    /// </summary>
    /// <param name="value"> The <see cref="Nullable{T}"/> instance to check. </param>
    /// <param name="check"> The check to return if <paramref name="value"/> is not null. </param>
    /// <typeparam name="T"> The <see cref="Nullable{T}"/> type of instance to check. </typeparam>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> WhenNotNull<T>(T? value, Chk<CheckKind> check)
        where T : struct
    {
        return value.HasValue ? check : None;
    }

    /// <summary>
    /// Checks if <paramref name="value"/> is not <see langword="null"/> and only then returns <paramref name="check"/>;
    /// returns a passed test otherwise.
    /// </summary>
    /// <param name="value"> The instance to check. </param>
    /// <param name="check"> The check to return if <paramref name="value"/> is not null. </param>
    /// <typeparam name="T"> The reference type of instance to check. </typeparam>
    /// <returns>
    /// A new <see cref="Chk{T}"/> of <see cref="CheckKind"/> that is <see cref="Chk.Passed"/> when conditions are met.
    /// </returns>
    public static Chk<CheckKind> WhenNotNull<T>(T? value, Chk<CheckKind> check)
        where T : class
    {
        return value != null ? check : None;
    }  

    #endregion
}
