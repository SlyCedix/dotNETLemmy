using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class GetReportCountResponse : Response
{
    [JsonInclude] public int CommentReports { get; private set; }
    [JsonInclude] public int? CommunityId { get; private set; }
    [JsonInclude] public int PostReports { get; private set; }
    [JsonInclude] public int? PrivateMessageReports { get; private set; }
}