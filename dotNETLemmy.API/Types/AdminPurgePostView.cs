using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class AdminPurgePostView
{
    [JsonProperty] public PersonSafe Admin { get; private set; } = null!;
    [JsonProperty] public AdminPurgePost AdminPurgePost { get; private set; } = null!;
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
}