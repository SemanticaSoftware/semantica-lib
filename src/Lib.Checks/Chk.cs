using Semantica.Patterns;

namespace Semantica.Checks;

/// <summary>
/// Represents the result of a (<see langword="bool"/>) check, with an optional <see cref="Reason"/>.
/// </summary>
/// <remarks>
/// Instances of <see cref="Chk"/> can be used just as booleans. Short-circuiting is supported for operators <c>&amp;&amp;</c>
/// and <c>||</c>. The <see cref="Reason"/> is always associated with a certain outcome (<see cref="Passed"/> or
/// <see cref="Failed"/>). When two instances are combined with an operator, only the reasons that are associated with the
/// outcome will be present in the result. Multiple applicable reasons are concatenated. <see cref="Chk"/> is
/// <see cref="IDeterminable"/>. An undetermined instance has the meaning of _only_ being a reason associated to a specific
/// outcome, and it's value will never influence a binary operator's outcome.
/// </remarks>
public readonly struct Chk : IChk, IDeterminable
{
    private Chk(bool passed, string? reason, bool isDetermined = true)
    {
        Passed = passed;
        Reason = reason;
        IsDetermined = isDetermined;
    }

    public bool Passed { get; }

    public bool Failed => ! Passed;
        
    /// <summary>
    /// <see langword="true"/> for an actual check outcome. <see langword="false"/> if the instance is only a reason associated
    /// to a specific outcome. The value will never influence a binary operator's outcome.
    /// </summary>
    public bool IsDetermined { get; }
        
    public string? Reason { get; }

    public bool HasFailed() => ! HasPassed();

    public bool HasPassed() => IsDetermined && Passed;

    /// <summary>
    /// Makes an instance with a new value for <see cref="Reason"/>, but only if the check already <see cref="Failed"/>.
    /// </summary>
    /// <param name="failReason"> The new value of <see cref="Reason"/> if <see cref="Failed"/> </param>
    /// <returns>
    /// A new instance of <see cref="Chk"/> containing <paramref name="failReason"/> if <see cref="Failed"/>, otherwise
    /// <see cref="Reason"/> is retained.
    /// </returns>
    public Chk Fails(string? failReason)
    {
        return Failed ? new Chk(false, failReason) : this;
    }
    
    /// <summary>
    /// Makes an instance with a new value for <see cref="Chk{TPayload}.Payload"/>, but only if the check already
    /// <see cref="Failed"/>.
    /// </summary>
    /// <param name="payload"> The value of <see cref="Chk{TPayload}.Payload"/> if <see cref="Failed"/>. </param>
    /// <typeparam name="TPayload"> The type of the payload. </typeparam>
    /// <returns>
    /// A new instance of <see cref="Chk{T}"/> containing <paramref name="payload"/> if <see cref="Failed"/>, otherwise the
    /// <see cref="Chk{TPayload}.Payload"/> is <see langword="default"/>.
    /// </returns>
    public Chk<TPayload> Fails<TPayload>(TPayload payload)
    {
        return new Chk<TPayload>(this, this.Failed ? payload : default);
    }

    /// <summary>
    /// Makes an instance with new values for <see cref="Chk{TPayload}.Payload"/> and <see cref="Reason"/>, but only if the
    /// check already <see cref="Failed"/>.
    /// </summary>
    /// <param name="failReason"> The new value of <see cref="Reason"/> if <see cref="Failed"/>. </param>
    /// <param name="payload"> The value of <see cref="Chk{TPayload}.Payload"/> if <see cref="Failed"/>. </param>
    /// <typeparam name="TPayload"> The type of the payload. </typeparam>
    /// <returns>
    /// A new instance of <see cref="Chk{T}"/> containing <paramref name="failReason"/> and <paramref name="payload"/> if
    /// <see cref="Failed"/>, otherwise the <see cref="Chk{TPayload}.Payload"/> is <see langword="default"/>, and
    /// <see cref="Reason"/> is retained.
    /// </returns>
    public Chk<TPayload> Fails<TPayload>(string? failReason, TPayload payload) => this.Fails(failReason).Fails(payload);
    
    public override int GetHashCode() => HashCode.Combine(Passed, IsDetermined, Reason);

    /// <summary>
    /// Makes an instance with a new value for <see cref="Reason"/>, but only if the check already <see cref="Passed"/>.
    /// </summary>
    /// <param name="passReason"> The new value of <see cref="Reason"/> if <see cref="Passed"/>. </param>
    /// <returns>
    /// A new instance of <see cref="Chk{T}"/> containing <paramref name="passReason"/> if <see cref="Passed"/>, otherwise
    /// <see cref="Reason"/> is retained.
    /// </returns>
    public Chk Passes(string? passReason)
    {
        return Passed ? new Chk(true, passReason) : this;
    }

    /// <summary>
    /// Makes an instance with a value for <see cref="Chk{TPayload}.Payload"/>, but only if the check already
    /// <see cref="Passed"/>.
    /// </summary>
    /// <param name="payload"> The value of <see cref="Chk{TPayload}.Payload"/> if <see cref="Passed"/>. </param>
    /// <typeparam name="TPayload"> The type of the payload. </typeparam>
    /// <returns>
    /// A new instance of <see cref="Chk{T}"/> containing <paramref name="payload"/> if <see cref="Passed"/>, otherwise the
    /// <see cref="Chk{TPayload}.Payload"/> is <see langword="default"/>.
    /// </returns>
    public Chk<TPayload> Passes<TPayload>(TPayload payload)
    {
        return new Chk<TPayload>(this, this.Passed ? payload : default);
    }

    /// <summary>
    /// Makes an instance with new values for <see cref="Chk{TPayload}.Payload"/> and <see cref="Reason"/>, but only if the
    /// check already <see cref="Passed"/>.
    /// </summary>
    /// <param name="passReason"> The new value of <see cref="Reason"/> if <see cref="Passed"/>. </param>
    /// <param name="payload"> The value of <see cref="Chk{TPayload}.Payload"/> if <see cref="Passed"/>. </param>
    /// <typeparam name="TPayload"> The type of the payload. </typeparam>
    /// <returns>
    /// A new instance of <see cref="Chk{T}"/> containing <paramref name="passReason"/> and <paramref name="payload"/> if
    /// <see cref="Passed"/>, otherwise the <see cref="Chk{TPayload}.Payload"/> is <see langword="default"/>, and
    /// <see cref="Reason"/> is retained.
    /// </returns>
    public Chk<TPayload> Passes<TPayload>(string? passReason, TPayload payload) => this.Passes(passReason).Passes(payload);

    /// <summary>
    /// If multiple reasons were previously combined, this method can split up these reasons.
    /// </summary>
    /// <returns> A <see langword="string[]"/> containing all the reasons associated with the outcome.</returns>
    public string[] SplitReasons()
    {
        return Rsn.Split(Reason) ?? Array.Empty<string>();
    }

    /// <summary>
    /// Returns a descriptive version of the value of the instance.
    /// </summary>
    public override string ToString()
    {
        return IsDetermined 
            ? $"{(Passed ? nameof(Passed) : nameof(Failed))} {nameof(Chk)}{(Reason == null ? String.Empty : $": {Reason}")}"
            : $"Undetermined {nameof(Chk)} {(Reason == null ? String.Empty : $" with {nameof(Reason)} to {(Passed ? nameof(Pass) : nameof(Fail))}: {Reason}")}";
    }

    /// <summary>
    /// Makes an instance with new values for <see cref="Chk{TPayload}.Payload"/>, regardless if the check <see cref="Failed"/>
    /// or <see cref="Passed"/>.
    /// </summary>
    /// <param name="payload"> The value of <see cref="Chk{TPayload}.Payload"/>. </param>
    /// <typeparam name="TPayload"> The type of the payload.</typeparam>
    /// <returns> A new instance of <see cref="Chk{T}"/> containing <paramref name="payload"/>. </returns>
    public Chk<TPayload> WithPld<TPayload>(TPayload payload)
    {
        return new Chk<TPayload>(this, payload);
    }

    /// <summary>
    /// Makes an instance with a new value for <see cref="Reason"/>, regardless if the check <see cref="Failed"/> or
    /// <see cref="Passed"/>.
    /// </summary>
    /// <param name="reason"> The new value of <see cref="Reason"/>. </param>
    /// <returns> A new instance of <see cref="Chk"/> containing <paramref name="reason"/>. </returns>
    public Chk WithRsn(string? reason)
    {
        return new Chk(this.Passed, reason);
    }

    [Obsolete("use " + nameof(Fails) + "<TPayload>(payload)")]
    public Chk<TPayload> WithFailPld<TPayload>(TPayload payload) => new Chk<TPayload>(this, this.Failed ? payload : default);
    
    [Obsolete("use " + nameof(Passes) + "<TPayload>(payload)")]
    public Chk<TPayload> WithPassPld<TPayload>(TPayload payload) => new Chk<TPayload>(this, this.Passed ? payload : default);

    /// <summary> And-operator for two <see cref="Chk"/> instances. </summary>
    /// <remarks>
    /// If the outcome is <see cref="Failed"/>, only reasons of <see cref="Failed"/> inputs are retained in the output.
    /// If the outcome is <see cref="Passed"/>, only reasons of <see cref="Passed"/> inputs are retained in the output.
    /// </remarks>
    /// <param name="left"> The left operand. </param>
    /// <param name="right"> The right operand. </param>
    /// <exception cref="InvalidOperationException">
    /// When a fail reason <see cref="Chk.Rsn.Fail"/> is used as right operand (<see cref="IsDetermined"/> is
    /// <see langword="false"/>)
    /// </exception>    
    /// <returns>
    /// <see cref="Passed"/> if <paramref name="left"/> *and* <paramref name="right"/> both <see cref="Passed"/>, otherwise
    /// <see cref="Failed"/>.
    /// </returns>
    public static Chk operator &(Chk left, Chk right)
    {
        if (right.Failed && ! right.IsDetermined)
        {
            throw new InvalidOperationException("usage of & with undetermined Failed as right operand is not allowed. Use | instead.");
        }
        var reason =
            left.Passed != right.Passed
                ? left.Failed
                    ? left.Reason
                    : right.Reason
                : Rsn.Combine(left, right);
        return new Chk(left.Passed && right.Passed, reason);
    }
        
    /// <summary> Or-operator for two <see cref="Chk"/> instances. </summary>
    /// <remarks>
    /// If the outcome is <see cref="Failed"/>, only reasons of <see cref="Failed"/> inputs are retained in the output.
    /// If the outcome is <see cref="Passed"/>, only reasons of <see cref="Passed"/> inputs are retained in the output.
    /// </remarks>
    /// <param name="left"> The left operand. </param>
    /// <param name="right"> The right operand. </param>
    /// <exception cref="InvalidOperationException">
    /// When a pass reason <see cref="Chk.Rsn.Pass"/> is used as right operand (<see cref="IsDetermined"/> is
    /// <see langword="false"/>).
    /// </exception>    
    /// <returns>
    /// <see cref="Passed"/> if <paramref name="left"/> *or* <paramref name="right"/> have <see cref="Passed"/>, otherwise
    /// <see cref="Failed"/>.
    /// </returns>
    public static Chk operator |(Chk left, Chk right)
    {
        if (right.Passed && ! right.IsDetermined)
        {
            throw new InvalidOperationException("usage of | with undetermined Passed right operand is not allowed. Use & instead.");
        }
        var reason =
            left.Passed != right.Passed
                ? left.Passed
                    ? left.Reason
                    : right.Reason
                : Rsn.Combine(left, right);            
        return new Chk(left.Passed || right.Passed, reason);
    }

    /// <summary>
    /// Not-operator. 
    /// </summary>
    /// <remarks> Required for short-circuiting. </remarks>
    public static bool operator !(Chk chk) => ! chk.Passed;
    /// <summary>
    /// Determines true-value of <see cref="Chk"/> instance. 
    /// </summary>
    /// <remarks> Required for short-circuiting. </remarks>
    public static bool operator true(Chk chk) => chk.Passed;
    /// <summary>
    /// Determines false-value of <see cref="Chk"/> instance. 
    /// </summary>
    /// <remarks> Required for short-circuiting. </remarks>
    public static bool operator false(Chk chk) => ! chk.Passed;
    
    /// <summary>
    /// A <see cref="Failed"/> instance.
    /// </summary>
    public static Chk Fail => new Chk(false, null);
    
    /// <summary>
    /// A <see cref="Passed"/> instance.
    /// </summary>
    public static Chk Pass => new Chk(true, null);
    
    /// <summary>
    /// A new instance of <see cref="Chk"/> that <see cref="Passed"/> if <paramref name="result"/> is <see langword="true"/>.
    /// </summary>
    /// <param name="result"> <see langword="bool"/> result of some check. </param>
    /// <returns> A new instance of <see cref="Chk"/> with no specified reason. </returns>
    public static Chk If(bool result) => new Chk(result, null);
    
    /// <summary>
    /// A new instance of <see cref="Chk{TPayload}"/> that <see cref="Passed"/> if <paramref name="result"/> is
    /// <see langword="true"/>.
    /// </summary>
    /// <param name="result"> <see langword="bool"/> result of some check. </param>
    /// <returns> A new instance of <see cref="Chk{TPayload}"/> with no specified reason or payload. </returns>
    public static Chk<TPayload> If<TPayload>(bool result) => new Chk<TPayload>(new Chk(result, null), default(TPayload));
    
    /// <summary>
    /// Provides static functionality to create <see cref="Chk"/> instances with undetermined outcome.
    /// These instances are only a <see cref="Reason"/> associated with a specific eventual outcome.
    /// </summary>
    public static class Rsn
    {
        private const string c_separator = " -|- ";

        // ReSharper disable MemberHidesStaticFromOuterClass
        /// <summary>
        /// An undetermined <see cref="Failed"/> instance.
        /// </summary>
        public static Chk Fail => new Chk(false, null, isDetermined: false);
        
        /// <summary>
        /// An undetermined <see cref="Passed"/> instance.
        /// </summary>
        public static Chk Pass => new Chk(true, null, isDetermined: false);
        // ReSharper restore MemberHidesStaticFromOuterClass

        internal static string? Combine(Chk left, Chk right)
        {
            return left.Reason == null 
                ? right.Reason 
                : right.Reason == null 
                    ? left.Reason 
                    : $"{left.Reason}{c_separator}{right.Reason}";
        }
            
        /// <summary>
        /// An undetermined value with a failure reason that can be <c>||</c>-attached to a determined check, so this
        /// expression will only be evaluated if needed, and short-circuited if not. 
        /// </summary>
        /// <param name="reason"> The <see cref="Reason"/> for failure. </param>
        /// <returns> Undetermined <see cref="Failed"/> instance. </returns>
        public static Chk ForFail(string? reason) => new Chk(false, reason, isDetermined: false);
            
        
        // ReSharper restore MemberHidesStaticFromOuterClass

        /// <summary>
        /// An undetermined value with a failure reason that can be <c>||</c>-attached to a determined check, so this
        /// expression will only be evaluated if needed, and short-circuited if not.
        /// </summary>
        /// <param name="reason"> The <see cref="Reason"/> for failure </param>
        /// <returns> Undetermined <see cref="Failed"/> instance. </returns>
        public static Chk<TPayload> ForFail<TPayload>(string? reason) => new Chk<TPayload>(Rsn.ForFail(reason), default);
        
        /// <summary>
        /// An undetermined value with a pass reason that can be <c>&amp;&amp;</c>-attached to a determined check, so this
        /// expression will only be evaluated if needed, and short-circuited if not. 
        /// </summary>
        /// <param name="reason"> The <see cref="Reason"/> for passing. </param>
        /// <returns> Undetermined <see cref="Passed"/> instance. </returns>
        public static Chk ForPass(string? reason) => new Chk(true, reason, isDetermined: false);
                        
        /// <summary>
        /// An undetermined value with a pass reason that can be <c>&amp;&amp;</c>-attached to a determined check, so this
        /// expression will only be evaluated if needed, and short-circuited if not.
        /// </summary>
        /// <param name="reason"> The <see cref="Reason"/> for passing. </param>
        /// <returns> Undetermined <see cref="Passed"/> instance. </returns>
        public static Chk<TPayload> ForPass<TPayload>(string? reason) => new Chk<TPayload>(Rsn.ForPass(reason), default);

        internal static string[]? Split(string? reason)
        {
            return reason?.Split(c_separator);
        }
    }

    /// <summary>
    /// Provides static functionality to create <see cref="Chk"/> instances with undetermined outcome. These instances are only
    /// a <see cref="Chk{T}.Payload"/> and possibly a <see cref="Reason"/> associated with a specific eventual outcome.
    /// </summary>
    public static class Pld
    {
        /// <summary>
        /// An undetermined value with a fail reason that can be <c>||</c>-attached to a determined check, so this expression
        /// will only be evaluated if needed.
        /// </summary>
        /// <param name="payload"> The payload for failing. </param>
        /// <returns> Undetermined Failed Chk Payload. </returns>
        public static Chk<TPayload> ForFail<TPayload>(TPayload payload) => new Chk<TPayload>(Rsn.Fail, payload);

        /// <summary>
        /// An undetermined value with a payload and a fail reason that can be <c>||</c>-attached to a determined check, so
        /// this expression will only be evaluated if needed.
        /// </summary>
        /// <param name="payload"> The payload for failing. </param>
        /// <param name="reason"> The reason for failing. </param>
        /// <returns> Undetermined Failed Chk Payload. </returns>
        public static Chk<TPayload> ForFail<TPayload>(TPayload payload, string? reason) 
            => new Chk<TPayload>(Rsn.ForFail(reason), payload);
        
        /// <summary>
        /// An undetermined value with a pass reason that can be <c>&amp;&amp;</c>-attached to a determined check, so this
        /// expression will only be evaluated if needed. 
        /// </summary>
        /// <param name="payload"> The payload for passing. </param>
        /// <returns> Undetermined Passed Chk Payload. </returns>
        public static Chk<TPayload> ForPass<TPayload>(TPayload payload) => new Chk<TPayload>(Rsn.Pass, payload);

        /// <summary>
        /// An undetermined value with a payload and a pass reason that can be <c>&amp;&amp;</c>-attached to a determined check,
        /// so this expression will only be evaluated if needed 
        /// </summary>
        /// <param name="payload"> The payload for passing. </param>
        /// <param name="reason"> The reason for passing. </param>
        /// <returns> Undetermined Passed Chk Payload. </returns>
        public static Chk<TPayload> ForPass<TPayload>(TPayload payload, string? reason) 
            => new Chk<TPayload>(Rsn.ForPass(reason), payload);
    }

}
