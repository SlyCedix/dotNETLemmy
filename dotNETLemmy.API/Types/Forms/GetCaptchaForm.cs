namespace dotNETLemmy.API.Types.Forms;

public class GetCaptchaForm : IForm
{
    public string EndPoint => "/user/get_captcha";
    public HttpMethod Method => HttpMethod.Get;
}