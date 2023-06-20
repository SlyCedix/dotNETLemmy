# API Documentation

Refer to [LemmyHttpClient](xref:dotNETLemmy.API.LemmyHttpClient) for information about available standard api calls.

If a Lemmy instance supports a non standard API call the following steps can be done to send that call:

Create a Form that implements [IForm](xref:dotNETLemmy.API.Types.IForm) (see examples [here](xref:dotNETLemmy.API.Types.Forms)):
```csharp
using Newtonsoft.Json;

public class NonstandardForm : IForm
{
    public bool ExampleBool { get; set; } // serialized as example_bool
    public string? ExampleString { get; set; } // serialized as example_string only when defined
    
    [JsonProperty(PropertyName = "NonStandardExample")]
    public int ExampleInt { get; set; } // serialized as NonStandardExample
    
    public string EndPoint => "/nonstandard/api/endpoint"
    public HttpMethod Method => HttpMethod.Post; // Substitute for correct request method
}
```

Create a Response class that inherits from [Response](xref:dotNETLemmy.API.Types.Responses.Response):
```csharp
using Newtonsoft.Json;

public class NonstandardResponse : Response
{
    [JsonProperty] public string ExampleString { get; private set; } = string.Empty; // deserialized from example_string
    
    [JsonProperty(PropertyName = "non_standard_example_")] 
    public int ExampleInt { get; private set; } // deserialized from non_standard_example_
}
```

Either call [LemmyHttpClient.SendAsync](xref:dotNETLemmy.API.LemmyHttpClient.SendAsync*) directly or create an extension method like so:

```csharp
public static class LemmyHttpClientExtensions {
    public static Task<NonstandardResponse> NonstandardApiCall(this LemmyHttpClient client, NonstandardForm form) {
        return client.SendAsync<NonstandardResponse>(form);
    }
}
```