using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class ModTransferCommunity
{
    [JsonProperty] public int CommunityId { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public int ModPersonId { get; private set; }
    [JsonProperty] public int OtherPersonId { get; private set; }
    [JsonProperty] public bool? Removed { get; private set; }
    [JsonProperty(PropertyName = "when_")] public string When { get; private set; } = string.Empty;
}