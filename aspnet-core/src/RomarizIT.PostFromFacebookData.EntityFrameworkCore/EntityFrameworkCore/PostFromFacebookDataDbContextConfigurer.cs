using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace RomarizIT.PostFromFacebookData.EntityFrameworkCore
{
    public static class PostFromFacebookDataDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PostFromFacebookDataDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PostFromFacebookDataDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
