using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class PrivateMessageReportResponse : Response
{
    [JsonProperty] public PrivateMessageReportView PrivateMessageReportView { get; private set; } = null!;
}