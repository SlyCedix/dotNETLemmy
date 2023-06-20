using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class BlockCommunityResponse : Response
{
    [JsonProperty] public bool Blocked { get; private set; }
    [JsonProperty] public CommunityView CommunityView { get; private set; } = null!;
}