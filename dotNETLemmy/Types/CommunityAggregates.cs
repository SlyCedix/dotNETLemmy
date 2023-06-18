using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class CommunityAggregates
{
    [JsonProperty]
    public int Comments { get; private set; }

    [JsonProperty]
    public int CommunityId { get; private set; }

    [JsonProperty]
    public int Id { get; private set; }

    [JsonProperty]
    public int Posts { get; private set; }

    [JsonProperty]
    public int Subscribers { get; private set; }

    [JsonProperty]
    public int UsersActiveDay { get; private set; }

    [JsonProperty]
    public int UsersActiveHalfYear { get; private set; }

    [JsonProperty]
    public int UsersActiveMonth { get; private set; }

    [JsonProperty]
    public int UsersActiveWeek { get; private set; }
}