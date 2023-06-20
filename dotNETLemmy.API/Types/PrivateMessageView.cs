using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class PrivateMessageView
{
    [JsonProperty] public PersonSafe Creator { get; private set; } = null!;
    [JsonProperty] public PrivateMessage PrivateMessage { get; private set; } = null!;
    [JsonProperty] public PersonSafe Recipient { get; private set; } = null!;
}