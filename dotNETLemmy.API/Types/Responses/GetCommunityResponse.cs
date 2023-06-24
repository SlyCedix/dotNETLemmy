using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class GetCommunityResponse : Response
{
    [JsonInclude] public CommunityView CommunityView { get; private set; } = null!;
    [JsonInclude] public int? DefaultPostLanguage { get; private set; }
    [JsonInclude] public int[] DiscussionLanguage { get; private set; } = null!;
    [JsonInclude] public CommunityModeratorView[] Moderators { get; private set; } = null!;
    [JsonInclude] public int Online { get; private set; }
    [JsonInclude] public Site? Site { get; private set; }
}