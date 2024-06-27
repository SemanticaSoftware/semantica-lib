namespace Semantica.Storage.EntityFramework.Config;

public static class ColumnNameHelper
{
    public static string MakeName(string ownerPropertyName, string propertyName)
    {
        return $"{ownerPropertyName}_{propertyName}";
    }
}