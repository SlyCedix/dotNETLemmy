using dotNETLemmy.API.Types.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace dotNETLemmy.API.Types.Forms;

public class GetRepliesForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int? Limit { get; set; }
    public int? Page { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    public SortType? Sort { get; set; }

    public bool? UnreadOnly { get; set; }

    public string EndPoint => "/api/v3/user/replies";
    public HttpMethod Method => HttpMethod.Get;
}