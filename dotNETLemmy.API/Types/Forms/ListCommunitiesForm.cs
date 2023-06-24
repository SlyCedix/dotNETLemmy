using dotNETLemmy.API.Types.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace dotNETLemmy.API.Types.Forms;

public class ListCommunitiesForm : IForm
{
    public string? Auth { get; set; }
    public int? Limit { get; set; }
    public int? Page { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    public SortType? Sort { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    [JsonProperty(PropertyName = "type_")]
    public ListingType? Type { get; set; }

    public string EndPoint => "/api/v3/community/list";
    public HttpMethod Method => HttpMethod.Get;
}