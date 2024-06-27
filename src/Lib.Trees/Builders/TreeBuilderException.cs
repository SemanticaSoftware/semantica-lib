namespace Semantica.Trees.Builders;

public class TreeBuilderException : Exception
{
    public TreeBuilderException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public TreeBuilderException(string message) : base(message)
    {
    }
}