using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class ListPrivateMessageReportsResponse : Response
{
    [JsonProperty] public PrivateMessageReportView[] PrivateMessageReports { get; private set; } = null!;
}