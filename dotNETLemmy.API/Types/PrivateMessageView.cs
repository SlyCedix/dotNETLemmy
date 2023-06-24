using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class PrivateMessageView : IJsonObject
{
    [JsonInclude] public PersonSafe Creator { get; private set; } = null!;
    [JsonInclude] public PrivateMessage PrivateMessage { get; private set; } = null!;
    [JsonInclude] public PersonSafe Recipient { get; private set; } = null!;
}