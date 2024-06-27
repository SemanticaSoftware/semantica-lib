using System.Diagnostics;

namespace Semantica.Types;

[DebuggerDisplay("Link: {Value}")]
public readonly record struct Link(string Value)
{
    public override string ToString() => Value;

    public static implicit operator string(Link link) => link.Value;

    public static implicit operator Link(string value) => new Link(value);


    public static implicit operator Uri(Link link) => new Uri(link.Value);

    public static implicit operator Link(Uri uri) => new Link(uri.AbsoluteUri);
}    
