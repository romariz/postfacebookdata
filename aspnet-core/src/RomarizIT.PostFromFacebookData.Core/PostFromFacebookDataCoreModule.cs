using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using RomarizIT.PostFromFacebookData.Authorization.Roles;
using RomarizIT.PostFromFacebookData.Authorization.Users;
using RomarizIT.PostFromFacebookData.Configuration;
using RomarizIT.PostFromFacebookData.Localization;
using RomarizIT.PostFromFacebookData.MultiTenancy;
using RomarizIT.PostFromFacebookData.Timing;

namespace RomarizIT.PostFromFacebookData
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class PostFromFacebookDataCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            PostFromFacebookDataLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = PostFromFacebookDataConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PostFromFacebookDataCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
