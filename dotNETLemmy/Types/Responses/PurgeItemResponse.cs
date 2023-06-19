using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class PurgeItemResponse : Response
{
    [JsonProperty] public bool Success { get; private set; }
}