using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class ModTransferCommunityView : IJsonObject
{
    [JsonInclude] public CommunitySafe Community { get; private set; } = null!;
    [JsonInclude] public ModTransferCommunity ModTransferCommunity { get; private set; } = null!;
    [JsonInclude] public PersonSafe ModdedPerson { get; private set; } = null!;
    [JsonInclude] public PersonSafe? Moderator { get; private set; }
}