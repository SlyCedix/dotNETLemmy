using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class PostReportResponse : Response
{
    [JsonProperty] public PostReportView PostReportView { get; private set; } = null!;
}