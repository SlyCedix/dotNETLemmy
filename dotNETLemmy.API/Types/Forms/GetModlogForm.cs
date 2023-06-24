using System.Text.Json.Serialization;
using dotNETLemmy.API.Types.Enums;

namespace dotNETLemmy.API.Types.Forms;

public class GetModlogForm : IForm
{
    public string? Auth { get; set; }
    public string? CommunityId { get; set; }
    public int? Limit { get; set; }
    public int? ModPersonId { get; set; }
    public int? OtherPersonId { get; set; }
    public int? Page { get; set; }
    
    [JsonPropertyName("type_")]
    public ModlogActionType Type { get; set; }

    public string EndPoint => "/api/v3/modlog";
    public HttpMethod Method => HttpMethod.Get;
}