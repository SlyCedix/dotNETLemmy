using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class ListCommentReportsResponse : Response
{
    [JsonProperty] public CommentReportView[] CommentReports { get; private set; } = null!;
}