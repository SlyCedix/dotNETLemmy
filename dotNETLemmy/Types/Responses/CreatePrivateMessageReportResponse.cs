using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class CreatePrivateMessageReportResponse : Response
{
    [JsonProperty] public PrivateMessageReportView PrivateMessageReportView { get; private set; } = null!;
}