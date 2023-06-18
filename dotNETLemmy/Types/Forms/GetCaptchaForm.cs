namespace dotNetLemmy.Types;

public class GetCaptchaForm : IForm
{
    public string EndPoint => "/user/get_captcha";
    public HttpMethod Method => HttpMethod.Get;
}