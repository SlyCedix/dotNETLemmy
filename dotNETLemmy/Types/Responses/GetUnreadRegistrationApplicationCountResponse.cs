using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class GetUnreadRegistrationApplicationCountResponse : Response
{
    [JsonProperty] public int RegistrationApplications { get; private set; }
}