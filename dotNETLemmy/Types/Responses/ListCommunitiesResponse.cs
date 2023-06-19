using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class ListCommunitiesResponse : Response
{
    [JsonProperty] public CommunityView[] Communities { get; private set; } = null!;
}