using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LiteraryRecommendation.Api.Core.Identity
{

    public class ClaimsAuthorizeAttribute : TypeFilterAttribute
    {
        public ClaimsAuthorizeAttribute(string claimName, string claimValue) : base(typeof(RequisitoClaimsFilter))
        {
            Arguments = new object[] { new Claim(claimName, claimValue) };
        }
    }


}
