namespace LiteraryRecommendation.Authentication.Models.Token
{
    public class UserResponseLoginViewModel
    {
        public string AcessToken { get; set; }
        public double ExpiresIn { get; set; }
        public UserTokenViewModel UserToken { get; set; }
    }
}
