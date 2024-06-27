namespace Semantica.Checks;

/// <summary>
/// Represents the result of a (<see langword="bool"/>) check, with an optional <see cref="Reason"/> and <see cref="Payload"/>
/// of type <typeparamref name="T"/>.
/// </summary>
/// <remarks>
/// Instances of <see cref="Chk"/> can be used just as booleans. Short-circuiting is supported for operators <c>&amp;&amp;</c>
/// and <c>||</c>. The <see cref="Reason"/> and <see cref="Payload"/> are always associated with a certain outcome
/// (<see cref="Passed"/> or <see cref="Failed"/>). When two instances are combined with an operator, only the reasons that are
/// associated with the outcome will be present in the result. Multiple applicable reasons are concatenated.
/// <see cref="Chk{T}"/> is <see cref="Semantica.Patterns.IDeterminable"/>. An undetermined instance has the meaning of _only_
/// being a reason or payload associated to a specific outcome, and it's value will never influence a binary operator's outcome.
/// </remarks>
public readonly struct Chk<T> : IChk
{
    private readonly Chk _check;
        
    internal Chk(Chk chk, T? payload)
    {
        _check = chk;
        Payload = payload;
    }
    
    public bool Passed => _check.Passed;

    public bool Failed => _check.Failed;

    public string? Reason => _check.Reason;
    
    /// <summary>
    /// A payload of type <typeparamref name="T"/> associated with this check's <see cref="Passed"/> or <see cref="Failed"/>
    /// value.
    /// </summary>
    public T? Payload { get; }

    public bool HasFailed() => _check.HasFailed();

    public bool HasPassed() => _check.HasPassed();
    
    /// <summary>
    /// Makes an instance with a new value for <see cref="Reason"/>, but only if the check already <see cref="Failed"/>.
    /// </summary>
    /// <param name="failReason"> The new value of <see cref="Reason"/> if <see cref="Failed"/>. </param>
    /// <returns>
    /// A new instance of <see cref="Chk{T}"/> containing <paramref name="failReason"/> if <see cref="Failed"/>, otherwise
    /// <see cref="Reason"/> is retained.
    /// </returns>
    public Chk<T> Fails(string? failReason) => new Chk<T>(_check.Fails(failReason), Payload);

    /// <summary>
    /// Makes an instance with a new value for <see cref="Payload"/>, but only if the check already <see cref="Failed"/>.
    /// </summary>
    /// <param name="payload"> The value of <see cref="Payload"/> if <see cref="Failed"/>. </param>
    /// <returns>
    /// A new instance of <see cref="Chk{T}"/> containing <paramref name="payload"/> if <see cref="Failed"/>, otherwise the
    /// <see cref="Payload"/> is <see langword="default"/>.
    /// </returns>
    public Chk<T> Fails(T payload)
    {
        return Failed ? new Chk<T>(_check, payload) : this;
    }

    /// <summary>
    /// Makes an instance with new values for <see cref="Payload"/> and <see cref="Reason"/>, but only if the check already
    /// <see cref="Failed"/>.
    /// </summary>
    /// <param name="failReason"> The new value of <see cref="Reason"/> if <see cref="Failed"/>. </param>
    /// <param name="payload"> The value of <see cref="Payload"/> if <see cref="Failed"/>. </param>
    /// <returns>
    /// A new instance of <see cref="Chk{T}"/> containing <paramref name="failReason"/> and <paramref name="payload"/> if
    /// <see cref="Failed"/>, otherwise the <see cref="Payload"/> is <see langword="default"/>, and <see cref="Reason"/> is
    /// retained.
    /// </returns>
    public Chk<T> Fails(string? failReason, T payload)
    {
        return this.Fails(failReason).Fails(payload);
    }

    public override int GetHashCode() => HashCode.Combine(_check, Payload);

    /// <summary>
    /// Makes an instance with a new value for <see cref="Reason"/>, but only if the check already <see cref="Passed"/>.
    /// </summary>
    /// <param name="passReason"> The new value of <see cref="Reason"/> if <see cref="Passed"/>. </param>
    /// <returns>
    /// A new instance of <see cref="Chk{T}"/> containing <paramref name="passReason"/> if <see cref="Passed"/>, otherwise
    /// <see cref="Reason"/> is retained.
    /// </returns>
    public Chk<T> Passes(string? passReason) => new Chk<T>(_check.Passes(passReason), Payload);

    /// <summary>
    /// Makes an instance with a value for <see cref="Payload"/>, but only if the check already <see cref="Passed"/>.
    /// </summary>
    /// <param name="payload"> The value of <see cref="Payload"/> if <see cref="Passed"/>. </param>
    /// <returns>
    /// A new instance of <see cref="Chk{T}"/> containing <paramref name="payload"/> if <see cref="Passed"/>, otherwise the
    /// <see cref="Payload"/> is <see langword="default"/>.
    /// </returns>
    public Chk<T> Passes(T payload)
    {
        return Passed ? new Chk<T>(_check, payload) : this;
    }

    /// <summary>
    /// Makes an instance with new values for <see cref="Payload"/> and <see cref="Reason"/>, but only if the check already
    /// <see cref="Passed"/>.
    /// </summary>
    /// <param name="passReason"> The new value of <see cref="Reason"/> if <see cref="Passed"/>. </param>
    /// <param name="payload"> The value of <see cref="Payload"/> if <see cref="Passed"/>. </param>
    /// <returns>
    /// A new instance of <see cref="Chk{T}"/> containing <paramref name="passReason"/> and <paramref name="payload"/> if
    /// <see cref="Passed"/>, otherwise the <see cref="Payload"/> is <see langword="default"/>, and <see cref="Reason"/> is
    /// retained.
    /// </returns>
    public Chk<T> Passes(string? passReason, T payload) => this.Passes(passReason).Passes(payload);

    /// <summary>
    /// Drops the payload and returns the non-generic <see cref="Chk"/>.
    /// </summary>
    /// <returns><see cref="Chk"/> with only value and reason retained.</returns>
    public Chk Simplify() => _check;

    /// <summary>
    /// Drops the payload and returns the non-generic <see cref="Chk"/>, and <see cref="Payload"/> as out-parameter.
    /// </summary>
    /// <param name="payload"> Out-parameter contains the value of <see cref="Payload"/>. </param>
    /// <returns><see cref="Chk"/> with only value and reason retained.</returns>
    public Chk Simplify(out T? payload)
    {
        payload = Payload;
        return _check;
    }

    /// <summary>
    /// If multiple reasons were previously combined, this method can split up these reasons.
    /// </summary>
    /// <returns>A <see langword="string[]"/> containing all the reasons associated with the outcome.</returns>
    public string[] SplitReasons()
    {
        return _check.SplitReasons();
    }

    /// <inheritdoc cref="Chk.ToString"/>
    public override string ToString()
    {
        return $"{_check.ToString()} with payload of type {typeof(T).Name}";
    }
    
    public static implicit operator Chk<T>(Chk chk) => new Chk<T>(chk, default(T));

    public static implicit operator Chk(Chk<T> chk) => chk._check;
    
    /// <summary> And-operator for two <see cref="Chk{T}"/> instances. </summary>
    /// <remarks>
    /// If the outcome is <see cref="Failed"/>, only reasons or payloads of <see cref="Failed"/> inputs are retained in the
    /// output. If the outcome is <see cref="Passed"/>, only reasons or payloads of <see cref="Passed"/> inputs are retained in
    /// the output.
    /// </remarks>
    /// <param name="left"> The left operand. </param>
    /// <param name="right"> The right operand. </param>
    /// <exception cref="System.InvalidOperationException">
    /// When a fail reason or payloads <see cref="Chk{T}.Rsn.Fail"/> is used as right operand (<see cref="Chk.IsDetermined"/>
    /// is <see langword="false"/>).
    /// </exception>    
    /// <returns>
    /// <see cref="Passed"/> if <paramref name="left"/> *and* <paramref name="right"/> both <see cref="Passed"/>, otherwise
    /// <see cref="Failed"/>.
    /// </returns>
    public static Chk<T> operator &(Chk<T> left, Chk<T> right)
    {
        var check = left._check & right._check;
        var payload = left.Passed == right.Passed
            ? (EqualityComparer<T>.Default.Equals(default(T), left.Payload) ? right.Payload : left.Payload)
            : (left.Failed ? left.Payload : right.Payload);
        return new Chk<T>(check, payload);
    }

    /// <summary> And-operator for two <see cref="Chk{T}"/> instances. </summary>
    /// <remarks>
    /// If the outcome is <see cref="Failed"/>, only reasons or payloads of <see cref="Failed"/> inputs are retained in the
    /// output. If the outcome is <see cref="Passed"/>, only reasons or payloads of <see cref="Passed"/> inputs are retained in
    /// the output. Cannot be used as short-circuiting operator (<c>&amp;&amp;</c>).
    /// </remarks>
    /// <param name="left"> The left operand. </param>
    /// <param name="right"> The right operand. </param>
    /// <exception cref="System.InvalidOperationException">
    /// When a fail reason or payloads <see cref="Chk.Rsn.Fail"/> is used as right operand (<see cref="Chk.IsDetermined"/> is
    /// <see langword="false"/>).
    /// </exception>    
    /// <returns>
    /// <see cref="Passed"/> if <paramref name="left"/> *and* <paramref name="right"/> both <see cref="Passed"/>, otherwise
    /// <see cref="Failed"/>.
    /// </returns>
    public static Chk<T> operator &(Chk<T> left, Chk right)
    {
        var check = left._check & right;
        return new Chk<T>(check, check.Passed == left.Passed ? left.Payload : default );
    }

    /// <summary> Or-operator for two <see cref="Chk{T}"/> instances. </summary>
    /// <remarks>
    /// If the outcome is <see cref="Failed"/>, only reasons or payloads of <see cref="Failed"/> inputs are retained in the
    /// output. If the outcome is <see cref="Passed"/>, only reasons or payloads of <see cref="Passed"/> inputs are retained in
    /// the output.
    /// </remarks>
    /// <param name="left"> The left operand. </param>
    /// <param name="right"> The right operand. </param>
    /// <exception cref="System.InvalidOperationException">
    /// When a pass reason or payloads <see cref="Chk{T}.Rsn.Pass"/> is used as right operand (<see cref="Chk.IsDetermined"/>
    /// is <see langword="false"/>)
    /// </exception>    
    /// <returns>
    /// <see cref="Passed"/> if <paramref name="left"/> *or* <paramref name="right"/> have <see cref="Passed"/>, otherwise
    /// <see cref="Failed"/>
    /// </returns>
    public static Chk<T> operator |(Chk<T> left, Chk<T> right)
    {
        var check = left._check | right._check;
        var payload = left.Passed == right.Passed
            ? (EqualityComparer<T>.Default.Equals(default(T), left.Payload) ? right.Payload : left.Payload)
            : (left.Passed ? left.Payload : right.Payload);
        return new Chk<T>(check, payload);
    }

    /// <summary> Or-operator for two <see cref="Chk{T}"/> instances. </summary>
    /// <remarks>
    /// If the outcome is <see cref="Failed"/>, only reasons or payloads of <see cref="Failed"/> inputs are retained in the
    /// output. If the outcome is <see cref="Passed"/>, only reasons or payloads of <see cref="Passed"/> inputs are retained in
    /// the output. Cannot be used as short-circuiing operator (<c>||</c>).
    /// </remarks>
    /// <param name="left"> The left operand. </param>
    /// <param name="right"> The right operand. </param>
    /// <exception cref="System.InvalidOperationException">
    /// When a pass reason or payloads <see cref="Chk{T}.Rsn.Pass"/> is used as right operand (<see cref="Chk.IsDetermined"/>
    /// is <see langword="false"/>)
    /// </exception>    
    /// <returns>
    /// <see cref="Passed"/> if <paramref name="left"/> *or* <paramref name="right"/> have <see cref="Passed"/>, otherwise
    /// <see cref="Failed"/>
    /// </returns>
    public static Chk<T> operator |(Chk<T> left, Chk right)
    {
        var check = left._check | right;
        return new Chk<T>(check, check.Passed == left.Passed ? left.Payload : default);
    }

    /// <inheritdoc cref="Chk.operator!"/>
    public static bool operator !(Chk<T> chk) => ! chk._check.Passed;
    /// <inheritdoc cref="Chk.operator true"/>
    public static bool operator true(Chk<T> chk) => chk._check.Passed;
    /// <inheritdoc cref="Chk.operator false"/>
    public static bool operator false(Chk<T> chk) => ! chk._check.Passed;
    
    /// <summary>
    /// A <see cref="Failed"/> instance.
    /// </summary>
    public static Chk<T> Fail = new Chk<T>(Chk.Fail, default); 

    /// <summary>
    /// A <see cref="Passed"/> instance.
    /// </summary>
    public static Chk<T> Pass = new Chk<T>(Chk.Pass, default);

    /// <inheritdoc cref="Chk.Rsn"/>
    public static class Rsn
    {
        // ReSharper disable MemberHidesStaticFromOuterClass
        /// <summary>
        /// An undetermined <see cref="Failed"/> instance.
        /// </summary>
        public static Chk<T> Fail => new Chk<T>(Chk.Rsn.Fail, default);

        /// <summary>
        /// An undetermined <see cref="Passed"/> instance.
        /// </summary>
        public static Chk<T> Pass => new Chk<T>(Chk.Rsn.Pass, default);
        // ReSharper restore MemberHidesStaticFromOuterClass
    }
}
