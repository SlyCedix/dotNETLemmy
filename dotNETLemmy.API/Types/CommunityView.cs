using System.Text.Json.Serialization;
using dotNETLemmy.API.Types.Enums;

namespace dotNETLemmy.API.Types;

public class CommunityView : IJsonObject
{
    [JsonInclude] public bool Blocked { get; private set; }
    [JsonInclude] public CommunitySafe Community { get; private set; } = null!;
    [JsonInclude] public CommunityAggregates Counts { get; private set; } = null!;
    [JsonInclude] public SubscribedType Subscribed { get; private set; }
}