namespace Semantica.Storage.EntityFramework.Config;

public static class ConfigTypes
{
    public static string Decimal(int precision, int scale)
    {
        return $"decimal({precision},{scale})";
    }

    public static string Date()
    {
        return "date";
    }
}