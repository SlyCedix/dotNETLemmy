using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class ListRegistrationApplicationsResponse : Response
{
    [JsonProperty] public RegistrationApplicationView[] RegistrationApplications { get; private set; } = null!;
}