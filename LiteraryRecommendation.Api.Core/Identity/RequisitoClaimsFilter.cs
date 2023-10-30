using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace LiteraryRecommendation.Api.Core.Identity
{
    public class RequisitoClaimsFilter : IAuthorizationFilter
    {
        private readonly Claim _claim;

        public RequisitoClaimsFilter(Claim claim)
        {
            _claim = claim;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                context.Result = new StatusCodeResult(401);
                return;
            }

            if (!CustomAuthorization.UserClaimsValidation(context.HttpContext, _claim.Type, _claim.Value))
            {
                context.Result = new StatusCodeResult(203);
            }
        }
    }
}
