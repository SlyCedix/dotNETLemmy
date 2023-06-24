using System.Text.Json.Serialization;
using dotNETLemmy.API.Types.Enums;

namespace dotNETLemmy.API.Types.Forms;

public class SearchForm : IForm
{
    public string? Auth { get; set; }
    public int? CommunityId { get; set; }
    public string? CommunityName { get; set; }
    public int? CreatorId { get; set; }
    public int? Limit { get; set; }

    public ListingType? ListingType { get; set; }

    public string Q { get; set; } = string.Empty;

    public SortType? SortType { get; set; }

    [JsonPropertyName("type_")]
    public SearchType? Type { get; set; }

    public string EndPoint => "/api/v3/search";
    public HttpMethod Method => HttpMethod.Get;
}