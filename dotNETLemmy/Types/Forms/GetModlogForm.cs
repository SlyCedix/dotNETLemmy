using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace dotNetLemmy.Types;

public class GetModlogForm : IForm
{
    public string? Auth { get; set; }
    public string? CommunityId { get; set; }
    public int? Limit { get; set; }
    public int? ModPersonId { get; set; }
    public int? OtherPersonId { get; set; }
    public int? Page { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    // ReSharper disable once InconsistentNaming
    public ModlogActionType Type_ { get; set; }

    public string EndPoint => "/modlog";
    public HttpMethod Method => HttpMethod.Get;
}