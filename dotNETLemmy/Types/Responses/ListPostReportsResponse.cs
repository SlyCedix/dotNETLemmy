using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class ListPostReportsResponse : Response
{
    [JsonProperty] public PostReportView[] PostReports { get; private set; } = null!;
}