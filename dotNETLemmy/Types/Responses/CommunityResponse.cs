using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class CommunityResponse : Response
{
    [JsonProperty] public CommunityView CommunityView { get; private set; } = null!;
    [JsonProperty] public int[] DiscussionLanguages { get; private set; } = null!;
}