using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class GetPostResponse : Response
{
    [JsonProperty] public CommunityView CommunityView { get; private set; } = null!;
    [JsonProperty] public CommunityModeratorView[] Moderators { get; private set; } = null!;
    [JsonProperty] public int Online { get; private set; }
    [JsonProperty] public PostView PostView { get; private set; } = null!;
}