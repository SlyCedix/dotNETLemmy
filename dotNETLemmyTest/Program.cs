// See https://aka.ms/new-console-template for more information

using dotNetLemmy;
using dotNetLemmy.Types;

var Lemmy = new LemmyHttpClient(new Uri("https://enterprise.lemmy.ml"));

var LoginForm = new LoginForm
{
    UsernameOrEmail = "cyn", Password = "2thJJ$8xh$Nfp^"
};

var res = await Lemmy.Login(LoginForm);

while (true) await Task.Delay(1000);
