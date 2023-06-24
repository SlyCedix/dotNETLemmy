using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class ModBanView : IJsonObject
{
    [JsonInclude] public PersonSafe BannedPerson { get; private set; } = null!;
    [JsonInclude] public ModBan ModBan { get; private set; } = null!;
    [JsonInclude] public PersonSafe? Moderator { get; private set; }
}