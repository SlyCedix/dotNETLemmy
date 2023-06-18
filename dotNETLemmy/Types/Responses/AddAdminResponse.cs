using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class AddAdminResponse : Response
{
    [JsonProperty] public PersonViewSafe[] Admins { get; private set; } = null!;
}