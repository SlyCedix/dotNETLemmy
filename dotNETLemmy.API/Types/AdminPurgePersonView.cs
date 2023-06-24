using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class AdminPurgePersonView : IJsonObject
{
    [JsonInclude] public PersonSafe Admin { get; private set; } = null!;
    [JsonInclude] public AdminPurgePerson AdminPurgePerson { get; private set; } = null!;
}