using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class AdminPurgePersonView
{
    [JsonProperty] public PersonSafe Admin { get; private set; } = null!;
    [JsonProperty] public AdminPurgePerson AdminPurgePerson { get; private set; } = null!;
}