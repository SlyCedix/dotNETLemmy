using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class SiteAggregates
{
    [JsonProperty] public int Comments { get; private set; }
    [JsonProperty] public int Communities { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public int Posts { get; private set; }
    [JsonProperty] public int SiteId { get; private set; }
    [JsonProperty] public int Users { get; private set; }
    [JsonProperty] public int UsersActiveDay { get; private set; }
    [JsonProperty] public int UsersActiveHalfYear { get; private set; }
    [JsonProperty] public int UsersActiveMonth { get; private set; }
    [JsonProperty] public int UsersActiveWeek { get; private set; }
}