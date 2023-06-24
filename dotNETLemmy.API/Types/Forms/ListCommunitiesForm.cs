using System.Text.Json.Serialization;
using dotNETLemmy.API.Types.Enums;

namespace dotNETLemmy.API.Types.Forms;

public class ListCommunitiesForm : IForm
{
    public string? Auth { get; set; }
    public int? Limit { get; set; }
    public int? Page { get; set; }

    public SortType? Sort { get; set; }

    [JsonPropertyName("type_")]
    public ListingType? Type { get; set; }

    public string EndPoint => "/api/v3/community/list";
    public HttpMethod Method => HttpMethod.Get;
}