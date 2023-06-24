using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class PurgeItemResponse : Response
{
    [JsonInclude] public bool Success { get; private set; }
}