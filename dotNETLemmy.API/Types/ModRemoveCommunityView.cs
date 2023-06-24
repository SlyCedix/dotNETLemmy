using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class ModRemoveCommunityView : IJsonObject
{
    [JsonInclude] public CommunitySafe Community { get; private set; } = null!;
    [JsonInclude] public ModRemoveCommunity ModRemoveCommunity { get; private set; } = null!;
    [JsonInclude] public PersonSafe? Moderator { get; private set; }
}