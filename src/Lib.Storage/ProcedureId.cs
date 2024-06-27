using Semantica.Checks;
using Semantica.Patterns;

namespace Semantica.Storage;

public readonly record struct ProcedureId : ICanBeEmpty
{
    public ProcedureId(string name, string schema = "dbo")
    {
        Guard.For(Check.NotEmpty(name));
        Guard.For(Check.NotEmpty(schema));
        Name = name;
        Schema = schema;
    }

    public string Name { get; }

    public string Schema { get; }

    public bool IsEmpty() => Name == null;

    public override string ToString() => $"[{Schema}].[{Name}]";
}