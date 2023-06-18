using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class PrivateMessageReportView
{
    [JsonProperty] public PersonSafe Creator { get; private set; } = null!;
    [JsonProperty] public PrivateMessage PrivateMessage { get; private set; } = null!;
    [JsonProperty] public PersonSafe PrivateMessageCreator { get; private set; } = null!;
    [JsonProperty] public PrivateMessageReport PrivateMessageReport { get; private set; } = null!;
    [JsonProperty] public PersonSafe Resolver { get; private set; } = null!;
}