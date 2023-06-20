using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class PurgeItemResponse : Response
{
    [JsonProperty] public bool Success { get; private set; }
}