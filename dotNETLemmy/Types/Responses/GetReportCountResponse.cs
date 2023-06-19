﻿using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class GetReportCountResponse : Response
{
    [JsonProperty] public int CommentReports { get; private set; }
    [JsonProperty] public int? CommunityId { get; private set; }
    [JsonProperty] public int PostReports { get; private set; }
    [JsonProperty] public int? PrivateMessageReports { get; private set; }
}