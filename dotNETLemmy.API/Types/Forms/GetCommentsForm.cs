using System.Text.Json.Serialization;
using dotNETLemmy.API.Types.Enums;

namespace dotNETLemmy.API.Types.Forms;

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
    public CommentSortType? Sort { get; set; }

    [JsonPropertyName("type_")]
    public ListingType Type { get; set; }

    public string EndPoint => "/api/v3/comment/list";
    public HttpMethod Method => HttpMethod.Get;
}