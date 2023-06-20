using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class ApproveRegistrationApplicationResponse : Response
{
    [JsonProperty] public RegistrationApplicationView RegistrationApplication { get; private set; } = null!;
}