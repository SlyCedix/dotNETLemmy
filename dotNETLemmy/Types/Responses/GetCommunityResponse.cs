using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class GetCommunityResponse : Response
{
    [JsonProperty] public CommunityView CommunityView { get; private set; } = null!;
    [JsonProperty] public int? DefaultPostLanguage { get; private set; }
    [JsonProperty] public int[] DiscussionLanguage { get; private set; } = null!;
    [JsonProperty] public CommunityModeratorView[] Moderators { get; private set; } = null!;
    [JsonProperty] public int Online { get; private set; }
    [JsonProperty] public Site? Site { get; private set; }
}