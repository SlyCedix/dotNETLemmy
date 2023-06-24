namespace dotNETLemmy.API.Extensions;

internal static class StringExtensions
{
    internal static string JsonToQuery(this string jsonQuery)
    {
        var str = "?";
        str += jsonQuery.Replace(":", "=").Replace("{", "").Replace("}", "").Replace(",", "&").Replace("\"", "");
        return str.Length > 1 ? str : string.Empty;
    }

    internal static string ToSnakeCase(this string str)
    {
        return string.Concat(str.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x : x.ToString())).ToLower();
    }
}