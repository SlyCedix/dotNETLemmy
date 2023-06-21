using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class AdminPurgeCommunityView : IJsonObject
{
    [JsonProperty] public PersonSafe Admin { get; private set; } = null!;
    [JsonProperty] public AdminPurgeCommunity AdminPurgeCommunity { get; private set; } = null!;
}