using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class ListPostReportsResponse : Response
{
    [JsonProperty] public PostReportView[] PostReports { get; private set; } = null!;
}