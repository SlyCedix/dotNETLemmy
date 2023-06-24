using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class FederatedInstances : IJsonObject
{
    [JsonInclude] public string[]? Allowed { get; private set; }
    [JsonInclude] public string[]? Blocked { get; private set; }
    [JsonInclude] public string[] Linked { get; private set; } = null!;
}