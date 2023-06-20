using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class ModBanView
{
    [JsonProperty] public PersonSafe BannedPerson { get; private set; } = null!;
    [JsonProperty] public ModBan ModBan { get; private set; } = null!;
    [JsonProperty] public PersonSafe? Moderator { get; private set; }
}