using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class PrivateMessagesResponse : Response
{
    [JsonProperty] public PrivateMessageView[] PrivateMessages { get; private set; } = null!;
}