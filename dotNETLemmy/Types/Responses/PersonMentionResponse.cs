using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class PersonMentionResponse : Response
{
    [JsonProperty] public PersonMentionView PersonMentionView { get; private set; } = null!;
}