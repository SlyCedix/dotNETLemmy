using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class GetUnreadRegistrationApplicationCountResponse : Response
{
    [JsonInclude] public int RegistrationApplications { get; private set; }
}