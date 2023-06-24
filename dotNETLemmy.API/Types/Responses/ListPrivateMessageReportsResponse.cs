using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class ListPrivateMessageReportsResponse : Response
{
    [JsonInclude] public PrivateMessageReportView[] PrivateMessageReports { get; private set; } = null!;
}