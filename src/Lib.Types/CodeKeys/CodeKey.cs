namespace Semantica.Types.CodeKeys;

public readonly record struct CodeKey
{
    public const int MaxLength = 6;
    
    public CodeKey(string Value) { this.Value = Value.PadLeft(MaxLength, CodeKeys.NulChar); }

    public string Value { get; }

    public bool IsValid() => CodeKeys.IsValid(Value);

    public override string ToString() => Value.TrimStart(CodeKeys.NulChar);
    
    public static CodeKey FromHumanInput(string value) => new CodeKey(CodeKeys.SanitizeHumanInput(value));
    
    public static CodeKey FromInt(int value) => new CodeKey(CodeKeys.Int32ToCode(value));

    public static CodeKey FromString(string value)
        => CodeKeys.IsValid(value) ? new CodeKey(value) : throw new ArgumentException(nameof(value));
}
