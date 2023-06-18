using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class ApproveRegistrationApplicationResponse : Response
{
    [JsonProperty] public RegistrationApplicationView RegistrationApplication { get; private set; } = null!;
}