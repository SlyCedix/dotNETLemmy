using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class ModAddView
{
    [JsonProperty] public ModAdd ModAdd { get; private set; } = null!;
    [JsonProperty] public PersonSafe ModdedPerson { get; private set; } = null!;
    [JsonProperty] public PersonSafe? Moderator { get; private set; }
}