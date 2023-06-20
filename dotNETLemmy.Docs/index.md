<div class="article">

# Lemmy .NET API

An implementation of the Lemmy HTTP API modeled after [lemmy-js-client](https://github.com/LemmyNet/lemmy-js-client).

## Usage
[LemmyHttpClient Docs](api/dotNETLemmy.API.LemmyHttpClient.html)

```csharp
// Logs into lemmy.ml and stores the authentication token to be used for further requests

using dotNETLemmy.API;

var lemmyClient = new LemmyHttpClient("https://lemmy.ml");

var loginForm = new LoginForm {
    UsernameOrEmail = "username",
    Password = "password"
}

LoginResponse loginResponse = await lemmyClient.Login(loginForm);

if(loginResponse.Jwt is not string auth) throw new Exception("Login Failed");

```

</div>