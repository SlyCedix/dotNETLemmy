using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class PostReportResponse : Response
{
    [JsonInclude] public PostReportView PostReportView { get; private set; } = null!;
}