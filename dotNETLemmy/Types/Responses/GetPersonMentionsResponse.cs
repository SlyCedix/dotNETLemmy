using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class GetPersonMentionsResponse : Response
{
    [JsonProperty] public PersonMentionView[] Mentions { get; private set; } = null!;
}