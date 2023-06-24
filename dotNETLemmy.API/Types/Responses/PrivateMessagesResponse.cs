using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class PrivateMessagesResponse : Response
{
    [JsonInclude] public PrivateMessageView[] PrivateMessages { get; private set; } = null!;
}