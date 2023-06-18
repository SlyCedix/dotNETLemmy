using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class AddModToCommunityResponse : Response
{
    [JsonProperty] public CommunityModeratorView[] Moderators { get; private set; } = null!;
}