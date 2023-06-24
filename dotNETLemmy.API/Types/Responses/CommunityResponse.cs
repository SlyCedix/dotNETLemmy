using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class CommunityResponse : Response
{
    [JsonInclude] public CommunityView CommunityView { get; private set; } = null!;
    [JsonInclude] public int[] DiscussionLanguages { get; private set; } = null!;
}