using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class CommentReportResponse : Response
{
    [JsonProperty] public CommentReportView CommentReportView { get; private set; } = null!;
}