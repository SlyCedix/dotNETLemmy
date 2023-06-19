﻿using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class ModRemovePost
{
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public int ModPersonId { get; private set; }
    [JsonProperty] public int PostId { get; private set; }
    [JsonProperty] public string? Reason { get; private set; }
    [JsonProperty] public bool? Removed { get; private set; }
    [JsonProperty(PropertyName = "when_")] public string When { get; private set; } = string.Empty;
}