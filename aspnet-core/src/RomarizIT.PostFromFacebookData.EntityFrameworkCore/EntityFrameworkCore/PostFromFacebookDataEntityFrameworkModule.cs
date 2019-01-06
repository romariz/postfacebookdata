using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using RomarizIT.PostFromFacebookData.EntityFrameworkCore.Seed;

namespace RomarizIT.PostFromFacebookData.EntityFrameworkCore
{
    [DependsOn(
        typeof(PostFromFacebookDataCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class PostFromFacebookDataEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<PostFromFacebookDataDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        PostFromFacebookDataDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        PostFromFacebookDataDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PostFromFacebookDataEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
