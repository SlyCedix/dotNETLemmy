using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class BannedPersonsResponse : Response
{
    [JsonInclude] public PersonViewSafe[] Banned { get; private set; } = null!;
}