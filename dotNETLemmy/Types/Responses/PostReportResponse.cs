using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class PostReportResponse : Response
{
    [JsonProperty] public PostReportView PostReportView { get; private set; } = null!;
}