using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class DeleteAccountResponse : Response
{
    [JsonProperty] public PersonViewSafe[] Banned { get; private set; } = null!;
}