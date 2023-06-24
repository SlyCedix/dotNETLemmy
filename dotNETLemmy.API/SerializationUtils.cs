using System.Text.Json;
using System.Text.Json.Serialization;
using dotNETLemmy.API.Extensions;

namespace dotNETLemmy.API;

internal class SerializationUtils
{
    private static JsonSerializerOptions SerializerOptions { get; } = new()
    {
        PropertyNamingPolicy = SnakeCaseNamingPolicy.Instance,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        WriteIndented = false,
        IgnoreReadOnlyProperties = true,
        Converters =
        {
            new JsonStringEnumConverter()
        }
    };

    public static string Serialize(object? value) => JsonSerializer.Serialize(value, SerializerOptions);
    public static T? Deserialize<T>(string value) => JsonSerializer.Deserialize<T>(value, SerializerOptions);

    private class SnakeCaseNamingPolicy : JsonNamingPolicy
    {
        public static readonly SnakeCaseNamingPolicy Instance = new();

        public override string ConvertName(string name) => name.ToSnakeCase();
    }
}