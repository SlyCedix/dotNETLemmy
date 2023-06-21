namespace dotNETLemmy.API.Extensions;

internal static class StringExtensions
{
    internal static string JsonToQuery(this string jsonQuery)
    {
        var str = "?";
        str += jsonQuery.Replace(":", "=").Replace("{","").
            Replace("}", "").Replace(",","&").
            Replace("\"", "");
        return str;
    }
}