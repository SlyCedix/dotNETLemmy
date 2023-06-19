using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class ListRegistrationApplicationsResponse : Response
{
    [JsonProperty] public RegistrationApplicationView[] RegistrationApplications { get; private set; } = null!;
}