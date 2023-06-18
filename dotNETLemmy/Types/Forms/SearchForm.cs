﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace dotNetLemmy.Types;

public class SearchForm : IForm
{
    public string? Auth { get; set; }
    public int? CommunityId { get; set; }
    public string? CommunityName { get; set; }
    public int? CreatorId { get; set; }
    public int? Limit { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    public ListingType? ListingType { get; set; }

    public string Q { get; set; } = string.Empty;

    [JsonConverter(typeof(StringEnumConverter))]
    public SortType? SortType { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    // ReSharper disable once InconsistentNaming
    public SearchType? Type_ { get; set; }

    public string EndPoint => "/search";
    public HttpMethod Method => HttpMethod.Get;
}