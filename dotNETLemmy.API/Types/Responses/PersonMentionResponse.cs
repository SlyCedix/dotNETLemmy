using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class PersonMentionResponse : Response
{
    [JsonInclude] public PersonMentionView PersonMentionView { get; private set; } = null!;
}