using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class GetUnreadCountResponse : Response
{
    [JsonInclude] public int Mentions { get; private set; }
    [JsonInclude] public int PrivateMessages { get; private set; }
    [JsonInclude] public int Replies { get; private set; }
}