using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using RomarizIT.PostFromFacebookData.Authorization;
using RomarizIT.PostFromFacebookData.Authorization.Roles;
using RomarizIT.PostFromFacebookData.Authorization.Users;
using RomarizIT.PostFromFacebookData.Editions;
using RomarizIT.PostFromFacebookData.MultiTenancy;

namespace RomarizIT.PostFromFacebookData.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
