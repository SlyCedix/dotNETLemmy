using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class FederatedInstances
{
    [JsonProperty] public string[]? Allowed { get; private set; }
    [JsonProperty] public string[]? Blocked { get; private set; }
    [JsonProperty] public string[] Linked { get; private set; } = null!;
}