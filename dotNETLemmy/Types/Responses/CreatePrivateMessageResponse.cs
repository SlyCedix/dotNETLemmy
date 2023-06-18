using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class CreatePrivateMessageResponse : Response
{
    [JsonProperty] public PrivateMessageView PrivateMessageView { get; private set; } = null!;
}