using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Semantica.Checks.Exceptions;

namespace Semantica.Checks;

/// <summary>
/// Provides static functions for guarding of all three types <see cref="ContractException"/>, <see cref="GuardException"/> and
/// <see cref="StateException"/>.
/// </summary>
public static class Guard
{
    
    /// <summary>
    /// Throws if the argument check failed.
    /// </summary>
    /// <param name="check"> <see langword="bool"/> result of a check. </param>
    /// <param name="expression"> The expression to be added as description of failure. </param>
    /// <exception cref="ContractArgumentException"> Throws if <paramref name="check"/> is <see langword="false"/>. </exception>
    [Conditional("DEBUGGUARD")]
    [ContractAnnotation("check: false => halt")]
    [DebuggerHidden]
    public static void Contract(bool check, [CallerArgumentExpression("check")] string? expression = null)
    {
        if (! check) throw ContractException.Make(expression);
    }

    /// <summary>
    /// Throws if the argument check failed.
    /// </summary>
    /// <param name="check"> <see langword="bool"/> result of a check. </param>
    /// <param name="description"> Description added to the thrown exception. </param>
    /// <param name="argumentName"> Name of the argument that violates the code contract. </param>
    /// <exception cref="ContractArgumentException"> Throws if <paramref name="check"/> is <see langword="false"/>. </exception>
    [Conditional("DEBUGGUARD")]
    [ContractAnnotation("check: false => halt")]
    [DebuggerHidden]
    public static void Contract(bool check, string description, [InvokerParameterName] string argumentName)
    {
        if (! check) throw ContractException.Make(description, argumentName);
    }

    /// <summary>
    /// Throws if the argument check failed.
    /// </summary>
    /// <param name="check"> Check result, optionally containing the kind of check and/or description. </param>
    /// <exception cref="ArgumentException">
    /// Depending on the kind of check, throws one of the contract-subtypes when it's failed.
    /// </exception>
    [Conditional("DEBUGGUARD")]
    [ContractAnnotation("check: false => halt")]
    [DebuggerHidden]
    public static void Contract(Chk<CheckKind> check)
    {
        if (check.Failed) throw ContractException.MakeFor(check);
    }

    /// <summary>
    /// Throws if the argument check failed.
    /// </summary>
    /// <param name="check"> Check result, optionally containing the kind of check and/or description. </param>
    /// <param name="description"> Description added to the thrown exception. </param>
    /// <exception cref="ArgumentException">
    /// Depending on the kind of check, throws one of the contract-subtypes when it's failed.
    /// </exception>
    [Conditional("DEBUGGUARD")]
    [ContractAnnotation("check: false => halt")]
    [DebuggerHidden]
    public static void Contract(Chk<CheckKind> check, string description)
    {
        if (check.Failed) throw ContractException.MakeFor(check, description);
    }

    /// <summary>
    /// Throws if the argument check failed.
    /// </summary>
    /// <param name="check"> <see langword="bool"/> result of a check. </param>
    /// <param name="expression"> The expression to be added as description of failure. </param>
    /// <exception cref="GuardArgumentException"> Throws if <paramref name="check"/> is <see langword="false"/>. </exception>
    [ContractAnnotation("check: false => halt")]
    [DebuggerHidden]
    public static void For(bool check, [CallerArgumentExpression("check")] string? expression = null)
    {
        if (! check) throw GuardException.Make(expression);
    }

    /// <summary>
    /// Throws if the argument check failed.
    /// </summary>
    /// <param name="check"> <see langword="bool"/> result of a check. </param>
    /// <param name="description"> Description added to the thrown exception. </param>
    /// <param name="argumentName"> Name of the argument that violates the code contract. </param>
    /// <exception cref="GuardArgumentException"> Throws if <paramref name="check"/> is <see langword="false"/>. </exception>
    [ContractAnnotation("check: false => halt")]
    [DebuggerHidden]
    public static void For(bool check, string description, [InvokerParameterName] string argumentName)
    {
        if (! check) throw GuardException.Make(description, argumentName);
    }

    /// <summary>
    /// Throws if the argument check failed.
    /// </summary>
    /// <param name="check"> Check result, optionally containing the kind of check and/or description. </param>
    /// <exception cref="ArgumentException">
    /// Depending on the kind of check, throws one of the guard-subtypes when it's failed.
    /// </exception>
    [DebuggerHidden]
    [ContractAnnotation("check: false => halt")]
    public static void For(Chk<CheckKind> check)
    {
        if (check.Failed) throw GuardException.MakeFor(check);
    }

