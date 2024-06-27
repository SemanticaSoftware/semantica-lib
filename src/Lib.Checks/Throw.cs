using System.Diagnostics;
using JetBrains.Annotations;
using Semantica.Checks.Exceptions;

namespace Semantica.Checks;

/// <summary>
/// Static helper methods that always throw an exception
/// </summary>
public static class Throw
{
    
    /// <param name="expression"> Expression that violated the code contract. </param>
    /// <exception cref="ContractArgumentException"> Throws always. </exception>
    [Conditional("DEBUGGUARD")]
    [DebuggerHidden]
    [ContractAnnotation("=> halt")]
    public static void Contract(string expression)
    {
        throw ContractException.Make(expression);
    }
    
    /// <param name="description"> Description added to the thrown exception. </param>
    /// <param name="argumentName"> Name of the argument that violates the code contract. </param>
    /// <exception cref="ContractArgumentException"> Throws always. </exception>
    [Conditional("DEBUGGUARD")]
    [DebuggerHidden]
    [ContractAnnotation("=> halt")]
    public static void Contract(string description, [InvokerParameterName] string argumentName)
    {
        throw ContractException.Make(description, argumentName);
    }

    /// <param name="check"> Check result, optionally containing the kind of check and/or description. </param>
    /// <exception cref="ArgumentException"> Depending on the kind of check, throws one of the contract-subtypes. </exception>
    [Conditional("DEBUGGUARD")]
    [DebuggerHidden]
    [ContractAnnotation("=> halt")]
    public static void ContractFor(Chk<CheckKind> check)
    {
        throw ContractException.MakeFor(check);
    }

    /// <param name="description"> Description added to the thrown exception. </param>
    /// <param name="check"> Check result, optionally containing the kind of check. </param>
    /// <exception cref="ArgumentException"> Depending on the kind of check, throws one of the contract-subtypes. </exception>
    [Conditional("DEBUGGUARD")]
    [DebuggerHidden]
    [ContractAnnotation("=> halt")]
    public static void ContractFor(Chk<CheckKind> check, string description)
    {
        throw ContractException.MakeFor(check, description);
    }

    /// <param name="expression"> Expression that violated the code contract. </param>
    /// <exception cref="GuardArgumentException"> Throws always. </exception>
    [DebuggerHidden]
    [ContractAnnotation("=> halt")]
    public static void Guard(string expression)
    {
        throw GuardException.Make(expression);
    }

    /// <param name="description"> Description added to the thrown exception. </param>
    /// <param name="argumentName"> Name of the argument that violates the code contract. </param>
    /// <exception cref="GuardArgumentException"> Throws always. </exception>
    [DebuggerHidden]
    [ContractAnnotation("=> halt")]
    public static void Guard(string description, [InvokerParameterName] string argumentName)
    {
        throw GuardException.Make(description, argumentName);
    }

    /// <param name="check"> Check result, optionally containing the kind of check and/or description. </param>
    /// <exception cref="ArgumentException"> Depending on the kind of check, throws one of the guard-subtypes. </exception>
    [DebuggerHidden]
    [ContractAnnotation("=> halt")]
    public static void GuardFor(Chk<CheckKind> check)
    {
        throw GuardException.MakeFor(check);
    }

    /// <param name="description"> Description added to the thrown exception. </param>
    /// <param name="check"> Check result, optionally containing the kind of check. </param>
    /// <exception cref="ArgumentException"> Depending on the kind of check, throws one of the guard-subtypes. </exception>
    [DebuggerHidden]
    [ContractAnnotation("=> halt")]
    public static void GuardFor(Chk<CheckKind> check, string description)
    {
        throw GuardException.MakeFor(check, description);
    }

    /// <param name="expression"> Expression that failed the state guard. </param>
    /// <exception cref="StateException"> Throws always. </exception>
    [DebuggerHidden]
    [ContractAnnotation("=> halt")]
    public static void State(string expression)
    {
        throw StateException.Make(expression);
    }

    /// <param name="description"> Description added to the thrown exception. </param>
    /// <param name="fieldName"> Name of the field that indicates the unexpected state. </param>
    /// <exception cref="StateException"> Throws always. </exception>
    [DebuggerHidden]
    [ContractAnnotation("=> halt")]
    public static void State(string description, string fieldName)
    {
        throw StateException.Make(description, fieldName);
    }

    /// <param name="check"> Check result, optionally containing the kind of check and/or description. </param>
    /// <param name="fieldName"> Name of the field that indicates the unexpected state. </param>
    /// <exception cref="StateException"> Throws always. </exception>
    [DebuggerHidden]
    [ContractAnnotation("=> halt")]
    public static void StateFor(Chk<CheckKind> check, string fieldName)
    {
        throw StateException.MakeFor(check, fieldName);
    }
}