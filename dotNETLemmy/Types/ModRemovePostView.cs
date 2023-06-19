﻿using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class ModRemovePostView
{
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public ModRemovePost ModRemovePost { get; private set; } = null!;
    [JsonProperty] public PersonSafe? Moderator { get; private set; }
    [JsonProperty] public Post Post { get; private set; } = null!;
}