using System.Diagnostics;
using System.Text.Json;
using dotNETLemmy.API;
using dotNETLemmy.API.Types;
using dotNETLemmy.API.Types.Forms;

namespace dotNETLemmy.Tests;

[TestFixture]
public class Tests
{
    private Dictionary<string, string> _testConfig = null!;
    private LemmyHttpClient? _client;
    private string? _jwt;

    [OneTimeSetUp]
    public void Init()
    {
        var json = File.ReadAllText("config.json");
        var testConfig = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
        
        Assert.That(testConfig, Is.Not.Null);
        _testConfig = testConfig!;
        
        Assert.Multiple(() =>
        {
            Assert.That(_testConfig!["instanceUrl"], Is.Not.Null);
            Assert.That(_testConfig!["username"], Is.Not.Null);
            Assert.That(_testConfig!["password"], Is.Not.Null);
        });
        
        _client = new LemmyHttpClient(new Uri(_testConfig!["instanceUrl"]));
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
            UsernameOrEmail = _testConfig["username"], Password = _testConfig["password"]
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
        Assert.That(listCommunitiesResponse.Communities, Has.Length);

        var firstCommunity = listCommunitiesResponse.Communities.First();
        Assert.That(firstCommunity, Is.Not.Null);

        var getCommunityForm = new GetCommunityForm { Id = firstCommunity.Community.Id };
        var getCommunityResponse = await _client!.GetCommunity(getCommunityForm);
        var secondCommunity = getCommunityResponse.CommunityView;
        
        Assert.That(IJsonObject.EqualsByJson(firstCommunity, secondCommunity), Is.True);
    }

    [Test]
    public async Task GetPostsTest()
    {
        Assert.That(_client, Is.Not.Null);

        var getPostsForm = new GetPostsForm { CommunityId = 15 };
        var getPostsResponse = await _client!.GetPosts(getPostsForm);
        
        Assert.That(getPostsResponse.Posts, Has.Length);
        
        Debug.WriteLine(getPostsResponse.Posts.First());
    }
}