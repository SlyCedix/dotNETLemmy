using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class BlockCommunityResponse : Response
{
    [JsonProperty] public bool Blocked { get; private set; }
    [JsonProperty] public CommunityView CommunityView { get; private set; } = null!;
}