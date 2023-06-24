using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class ListCommentReportsResponse : Response
{
    [JsonInclude] public CommentReportView[] CommentReports { get; private set; } = null!;
}