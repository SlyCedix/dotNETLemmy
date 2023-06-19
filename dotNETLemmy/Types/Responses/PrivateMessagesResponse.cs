using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class PrivateMessagesResponse : Response
{
    [JsonProperty] public PrivateMessageView[] PrivateMessages { get; private set; } = null!;
}