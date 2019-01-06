using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RomarizIT.PostFromFacebookData.Configuration;

namespace RomarizIT.PostFromFacebookData.Web.Host.Startup
{
    [DependsOn(
       typeof(PostFromFacebookDataWebCoreModule))]
    public class PostFromFacebookDataWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PostFromFacebookDataWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PostFromFacebookDataWebHostModule).GetAssembly());
        }
    }
}
