using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class PrivateMessageReportResponse : Response
{
    [JsonProperty] public PrivateMessageReportView PrivateMessageReportView { get; private set; } = null!;
}