using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace dotNETLemmy.API;

internal class SerializationUtils
{
    private static JsonSerializerSettings SerializerSettings { get; } = new()
    {
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new SnakeCaseNamingStrategy()
        },
        NullValueHandling = NullValueHandling.Ignore
    };

    public static string Serialize(object? value) => JsonConvert.SerializeObject(value, SerializerSettings);
    public static T? Deserialize<T>(string value) => JsonConvert.DeserializeObject<T>(value, SerializerSettings);
}