using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class ListCommunitiesResponse : Response
{
    [JsonInclude] public CommunityView[] Communities { get; private set; } = null!;
}