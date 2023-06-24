using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class PrivateMessageReportResponse : Response
{
    [JsonInclude] public PrivateMessageReportView PrivateMessageReportView { get; private set; } = null!;
}