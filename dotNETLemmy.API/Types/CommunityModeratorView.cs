using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class CommunityModeratorView : IJsonObject
{
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public PersonSafe Moderator { get; private set; } = null!;
}