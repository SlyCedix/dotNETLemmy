using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class CommentReportResponse : Response
{
    [JsonProperty] public CommentReportView CommentReportView { get; private set; } = null!;
}