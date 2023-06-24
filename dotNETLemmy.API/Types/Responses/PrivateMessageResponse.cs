using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class PrivateMessageResponse : Response
{
    [JsonInclude] public PrivateMessageView PrivateMessageView { get; private set; } = null!;
}