<div class="article">

# Lemmy .NET API

An implementation of the Lemmy HTTP API modeled after [lemmy-js-client](https://github.com/LemmyNet/lemmy-js-client).

## Usage

The [LemmyHttpClient](xref:dotNETLemmy.API.LemmyHttpClient) class has a constructor which takes
an [HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=net-7.0) as a parameter,
allowing for it to be used as a
typed [IHttpClientFactory](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-7.0)
client with dependency injection.

`Program.cs:`

```csharp
HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddHostedService<LemmyWorker>(provider => 
    new LemmyWorker(provider.GetRequiredService<ILemmyHttpClient>())
    {
        BaseAddress = "https://enterprise.lemmy.ml/"
    });
builder.Services.AddHttpClient<ILemmyHttpClient, LemmyHttpClient>();

IHost host = builder.Build();

host.Run();
```

`LemmyWorker.cs:`

```csharp
// Logs getPostResponse every 10 seconds
public class LemmyWorker : BackgroundService
{
    public string BaseAddress
    {
        get => _lemmyHttpClient.BaseAddress;
        set => _lemmyHttpClient.BaseAddress = value;
    }
    
    private readonly ILemmyHttpClient _lemmyHttpClient;

    public LemmyWorker(ILemmyHttpClient lemmyHttpClient) =>
        _lemmyHttpClient = lemmyHttpClient;
    
    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        while(!cancellationToken.IsCancellationRequested)
        {
            GetPostsResponse getPostsResponse = await _lemmyHttpClient.GetPosts(new GetPostsForm(), cancellationToken);
            Console.WriteLine(getPostsResponse);
            await Task.Delay(10000, cancellationToken);
        }
    }
}
```

</div>