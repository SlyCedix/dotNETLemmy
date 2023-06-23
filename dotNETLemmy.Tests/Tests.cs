using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using dotNETLemmy.API;
using dotNETLemmy.API.Types;
using dotNETLemmy.API.Types.Forms;

namespace dotNETLemmy.Tests;

[TestFixture]
public class Tests
{
    private LemmyHttpClient? _client;
    
    private string? _jwt;
    
    private readonly string _username = Environment.GetEnvironmentVariable("LEMMY_USER") ?? "";
    private readonly string _password = Environment.GetEnvironmentVariable("LEMMY_PASS") ?? "";
    private readonly string _lemmyurl = Environment.GetEnvironmentVariable("LEMMY_URL") ?? "";
    
    [OneTimeSetUp]
    public void Init()
    {
        Assert.Multiple(() =>
        {
            Assert.That(_username, Is.Not.Empty);
            Assert.That(_password, Is.Not.Empty);
            Assert.That(_lemmyurl, Is.Not.Empty);
        });
        
        _client = new LemmyHttpClient(new Uri(_lemmyurl));
    }

    [OneTimeTearDown]
    public void Cleanup()
    {
        _client?.Dispose();
    }

    /// <summary>
    /// Should be run first to initialize _jwt
    /// </summary>
    [Test, Order(1)]
    public async Task LoginTest()
    {
        Assert.That(_client, Is.Not.Null);
        
        var loginForm = new LoginForm
        {
            UsernameOrEmail = _username, Password = _password
        };
        
        var loginResponse = await _client!.Login(loginForm);

        Assert.That(loginResponse.Jwt, Is.Not.Null);

        _jwt = loginResponse.Jwt!;
    }
    
    [Test]
    public async Task CommunitiesTest()
    {
        Assert.That(_client, Is.Not.Null);
        
        var listCommunitiesResponse = await _client!.ListCommunities(new ListCommunitiesForm());
        Assert.Multiple(() =>
        {
            Assert.That(listCommunitiesResponse.HasError, Is.False);
            Assert.That(listCommunitiesResponse.IsSuccessStatusCode, Is.True);
            Assert.That(listCommunitiesResponse.Communities, Has.Length);
        });
        
        var firstCommunity = listCommunitiesResponse.Communities.First();
        Assert.That(firstCommunity, Is.Not.Null);

        var getCommunityForm = new GetCommunityForm { Id = firstCommunity.Community.Id };
        var getCommunityResponse = await _client!.GetCommunity(getCommunityForm);
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
        Assert.That(_client, Is.Not.Null);
        
        var getPostsResponse = await _client!.GetPosts(new GetPostsForm());
        Assert.Multiple(() =>
        {
            Assert.That(getPostsResponse.HasError, Is.False);
            Assert.That(getPostsResponse.IsSuccessStatusCode, Is.True);
            Assert.That(getPostsResponse.Posts, Has.Length);
        });
        
        var firstPost = getPostsResponse.Posts.First();
        Assert.That(firstPost, Is.Not.Null);

        var getPostForm = new GetPostForm { Id = firstPost.Post.Id };
        var getPostResponse = await _client!.GetPost(getPostForm);
        Assert.Multiple(() =>
        {
            Assert.That(getPostResponse.HasError, Is.False);
            Assert.That(getPostResponse.IsSuccessStatusCode, Is.True);
            Assert.That(getPostResponse.PostView, Is.Not.Null);
            Assert.That(IJsonObject.EqualsByJson(firstPost, getPostResponse.PostView), Is.True);
        });
    }
}