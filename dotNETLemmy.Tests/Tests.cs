using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using dotNETLemmy.API;
using dotNETLemmy.API.Types;
using dotNETLemmy.API.Types.Forms;

namespace dotNETLemmy.Tests;

[TestFixture]
public class Tests
{
    private IHost? _host;
    
    private readonly string _username = Environment.GetEnvironmentVariable("LEMMY_USER") ?? "";
    private readonly string _password = Environment.GetEnvironmentVariable("LEMMY_PASS") ?? "";
    private readonly string _lemmyurl = Environment.GetEnvironmentVariable("LEMMY_URL") ?? "";

    private ILemmyHttpClient GetDefaultClient()
    {
        Assert.That(_host, Is.Not.Null);
        var client = _host!.Services.GetService<ILemmyHttpClient>();
        Assert.That(client, Is.Not.Null);
        return client!;
    }
    
    [OneTimeSetUp]
    public void Init()
    {
        // Configure default client
        Assert.That(_lemmyurl, Is.Not.Empty);
        var builder = Host.CreateApplicationBuilder();
        builder.Services.AddHttpClient<ILemmyHttpClient, LemmyHttpClient>();
        _host = builder.Build();
    }

    [Test]
    public async Task LoginTest()
    {
        Assert.Multiple(() =>
        {
            Assert.That(_username, Is.Not.Empty);
            Assert.That(_password, Is.Not.Empty);
        });
        var client = GetDefaultClient();
        client.BaseAddress = _lemmyurl;
        
        var loginForm = new LoginForm
        {
            UsernameOrEmail = _username, Password = _password
        };
        
        var loginResponse = await client.Login(loginForm);

        Assert.That(loginResponse.Jwt, Is.Not.Null);
    }

    [Test]
    public async Task CommunitiesTest()
    {
        var client = GetDefaultClient();
        client.BaseAddress = _lemmyurl;
        
        var listCommunitiesResponse = await client.ListCommunities(new ListCommunitiesForm());
        Assert.Multiple(() =>
        {
            Assert.That(listCommunitiesResponse.HasError, Is.False);
            Assert.That(listCommunitiesResponse.IsSuccessStatusCode, Is.True);
            Assert.That(listCommunitiesResponse.Communities, Has.Length);
        });
        
        var firstCommunity = listCommunitiesResponse.Communities.First();
        Assert.That(firstCommunity, Is.Not.Null);

        var getCommunityForm = new GetCommunityForm { Id = firstCommunity.Community.Id };
        var getCommunityResponse = await client.GetCommunity(getCommunityForm);
        Assert.Multiple(() =>
        {
            Assert.That(getCommunityResponse.HasError, Is.False);
            Assert.That(getCommunityResponse.IsSuccessStatusCode, Is.True);
            Assert.That( getCommunityResponse.CommunityView, Is.Not.Null);
            Assert.That(IJsonObject.EqualsByJson(firstCommunity, getCommunityResponse.CommunityView), Is.True);
        });
    }

    [Test]
    public async Task GetPostsTest()
    {
        var client = GetDefaultClient();
        client.BaseAddress = _lemmyurl;
        
        var getPostsResponse = await client.GetPosts(new GetPostsForm());
        Assert.Multiple(() =>
        {
            Assert.That(getPostsResponse.HasError, Is.False);
            Assert.That(getPostsResponse.IsSuccessStatusCode, Is.True);
            Assert.That(getPostsResponse.Posts, Has.Length);
        });
        
        var firstPost = getPostsResponse.Posts.First();
        Assert.That(firstPost, Is.Not.Null);

        var getPostForm = new GetPostForm { Id = firstPost.Post.Id };
        var getPostResponse = await client!.GetPost(getPostForm);
        Assert.Multiple(() =>
        {
            Assert.That(getPostResponse.HasError, Is.False);
            Assert.That(getPostResponse.IsSuccessStatusCode, Is.True);
            Assert.That(getPostResponse.PostView, Is.Not.Null);
            Assert.That(IJsonObject.EqualsByJson(firstPost, getPostResponse.PostView), Is.True);
        });
    }
}