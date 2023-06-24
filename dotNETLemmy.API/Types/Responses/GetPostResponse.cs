using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class GetPostResponse : Response
{
    [JsonInclude] public CommunityView CommunityView { get; private set; } = null!;
    [JsonInclude] public CommunityModeratorView[] Moderators { get; private set; } = null!;
    [JsonInclude] public int Online { get; private set; }
    [JsonInclude] public PostView PostView { get; private set; } = null!;
}