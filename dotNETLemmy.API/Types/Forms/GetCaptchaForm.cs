namespace dotNETLemmy.API.Types.Forms;

public class GetCaptchaForm : IForm
{
    public string EndPoint => "/api/v3/user/get_captcha";
    public HttpMethod Method => HttpMethod.Get;
}