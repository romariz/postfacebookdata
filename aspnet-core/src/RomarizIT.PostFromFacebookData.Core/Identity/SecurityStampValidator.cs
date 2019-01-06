using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using RomarizIT.PostFromFacebookData.Authorization.Roles;
using RomarizIT.PostFromFacebookData.Authorization.Users;
using RomarizIT.PostFromFacebookData.MultiTenancy;

namespace RomarizIT.PostFromFacebookData.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options, 
            SignInManager signInManager,
            ISystemClock systemClock) 
            : base(
                  options, 
                  signInManager, 
                  systemClock)
        {
        }
    }
}
