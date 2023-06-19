﻿using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class GetUnreadCountResponse : Response
{
    [JsonProperty] public int Mentions { get; private set; }
    [JsonProperty] public int PrivateMessages { get; private set; }
    [JsonProperty] public int Replies { get; private set; }
}