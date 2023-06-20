using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class GetUnreadRegistrationApplicationCountResponse : Response
{
    [JsonProperty] public int RegistrationApplications { get; private set; }
}