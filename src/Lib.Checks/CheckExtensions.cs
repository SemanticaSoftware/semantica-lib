using System.Diagnostics;
using JetBrains.Annotations;
using Semantica.Checks.Exceptions;

namespace Semantica.Checks;

/// <summary>
/// Provides extension methods on <see cref="Chk"/> of <see cref="CheckKind"/> that can be used for guarding of all three types
/// <see cref="ContractException"/>, <see cref="GuardException"/> and <see cref="StateException"/>.
/// </summary>
public static class CheckExtensions
{
    /// <summary>
    /// Throws if the check failed.
    /// </summary>
    /// <param name="check"> Check result, optionally containing the kind of check and/or description. </param>
    /// <exception cref="ArgumentException">
    /// Depending on the kind of check, throws one of the contract-subtypes when it's failed.
    /// </exception>
    [Conditional("DEBUGGUARD")]
    [DebuggerHidden]
    [ContractAnnotation("check: false => halt")]
    public static void Contract(this Chk<CheckKind> check)
    {
        if (check.Failed) throw ContractException.MakeFor(check);
    }

    /// <summary>
    /// Throws if the check failed.
    /// </summary>
    /// <param name="check"> Check result, optionally containing the kind of check. </param>
    /// <param name="description"> Description added to the thrown exception. </param>
    /// <exception cref="ArgumentException">
    /// Depending on the kind of check, throws one of the contract-subtypes when it's failed.
    /// </exception>
    [Conditional("DEBUGGUARD")]
    [DebuggerHidden]
    [ContractAnnotation("check: false => halt")]
    public static void Contract(this Chk<CheckKind> check, string description)
    {
        if (check.Failed) throw ContractException.MakeFor(check, description);

    }

    /// <summary>
    /// Throws if the check failed.
    /// </summary>
    /// <param name="check"> Check result, optionally containing the kind of check and/or description. </param>
    /// <exception cref="ArgumentException">
    /// Depending on the kind of check, throws one of the guard-subtypes when it's failed.
    /// </exception>
    [DebuggerHidden]
    [ContractAnnotation("check: false => halt")]
    public static void Guard(this Chk<CheckKind> check)
    {
        if (check.Failed) throw GuardException.MakeFor(check);
    }

    /// <summary>
    /// Throws if the check failed.
    /// </summary>
    /// <param name="check"> Check result, optionally containing the kind of check. </param>
    /// <param name="description"> Description added to the thrown exception. </param>
    /// <exception cref="ArgumentException">
    /// Depending on the kind of check, throws one of the guard-subtypes when it's failed.
    /// </exception>
    [DebuggerHidden]
    [ContractAnnotation("check: false => halt")]
    public static void Guard(this Chk<CheckKind> check, string description)
    {
        if (check.Failed) throw GuardException.MakeFor(check, description);
    }
    
    /// <summary>
    /// Throws if the check failed.
    /// </summary>
    /// <param name="check"> Check result, optionally containing the kind of check and/or description. </param>
    /// <exception cref="StateException"> Throws when <paramref name="check"/> failed. </exception>
    [DebuggerHidden]
    [ContractAnnotation("check: false => halt")]
    public static void State(this Chk<CheckKind> check)
    {
        if (check.Failed) throw StateException.MakeFor(check);
    }

    /// <summary>
    /// Throws if the check failed.
    /// </summary>
    /// <param name="check"> Check result, optionally containing the kind of check. </param>
    /// <param name="description"> Description added to the thrown exception. </param>
    /// <exception cref="StateException"> Throws when <paramref name="check"/> failed. </exception>
    [DebuggerHidden]
    [ContractAnnotation("check: false => halt")]
    public static void State(this Chk<CheckKind> check, string description)
    {
        if (check.Failed) throw StateException.MakeFor(check, description);
    }

    /// <summary>
    /// Assigns the input <paramref name="check"/> to the out parameter <paramref name="chk"/>, and also returns it.
    /// </summary>
    /// <remarks>
    /// This method can be used to assign the result of a check to a variable an in-line, making it more compact to use it in
    /// an if and it's then-statement. 
    /// </remarks>
    /// <param name="check"> Input <see cref="Chk{T}"/> of <see cref="CheckKind"/>. </param>
    /// <param name="chk"> Out parameter that will contain a copy of <paramref name="check"/>. </param>
    /// <returns> The input. </returns>
    public static Chk<CheckKind> Out(this Chk<CheckKind> check, out Chk<CheckKind> chk)
    {
        chk = check;
        return check;
    }
}
