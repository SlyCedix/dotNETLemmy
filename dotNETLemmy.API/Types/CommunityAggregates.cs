using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class CommunityAggregates : IJsonObject
{
    [JsonInclude]
    public int Comments { get; private set; }

    [JsonInclude]
    public int CommunityId { get; private set; }

    [JsonInclude]
    public int Id { get; private set; }

    [JsonInclude]
    public int Posts { get; private set; }

    [JsonInclude]
    public int Subscribers { get; private set; }

    [JsonInclude]
    public int UsersActiveDay { get; private set; }

    [JsonInclude]
    public int UsersActiveHalfYear { get; private set; }

    [JsonInclude]
    public int UsersActiveMonth { get; private set; }

    [JsonInclude]
    public int UsersActiveWeek { get; private set; }
}