using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class FederatedInstances : IJsonObject
{
    [JsonProperty] public string[]? Allowed { get; private set; }
    [JsonProperty] public string[]? Blocked { get; private set; }
    [JsonProperty] public string[] Linked { get; private set; } = null!;
}