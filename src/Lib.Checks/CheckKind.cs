namespace Semantica.Checks;

public enum CheckKind
{
    Bool = 0,
    Defined,
    MaxValue,
    NotNull,
    NotEmpty,
    NonZero,
    NonNegative,
    StrictPositive,
}
