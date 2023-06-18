using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class CommunityModeratorView
{
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public PersonSafe Moderator { get; private set; } = null!;
}