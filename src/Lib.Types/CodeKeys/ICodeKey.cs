namespace Semantica.Types.CodeKeys;

public interface ICodeKey
{
    string Code { get; }

    string AsStorage();
}