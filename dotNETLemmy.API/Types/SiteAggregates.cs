using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class SiteAggregates : IJsonObject
{
    [JsonInclude] public int Comments { get; private set; }
    [JsonInclude] public int Communities { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public int Posts { get; private set; }
    [JsonInclude] public int SiteId { get; private set; }
    [JsonInclude] public int Users { get; private set; }
    [JsonInclude] public int UsersActiveDay { get; private set; }
    [JsonInclude] public int UsersActiveHalfYear { get; private set; }
    [JsonInclude] public int UsersActiveMonth { get; private set; }
    [JsonInclude] public int UsersActiveWeek { get; private set; }
}