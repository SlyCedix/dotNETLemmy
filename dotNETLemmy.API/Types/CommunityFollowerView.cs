using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class CommunityFollowerView : IJsonObject
{
    [JsonInclude] public CommunitySafe Community { get; private set; } = null!;
    [JsonInclude] public PersonSafe Follower { get; private set; } = null!;
}