using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RomarizIT.PostFromFacebookData.Authorization;

namespace RomarizIT.PostFromFacebookData
{
    [DependsOn(
        typeof(PostFromFacebookDataCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PostFromFacebookDataApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PostFromFacebookDataAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PostFromFacebookDataApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
