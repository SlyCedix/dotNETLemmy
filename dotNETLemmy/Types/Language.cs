using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class Language
{
    [JsonProperty] public string Code { get; private set; } = string.Empty;
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public string Name { get; private set; } = string.Empty;
}