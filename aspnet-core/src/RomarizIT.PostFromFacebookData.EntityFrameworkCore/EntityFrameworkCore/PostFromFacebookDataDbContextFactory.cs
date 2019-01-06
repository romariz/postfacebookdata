using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RomarizIT.PostFromFacebookData.Configuration;
using RomarizIT.PostFromFacebookData.Web;

namespace RomarizIT.PostFromFacebookData.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PostFromFacebookDataDbContextFactory : IDesignTimeDbContextFactory<PostFromFacebookDataDbContext>
    {
        public PostFromFacebookDataDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PostFromFacebookDataDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PostFromFacebookDataDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PostFromFacebookDataConsts.ConnectionStringName));

            return new PostFromFacebookDataDbContext(builder.Options);
        }
    }
}
