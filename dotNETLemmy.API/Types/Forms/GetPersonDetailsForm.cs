using dotNETLemmy.API.Types.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace dotNETLemmy.API.Types.Forms;

public class GetPersonDetailsForm : IForm
{
    public string? Auth { get; set; }
    public int? CommunityId { get; set; }
    public int? Limit { get; set; }
    public int? PersonId { get; set; }
    public bool? SavedOnly { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    public SortType Sort { get; set; }

    public string? Username { get; set; }

    public string EndPoint => "/api/v3/user";
    public HttpMethod Method => HttpMethod.Get;
}