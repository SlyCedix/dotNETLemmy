using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class ModAddView : IJsonObject
{
    [JsonInclude] public ModAdd ModAdd { get; private set; } = null!;
    [JsonInclude] public PersonSafe ModdedPerson { get; private set; } = null!;
    [JsonInclude] public PersonSafe? Moderator { get; private set; }
}