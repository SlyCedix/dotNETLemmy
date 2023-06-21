using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class Language : IJsonObject
{
    [JsonProperty] public string Code { get; private set; } = string.Empty;
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public string Name { get; private set; } = string.Empty;
}