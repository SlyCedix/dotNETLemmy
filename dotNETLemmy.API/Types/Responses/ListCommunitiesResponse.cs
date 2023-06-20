using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class ListCommunitiesResponse : Response
{
    [JsonProperty] public CommunityView[] Communities { get; private set; } = null!;
}