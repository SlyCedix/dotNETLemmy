using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class ListPrivateMessageReportsResponse : Response
{
    [JsonProperty] public PrivateMessageReportView[] PrivateMessageReports { get; private set; } = null!;
}