using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace dotNetLemmy.Types;

public class GetCommentsForm : IForm
{
    public string? Auth { get; set; }
    public int? CommunityId { get; set; }
    public string? CommunityName { get; set; }
    public int? Limit { get; set; }
    public int? MaxDepth { get; set; }
    public int? Page { get; set; }
    public int? ParentId { get; set; }
    public int? PostId { get; set; }
    public int? SavedOnly { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    public CommentSortType? Sort { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    [JsonProperty(PropertyName = "type_")]
    public ListingType Type { get; set; }

    public string EndPoint => "/comment/list";
    public HttpMethod Method => HttpMethod.Get;
}