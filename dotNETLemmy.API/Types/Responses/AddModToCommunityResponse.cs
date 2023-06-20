using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class AddModToCommunityResponse : Response
{
    [JsonProperty] public CommunityModeratorView[] Moderators { get; private set; } = null!;
}