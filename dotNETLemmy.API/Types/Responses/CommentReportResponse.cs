using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class CommentReportResponse : Response
{
    [JsonInclude] public CommentReportView CommentReportView { get; private set; } = null!;
}