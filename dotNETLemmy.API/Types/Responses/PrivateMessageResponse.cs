using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class PrivateMessageResponse : Response
{
    [JsonProperty] public PrivateMessageView PrivateMessageView { get; private set; } = null!;
}