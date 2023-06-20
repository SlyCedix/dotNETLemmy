using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class BannedPersonsResponse : Response
{
    [JsonProperty] public PersonViewSafe[] Banned { get; private set; } = null!;
}