    /// <summary>
    /// Throws if the state check failed.
    /// </summary>
    /// <param name="check"> <see langword="bool"/> result of a check. </param>
    /// <typeparamref name="T"> Type of the exception to throw. No message can be thrown. </typeparamref>
    /// <exception cref="Exception"> Throws if <paramref name="check"/> is <see langword="false"/>. </exception>
    [ContractAnnotation("check: false => halt")]
    [DebuggerHidden]
    public static void For<T>(bool check)
        where T: Exception, new()
    {
        if (! check) throw new T();
    }

    /// <summary>
    /// Throws if the argument check failed.
    /// </summary>
    /// <param name="check"> Check result, optionally containing the kind of check and/or description. </param>
    /// <param name="description"> Description added to the thrown exception. </param>
    /// <exception cref="ArgumentException">
    /// Depending on the kind of check, throws one of the guard-subtypes when it's failed.
    /// </exception>
    [DebuggerHidden]
    [ContractAnnotation("check: false => halt")]
    public static void For(Chk<CheckKind> check, string description)
    {
        if (check.Failed) throw GuardException.MakeFor(check, description);
    }

    /// <summary>
    /// Throws if the index is not in range.
    /// </summary>
    /// <param name="index"> Value of the index to check. </param>
    /// <param name="end"> The exclusive end of the valid range. </param>
    /// <exception cref="System.IndexOutOfRangeException">
    /// Throws when index is less than <c>0</c>, or greater than or equal to <paramref name="end"/>.
    /// </exception>
    [DebuggerHidden]
    public static void Index(int index, int end)
    {
        if (index < 0 || index >= end) throw GuardException.MakeIndex(0, end);
    }

    /// <summary>
    /// Throws if the index is not in range.
    /// </summary>
    /// <param name="index"> Value of the index to check. </param>
    /// <param name="start"> The inclusive start of the valid range. </param>
    /// <param name="end"> The exclusive end of the valid range. </param>
    /// <exception cref="System.IndexOutOfRangeException">
    /// Throws when index is less than <paramref name="start"/>, or greater than or equal to
    /// <paramref name="end"/>.
    /// </exception>
    [DebuggerHidden]
    public static void Index(int index, int start, int end)
    {
        if (index < start || index >= end) throw GuardException.MakeIndex(start, end);
    }

    /// <summary>
    /// Throws if the state check failed.
    /// </summary>
    /// <param name="check"> <see langword="bool"/> result of a check. </param>
    /// <param name="expression"> The expression to be added as description of failure. </param>
    /// <exception cref="StateException"> Throws if <paramref name="check"/> is <see langword="false"/>. </exception>
    [ContractAnnotation("check: false => halt")]
    [DebuggerHidden]
    public static void State(bool check, [CallerArgumentExpression("check")] string? expression = null)
    {
        if (! check) throw StateException.Make(expression);
    }

    /// <summary>
    /// Throws if the state check failed.
    /// </summary>
    /// <param name="check"> <see langword="bool"/> result of a check. </param>
    /// <param name="description"> Description added to the thrown exception. </param>
    /// <param name="fieldName"> Name of the field that indicates the unexpected state. </param>
    /// <exception cref="StateException"> Throws if <paramref name="check"/> is <see langword="false"/>. </exception>
    [ContractAnnotation("check: false => halt")]
    [DebuggerHidden]
    public static void State(bool check, string description, string fieldName)
    {
        if (! check) throw StateException.Make(description, fieldName);
    }

    /// <summary>
    /// Throws if the state check failed.
    /// </summary>
    /// <param name="check"> Check result, optionally containing the kind of check and/or description. </param>
    /// <exception cref="StateException"> Throws if <paramref name="check"/> has failed. </exception>
    [DebuggerHidden]
    [ContractAnnotation("check: false => halt")]
    public static void State(Chk<CheckKind> check)
    {
        if (check.Failed) StateException.MakeFor(check);
    }

    /// <summary>
    /// Throws if the state check failed.
    /// </summary>
    /// <param name="check"> Check result, optionally containing the kind of check and/or description. </param>
    /// <param name="description"> Description added to the thrown exception. </param>
    /// <exception cref="StateException"> Throws if <paramref name="check"/> has failed. </exception>
    [DebuggerHidden]
    [ContractAnnotation("check: false => halt")]
    public static void State(Chk<CheckKind> check, string description)
    {
        if (check.Failed) StateException.MakeFor(check, description);
    }
}
