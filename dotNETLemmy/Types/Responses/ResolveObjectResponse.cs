﻿using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class ResolveObjectResponse : Response
{
    [JsonProperty] public CommentView? Comment { get; private set; }
    [JsonProperty] public CommunityView? Community { get; private set; }
    [JsonProperty] public PersonViewSafe? Person { get; private set; }
    [JsonProperty] public PostView? Post { get; private set; }
}