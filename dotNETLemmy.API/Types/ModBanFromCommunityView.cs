using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class ModBanFromCommunityView : IJsonObject
{
    [JsonInclude] public PersonSafe BannedPerson { get; private set; } = null!;
    [JsonInclude] public CommunitySafe Community { get; private set; } = null!;
    [JsonInclude] public ModBanFromCommunity ModBanFromCommunity { get; private set; } = null!;
    [JsonInclude] public PersonSafe? Moderator { get; private set; }
}