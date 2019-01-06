using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using RomarizIT.PostFromFacebookData.Authorization.Users;
using RomarizIT.PostFromFacebookData.MultiTenancy;

namespace RomarizIT.PostFromFacebookData
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class PostFromFacebookDataAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected PostFromFacebookDataAppServiceBase()
        {
            LocalizationSourceName = PostFromFacebookDataConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
            if (user == null)
            {
                throw new Exception("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
