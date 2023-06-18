using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class CreateCommentReportResponse : Response
{
    [JsonProperty] public CommentReportView CommentReportView { get; private set; } = null!;
}