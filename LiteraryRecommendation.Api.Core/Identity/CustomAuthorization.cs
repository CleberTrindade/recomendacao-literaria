using Microsoft.AspNetCore.Http;

namespace LiteraryRecommendation.Api.Core.Identity
{
    public class CustomAuthorization
    {
        public static bool UserClaimsValidation(HttpContext context, string claimName, string claimValue)
        {
            return context.User.Identity.IsAuthenticated &&
                   context.User.Claims.Any(c => c.Type == claimName && c.Value.Contains(claimValue));
        }
    }
}
