using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RomarizIT.PostFromFacebookData.Configuration;
using RomarizIT.PostFromFacebookData.EntityFrameworkCore;
using RomarizIT.PostFromFacebookData.Migrator.DependencyInjection;

namespace RomarizIT.PostFromFacebookData.Migrator
{
    [DependsOn(typeof(PostFromFacebookDataEntityFrameworkModule))]
    public class PostFromFacebookDataMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public PostFromFacebookDataMigratorModule(PostFromFacebookDataEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(PostFromFacebookDataMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                PostFromFacebookDataConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PostFromFacebookDataMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
