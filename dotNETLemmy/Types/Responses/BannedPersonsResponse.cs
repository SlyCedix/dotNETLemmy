using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class BannedPersonsResponse : Response
{
    [JsonProperty] public PersonViewSafe[] Banned { get; private set; } = null!;
}