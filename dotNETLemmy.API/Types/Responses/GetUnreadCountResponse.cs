using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class GetUnreadCountResponse : Response
{
    [JsonProperty] public int Mentions { get; private set; }
    [JsonProperty] public int PrivateMessages { get; private set; }
    [JsonProperty] public int Replies { get; private set; }
}