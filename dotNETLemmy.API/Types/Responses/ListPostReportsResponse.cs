using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class ListPostReportsResponse : Response
{
    [JsonInclude] public PostReportView[] PostReports { get; private set; } = null!;
}