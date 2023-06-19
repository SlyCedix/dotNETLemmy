using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class PrivateMessageResponse : Response
{
    [JsonProperty] public PrivateMessageView PrivateMessageView { get; private set; } = null!;
}