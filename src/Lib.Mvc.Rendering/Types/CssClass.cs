using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Semantica.Linq;
using Semantica.Patterns;

namespace Semantica.Mvc.Rendering.Types;

/// <summary>
///     represents a css class, or a set of css classes.
/// </summary>
public struct CssClass : ICanBeEmpty
{
    private readonly string[] _classes;
        
    public CssClass([HtmlElementAttributes("class")] params string[] classes)
    {
        _classes = classes.WhereNotNullOrEmpty().ToArray();
    }

    public int Length => _classes?.Length ?? 0;
    public IEnumerable<string> Classes => _classes ?? Enumerable.Empty<string>();
        
    public override string ToString()
    {
        return string.Join(" ", Classes.WhereNotNullOrEmpty());
    }

    public bool IsEmpty()
    {
        return Length == 0;
    }

    public static CssClass Empty => new CssClass();

    public static CssClass operator +(CssClass left, CssClass right)
    {
        if (right.IsEmpty())
        {
            return left;
        }
        if (left.IsEmpty())
        {
            return right;
        }

        var target = new string[left.Length + right.Length];
        left._classes.CopyTo(target, 0);
        right._classes.CopyTo(target, left.Length);
        return new CssClass(target);
    }

    public static CssClass operator +(CssClass left, CssClass? right)
    {
        if (!right.HasValue)
        {
            return left;
        }

        return left + right.Value;
    }

    public static CssClass operator +(CssClass left, string right)
    {
        return left.Add(right);
    }

    public CssClass Add(string addition)
    {
        if (string.IsNullOrEmpty(addition))
        {
            return this;
        }
        if (this.IsEmpty())
        {
            return new CssClass(addition);
        }

        var target = new string[Length + 1];
        _classes.CopyTo(target, 0);
        target[Length] = addition;
        return new CssClass(target);
    }
}
