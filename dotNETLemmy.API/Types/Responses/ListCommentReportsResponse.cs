using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class ListCommentReportsResponse : Response
{
    [JsonProperty] public CommentReportView[] CommentReports { get; private set; } = null!;
}