using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace dotNetLemmy.Types;

public class GetPostsForm : IForm
{
    public string? Auth { get; set; }
    public string? CommunityName { get; set; }
    public int? CommunityId { get; set; }
    public int? Limit { get; set; }
    public int? Page { get; set; }
    public bool? SavedOnly { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    public SortType? Sort { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    [JsonProperty(PropertyName = "type_")]
    public ListingType? Type { get; set; }

    public string EndPoint => "/post/list";
    public HttpMethod Method => HttpMethod.Get;
}