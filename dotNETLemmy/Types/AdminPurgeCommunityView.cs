﻿using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class AdminPurgeCommunityView
{
    [JsonProperty] public PersonSafe Admin { get; private set; } = null!;
    [JsonProperty] public AdminPurgeCommunity AdminPurgeCommunity { get; private set; } = null!;
}