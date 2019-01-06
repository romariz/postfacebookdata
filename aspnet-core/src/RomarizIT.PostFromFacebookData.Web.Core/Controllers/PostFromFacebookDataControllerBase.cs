using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace RomarizIT.PostFromFacebookData.Controllers
{
    public abstract class PostFromFacebookDataControllerBase: AbpController
    {
        protected PostFromFacebookDataControllerBase()
        {
            LocalizationSourceName = PostFromFacebookDataConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
