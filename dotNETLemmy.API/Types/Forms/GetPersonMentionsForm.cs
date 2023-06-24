using dotNETLemmy.API.Types.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace dotNETLemmy.API.Types.Forms;

public class GetPersonMentionsForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int? Limit { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    public CommentSortType? Sort { get; set; }

    public int? Page { get; set; }
    public bool? UnreadOnly { get; set; }

    public string EndPoint => "/api/v3/user/mention";
    public HttpMethod Method => HttpMethod.Get;
}