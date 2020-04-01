using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NetCoreAuth
{
    public class AgeHandler : AuthorizationHandler<IAuthorizationRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IAuthorizationRequirement requirement)
        {
            if (!context.User.HasClaim(user => user.Type == ClaimTypes.DateOfBirth))
            {
                return Task.CompletedTask;
            }
            DateTime birth = DateTime.Parse(context.User.FindFirst(u => u.Type == ClaimTypes.DateOfBirth).Value);
            if ((DateTime.Now.Year - birth.Year) > ((MinimumAgeRequirement)requirement).MinimumAge)
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }

    public class MinimumAgeRequirement : IAuthorizationRequirement
    {
        public int MinimumAge { get; }

        public MinimumAgeRequirement(int minimumAge)
        {
            MinimumAge = minimumAge;
        }
    }
}
