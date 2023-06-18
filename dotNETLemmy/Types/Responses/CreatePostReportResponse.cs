using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class CreatePostReportResponse : Response
{
    [JsonProperty] public PostReportView PostReportView { get; private set; } = null!;
}