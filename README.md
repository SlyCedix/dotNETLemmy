# Lemmy .NET API

An implementation of the Lemmy HTTP API modeled after [lemmy-js-client](https://github.com/LemmyNet/lemmy-js-client).

## Usage
[LemmyHttpClient Docs](xref:dotNETLemmy.API.LemmyHttpClient)

```csharp
// Logs into lemmy.ml and stores the authentication token to be used for further requests
var lemmyClient = new LemmyHttpClient("https://lemmy.ml");

var loginForm = new LoginForm {
    UsernameOrEmail = "username",
    Password = "password"
}

LoginResponse loginResponse = await lemmyClient.Login(loginForm);

if(loginResponse.Jwt is not string auth) throw new Exception("Login Failed");
```