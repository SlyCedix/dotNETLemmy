using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class AdminPurgeCommunityView : IJsonObject
{
    [JsonInclude] public PersonSafe Admin { get; private set; } = null!;
    [JsonInclude] public AdminPurgeCommunity AdminPurgeCommunity { get; private set; } = null!;
}