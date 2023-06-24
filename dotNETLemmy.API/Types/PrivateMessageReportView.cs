using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class PrivateMessageReportView : IJsonObject
{
    [JsonInclude] public PersonSafe Creator { get; private set; } = null!;
    [JsonInclude] public PrivateMessage PrivateMessage { get; private set; } = null!;
    [JsonInclude] public PersonSafe PrivateMessageCreator { get; private set; } = null!;
    [JsonInclude] public PrivateMessageReport PrivateMessageReport { get; private set; } = null!;
    [JsonInclude] public PersonSafe Resolver { get; private set; } = null!;
}