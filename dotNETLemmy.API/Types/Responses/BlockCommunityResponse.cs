using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class BlockCommunityResponse : Response
{
    [JsonInclude] public bool Blocked { get; private set; }
    [JsonInclude] public CommunityView CommunityView { get; private set; } = null!;
}